namespace hotel_management
{
    partial class Manage_Packages
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
            this.label1 = new System.Windows.Forms.Label();
            this.textId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.costPerPerson = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.description = new System.Windows.Forms.TextBox();
            this.lable8 = new System.Windows.Forms.Label();
            this.complementary = new System.Windows.Forms.TextBox();
            this.viewAllPackages = new System.Windows.Forms.Button();
            this.create = new System.Windows.Forms.Button();
            this.reset = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(325, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id";
            // 
            // textId
            // 
            this.textId.Location = new System.Drawing.Point(326, 83);
            this.textId.Name = "textId";
            this.textId.Size = new System.Drawing.Size(183, 20);
            this.textId.TabIndex = 1;
            this.textId.TextChanged += new System.EventHandler(this.textId_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(326, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name";
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(327, 126);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(182, 20);
            this.name.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(327, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Cost per person";
            // 
            // costPerPerson
            // 
            this.costPerPerson.Location = new System.Drawing.Point(327, 170);
            this.costPerPerson.Name = "costPerPerson";
            this.costPerPerson.Size = new System.Drawing.Size(182, 20);
            this.costPerPerson.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(328, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Description";
            // 
            // description
            // 
            this.description.Location = new System.Drawing.Point(327, 214);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(182, 20);
            this.description.TabIndex = 7;
            // 
            // lable8
            // 
            this.lable8.AutoSize = true;
            this.lable8.Location = new System.Drawing.Point(330, 241);
            this.lable8.Name = "lable8";
            this.lable8.Size = new System.Drawing.Size(79, 13);
            this.lable8.TabIndex = 8;
            this.lable8.Text = "Complementary";
            // 
            // complementary
            // 
            this.complementary.Location = new System.Drawing.Point(328, 258);
            this.complementary.Name = "complementary";
            this.complementary.Size = new System.Drawing.Size(181, 20);
            this.complementary.TabIndex = 9;
            // 
            // viewAllPackages
            // 
            this.viewAllPackages.Location = new System.Drawing.Point(613, 12);
            this.viewAllPackages.Name = "viewAllPackages";
            this.viewAllPackages.Size = new System.Drawing.Size(124, 44);
            this.viewAllPackages.TabIndex = 10;
            this.viewAllPackages.Text = "View All Packages";
            this.viewAllPackages.UseVisualStyleBackColor = true;
            this.viewAllPackages.Click += new System.EventHandler(this.viewAllPackages_Click);
            // 
            // create
            // 
            this.create.Location = new System.Drawing.Point(467, 302);
            this.create.Name = "create";
            this.create.Size = new System.Drawing.Size(75, 23);
            this.create.TabIndex = 11;
            this.create.Text = "Create";
            this.create.UseVisualStyleBackColor = true;
            this.create.Click += new System.EventHandler(this.create_Click);
            // 
            // reset
            // 
            this.reset.Location = new System.Drawing.Point(386, 302);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(75, 23);
            this.reset.TabIndex = 12;
            this.reset.Text = "Reset";
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(305, 302);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(75, 23);
            this.cancel.TabIndex = 13;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // Manage_Packages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.create);
            this.Controls.Add(this.viewAllPackages);
            this.Controls.Add(this.complementary);
            this.Controls.Add(this.lable8);
            this.Controls.Add(this.description);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.costPerPerson);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textId);
            this.Controls.Add(this.label1);
            this.Name = "Manage_Packages";
            this.Text = "Manage Packages";
            this.Load += new System.EventHandler(this.Manage_Packages_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox costPerPerson;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox description;
        private System.Windows.Forms.Label lable8;
        private System.Windows.Forms.TextBox complementary;
        private System.Windows.Forms.Button viewAllPackages;
        private System.Windows.Forms.Button create;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.Button cancel;
    }
}