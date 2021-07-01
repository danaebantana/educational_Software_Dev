using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Εducational_Software.Services;

namespace Εducational_Software
{
    public partial class LoginForm : Form
    {
        private AuthenticationService auth;

        public LoginForm()
        {
            InitializeComponent();
            auth = new AuthenticationService();
        }

        private void linkLabel_register_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            RegisterForm rf = new RegisterForm(auth);
            rf.ShowDialog();
            this.Show();
        }

        private void button_login_Click(object sender, EventArgs e)
        {
            try
            {
                User u = auth.Login(textBox_username.Text, textBox_password.Text);
                this.Hide();
                MainForm main = new MainForm(auth);
                main.ShowDialog();
                this.Close();
            } catch (InvalidCredentialsException)
            {
                MessageBox.Show("Ο λογαριασμός δεν βρέθηκε!");
                textBox_username.Clear();
                textBox_password.Clear();
            }
        }

        private void button_help_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Για να μπεις στην εφαρμογή βάλε το 'Όνομα χρήστη' σου και τον 'Κωδικό' σου στα αντίστοιχα πεδία " +
                "και πάτησε το κουμπί 'Είσοδος'. \n" +
                "Εάν δεν έχεις λογαριασμό πάτησε το λινκ 'Δεν έχετε λογαριασμό; Εγγραφείτε εδώ'.");
        }
    }
}
