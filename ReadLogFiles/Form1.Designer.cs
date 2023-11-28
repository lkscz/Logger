namespace ReadLogFiles
{
    partial class Form
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_FindError = new System.Windows.Forms.Button();
            this.ShowErrorBox = new System.Windows.Forms.TextBox();
            this.Save_Files = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_FindError
            // 
            this.btn_FindError.Location = new System.Drawing.Point(85, 48);
            this.btn_FindError.Name = "btn_FindError";
            this.btn_FindError.Size = new System.Drawing.Size(121, 35);
            this.btn_FindError.TabIndex = 0;
            this.btn_FindError.Text = "Read Files";
            this.btn_FindError.UseVisualStyleBackColor = true;
            this.btn_FindError.Click += new System.EventHandler(this.btn_Find_Error_Click);
            // 
            // ShowErrorBox
            // 
            this.ShowErrorBox.Location = new System.Drawing.Point(13, 137);
            this.ShowErrorBox.Name = "ShowErrorBox";
            this.ShowErrorBox.Size = new System.Drawing.Size(412, 22);
            this.ShowErrorBox.TabIndex = 1;
            this.ShowErrorBox.TextChanged += new System.EventHandler(this.ShowErrorBox_TextChanged);
            // 
            // Save_Files
            // 
            this.Save_Files.Location = new System.Drawing.Point(240, 48);
            this.Save_Files.Name = "Save_Files";
            this.Save_Files.Size = new System.Drawing.Size(112, 35);
            this.Save_Files.TabIndex = 2;
            this.Save_Files.Text = "Save Files";
            this.Save_Files.UseVisualStyleBackColor = true;
            this.Save_Files.Click += new System.EventHandler(this.Save_Files_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 190);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox2.Size = new System.Drawing.Size(412, 147);
            this.textBox2.TabIndex = 3;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Form
            // 
            this.ClientSize = new System.Drawing.Size(437, 349);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.Save_Files);
            this.Controls.Add(this.ShowErrorBox);
            this.Controls.Add(this.btn_FindError);
            this.Name = "Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_FindError;
        private System.Windows.Forms.TextBox ShowErrorBox;
        private System.Windows.Forms.Button Save_Files;
        private System.Windows.Forms.TextBox textBox2;
    }
}

