namespace hotel_management
{
    partial class All_Packages
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
            this.back = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.TextBox();
            this.delete_button = new System.Windows.Forms.Button();
            this.edit = new System.Windows.Forms.TextBox();
            this.edit_btn = new System.Windows.Forms.Button();
            this.column_name = new System.Windows.Forms.ComboBox();
            this.value = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPkg)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewPkg
            // 
            this.dataGridViewPkg.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridViewPkg.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewPkg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPkg.Location = new System.Drawing.Point(123, 67);
            this.dataGridViewPkg.Name = "dataGridViewPkg";
            this.dataGridViewPkg.Size = new System.Drawing.Size(559, 150);
            this.dataGridViewPkg.TabIndex = 0;
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(13, 13);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(84, 29);
            this.back.TabIndex = 1;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(123, 245);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(125, 20);
            this.delete.TabIndex = 2;
            // 
            // delete_button
            // 
            this.delete_button.Location = new System.Drawing.Point(254, 245);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(78, 23);
            this.delete_button.TabIndex = 3;
            this.delete_button.Text = "Delete by id";
            this.delete_button.UseVisualStyleBackColor = true;
            this.delete_button.Click += new System.EventHandler(this.delete_button_Click);
            // 
            // edit
            // 
            this.edit.Location = new System.Drawing.Point(409, 247);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(125, 20);
            this.edit.TabIndex = 4;
            // 
            // edit_btn
            // 
            this.edit_btn.Location = new System.Drawing.Point(409, 380);
            this.edit_btn.Name = "edit_btn";
            this.edit_btn.Size = new System.Drawing.Size(75, 23);
            this.edit_btn.TabIndex = 5;
            this.edit_btn.Text = "Edit by id";
            this.edit_btn.UseVisualStyleBackColor = true;
            this.edit_btn.Click += new System.EventHandler(this.edit_btn_Click);
            // 
            // column_name
            // 
            this.column_name.FormattingEnabled = true;
            this.column_name.Location = new System.Drawing.Point(409, 296);
            this.column_name.Name = "column_name";
            this.column_name.Size = new System.Drawing.Size(125, 21);
            this.column_name.TabIndex = 6;
            // 
            // value
            // 
            this.value.Location = new System.Drawing.Point(409, 346);
            this.value.Name = "value";
            this.value.Size = new System.Drawing.Size(125, 20);
            this.value.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(409, 230);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(409, 279);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Column Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(408, 329);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Value";
            // 
            // All_Packages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.value);
            this.Controls.Add(this.column_name);
            this.Controls.Add(this.edit_btn);
            this.Controls.Add(this.edit);
            this.Controls.Add(this.delete_button);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.back);
            this.Controls.Add(this.dataGridViewPkg);
            this.Name = "All_Packages";
            this.Text = "All Packages";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPkg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewPkg;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.TextBox delete;
        private System.Windows.Forms.Button delete_button;
        private System.Windows.Forms.TextBox edit;
        private System.Windows.Forms.Button edit_btn;
        private System.Windows.Forms.ComboBox column_name;
        private System.Windows.Forms.TextBox value;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}