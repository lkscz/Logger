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
            this.SuspendLayout();
            // 
            // btn_FindError
            // 
            this.btn_FindError.Location = new System.Drawing.Point(154, 48);
            this.btn_FindError.Name = "btn_FindError";
            this.btn_FindError.Size = new System.Drawing.Size(121, 35);
            this.btn_FindError.TabIndex = 0;
            this.btn_FindError.Text = "Read Files";
            this.btn_FindError.UseVisualStyleBackColor = true;
            this.btn_FindError.Click += new System.EventHandler(this.btn_Find_Error_Click);
            // 
            // ShowErrorBox
            // 
            this.ShowErrorBox.Location = new System.Drawing.Point(12, 129);
            this.ShowErrorBox.Name = "ShowErrorBox";
            this.ShowErrorBox.Size = new System.Drawing.Size(412, 22);
            this.ShowErrorBox.TabIndex = 1;
            this.ShowErrorBox.TextChanged += new System.EventHandler(this.ShowErrorBox_TextChanged);
            // 
            // Form
            // 
            this.ClientSize = new System.Drawing.Size(436, 253);
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
    }
}

