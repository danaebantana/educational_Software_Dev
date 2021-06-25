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
        private List<Panel> panelQuestionList;
        Random random;

        public TestForm(AuthenticationService _auth, int _unit)
        {
            InitializeComponent();
            this.auth = _auth;
            this.unit = _unit;
            panelQuestionList = new List<Panel>() { panel_fillTheBlank, panel_trueOrFalse, panel_multiplyChoice };
            random = new Random();
        }

        private void TestForm_Load(object sender, EventArgs e)
        {
            pictureBox_helper.Image = (Image)Properties.Resources.ResourceManager.GetObject(unit.ToString());
        }

        private void button_start_Click(object sender, EventArgs e)
        {
            button_start.Visible = false;
            //Randomly pick a type of Question through the panelQuestionList
            int index = random.Next(panelQuestionList.Count - 1);
            Panel panel = panelQuestionList.ElementAt(index);
            panel.Visible = true;
        }
    }
}
