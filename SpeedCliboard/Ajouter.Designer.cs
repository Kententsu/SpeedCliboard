namespace SpeedCliboard
{
    partial class Ajouter
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
            this.button1 = new System.Windows.Forms.Button();
            this.pathName = new System.Windows.Forms.TextBox();
            this.pathLabel = new System.Windows.Forms.Label();
            this.NameFile = new System.Windows.Forms.TextBox();
            this.nomLibel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(271, 16);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Creer";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pathName
            // 
            this.pathName.Location = new System.Drawing.Point(43, 43);
            this.pathName.Name = "pathName";
            this.pathName.Size = new System.Drawing.Size(207, 20);
            this.pathName.TabIndex = 8;
            // 
            // pathLabel
            // 
            this.pathLabel.AutoSize = true;
            this.pathLabel.Location = new System.Drawing.Point(8, 46);
            this.pathLabel.Name = "pathLabel";
            this.pathLabel.Size = new System.Drawing.Size(29, 13);
            this.pathLabel.TabIndex = 7;
            this.pathLabel.Text = "Path";
            // 
            // NameFile
            // 
            this.NameFile.Location = new System.Drawing.Point(43, 13);
            this.NameFile.Name = "NameFile";
            this.NameFile.Size = new System.Drawing.Size(207, 20);
            this.NameFile.TabIndex = 6;
            // 
            // nomLibel
            // 
            this.nomLibel.AutoSize = true;
            this.nomLibel.Location = new System.Drawing.Point(4, 16);
            this.nomLibel.Name = "nomLibel";
            this.nomLibel.Size = new System.Drawing.Size(29, 13);
            this.nomLibel.TabIndex = 5;
            this.nomLibel.Text = "Nom";
            // 
            // Ajouter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 73);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pathName);
            this.Controls.Add(this.pathLabel);
            this.Controls.Add(this.NameFile);
            this.Controls.Add(this.nomLibel);
            this.Name = "Ajouter";
            this.Text = "Ajouter";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Ajouter_FormClosing_1);
            this.Load += new System.EventHandler(this.Ajouter_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox pathName;
        private System.Windows.Forms.Label pathLabel;
        private System.Windows.Forms.TextBox NameFile;
        private System.Windows.Forms.Label nomLibel;
    }
}