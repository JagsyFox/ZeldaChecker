using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO;
using System.Text.Json;


namespace ZeldaChecker
{
    public partial class GameSelectedForm : Form
    {
        // IMPORTANT//
        // This is required for opening files
        public string gameToLoad;
        bool listOne = true;
        public string listOneKey;
        public string listTwoKey;
        public bool useObtained = false;

        public string title; //Title, used for the top label
        Collectables coll = new Collectables(); // Collectables class call, handles all other colelctable items


        public GameSelectedForm()
        {
            InitializeComponent();
        }

        private void GameSelectedForm_Load(object sender, EventArgs e)
        {        
            gameLabel.Text = title;

            foreach (string file in Directory.GetFiles($"..\\Games\\{gameToLoad}\\load"))
            {
                string name = Path.GetFileName(file); // gets file name, then regex to remove .txt
                string txtRep = Regex.Replace(name, ".txt", "");

                //returns a list of all collectables in the file
                coll.returnCollectableList(gameToLoad, name, coll.collectables, txtRep, locationListBox);

            }

            // Adds key values to a list
            foreach (string key in coll.collectableDictionary.Keys)
            {
                catagoriesListBox.Items.Add(key);
            }

            coll.returnItemsList();

           
        }

        //Clears all
        private void clearBoxes_Click(object sender, EventArgs e)
        {
            obtainableListBox1.Items.Clear();
            list1GuideBox.Clear();
            list1ConditionsBox.Clear();
            obtainableListBox2.Items.Clear();
            list2GuideBox.Clear();
            list2ConditionsBox.Clear();
        }

        //Changes button and use obtained value
        private void viewObtainedButton_Click(object sender, EventArgs e)
        {
            if(useObtained)
            {
                viewObtainedButton.Text = "Selecting obtained";
                useObtained = !useObtained;
            }
            else
            {
                viewObtainedButton.Text = "Selecting unobtained";
                useObtained = !useObtained;
            }

        }

        //These two functions update guide/loc/info boxees for a sleected index on each list
        private void obtainableListBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            coll.updateGuideTextBox(listTwoKey, list2ConditionsBox, list2GuideBox, list2LocationsBox, obtainableListBox2.GetItemText(obtainableListBox2.SelectedItem)) ;
        }

        private void obtainableListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            coll.updateGuideTextBox(listOneKey, list1ConditionsBox, list1GuideBox, list1locationbox, obtainableListBox1.GetItemText(obtainableListBox1.SelectedItem));
        }

        //This function updates whichever selected listbox
        private void catagoriesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listOne)            
            {
                listOneKey = catagoriesListBox.SelectedItem.ToString();
                obtainableListBox1.Items.Clear();
                coll.fillObtainableBox(obtainableListBox1, listOneKey, useObtained);
                list1CountLabel.Text = obtainableListBox1.Items.Count.ToString();
            }
            else
            {
                listTwoKey = catagoriesListBox.SelectedItem.ToString();
                obtainableListBox2.Items.Clear();
                coll.fillObtainableBox(obtainableListBox2, listTwoKey, useObtained);
                list2CountLabel.Text = obtainableListBox2.Items.Count.ToString();
            }
        }

        //This button selects which list is being updated
        private void setListButton_Click(object sender, EventArgs e)
        {
            if (listOne)
            {
                setListButton.Text = "Updating List 2";
                listOne = !listOne;
            }
            else
            {
                setListButton.Text = "Updating List 1";
                listOne = !listOne;
            }
        }

        //These two functions update the value of an item to collected or not
        private void setTrueFalseList2Button_Click(object sender, EventArgs e)
        {
            string listValue = obtainableListBox2.GetItemText(obtainableListBox2.SelectedItem);
            coll.setTrueFalse(gameToLoad, listValue, listTwoKey);
            coll.fillObtainableBox(obtainableListBox2, listTwoKey, useObtained);
            coll.returnItemsList();
        }

        private void setTrueFalseList1Button_Click(object sender, EventArgs e)
        {
            string listValue = obtainableListBox1.GetItemText(obtainableListBox1.SelectedItem);
            coll.setTrueFalse(gameToLoad, listValue, listOneKey);
            coll.fillObtainableBox(obtainableListBox1, listOneKey, useObtained);
            coll.returnItemsList();
        }
    }
}