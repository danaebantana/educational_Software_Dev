namespace Εducational_Software
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.label_Mathster = new System.Windows.Forms.Label();
            this.textBox_username = new System.Windows.Forms.TextBox();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.button_login = new System.Windows.Forms.Button();
            this.linkLabel_register = new System.Windows.Forms.LinkLabel();
            this.panel_login = new System.Windows.Forms.Panel();
            this.button_help = new System.Windows.Forms.Button();
            this.label_password = new System.Windows.Forms.Label();
            this.label_username = new System.Windows.Forms.Label();
            this.panel_login.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_Mathster
            // 
            this.label_Mathster.AutoSize = true;
            this.label_Mathster.BackColor = System.Drawing.Color.Transparent;
            this.label_Mathster.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Mathster.Location = new System.Drawing.Point(135, 48);
            this.label_Mathster.Name = "label_Mathster";
            this.label_Mathster.Size = new System.Drawing.Size(151, 39);
            this.label_Mathster.TabIndex = 0;
            this.label_Mathster.Text = "Mathster";
            // 
            // textBox_username
            // 
            this.textBox_username.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_username.Location = new System.Drawing.Point(149, 12);
            this.textBox_username.Name = "textBox_username";
            this.textBox_username.Size = new System.Drawing.Size(181, 31);
            this.textBox_username.TabIndex = 1;
            // 
            // textBox_password
            // 
            this.textBox_password.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_password.Location = new System.Drawing.Point(149, 61);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.PasswordChar = '*';
            this.textBox_password.Size = new System.Drawing.Size(181, 31);
            this.textBox_password.TabIndex = 2;
            // 
            // button_login
            // 
            this.button_login.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_login.Location = new System.Drawing.Point(17, 115);
            this.button_login.Name = "button_login";
            this.button_login.Size = new System.Drawing.Size(267, 36);
            this.button_login.TabIndex = 3;
            this.button_login.Text = "Είσοδος";
            this.button_login.UseVisualStyleBackColor = true;
            this.button_login.Click += new System.EventHandler(this.button_login_Click);
            // 
            // linkLabel_register
            // 
            this.linkLabel_register.AutoSize = true;
            this.linkLabel_register.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel_register.LinkColor = System.Drawing.Color.Snow;
            this.linkLabel_register.Location = new System.Drawing.Point(13, 154);
            this.linkLabel_register.Name = "linkLabel_register";
            this.linkLabel_register.Size = new System.Drawing.Size(321, 21);
            this.linkLabel_register.TabIndex = 4;
            this.linkLabel_register.TabStop = true;
            this.linkLabel_register.Text = "Δεν έχετε λογαριασμό; Εγγραφείτε εδώ";
            this.linkLabel_register.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_register_LinkClicked);
            // 
            // panel_login
            // 
            this.panel_login.BackColor = System.Drawing.Color.Transparent;
            this.panel_login.Controls.Add(this.button_help);
            this.panel_login.Controls.Add(this.label_password);
            this.panel_login.Controls.Add(this.label_username);
            this.panel_login.Controls.Add(this.linkLabel_register);
            this.panel_login.Controls.Add(this.textBox_username);
            this.panel_login.Controls.Add(this.button_login);
            this.panel_login.Controls.Add(this.textBox_password);
            this.panel_login.Location = new System.Drawing.Point(35, 112);
            this.panel_login.Name = "panel_login";
            this.panel_login.Size = new System.Drawing.Size(342, 184);
            this.panel_login.TabIndex = 5;
            // 
            // button_help
            // 
            this.button_help.Image = global::Εducational_Software.Properties.Resources.help;
            this.button_help.Location = new System.Drawing.Point(290, 114);
            this.button_help.Name = "button_help";
            this.button_help.Size = new System.Drawing.Size(40, 40);
            this.button_help.TabIndex = 7;
            this.button_help.UseVisualStyleBackColor = true;
            this.button_help.Click += new System.EventHandler(this.button_help_Click);
            // 
            // label_password
            // 
            this.label_password.AutoSize = true;
            this.label_password.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_password.ForeColor = System.Drawing.Color.White;
            this.label_password.Location = new System.Drawing.Point(60, 65);
            this.label_password.Name = "label_password";
            this.label_password.Size = new System.Drawing.Size(83, 21);
            this.label_password.TabIndex = 6;
            this.label_password.Text = "Κωδικός:";
            // 
            // label_username
            // 
            this.label_username.AutoSize = true;
            this.label_username.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_username.ForeColor = System.Drawing.Color.White;
            this.label_username.Location = new System.Drawing.Point(4, 16);
            this.label_username.Name = "label_username";
            this.label_username.Size = new System.Drawing.Size(139, 21);
            this.label_username.TabIndex = 5;
            this.label_username.Text = "Όνομα Χρήστη:";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Εducational_Software.Properties.Resources.loginBackground;
            this.ClientSize = new System.Drawing.Size(410, 375);
            this.Controls.Add(this.panel_login);
            this.Controls.Add(this.label_Mathster);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mathster";
            this.panel_login.ResumeLayout(false);
            this.panel_login.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Mathster;
        private System.Windows.Forms.TextBox textBox_username;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.Button button_login;
        private System.Windows.Forms.LinkLabel linkLabel_register;
        private System.Windows.Forms.Panel panel_login;
        private System.Windows.Forms.Label label_password;
        private System.Windows.Forms.Label label_username;
        private System.Windows.Forms.Button button_help;
    }
}