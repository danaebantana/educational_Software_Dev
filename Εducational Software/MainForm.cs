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
    public partial class MainForm : Form
    {
        public User user;
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            label_username.Text = user.GetName() + " " + user.GetSurname();
        }

    }
}
