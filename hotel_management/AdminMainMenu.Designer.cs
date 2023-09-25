namespace hotel_management
{
    partial class AdminMainMenu
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
            this.staff = new System.Windows.Forms.Button();
            this.packages = new System.Windows.Forms.Button();
            this.logout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // staff
            // 
            this.staff.Location = new System.Drawing.Point(159, 146);
            this.staff.Name = "staff";
            this.staff.Size = new System.Drawing.Size(126, 54);
            this.staff.TabIndex = 0;
            this.staff.Text = "Manage Staff ";
            this.staff.UseVisualStyleBackColor = true;
            this.staff.Click += new System.EventHandler(this.staff_Click);
            // 
            // packages
            // 
            this.packages.Location = new System.Drawing.Point(406, 146);
            this.packages.Name = "packages";
            this.packages.Size = new System.Drawing.Size(126, 54);
            this.packages.TabIndex = 1;
            this.packages.Text = "Manage Packages";
            this.packages.UseVisualStyleBackColor = true;
            this.packages.Click += new System.EventHandler(this.packages_Click);
            // 
            // logout
            // 
            this.logout.Location = new System.Drawing.Point(713, 13);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(75, 23);
            this.logout.TabIndex = 2;
            this.logout.Text = "Logout";
            this.logout.UseVisualStyleBackColor = true;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // AdminMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.logout);
            this.Controls.Add(this.packages);
            this.Controls.Add(this.staff);
            this.Name = "AdminMainMenu";
            this.Text = "Admin Main Menu";
            this.Load += new System.EventHandler(this.AdminMainMenu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button staff;
        private System.Windows.Forms.Button packages;
        private System.Windows.Forms.Button logout;
    }
}