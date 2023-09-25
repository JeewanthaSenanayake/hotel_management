namespace hotel_management
{
    partial class CustomerMainMenu
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
            this.reservations = new System.Windows.Forms.Button();
            this.packages = new System.Windows.Forms.Button();
            this.logout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // reservations
            // 
            this.reservations.Location = new System.Drawing.Point(168, 151);
            this.reservations.Name = "reservations";
            this.reservations.Size = new System.Drawing.Size(145, 66);
            this.reservations.TabIndex = 0;
            this.reservations.Text = "Manage Reservations";
            this.reservations.UseVisualStyleBackColor = true;
            this.reservations.Click += new System.EventHandler(this.reservations_Click);
            // 
            // packages
            // 
            this.packages.Location = new System.Drawing.Point(411, 151);
            this.packages.Name = "packages";
            this.packages.Size = new System.Drawing.Size(145, 66);
            this.packages.TabIndex = 1;
            this.packages.Text = "View Packages";
            this.packages.UseVisualStyleBackColor = true;
            this.packages.Click += new System.EventHandler(this.packages_Click);
            // 
            // logout
            // 
            this.logout.Location = new System.Drawing.Point(713, 12);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(75, 23);
            this.logout.TabIndex = 3;
            this.logout.Text = "Logout";
            this.logout.UseVisualStyleBackColor = true;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // CustomerMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.logout);
            this.Controls.Add(this.packages);
            this.Controls.Add(this.reservations);
            this.Name = "CustomerMainMenu";
            this.Text = "Customer Main Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button reservations;
        private System.Windows.Forms.Button packages;
        private System.Windows.Forms.Button logout;
    }
}