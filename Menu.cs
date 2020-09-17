using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ZeldaChecker
{
    public partial class Menu : Form
    {
        public static string gameTitle;

        // Used by buttons to initialize a load or new run
        public string gameToLoad;

        GameSelectedForm GameSelected = new GameSelectedForm();

        public Menu()
        {
            InitializeComponent();

            // Disables buttons until a game is set
            newButton.Visible = false;
            loadButton.Visible = false;
        }

        private void lttpLabel_Click(object sender, EventArgs e)
        {
            gameTitle = lttpLabel.Text;

            // sets game value, enables buttons
            onLabelClicked(lttpLabel);

            gameToLoad = "lttp";

            newButton.Visible = true;
            loadButton.Visible = true;

        }

        private void onLabelClicked(Label clickedLabel)
        {
            // sets new label text to confirm selection
            string originalText = clickedLabel.Text;
            clickedLabel.Text = originalText + " clicked - selection option";
        }

        private void newButton_Click(object sender, EventArgs e)
        {
            //Previous load file
            string removePrevious = $"..\\Games\\{gameToLoad}\\load";


            // Checks for previous data, then removes it
            if (Directory.Exists(removePrevious))
            {
                string[] files = Directory.GetFiles(removePrevious);
                foreach (string file in files)
                {       
                    File.Delete(file);
                }
                Directory.Delete(removePrevious);
                newSave();
            }
            else
            {
                //Creates new save
                newSave();
            }

            GameSelectedForm GameSelected = new GameSelectedForm();
            GameSelected.title = gameTitle;
            GameSelected.gameToLoad = gameToLoad;
            GameSelected.Show();

        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            GameSelectedForm GameSelected = new GameSelectedForm();
            GameSelected.title = gameTitle;
            GameSelected.gameToLoad = gameToLoad;
            GameSelected.Show();
        }

        private void newSave()
        {
            string loadFolder = $"..\\Games\\{gameToLoad}\\load";
            Directory.CreateDirectory(loadFolder);

            //loops through the base files, adds to load 
            foreach (var file in Directory.GetFiles($"..\\Games\\{gameToLoad}\\new"))
            {
                File.Copy(file, $"..\\Games\\{gameToLoad}\\load\\{Path.GetFileName(file)}");
            }
        }

        private void laLbal_Click(object sender, EventArgs e)
        {
            gameTitle = laLbal.Text;

            // sets game value, enables buttons
            onLabelClicked(laLbal);

            gameToLoad = "la";

            newButton.Visible = true;
            loadButton.Visible = true;

        }

        private void albw_Click(object sender, EventArgs e)
        {
            gameTitle = laLbal.Text;

            // sets game value, enables buttons
            onLabelClicked(laLbal);

            gameToLoad = "albw";

            newButton.Visible = true;
            loadButton.Visible = true;
        }
    }
}
