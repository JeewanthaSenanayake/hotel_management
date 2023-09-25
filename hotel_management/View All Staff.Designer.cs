namespace hotel_management
{
    partial class View_All_Staff
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
            this.dataGridViewStf = new System.Windows.Forms.DataGridView();
            this.Back = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.TextBox();
            this.delete_btn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.value = new System.Windows.Forms.TextBox();
            this.column_name = new System.Windows.Forms.ComboBox();
            this.edit_btn = new System.Windows.Forms.Button();
            this.edit = new System.Windows.Forms.TextBox();
            this.departmentList = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStf)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewStf
            // 
            this.dataGridViewStf.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridViewStf.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewStf.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStf.Location = new System.Drawing.Point(12, 90);
            this.dataGridViewStf.Name = "dataGridViewStf";
            this.dataGridViewStf.Size = new System.Drawing.Size(776, 150);
            this.dataGridViewStf.TabIndex = 0;
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(13, 13);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(80, 33);
            this.Back.TabIndex = 1;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(13, 276);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(115, 20);
            this.delete.TabIndex = 2;
            // 
            // delete_btn
            // 
            this.delete_btn.Location = new System.Drawing.Point(134, 276);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(75, 23);
            this.delete_btn.TabIndex = 3;
            this.delete_btn.Text = "Delete by id";
            this.delete_btn.UseVisualStyleBackColor = true;
            this.delete_btn.Click += new System.EventHandler(this.delete_btn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(346, 361);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Value";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(347, 311);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Column Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(347, 262);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Id";
            // 
            // value
            // 
            this.value.Location = new System.Drawing.Point(347, 378);
            this.value.Name = "value";
            this.value.Size = new System.Drawing.Size(125, 20);
            this.value.TabIndex = 14;
            this.value.TextChanged += new System.EventHandler(this.value_TextChanged);
            // 
            // column_name
            // 
            this.column_name.FormattingEnabled = true;
            this.column_name.Location = new System.Drawing.Point(347, 328);
            this.column_name.Name = "column_name";
            this.column_name.Size = new System.Drawing.Size(125, 21);
            this.column_name.TabIndex = 13;
            this.column_name.SelectedIndexChanged += new System.EventHandler(this.column_name_SelectedIndexChanged);
            // 
            // edit_btn
            // 
            this.edit_btn.Location = new System.Drawing.Point(347, 412);
            this.edit_btn.Name = "edit_btn";
            this.edit_btn.Size = new System.Drawing.Size(75, 23);
            this.edit_btn.TabIndex = 12;
            this.edit_btn.Text = "Edit by id";
            this.edit_btn.UseVisualStyleBackColor = true;
            this.edit_btn.Click += new System.EventHandler(this.edit_btn_Click);
            // 
            // edit
            // 
            this.edit.Location = new System.Drawing.Point(347, 279);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(125, 20);
            this.edit.TabIndex = 11;
            // 
            // departmentList
            // 
            this.departmentList.FormattingEnabled = true;
            this.departmentList.Location = new System.Drawing.Point(347, 377);
            this.departmentList.Name = "departmentList";
            this.departmentList.Size = new System.Drawing.Size(125, 21);
            this.departmentList.TabIndex = 18;
            this.departmentList.SelectedIndexChanged += new System.EventHandler(this.departmentList_SelectedIndexChanged);
            // 
            // View_All_Staff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.departmentList);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.value);
            this.Controls.Add(this.column_name);
            this.Controls.Add(this.edit_btn);
            this.Controls.Add(this.edit);
            this.Controls.Add(this.delete_btn);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.dataGridViewStf);
            this.Name = "View_All_Staff";
            this.Text = "View All Staff";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStf)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewStf;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.TextBox delete;
        private System.Windows.Forms.Button delete_btn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox value;
        private System.Windows.Forms.ComboBox column_name;
        private System.Windows.Forms.Button edit_btn;
        private System.Windows.Forms.TextBox edit;
        private System.Windows.Forms.ComboBox departmentList;
    }
}