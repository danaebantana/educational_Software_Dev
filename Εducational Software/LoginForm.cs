using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Εducational_Software
{
    public partial class LoginForm : Form
    {
        private DataConnection conn;

        public LoginForm()
        {
            InitializeComponent();
            conn = new DataConnection();
        }

        private void linkLabel_register_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            RegisterForm rf = new RegisterForm();
            rf.ShowDialog();
            this.Show();
        }

        private void button_login_Click(object sender, EventArgs e)
        {
            User u = conn.Login(textBox_username.Text, textBox_password.Text);
            if (u.GetName()!=(null))
            {
                this.Hide();
                MainForm main = new MainForm();
                main.user = u;
                main.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Ο λογαριασμός δεν βρέθηκε!");
                textBox_username.Clear();
                textBox_password.Clear();
            }
        }
    }
}
