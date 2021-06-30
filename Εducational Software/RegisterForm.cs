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
    public partial class RegisterForm : Form
    {
        AuthenticationService auth;

        public RegisterForm(AuthenticationService auth)
        {
            InitializeComponent();
            this.auth = auth;
        }

        private void button_register_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox_name.Text) || String.IsNullOrEmpty(textBox_surname.Text)
                || String.IsNullOrEmpty(textBox_email.Text) || String.IsNullOrEmpty(textBox_username.Text)
                || String.IsNullOrEmpty(textBox_password.Text))
            {
                MessageBox.Show("Πρέπει να συμπληρώσεις όλα τα πεδία!");
            }
            else
            {
                try
                {
                    auth.Register(textBox_name.Text, textBox_surname.Text, textBox_email.Text, textBox_username.Text, textBox_password.Text);
                    MessageBox.Show("Η εγγραφή έγινε με επιτυχία!");
                    this.Close();
                } catch (UserExistsException uex) 
                {
                    
                    MessageBox.Show(String.Format("Ο χρήστης με όνομα \"{0}\" υπάρχει ήδη.Επέλεξε κάτι διαφορετικό", uex.GetUsername()));
                } catch (Exception)
                {
                    MessageBox.Show("Ξαφνικό σφάλμα! Προσπάθησε ξανα!");
                }      
            }
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
