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
    public partial class TestForm : Form
    {
        private AuthenticationService auth;
        private int unit;

        public TestForm(AuthenticationService _auth, int _unit)
        {
            InitializeComponent();
            this.auth = _auth;
            this.unit = _unit;
        }

        private void TestForm_Load(object sender, EventArgs e)
        {
            pictureBox_helper.Image = (Image)Properties.Resources.ResourceManager.GetObject(unit.ToString());
        }
    }
}
