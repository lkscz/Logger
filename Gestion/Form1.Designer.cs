namespace Gestion
{
    partial class Form1
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
            this.BTN_search = new System.Windows.Forms.Button();
            this.TBX_SearchBar = new System.Windows.Forms.TextBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // BTN_search
            // 
            this.BTN_search.Location = new System.Drawing.Point(1459, 12);
            this.BTN_search.Name = "BTN_search";
            this.BTN_search.Size = new System.Drawing.Size(98, 32);
            this.BTN_search.TabIndex = 0;
            this.BTN_search.Text = "Search";
            this.BTN_search.UseVisualStyleBackColor = true;
            this.BTN_search.Click += new System.EventHandler(this.BTN_search_Click);
            // 
            // TBX_SearchBar
            // 
            this.TBX_SearchBar.BackColor = System.Drawing.SystemColors.HighlightText;
            this.TBX_SearchBar.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBX_SearchBar.ForeColor = System.Drawing.Color.Black;
            this.TBX_SearchBar.Location = new System.Drawing.Point(188, 12);
            this.TBX_SearchBar.Name = "TBX_SearchBar";
            this.TBX_SearchBar.Size = new System.Drawing.Size(1245, 27);
            this.TBX_SearchBar.TabIndex = 1;
            this.TBX_SearchBar.TextChanged += new System.EventHandler(this.Search_Bar_TextChanged);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(12, 65);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 2;
            this.monthCalendar1.TitleBackColor = System.Drawing.Color.Red;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(243, 45);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(1190, 548);
            this.listBox1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1675, 824);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.TBX_SearchBar);
            this.Controls.Add(this.BTN_search);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTN_search;
        private System.Windows.Forms.TextBox TBX_SearchBar;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.ListBox listBox1;
    }
}

