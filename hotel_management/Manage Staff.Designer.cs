namespace hotel_management
{
    partial class Manage_Staff
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
            this.viewAllStaff = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.sId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.genderList = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.departmentList = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.address = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.number = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.TextBox();
            this.create = new System.Windows.Forms.Button();
            this.reset = new System.Windows.Forms.Button();
            this.cancle = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.samount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // viewAllStaff
            // 
            this.viewAllStaff.Location = new System.Drawing.Point(624, 12);
            this.viewAllStaff.Name = "viewAllStaff";
            this.viewAllStaff.Size = new System.Drawing.Size(118, 46);
            this.viewAllStaff.TabIndex = 0;
            this.viewAllStaff.Text = "View All Staff";
            this.viewAllStaff.UseVisualStyleBackColor = true;
            this.viewAllStaff.Click += new System.EventHandler(this.viewAllStaff_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(281, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Id";
            // 
            // sId
            // 
            this.sId.Location = new System.Drawing.Point(284, 83);
            this.sId.Name = "sId";
            this.sId.Size = new System.Drawing.Size(186, 20);
            this.sId.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(281, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Name";
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(284, 123);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(186, 20);
            this.name.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(280, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Gender";
            // 
            // genderList
            // 
            this.genderList.FormattingEnabled = true;
            this.genderList.Location = new System.Drawing.Point(284, 167);
            this.genderList.Name = "genderList";
            this.genderList.Size = new System.Drawing.Size(186, 21);
            this.genderList.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(280, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Department";
            // 
            // departmentList
            // 
            this.departmentList.FormattingEnabled = true;
            this.departmentList.Location = new System.Drawing.Point(283, 210);
            this.departmentList.Name = "departmentList";
            this.departmentList.Size = new System.Drawing.Size(187, 21);
            this.departmentList.TabIndex = 8;
            this.departmentList.SelectedIndexChanged += new System.EventHandler(this.departmentList_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(281, 239);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Address";
            // 
            // address
            // 
            this.address.Location = new System.Drawing.Point(284, 255);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(186, 20);
            this.address.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(281, 282);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Contact number";
            // 
            // number
            // 
            this.number.Location = new System.Drawing.Point(283, 299);
            this.number.Name = "number";
            this.number.Size = new System.Drawing.Size(187, 20);
            this.number.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(281, 326);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Email Address";
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(284, 343);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(186, 20);
            this.email.TabIndex = 14;
            // 
            // create
            // 
            this.create.Location = new System.Drawing.Point(252, 405);
            this.create.Name = "create";
            this.create.Size = new System.Drawing.Size(75, 23);
            this.create.TabIndex = 15;
            this.create.Text = "Create";
            this.create.UseVisualStyleBackColor = true;
            this.create.Click += new System.EventHandler(this.create_Click);
            // 
            // reset
            // 
            this.reset.Location = new System.Drawing.Point(333, 405);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(75, 23);
            this.reset.TabIndex = 16;
            this.reset.Text = "Reset";
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // cancle
            // 
            this.cancle.Location = new System.Drawing.Point(415, 405);
            this.cancle.Name = "cancle";
            this.cancle.Size = new System.Drawing.Size(75, 23);
            this.cancle.TabIndex = 17;
            this.cancle.Text = "Cancel";
            this.cancle.UseVisualStyleBackColor = true;
            this.cancle.Click += new System.EventHandler(this.cancle_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(284, 381);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Salary : ";
            // 
            // samount
            // 
            this.samount.AutoSize = true;
            this.samount.Location = new System.Drawing.Point(328, 381);
            this.samount.Name = "samount";
            this.samount.Size = new System.Drawing.Size(10, 13);
            this.samount.TabIndex = 19;
            this.samount.Text = " ";
            // 
            // Manage_Staff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.samount);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cancle);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.create);
            this.Controls.Add(this.email);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.number);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.address);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.departmentList);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.genderList);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.sId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.viewAllStaff);
            this.Name = "Manage_Staff";
            this.Text = "Manage Staff";
            this.Load += new System.EventHandler(this.Manage_Staff_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button viewAllStaff;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox sId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox genderList;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox departmentList;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox address;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox number;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.Button create;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.Button cancle;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label samount;
    }
}