using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Εducational_Software.Services;

namespace Εducational_Software
{
    public partial class TheoryForm : Form
    {
        private AuthenticationService auth;
        private StatisticsService statisticsService;
        private int unit;
        public TheoryForm(AuthenticationService _auth, StatisticsService _statisticsService,  int _unit)
        {
            InitializeComponent();
            this.auth = _auth;
            this.statisticsService = _statisticsService;
            this.unit = _unit;
        }

        private void TheoryForm_Load(object sender, EventArgs e)
        {
            label_unit.Text = unit.ToString();
            label_multiTableNum.Text = unit.ToString();
            pictureBox_helper.Image = (Image)Properties.Resources.ResourceManager.GetObject(unit.ToString());
            Load_Unit_Theory(unit);

            // Keep track of the theory revision
            statisticsService.AddTheoryRevision(unit.ToString());
        }

        private void Load_Unit_Theory(int unit)
        {
            //Load Multiplication number and results.
            var multiLabels = panel_multiplicationTable.Controls.OfType<Label>().Where(n => n.Name.Contains("label_multiNum"));
            foreach (Label l in multiLabels)
            {
                l.Text = unit.ToString();
            }

            List<int> results = new List<int>(){1*unit, 2*unit, 3*unit, 4*unit, 5*unit, 6*unit, 7*unit, 8*unit, 9*unit, 10*unit};            
            var resultsLabels = panel_multiplicationTable.Controls.OfType<Label>().Where(n => n.Name.Contains("label_result")).OrderBy(t => t.TabIndex);
            int count = 0;
            foreach (Label l in resultsLabels)
            {
                l.Text = results.ElementAt(count).ToString();
                count++;
            }

            //Set Multiplication table colour.
            List<Color> colourList = new List<Color>()
            {
                Color.Salmon, Color.Coral, Color.Gold, Color.DarkKhaki, Color.YellowGreen, Color.LightGreen,
                Color.SpringGreen, Color.Turquoise, Color.Aquamarine, Color.LightBlue, Color.LightSteelBlue,
                Color.Plum, Color.Violet, Color.PaleVioletRed, Color.LightPink
            };
            Random random = new Random();
            int index = random.Next(colourList.Count-1);
            panel_multiplicationTable.BackColor = colourList.ElementAt(index);
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mainForm = new MainForm(auth);
            mainForm.ShowDialog();
            this.Close();
        }

        private void button_test_Click(object sender, EventArgs e)
        {
            this.Hide();
            TestForm testForm = new TestForm(auth, statisticsService, unit.ToString(), new int[]{ unit });
            testForm.ShowDialog();
            this.Close();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            HelpForm helpForm = new HelpForm();
            helpForm.ShowDialog();
            this.Show();
        }
    }
}
