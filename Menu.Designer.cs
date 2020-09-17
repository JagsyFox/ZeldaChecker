namespace ZeldaChecker
{
    partial class Menu
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
            this.lttpLabel = new System.Windows.Forms.Label();
            this.newButton = new System.Windows.Forms.Button();
            this.loadButton = new System.Windows.Forms.Button();
            this.laLbal = new System.Windows.Forms.Label();
            this.albw = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lttpLabel
            // 
            this.lttpLabel.AutoSize = true;
            this.lttpLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lttpLabel.Location = new System.Drawing.Point(42, 33);
            this.lttpLabel.Name = "lttpLabel";
            this.lttpLabel.Size = new System.Drawing.Size(142, 20);
            this.lttpLabel.TabIndex = 0;
            this.lttpLabel.Text = "A Link To The Past";
            this.lttpLabel.Click += new System.EventHandler(this.lttpLabel_Click);
            // 
            // newButton
            // 
            this.newButton.Location = new System.Drawing.Point(529, 33);
            this.newButton.Name = "newButton";
            this.newButton.Size = new System.Drawing.Size(123, 30);
            this.newButton.TabIndex = 1;
            this.newButton.Text = "New Run ";
            this.newButton.UseVisualStyleBackColor = true;
            this.newButton.Click += new System.EventHandler(this.newButton_Click);
            // 
            // loadButton
            // 
            this.loadButton.Location = new System.Drawing.Point(529, 85);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(123, 30);
            this.loadButton.TabIndex = 2;
            this.loadButton.Text = "Load Run";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // laLbal
            // 
            this.laLbal.AutoSize = true;
            this.laLbal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laLbal.Location = new System.Drawing.Point(42, 85);
            this.laLbal.Name = "laLbal";
            this.laLbal.Size = new System.Drawing.Size(131, 20);
            this.laLbal.TabIndex = 3;
            this.laLbal.Text = "Link\'s Awakening";
            this.laLbal.Click += new System.EventHandler(this.laLbal_Click);
            // 
            // albw
            // 
            this.albw.AutoSize = true;
            this.albw.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.albw.Location = new System.Drawing.Point(42, 134);
            this.albw.Name = "albw";
            this.albw.Size = new System.Drawing.Size(173, 20);
            this.albw.TabIndex = 4;
            this.albw.Text = "A Link Between Worlds";
            this.albw.Click += new System.EventHandler(this.albw_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 450);
            this.Controls.Add(this.albw);
            this.Controls.Add(this.laLbal);
            this.Controls.Add(this.loadButton);
            this.Controls.Add(this.newButton);
            this.Controls.Add(this.lttpLabel);
            this.Name = "Menu";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lttpLabel;
        private System.Windows.Forms.Button newButton;
        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.Label laLbal;
        private System.Windows.Forms.Label albw;
    }
}

