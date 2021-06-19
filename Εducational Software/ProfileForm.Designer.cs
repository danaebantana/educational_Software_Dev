namespace Εducational_Software
{
    partial class ProfileForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProfileForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.βοήθειαToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label_nameOfUser = new System.Windows.Forms.Label();
            this.label_surnameOfUser = new System.Windows.Forms.Label();
            this.label_emailOfUser = new System.Windows.Forms.Label();
            this.groupBox_personalDetails = new System.Windows.Forms.GroupBox();
            this.label_email = new System.Windows.Forms.Label();
            this.label_name = new System.Windows.Forms.Label();
            this.label_surname = new System.Windows.Forms.Label();
            this.label_profile = new System.Windows.Forms.Label();
            this.groupBox_statisticalDetails = new System.Windows.Forms.GroupBox();
            this.button_help = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.groupBox_personalDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backToolStripMenuItem,
            this.βοήθειαToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(692, 29);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // backToolStripMenuItem
            // 
            this.backToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backToolStripMenuItem.Name = "backToolStripMenuItem";
            this.backToolStripMenuItem.Size = new System.Drawing.Size(60, 25);
            this.backToolStripMenuItem.Text = "Πίσω";
            // 
            // βοήθειαToolStripMenuItem
            // 
            this.βοήθειαToolStripMenuItem.Name = "βοήθειαToolStripMenuItem";
            this.βοήθειαToolStripMenuItem.Size = new System.Drawing.Size(82, 25);
            this.βοήθειαToolStripMenuItem.Text = "Βοήθεια";
            // 
            // label_nameOfUser
            // 
            this.label_nameOfUser.AutoSize = true;
            this.label_nameOfUser.Location = new System.Drawing.Point(34, 44);
            this.label_nameOfUser.Name = "label_nameOfUser";
            this.label_nameOfUser.Size = new System.Drawing.Size(69, 21);
            this.label_nameOfUser.TabIndex = 2;
            this.label_nameOfUser.Text = "Όνομα:";
            // 
            // label_surnameOfUser
            // 
            this.label_surnameOfUser.AutoSize = true;
            this.label_surnameOfUser.Location = new System.Drawing.Point(33, 80);
            this.label_surnameOfUser.Name = "label_surnameOfUser";
            this.label_surnameOfUser.Size = new System.Drawing.Size(70, 21);
            this.label_surnameOfUser.TabIndex = 3;
            this.label_surnameOfUser.Text = "Επίθετο:";
            // 
            // label_emailOfUser
            // 
            this.label_emailOfUser.AutoSize = true;
            this.label_emailOfUser.Location = new System.Drawing.Point(47, 117);
            this.label_emailOfUser.Name = "label_emailOfUser";
            this.label_emailOfUser.Size = new System.Drawing.Size(56, 21);
            this.label_emailOfUser.TabIndex = 4;
            this.label_emailOfUser.Text = "Εμαιλ:";
            // 
            // groupBox_personalDetails
            // 
            this.groupBox_personalDetails.Controls.Add(this.label_email);
            this.groupBox_personalDetails.Controls.Add(this.label_name);
            this.groupBox_personalDetails.Controls.Add(this.label_nameOfUser);
            this.groupBox_personalDetails.Controls.Add(this.label_surname);
            this.groupBox_personalDetails.Controls.Add(this.label_emailOfUser);
            this.groupBox_personalDetails.Controls.Add(this.label_surnameOfUser);
            this.groupBox_personalDetails.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_personalDetails.Location = new System.Drawing.Point(25, 107);
            this.groupBox_personalDetails.Name = "groupBox_personalDetails";
            this.groupBox_personalDetails.Size = new System.Drawing.Size(640, 168);
            this.groupBox_personalDetails.TabIndex = 6;
            this.groupBox_personalDetails.TabStop = false;
            this.groupBox_personalDetails.Text = "Προσωπικά Στοιχεία";
            // 
            // label_email
            // 
            this.label_email.AutoSize = true;
            this.label_email.Location = new System.Drawing.Point(149, 117);
            this.label_email.Name = "label_email";
            this.label_email.Size = new System.Drawing.Size(15, 21);
            this.label_email.TabIndex = 7;
            this.label_email.Text = "-";
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Location = new System.Drawing.Point(149, 44);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(15, 21);
            this.label_name.TabIndex = 5;
            this.label_name.Text = "-";
            // 
            // label_surname
            // 
            this.label_surname.AutoSize = true;
            this.label_surname.Location = new System.Drawing.Point(149, 80);
            this.label_surname.Name = "label_surname";
            this.label_surname.Size = new System.Drawing.Size(15, 21);
            this.label_surname.TabIndex = 6;
            this.label_surname.Text = "-";
            // 
            // label_profile
            // 
            this.label_profile.AutoSize = true;
            this.label_profile.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_profile.Location = new System.Drawing.Point(18, 43);
            this.label_profile.Name = "label_profile";
            this.label_profile.Size = new System.Drawing.Size(129, 39);
            this.label_profile.TabIndex = 7;
            this.label_profile.Text = "Προφίλ";
            // 
            // groupBox_statisticalDetails
            // 
            this.groupBox_statisticalDetails.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_statisticalDetails.Location = new System.Drawing.Point(25, 294);
            this.groupBox_statisticalDetails.Name = "groupBox_statisticalDetails";
            this.groupBox_statisticalDetails.Size = new System.Drawing.Size(640, 147);
            this.groupBox_statisticalDetails.TabIndex = 8;
            this.groupBox_statisticalDetails.TabStop = false;
            this.groupBox_statisticalDetails.Text = "Στατιστικά Στοιχεία:";
            // 
            // button_help
            // 
            this.button_help.Location = new System.Drawing.Point(619, 53);
            this.button_help.Name = "button_help";
            this.button_help.Size = new System.Drawing.Size(46, 36);
            this.button_help.TabIndex = 9;
            this.button_help.Text = "Help";
            this.button_help.UseVisualStyleBackColor = true;
            // 
            // ProfileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 453);
            this.Controls.Add(this.button_help);
            this.Controls.Add(this.groupBox_statisticalDetails);
            this.Controls.Add(this.label_profile);
            this.Controls.Add(this.groupBox_personalDetails);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ProfileForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mathster";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox_personalDetails.ResumeLayout(false);
            this.groupBox_personalDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
        private System.Windows.Forms.Label label_nameOfUser;
        private System.Windows.Forms.Label label_surnameOfUser;
        private System.Windows.Forms.Label label_emailOfUser;
        private System.Windows.Forms.GroupBox groupBox_personalDetails;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.Label label_email;
        private System.Windows.Forms.Label label_surname;
        private System.Windows.Forms.Label label_profile;
        private System.Windows.Forms.GroupBox groupBox_statisticalDetails;
        private System.Windows.Forms.ToolStripMenuItem βοήθειαToolStripMenuItem;
        private System.Windows.Forms.Button button_help;
    }
}