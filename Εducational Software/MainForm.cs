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
    public partial class MainForm : Form
    {
        private AuthenticationService auth;

        public MainForm(AuthenticationService auth)
        {
            InitializeComponent();
            this.auth = auth;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            User user = auth.GetUser();
            label_username.Text = user.GetName() + " " + user.GetSurname();
        }

    }
}
