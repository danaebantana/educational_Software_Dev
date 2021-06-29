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
        private StatisticsService statisticsService;
        private int[] units;

        public MainForm(AuthenticationService auth)
        {
            InitializeComponent();
            this.auth = auth;
            this.statisticsService = new StatisticsService(auth.GetUser());
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            User user = auth.GetUser();
            label_username.Text = user.GetName() + " " + user.GetSurname();
            LoadUnlockedUnits();
        }

        private void LoadUnlockedUnits()
        {
            List<int> unitList = statisticsService.GetCompletedUnits();
            units = unitList.ToArray();
            if (!unitList.Count.Equals(9) && statisticsService.GetStatistics(unitList.Count.ToString()).IsUnlocked())
            {
                unitList.Add(unitList.Count + 1);
            }
            if (unitList.Count.Equals(0))
            {
                unitList.Add(unitList.Count + 1);
            }
            var pictureBoxUnits = panel_units.Controls.OfType<PictureBox>();
            foreach (int unit in unitList)
            {
                foreach (PictureBox pictureBox in pictureBoxUnits)
                {
                    if (pictureBox.Name.Contains(unit.ToString()))
                    {
                        pictureBox.Image = (Image)Properties.Resources.ResourceManager.GetObject(unit.ToString());
                        pictureBox.Enabled = true;
                    }
                }
            }
        }

        private void SelectUnit(object sender, EventArgs e)
        {
            PictureBox clickedPictureBox = sender as PictureBox;
            //Get the selected unit
            string[] pictureBoxName = clickedPictureBox.Name.Split('_');
            int unit = Int32.Parse(pictureBoxName[1]);

            this.Hide();
            TheoryForm theoryForm = new TheoryForm(auth, statisticsService, unit);
            theoryForm.ShowDialog();
            this.Close();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            auth.Logout();
            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();
            this.Close();
        }

        private void button_revisionTest_Click(object sender, EventArgs e)
        {
            this.Hide();
            TestForm testForm = new TestForm(auth, statisticsService, "revision", units);
            testForm.ShowDialog();
            this.Close();
        }

        private void profileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            ProfileForm profileForm = new ProfileForm(auth);
            profileForm.ShowDialog();
            this.Close();
        }
    }
}
