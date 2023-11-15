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
            this.BTN_Save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BTN_search
            // 
            this.BTN_search.Location = new System.Drawing.Point(356, 11);
            this.BTN_search.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BTN_search.Name = "BTN_search";
            this.BTN_search.Size = new System.Drawing.Size(99, 27);
            this.BTN_search.TabIndex = 0;
            this.BTN_search.Text = "Save Files";
            this.BTN_search.UseVisualStyleBackColor = true;
            this.BTN_search.Click += new System.EventHandler(this.BTN_search_Click);
            // 
            // TBX_SearchBar
            // 
            this.TBX_SearchBar.BackColor = System.Drawing.SystemColors.HighlightText;
            this.TBX_SearchBar.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBX_SearchBar.ForeColor = System.Drawing.Color.Black;
            this.TBX_SearchBar.Location = new System.Drawing.Point(148, 10);
            this.TBX_SearchBar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TBX_SearchBar.Name = "TBX_SearchBar";
            this.TBX_SearchBar.Size = new System.Drawing.Size(204, 27);
            this.TBX_SearchBar.TabIndex = 1;
            this.TBX_SearchBar.TextChanged += new System.EventHandler(this.Search_Bar_TextChanged);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(14, 121);
            this.monthCalendar1.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
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
            this.listBox1.Location = new System.Drawing.Point(14, 314);
            this.listBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(588, 264);
            this.listBox1.TabIndex = 3;
            // 
            // BTN_Save
            // 
            this.BTN_Save.Location = new System.Drawing.Point(460, 10);
            this.BTN_Save.Name = "BTN_Save";
            this.BTN_Save.Size = new System.Drawing.Size(87, 27);
            this.BTN_Save.TabIndex = 4;
            this.BTN_Save.Text = "Save";
            this.BTN_Save.UseVisualStyleBackColor = true;
            this.BTN_Save.Click += new System.EventHandler(this.BTN_Save_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1256, 670);
            this.Controls.Add(this.BTN_Save);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.TBX_SearchBar);
            this.Controls.Add(this.BTN_search);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTN_search;
        private System.Windows.Forms.TextBox TBX_SearchBar;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button BTN_Save;
    }
}

