namespace Εducational_Software
{
    partial class RegisterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            this.label_Register = new System.Windows.Forms.Label();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.textBox_surname = new System.Windows.Forms.TextBox();
            this.textBox_username = new System.Windows.Forms.TextBox();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.panel_registerUserDetails = new System.Windows.Forms.Panel();
            this.label_email = new System.Windows.Forms.Label();
            this.textBox_email = new System.Windows.Forms.TextBox();
            this.label_surname = new System.Windows.Forms.Label();
            this.label_name = new System.Windows.Forms.Label();
            this.panel_registerLoginUserDetails = new System.Windows.Forms.Panel();
            this.label_password = new System.Windows.Forms.Label();
            this.label_username = new System.Windows.Forms.Label();
            this.button_register = new System.Windows.Forms.Button();
            this.button_help = new System.Windows.Forms.Button();
            this.panel_registerUserDetails.SuspendLayout();
            this.panel_registerLoginUserDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_Register
            // 
            this.label_Register.AutoSize = true;
            this.label_Register.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Register.Location = new System.Drawing.Point(174, 29);
            this.label_Register.Name = "label_Register";
            this.label_Register.Size = new System.Drawing.Size(158, 39);
            this.label_Register.TabIndex = 0;
            this.label_Register.Text = "Εγγραφή";
            // 
            // textBox_name
            // 
            this.textBox_name.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_name.Location = new System.Drawing.Point(159, 25);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(181, 31);
            this.textBox_name.TabIndex = 1;
            // 
            // textBox_surname
            // 
            this.textBox_surname.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_surname.Location = new System.Drawing.Point(159, 69);
            this.textBox_surname.Name = "textBox_surname";
            this.textBox_surname.Size = new System.Drawing.Size(181, 31);
            this.textBox_surname.TabIndex = 2;
            // 
            // textBox_username
            // 
            this.textBox_username.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_username.Location = new System.Drawing.Point(159, 28);
            this.textBox_username.Name = "textBox_username";
            this.textBox_username.Size = new System.Drawing.Size(181, 31);
            this.textBox_username.TabIndex = 4;
            // 
            // textBox_password
            // 
            this.textBox_password.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_password.Location = new System.Drawing.Point(159, 69);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.Size = new System.Drawing.Size(181, 31);
            this.textBox_password.TabIndex = 5;
            // 
            // panel_registerUserDetails
            // 
            this.panel_registerUserDetails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_registerUserDetails.Controls.Add(this.label_email);
            this.panel_registerUserDetails.Controls.Add(this.textBox_name);
            this.panel_registerUserDetails.Controls.Add(this.textBox_surname);
            this.panel_registerUserDetails.Controls.Add(this.textBox_email);
            this.panel_registerUserDetails.Controls.Add(this.label_surname);
            this.panel_registerUserDetails.Controls.Add(this.label_name);
            this.panel_registerUserDetails.Location = new System.Drawing.Point(64, 82);
            this.panel_registerUserDetails.Name = "panel_registerUserDetails";
            this.panel_registerUserDetails.Size = new System.Drawing.Size(375, 166);
            this.panel_registerUserDetails.TabIndex = 5;
            // 
            // label_email
            // 
            this.label_email.AutoSize = true;
            this.label_email.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_email.Location = new System.Drawing.Point(97, 116);
            this.label_email.Name = "label_email";
            this.label_email.Size = new System.Drawing.Size(56, 21);
            this.label_email.TabIndex = 13;
            this.label_email.Text = "Εμαιλ:";
            // 
            // textBox_email
            // 
            this.textBox_email.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_email.Location = new System.Drawing.Point(159, 112);
            this.textBox_email.Name = "textBox_email";
            this.textBox_email.Size = new System.Drawing.Size(181, 31);
            this.textBox_email.TabIndex = 3;
            // 
            // label_surname
            // 
            this.label_surname.AutoSize = true;
            this.label_surname.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_surname.Location = new System.Drawing.Point(84, 73);
            this.label_surname.Name = "label_surname";
            this.label_surname.Size = new System.Drawing.Size(70, 21);
            this.label_surname.TabIndex = 10;
            this.label_surname.Text = "Επίθετο:";
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_name.Location = new System.Drawing.Point(85, 35);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(69, 21);
            this.label_name.TabIndex = 9;
            this.label_name.Text = "Όνομα:";
            // 
            // panel_registerLoginUserDetails
            // 
            this.panel_registerLoginUserDetails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_registerLoginUserDetails.Controls.Add(this.label_password);
            this.panel_registerLoginUserDetails.Controls.Add(this.label_username);
            this.panel_registerLoginUserDetails.Controls.Add(this.textBox_username);
            this.panel_registerLoginUserDetails.Controls.Add(this.textBox_password);
            this.panel_registerLoginUserDetails.Location = new System.Drawing.Point(64, 265);
            this.panel_registerLoginUserDetails.Name = "panel_registerLoginUserDetails";
            this.panel_registerLoginUserDetails.Size = new System.Drawing.Size(375, 126);
            this.panel_registerLoginUserDetails.TabIndex = 6;
            // 
            // label_password
            // 
            this.label_password.AutoSize = true;
            this.label_password.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_password.Location = new System.Drawing.Point(78, 73);
            this.label_password.Name = "label_password";
            this.label_password.Size = new System.Drawing.Size(75, 21);
            this.label_password.TabIndex = 12;
            this.label_password.Text = "Κωδικός:";
            // 
            // label_username
            // 
            this.label_username.AutoSize = true;
            this.label_username.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_username.Location = new System.Drawing.Point(23, 32);
            this.label_username.Name = "label_username";
            this.label_username.Size = new System.Drawing.Size(130, 21);
            this.label_username.TabIndex = 11;
            this.label_username.Text = "Όνομα Χρήστη:";
            // 
            // button_register
            // 
            this.button_register.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_register.Location = new System.Drawing.Point(200, 397);
            this.button_register.Name = "button_register";
            this.button_register.Size = new System.Drawing.Size(94, 41);
            this.button_register.TabIndex = 6;
            this.button_register.Text = "Εγγραφή";
            this.button_register.UseVisualStyleBackColor = true;
            // 
            // button_help
            // 
            this.button_help.Location = new System.Drawing.Point(300, 397);
            this.button_help.Name = "button_help";
            this.button_help.Size = new System.Drawing.Size(49, 41);
            this.button_help.TabIndex = 8;
            this.button_help.Text = "Help";
            this.button_help.UseVisualStyleBackColor = true;
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 467);
            this.Controls.Add(this.button_help);
            this.Controls.Add(this.button_register);
            this.Controls.Add(this.panel_registerLoginUserDetails);
            this.Controls.Add(this.panel_registerUserDetails);
            this.Controls.Add(this.label_Register);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mathster";
            this.panel_registerUserDetails.ResumeLayout(false);
            this.panel_registerUserDetails.PerformLayout();
            this.panel_registerLoginUserDetails.ResumeLayout(false);
            this.panel_registerLoginUserDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Register;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.TextBox textBox_surname;
        private System.Windows.Forms.TextBox textBox_username;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.Panel panel_registerUserDetails;
        private System.Windows.Forms.Panel panel_registerLoginUserDetails;
        private System.Windows.Forms.TextBox textBox_email;
        private System.Windows.Forms.Button button_register;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.Label label_surname;
        private System.Windows.Forms.Label label_username;
        private System.Windows.Forms.Label label_password;
        private System.Windows.Forms.Label label_email;
        private System.Windows.Forms.Button button_help;
    }
}