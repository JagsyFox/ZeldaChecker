namespace ZeldaChecker
{
    partial class GameSelectedForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gameLabel = new System.Windows.Forms.Label();
            this.list2CountLabel = new System.Windows.Forms.Label();
            this.itemBoxLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.list2GuideBox = new System.Windows.Forms.TextBox();
            this.viewObtainedButton = new System.Windows.Forms.Button();
            this.list2ConditionsBox = new System.Windows.Forms.TextBox();
            this.clearBoxes = new System.Windows.Forms.Button();
            this.obtainableListBox2 = new System.Windows.Forms.ListBox();
            this.obtainableListBox1 = new System.Windows.Forms.ListBox();
            this.list1ConditionsBox = new System.Windows.Forms.TextBox();
            this.list1GuideBox = new System.Windows.Forms.TextBox();
            this.locationListBox = new System.Windows.Forms.ListBox();
            this.catagoriesListBox = new System.Windows.Forms.ListBox();
            this.list1CountLabel = new System.Windows.Forms.Label();
            this.updateToFileButton = new System.Windows.Forms.Button();
            this.setTrueFalseList1Button = new System.Windows.Forms.Button();
            this.setTrueFalseList2Button = new System.Windows.Forms.Button();
            this.setListButton = new System.Windows.Forms.Button();
            this.list2LocationsBox = new System.Windows.Forms.TextBox();
            this.list1locationbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // gameLabel
            // 
            this.gameLabel.AutoSize = true;
            this.gameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameLabel.Location = new System.Drawing.Point(434, 9);
            this.gameLabel.Name = "gameLabel";
            this.gameLabel.Size = new System.Drawing.Size(70, 25);
            this.gameLabel.TabIndex = 0;
            this.gameLabel.Text = "label1";
            this.gameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // list2CountLabel
            // 
            this.list2CountLabel.AutoSize = true;
            this.list2CountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.list2CountLabel.Location = new System.Drawing.Point(548, 37);
            this.list2CountLabel.Name = "list2CountLabel";
            this.list2CountLabel.Size = new System.Drawing.Size(24, 25);
            this.list2CountLabel.TabIndex = 1;
            this.list2CountLabel.Text = "0";
            this.list2CountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // itemBoxLabel
            // 
            this.itemBoxLabel.AutoSize = true;
            this.itemBoxLabel.Location = new System.Drawing.Point(739, 279);
            this.itemBoxLabel.Name = "itemBoxLabel";
            this.itemBoxLabel.Size = new System.Drawing.Size(57, 13);
            this.itemBoxLabel.TabIndex = 3;
            this.itemBoxLabel.Text = "Catagories";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(727, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Locations List";
            // 
            // list2GuideBox
            // 
            this.list2GuideBox.Location = new System.Drawing.Point(342, 481);
            this.list2GuideBox.Multiline = true;
            this.list2GuideBox.Name = "list2GuideBox";
            this.list2GuideBox.Size = new System.Drawing.Size(284, 110);
            this.list2GuideBox.TabIndex = 8;
            // 
            // viewObtainedButton
            // 
            this.viewObtainedButton.Location = new System.Drawing.Point(639, 294);
            this.viewObtainedButton.Name = "viewObtainedButton";
            this.viewObtainedButton.Size = new System.Drawing.Size(66, 71);
            this.viewObtainedButton.TabIndex = 9;
            this.viewObtainedButton.Text = "View Obtained";
            this.viewObtainedButton.UseVisualStyleBackColor = true;
            this.viewObtainedButton.Click += new System.EventHandler(this.viewObtainedButton_Click);
            // 
            // list2ConditionsBox
            // 
            this.list2ConditionsBox.Location = new System.Drawing.Point(342, 448);
            this.list2ConditionsBox.Multiline = true;
            this.list2ConditionsBox.Name = "list2ConditionsBox";
            this.list2ConditionsBox.Size = new System.Drawing.Size(284, 27);
            this.list2ConditionsBox.TabIndex = 10;
            // 
            // clearBoxes
            // 
            this.clearBoxes.Location = new System.Drawing.Point(639, 371);
            this.clearBoxes.Name = "clearBoxes";
            this.clearBoxes.Size = new System.Drawing.Size(66, 71);
            this.clearBoxes.TabIndex = 11;
            this.clearBoxes.Text = "Clear";
            this.clearBoxes.UseVisualStyleBackColor = true;
            this.clearBoxes.Click += new System.EventHandler(this.clearBoxes_Click);
            // 
            // obtainableListBox2
            // 
            this.obtainableListBox2.FormattingEnabled = true;
            this.obtainableListBox2.Location = new System.Drawing.Point(342, 74);
            this.obtainableListBox2.Name = "obtainableListBox2";
            this.obtainableListBox2.Size = new System.Drawing.Size(291, 329);
            this.obtainableListBox2.TabIndex = 13;
            this.obtainableListBox2.SelectedIndexChanged += new System.EventHandler(this.obtainableListBox2_SelectedIndexChanged);
            // 
            // obtainableListBox1
            // 
            this.obtainableListBox1.FormattingEnabled = true;
            this.obtainableListBox1.Location = new System.Drawing.Point(19, 74);
            this.obtainableListBox1.Name = "obtainableListBox1";
            this.obtainableListBox1.Size = new System.Drawing.Size(291, 329);
            this.obtainableListBox1.TabIndex = 14;
            this.obtainableListBox1.SelectedIndexChanged += new System.EventHandler(this.obtainableListBox1_SelectedIndexChanged);
            // 
            // list1ConditionsBox
            // 
            this.list1ConditionsBox.Location = new System.Drawing.Point(19, 448);
            this.list1ConditionsBox.Multiline = true;
            this.list1ConditionsBox.Name = "list1ConditionsBox";
            this.list1ConditionsBox.Size = new System.Drawing.Size(284, 27);
            this.list1ConditionsBox.TabIndex = 15;
            // 
            // list1GuideBox
            // 
            this.list1GuideBox.Location = new System.Drawing.Point(19, 481);
            this.list1GuideBox.Multiline = true;
            this.list1GuideBox.Name = "list1GuideBox";
            this.list1GuideBox.Size = new System.Drawing.Size(284, 110);
            this.list1GuideBox.TabIndex = 16;
            // 
            // locationListBox
            // 
            this.locationListBox.FormattingEnabled = true;
            this.locationListBox.Location = new System.Drawing.Point(730, 37);
            this.locationListBox.Name = "locationListBox";
            this.locationListBox.Size = new System.Drawing.Size(233, 225);
            this.locationListBox.TabIndex = 17;
            // 
            // catagoriesListBox
            // 
            this.catagoriesListBox.FormattingEnabled = true;
            this.catagoriesListBox.Location = new System.Drawing.Point(742, 330);
            this.catagoriesListBox.Name = "catagoriesListBox";
            this.catagoriesListBox.Size = new System.Drawing.Size(233, 290);
            this.catagoriesListBox.TabIndex = 18;
            this.catagoriesListBox.SelectedIndexChanged += new System.EventHandler(this.catagoriesListBox_SelectedIndexChanged);
            // 
            // list1CountLabel
            // 
            this.list1CountLabel.AutoSize = true;
            this.list1CountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.list1CountLabel.Location = new System.Drawing.Point(240, 37);
            this.list1CountLabel.Name = "list1CountLabel";
            this.list1CountLabel.Size = new System.Drawing.Size(24, 25);
            this.list1CountLabel.TabIndex = 19;
            this.list1CountLabel.Text = "0";
            this.list1CountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // updateToFileButton
            // 
            this.updateToFileButton.Location = new System.Drawing.Point(19, 19);
            this.updateToFileButton.Name = "updateToFileButton";
            this.updateToFileButton.Size = new System.Drawing.Size(109, 43);
            this.updateToFileButton.TabIndex = 21;
            this.updateToFileButton.Text = "UPDATE";
            this.updateToFileButton.UseVisualStyleBackColor = true;
            // 
            // setTrueFalseList1Button
            // 
            this.setTrueFalseList1Button.Location = new System.Drawing.Point(105, 597);
            this.setTrueFalseList1Button.Name = "setTrueFalseList1Button";
            this.setTrueFalseList1Button.Size = new System.Drawing.Size(115, 23);
            this.setTrueFalseList1Button.TabIndex = 22;
            this.setTrueFalseList1Button.Text = "UPDATE";
            this.setTrueFalseList1Button.UseVisualStyleBackColor = true;
            this.setTrueFalseList1Button.Click += new System.EventHandler(this.setTrueFalseList1Button_Click);
            // 
            // setTrueFalseList2Button
            // 
            this.setTrueFalseList2Button.Location = new System.Drawing.Point(423, 597);
            this.setTrueFalseList2Button.Name = "setTrueFalseList2Button";
            this.setTrueFalseList2Button.Size = new System.Drawing.Size(115, 23);
            this.setTrueFalseList2Button.TabIndex = 23;
            this.setTrueFalseList2Button.Text = "UPDATE";
            this.setTrueFalseList2Button.UseVisualStyleBackColor = true;
            this.setTrueFalseList2Button.Click += new System.EventHandler(this.setTrueFalseList2Button_Click);
            // 
            // setListButton
            // 
            this.setListButton.Location = new System.Drawing.Point(813, 294);
            this.setListButton.Name = "setListButton";
            this.setListButton.Size = new System.Drawing.Size(140, 27);
            this.setListButton.TabIndex = 24;
            this.setListButton.Text = "button1";
            this.setListButton.UseVisualStyleBackColor = true;
            this.setListButton.Click += new System.EventHandler(this.setListButton_Click);
            // 
            // list2LocationsBox
            // 
            this.list2LocationsBox.Location = new System.Drawing.Point(342, 409);
            this.list2LocationsBox.Multiline = true;
            this.list2LocationsBox.Name = "list2LocationsBox";
            this.list2LocationsBox.Size = new System.Drawing.Size(284, 27);
            this.list2LocationsBox.TabIndex = 25;
            // 
            // list1locationbox
            // 
            this.list1locationbox.Location = new System.Drawing.Point(19, 409);
            this.list1locationbox.Multiline = true;
            this.list1locationbox.Name = "list1locationbox";
            this.list1locationbox.Size = new System.Drawing.Size(284, 27);
            this.list1locationbox.TabIndex = 26;
            // 
            // GameSelectedForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 632);
            this.Controls.Add(this.list1locationbox);
            this.Controls.Add(this.list2LocationsBox);
            this.Controls.Add(this.setListButton);
            this.Controls.Add(this.setTrueFalseList2Button);
            this.Controls.Add(this.setTrueFalseList1Button);
            this.Controls.Add(this.updateToFileButton);
            this.Controls.Add(this.list1CountLabel);
            this.Controls.Add(this.catagoriesListBox);
            this.Controls.Add(this.locationListBox);
            this.Controls.Add(this.list1GuideBox);
            this.Controls.Add(this.list1ConditionsBox);
            this.Controls.Add(this.obtainableListBox1);
            this.Controls.Add(this.obtainableListBox2);
            this.Controls.Add(this.clearBoxes);
            this.Controls.Add(this.list2ConditionsBox);
            this.Controls.Add(this.viewObtainedButton);
            this.Controls.Add(this.list2GuideBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.itemBoxLabel);
            this.Controls.Add(this.list2CountLabel);
            this.Controls.Add(this.gameLabel);
            this.Name = "GameSelectedForm";
            this.Text = "GameSelectedForm";
            this.Load += new System.EventHandler(this.GameSelectedForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label gameLabel;
        private System.Windows.Forms.Label list2CountLabel;
        private System.Windows.Forms.Label itemBoxLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox list2GuideBox;
        private System.Windows.Forms.Button viewObtainedButton;
        private System.Windows.Forms.TextBox list2ConditionsBox;
        private System.Windows.Forms.Button clearBoxes;
        private System.Windows.Forms.ListBox obtainableListBox2;
        private System.Windows.Forms.ListBox obtainableListBox1;
        private System.Windows.Forms.TextBox list1ConditionsBox;
        private System.Windows.Forms.TextBox list1GuideBox;
        private System.Windows.Forms.ListBox locationListBox;
        private System.Windows.Forms.ListBox catagoriesListBox;
        private System.Windows.Forms.Label list1CountLabel;
        private System.Windows.Forms.Button updateToFileButton;
        private System.Windows.Forms.Button setTrueFalseList1Button;
        private System.Windows.Forms.Button setTrueFalseList2Button;
        private System.Windows.Forms.Button setListButton;
        private System.Windows.Forms.TextBox list2LocationsBox;
        private System.Windows.Forms.TextBox list1locationbox;
    }
}