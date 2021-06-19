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
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
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
                User user = new User(textBox_name.Text, textBox_surname.Text, textBox_email.Text, 
                    textBox_username.Text, textBox_password.Text);
                DataConnection conn = new DataConnection();
                String result = conn.RegisterUser(user);
                MessageBox.Show(result);
                if(result.Equals("Η εγγραφή έγινε με επιτυχία!"))
                {
                    this.Close();
                }           
            }
        }
    }
}
