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
                        pictureBox.Visible = true;
                        pictureBox.Enabled = true;
                    }
                }
                foreach (Label label in panel_units.Controls.OfType<Label>().Where(n => n.Text.Contains(unit.ToString())))
                {
                    label.Visible = true;
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
            TheoryForm theoryForm = new TheoryForm(auth, statisticsService, unit, false);
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
            TestForm testForm = new TestForm(auth, statisticsService, "revision", units, false);
            testForm.ShowDialog();
            this.Close();
        }

        private void profileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            ProfileForm profileForm = new ProfileForm(auth);
            profileForm.ShowDialog();
            this.Show();
        }

        private void TakeUnitSelfAssessmentTest(object sender, EventArgs e)
        {
            PictureBox clickedPictureBox = sender as PictureBox;
            //Get the selected unit
            string[] pictureBoxName = clickedPictureBox.Name.Split('_');
            int unit = Int32.Parse(pictureBoxName[2]);

            this.Hide();
            TestForm testForm = new TestForm(auth, statisticsService, unit.ToString(), new int[] { unit }, false);
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

        private void button_help_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Επέλεξε μία από τις διαθέσιμες ενότητες που φαίνονται στην οθόνη πατώντας το αντίστοιχο ζωάκι." +
                "Πατώντας το ζωάκι θα δεις την θεωρία του κεφαλαίου.\n" +
                "Εάν θες να κάνεις απευθείας ένα 'Τεστ Αυτοαξιολόγησης' πάνω σε μία ενότητα πάτα το ερωτηματικό δίπλα από το " +
                "ζωάκι που επιθυμείς.\n" +
                "Εάν θες να κάνεις ένα επαναληπτικό τεστ πάνω στις ενότητες που έχεις ολοκληρώσει πάτα το κουμπί 'Επαναληπτικό Τεστ'.\n" +
                "Τέλος για την παρουσιάση των στοιχείων σου, τη σύντομη αναφορά στη λειτουργία της εφαρμογής και για την αποσύνδεσή " +
                "σου από την εφαρμογή επέλεξε τα αντίστοιχα κουμπιά του μενού 'Προφίλ', 'Βοήθεια' και 'Αποσύνδεση'.");
        }
    }
}
