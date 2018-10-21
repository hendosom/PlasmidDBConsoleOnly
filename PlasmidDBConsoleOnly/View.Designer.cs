namespace PlasmidDBConsoleOnly
{
    partial class View
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
            this.LblPlasmidName = new System.Windows.Forms.Label();
            this.InputPlasmidName = new System.Windows.Forms.TextBox();
            this.LblPlasmidSequence = new System.Windows.Forms.Label();
            this.InputPlasmidSequence = new System.Windows.Forms.TextBox();
            this.ButtonSaveToDB = new System.Windows.Forms.Button();
            this.LblShowInputName = new System.Windows.Forms.Label();
            this.LblShowInputSequence = new System.Windows.Forms.Label();
            this.LblDisplayInfoText = new System.Windows.Forms.Label();
            this.InputPlasmidNameToLoad = new System.Windows.Forms.TextBox();
            this.InputLoadPlasmid = new System.Windows.Forms.Button();
            this.LblOutputPlasmidName = new System.Windows.Forms.Label();
            this.LblOutputPlasmidSequence = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LblPlasmidName
            // 
            this.LblPlasmidName.AutoSize = true;
            this.LblPlasmidName.Location = new System.Drawing.Point(74, 122);
            this.LblPlasmidName.Name = "LblPlasmidName";
            this.LblPlasmidName.Size = new System.Drawing.Size(77, 13);
            this.LblPlasmidName.TabIndex = 0;
            this.LblPlasmidName.Text = "Plasmid-Name:";
            // 
            // InputPlasmidName
            // 
            this.InputPlasmidName.Location = new System.Drawing.Point(77, 138);
            this.InputPlasmidName.Name = "InputPlasmidName";
            this.InputPlasmidName.Size = new System.Drawing.Size(100, 20);
            this.InputPlasmidName.TabIndex = 1;
            this.InputPlasmidName.TextChanged += new System.EventHandler(this.InputPlasmidName_TextChanged);
            // 
            // LblPlasmidSequence
            // 
            this.LblPlasmidSequence.AutoSize = true;
            this.LblPlasmidSequence.Location = new System.Drawing.Point(74, 164);
            this.LblPlasmidSequence.Name = "LblPlasmidSequence";
            this.LblPlasmidSequence.Size = new System.Drawing.Size(91, 13);
            this.LblPlasmidSequence.TabIndex = 2;
            this.LblPlasmidSequence.Text = "Plasmid-Sequenz:";
            // 
            // InputPlasmidSequence
            // 
            this.InputPlasmidSequence.Location = new System.Drawing.Point(77, 180);
            this.InputPlasmidSequence.Name = "InputPlasmidSequence";
            this.InputPlasmidSequence.Size = new System.Drawing.Size(100, 20);
            this.InputPlasmidSequence.TabIndex = 3;
            this.InputPlasmidSequence.TextChanged += new System.EventHandler(this.InputPlasmidSequence_TextChanged);
            // 
            // ButtonSaveToDB
            // 
            this.ButtonSaveToDB.Location = new System.Drawing.Point(77, 225);
            this.ButtonSaveToDB.Name = "ButtonSaveToDB";
            this.ButtonSaveToDB.Size = new System.Drawing.Size(100, 59);
            this.ButtonSaveToDB.TabIndex = 4;
            this.ButtonSaveToDB.Text = "Plasmid speichern";
            this.ButtonSaveToDB.UseVisualStyleBackColor = true;
            this.ButtonSaveToDB.Click += new System.EventHandler(this.ButtonSaveToDB_Click);
            // 
            // LblShowInputName
            // 
            this.LblShowInputName.AutoSize = true;
            this.LblShowInputName.Location = new System.Drawing.Point(247, 141);
            this.LblShowInputName.Name = "LblShowInputName";
            this.LblShowInputName.Size = new System.Drawing.Size(65, 13);
            this.LblShowInputName.TabIndex = 5;
            this.LblShowInputName.Text = "(input name)";
            this.LblShowInputName.TextChanged += new System.EventHandler(this.LblShowInputName_TextChanged);
            // 
            // LblShowInputSequence
            // 
            this.LblShowInputSequence.AutoSize = true;
            this.LblShowInputSequence.Location = new System.Drawing.Point(247, 183);
            this.LblShowInputSequence.Name = "LblShowInputSequence";
            this.LblShowInputSequence.Size = new System.Drawing.Size(86, 13);
            this.LblShowInputSequence.TabIndex = 6;
            this.LblShowInputSequence.Text = "(input sequence)";
            this.LblShowInputSequence.TextChanged += new System.EventHandler(this.LblShowInputSequence_TextChanged);
            // 
            // LblDisplayInfoText
            // 
            this.LblDisplayInfoText.AutoSize = true;
            this.LblDisplayInfoText.Location = new System.Drawing.Point(247, 225);
            this.LblDisplayInfoText.Name = "LblDisplayInfoText";
            this.LblDisplayInfoText.Size = new System.Drawing.Size(13, 13);
            this.LblDisplayInfoText.TabIndex = 7;
            this.LblDisplayInfoText.Text = "  ";
            this.LblDisplayInfoText.TextChanged += new System.EventHandler(this.LblDisplayInfoText_TextChanged);
            // 
            // InputPlasmidNameToLoad
            // 
            this.InputPlasmidNameToLoad.Location = new System.Drawing.Point(481, 134);
            this.InputPlasmidNameToLoad.Name = "InputPlasmidNameToLoad";
            this.InputPlasmidNameToLoad.Size = new System.Drawing.Size(135, 20);
            this.InputPlasmidNameToLoad.TabIndex = 9;
            this.InputPlasmidNameToLoad.Text = "(enter plasmid name)";
            this.InputPlasmidNameToLoad.TextChanged += new System.EventHandler(this.InputPlasmidNameToLoad_TextChanged);
            // 
            // InputLoadPlasmid
            // 
            this.InputLoadPlasmid.Location = new System.Drawing.Point(481, 164);
            this.InputLoadPlasmid.Name = "InputLoadPlasmid";
            this.InputLoadPlasmid.Size = new System.Drawing.Size(135, 59);
            this.InputLoadPlasmid.TabIndex = 10;
            this.InputLoadPlasmid.Text = "Plasmid-Daten laden";
            this.InputLoadPlasmid.UseVisualStyleBackColor = true;
            this.InputLoadPlasmid.Click += new System.EventHandler(this.InputLoadPlasmid_Click);
            // 
            // LblOutputPlasmidName
            // 
            this.LblOutputPlasmidName.AutoSize = true;
            this.LblOutputPlasmidName.Location = new System.Drawing.Point(481, 270);
            this.LblOutputPlasmidName.Name = "LblOutputPlasmidName";
            this.LblOutputPlasmidName.Size = new System.Drawing.Size(72, 13);
            this.LblOutputPlasmidName.TabIndex = 11;
            this.LblOutputPlasmidName.Text = "(output name)";
            // 
            // LblOutputPlasmidSequence
            // 
            this.LblOutputPlasmidSequence.AutoSize = true;
            this.LblOutputPlasmidSequence.Location = new System.Drawing.Point(481, 294);
            this.LblOutputPlasmidSequence.Name = "LblOutputPlasmidSequence";
            this.LblOutputPlasmidSequence.Size = new System.Drawing.Size(93, 13);
            this.LblOutputPlasmidSequence.TabIndex = 11;
            this.LblOutputPlasmidSequence.Text = "(output sequence)";
            // 
            // View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LblOutputPlasmidSequence);
            this.Controls.Add(this.LblOutputPlasmidName);
            this.Controls.Add(this.InputLoadPlasmid);
            this.Controls.Add(this.InputPlasmidNameToLoad);
            this.Controls.Add(this.LblDisplayInfoText);
            this.Controls.Add(this.LblShowInputSequence);
            this.Controls.Add(this.LblShowInputName);
            this.Controls.Add(this.ButtonSaveToDB);
            this.Controls.Add(this.InputPlasmidSequence);
            this.Controls.Add(this.LblPlasmidSequence);
            this.Controls.Add(this.InputPlasmidName);
            this.Controls.Add(this.LblPlasmidName);
            this.Name = "View";
            this.Text = "View";
            this.TextChanged += new System.EventHandler(this.View_TextChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblPlasmidName;
        private System.Windows.Forms.TextBox InputPlasmidName;
        private System.Windows.Forms.Label LblPlasmidSequence;
        private System.Windows.Forms.TextBox InputPlasmidSequence;
        private System.Windows.Forms.Button ButtonSaveToDB;
        private System.Windows.Forms.Label LblShowInputName;
        private System.Windows.Forms.Label LblShowInputSequence;
        private System.Windows.Forms.Label LblDisplayInfoText;
        private System.Windows.Forms.TextBox InputPlasmidNameToLoad;
        private System.Windows.Forms.Button InputLoadPlasmid;
        private System.Windows.Forms.Label LblOutputPlasmidName;
        private System.Windows.Forms.Label LblOutputPlasmidSequence;
    }
}