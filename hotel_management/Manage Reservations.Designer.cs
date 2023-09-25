namespace hotel_management
{
    partial class Manage_Reservations
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
            this.Id = new System.Windows.Forms.Label();
            this.textId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.fName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.address = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.mobile = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.noOfPax = new System.Windows.Forms.TextBox();
            this.create = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.reset = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.tcost = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Id
            // 
            this.Id.AutoSize = true;
            this.Id.Location = new System.Drawing.Point(303, 33);
            this.Id.Name = "Id";
            this.Id.Size = new System.Drawing.Size(16, 13);
            this.Id.TabIndex = 0;
            this.Id.Text = "Id";
            // 
            // textId
            // 
            this.textId.Location = new System.Drawing.Point(305, 50);
            this.textId.Name = "textId";
            this.textId.Size = new System.Drawing.Size(183, 20);
            this.textId.TabIndex = 1;
            this.textId.TextChanged += new System.EventHandler(this.textId_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(303, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Full Name";
            // 
            // fName
            // 
            this.fName.Location = new System.Drawing.Point(305, 95);
            this.fName.Name = "fName";
            this.fName.Size = new System.Drawing.Size(183, 20);
            this.fName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(304, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Address";
            // 
            // address
            // 
            this.address.Location = new System.Drawing.Point(305, 139);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(183, 20);
            this.address.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(304, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Mobile ";
            // 
            // mobile
            // 
            this.mobile.Location = new System.Drawing.Point(305, 183);
            this.mobile.Name = "mobile";
            this.mobile.Size = new System.Drawing.Size(183, 20);
            this.mobile.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(303, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Reservation date";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.CustomFormat = "";
            this.dateTimePicker.Location = new System.Drawing.Point(306, 227);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(182, 20);
            this.dateTimePicker.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(306, 254);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "No of Pax";
            // 
            // noOfPax
            // 
            this.noOfPax.Location = new System.Drawing.Point(307, 271);
            this.noOfPax.Name = "noOfPax";
            this.noOfPax.Size = new System.Drawing.Size(181, 20);
            this.noOfPax.TabIndex = 11;
            this.noOfPax.Text = "0";
            this.noOfPax.TextChanged += new System.EventHandler(this.noOfPax_TextChanged);
            // 
            // create
            // 
            this.create.Location = new System.Drawing.Point(277, 329);
            this.create.Name = "create";
            this.create.Size = new System.Drawing.Size(75, 23);
            this.create.TabIndex = 12;
            this.create.Text = "Create";
            this.create.UseVisualStyleBackColor = true;
            this.create.Click += new System.EventHandler(this.create_Click);
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(368, 329);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(75, 23);
            this.cancel.TabIndex = 13;
            this.cancel.Text = "Cancel ";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // reset
            // 
            this.reset.Location = new System.Drawing.Point(457, 329);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(75, 23);
            this.reset.TabIndex = 14;
            this.reset.Text = "Reset";
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(307, 298);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Total cost : ";
            // 
            // tcost
            // 
            this.tcost.AutoSize = true;
            this.tcost.Location = new System.Drawing.Point(368, 297);
            this.tcost.Name = "tcost";
            this.tcost.Size = new System.Drawing.Size(0, 13);
            this.tcost.TabIndex = 16;
            // 
            // Manage_Reservations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tcost);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.create);
            this.Controls.Add(this.noOfPax);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.mobile);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.address);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.fName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textId);
            this.Controls.Add(this.Id);
            this.Name = "Manage_Reservations";
            this.Text = "Manage Reservations";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Id;
        private System.Windows.Forms.TextBox textId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox fName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox address;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox mobile;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox noOfPax;
        private System.Windows.Forms.Button create;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label tcost;
    }
}