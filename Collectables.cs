using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO;
using System.Text.Json;

namespace ZeldaChecker
{
    class Collectables
    {
        public List<Collectable> collectables = new List<Collectable>(); //list that'll be filled by function
        public Dictionary<string, List<Collectable>> collectableDictionary = new Dictionary<string, List<Collectable>>();
        public List<string> collectedItems = new List<string>();
        public List<string> locations = new List<string>();
        //This list stores' true' value items for iteration

        //This is the item class that all of Link's items will be stored as
        public class Collectable
        {
            public string name { get; set; }
            public string location { get; set; }
            public string[] conditions { get; set; }

            public string guide { get; set; }
            public bool status { get; set; }

        }

        // This function is used to read the JSON text file of items into seperate ITEM objects
        // This will be run when a game is selected, as item list is always present
        public void returnCollectableList(string gameFile, string collectableFile, List<Collectable> collectables, string keyName, ListBox locationsBox)
        {
            List<Collectable> addList = new List<Collectable>();

            string[] readJS = File.ReadAllLines($"..\\Games\\{gameFile}\\load\\{collectableFile}");

            foreach (string line in readJS)
            {
                addList.Add(JsonSerializer.Deserialize<Collectable>(line));
            }

            collectableDictionary.Add(keyName, addList);

            returnLocationsList(locationsBox);

            


        }

        //Controls writing an updated list to the items file
        public void updateListToFile(List<Collectable> collectables, string gameFile, string collectableFile)
        {
            int x = 0;

           foreach (Collectable item in collectables)
            {
                if (x == 0)
                {
                    string rewrite = JsonSerializer.Serialize(item);
                    File.WriteAllText($"..\\Games\\{gameFile}\\load\\{collectableFile}.txt", rewrite);
                    x++;
                }
                else
                {        
                    string rewrite = JsonSerializer.Serialize(item);
                    File.AppendAllText($"..\\Games\\{gameFile}\\load\\{collectableFile}.txt", "\n" + rewrite);
                }

            }
        }


        //Updates the textboxes below the checkbox list
        public void updateGuideTextBox(string listValue, TextBox conditionsBox, TextBox guideBox, TextBox locationBox, string selectedLine)
        {
            List<Collectable> foundList = new List<Collectable>();
            foreach(string key in collectableDictionary.Keys)
            {
                if (key == listValue)
                {
                    foundList = collectableDictionary[key];
                }
            }

            foreach(Collectable coll in foundList)
            {

                if (selectedLine == coll.name)
                {
                    if(coll.conditions.Length == 1)
                    {
                        conditionsBox.Text = coll.conditions[0];
                    }
                    else if (coll.conditions.Length == 2)
                    {
                        conditionsBox.Text = coll.conditions[0] + " " + coll.conditions[1]; 
                    }
                    else
                    {
                        conditionsBox.Text = coll.conditions[0] + " " + coll.conditions[1] + " " + coll.conditions[2];
                    }

                    locationBox.Text = coll.location;
                    guideBox.Text = coll.guide;
                }
            }
        }

        // This function fill sin the selected obtainables list box
        public void fillObtainableBox(ListBox listbox, string selectedValue, bool useObtained)
        {

            listbox.Items.Clear(); //flush

            foreach (string key in collectableDictionary.Keys)
            {
                
                if(key == selectedValue)
                {
                    foreach(Collectable coll in collectableDictionary[key])
                    {
                        if(key == "items" && !useObtained) //Allows items values to show up, as other collectables depend on this value to show
                        {
                            if (coll.status == false)
                            {
                                  listbox.Items.Add(coll.name);
                            }

                        }
                        //False value (if true will only display collectable items)
                        else if(!useObtained)
                        {
                            if (coll.status == false)
                            {
                                foreach(string item in collectedItems)
                                {
                                    if(coll.conditions.Contains(item) && listbox.Items.Contains(coll.name) == false)
                                    {
                                        listbox.Items.Add(coll.name);
                                    }
                                }

                                if(coll.conditions.Contains("Rupees") || coll.conditions.Contains("None"))
                                {
                                    listbox.Items.Add(coll.name);
                                }
                            }
                        }
                        else
                        {
                            if (coll.status == true)
                            {
                                listbox.Items.Add(coll.name);
                            }

                        }
                    }
                }
            }

        }

        public void setTrueFalse(string gameFile, string listValue, string dictKey)
        {
            foreach(string key in collectableDictionary.Keys)
            {
                if(key == dictKey)
                {
                    foreach(Collectable coll in collectableDictionary[key])
                    {
                        if(coll.name == listValue)
                        {
                            coll.status = !coll.status;
                        }
                    }
                    updateListToFile(collectableDictionary[dictKey], gameFile, dictKey);
                }
            }

        }

        public void returnItemsList()
        {
            foreach(Collectable coll in collectableDictionary["items"])
            {
                if(coll.status == true)
                {
                    collectedItems.Add(coll.name);
                }
            }
        }

        public void returnLocationsList(ListBox locationBox)
        {
            foreach(string key in collectableDictionary.Keys)
            {
                foreach(Collectable coll in collectableDictionary[key])
                {
                    if(locations.Contains(coll.location) == false)
                    {
                        locations.Add(coll.location);
                        locationBox.Items.Add(coll.location);
                    }
                }
            }
                

        }


    }

}



