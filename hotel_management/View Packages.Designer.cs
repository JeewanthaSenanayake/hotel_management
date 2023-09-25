namespace hotel_management
{
    partial class View_Packages
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
            this.dataGridViewPkg = new System.Windows.Forms.DataGridView();
            this.search = new System.Windows.Forms.TextBox();
            this.search_btn = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPkg)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewPkg
            // 
            this.dataGridViewPkg.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridViewPkg.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewPkg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPkg.Location = new System.Drawing.Point(142, 131);
            this.dataGridViewPkg.Name = "dataGridViewPkg";
            this.dataGridViewPkg.Size = new System.Drawing.Size(548, 207);
            this.dataGridViewPkg.TabIndex = 0;
            this.dataGridViewPkg.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPkg_CellContentClick);
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(142, 92);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(396, 20);
            this.search.TabIndex = 1;
            // 
            // search_btn
            // 
            this.search_btn.Location = new System.Drawing.Point(544, 92);
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(146, 23);
            this.search_btn.TabIndex = 2;
            this.search_btn.Text = "Search by package name";
            this.search_btn.UseVisualStyleBackColor = true;
            this.search_btn.Click += new System.EventHandler(this.search_btn_Click);
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(13, 13);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(87, 29);
            this.back.TabIndex = 3;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // View_Packages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.back);
            this.Controls.Add(this.search_btn);
            this.Controls.Add(this.search);
            this.Controls.Add(this.dataGridViewPkg);
            this.Name = "View_Packages";
            this.Text = "View Packages";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPkg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewPkg;
        private System.Windows.Forms.TextBox search;
        private System.Windows.Forms.Button search_btn;
        private System.Windows.Forms.Button back;
    }
}