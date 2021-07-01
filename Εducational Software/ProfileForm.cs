using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Εducational_Software.Models;
using Εducational_Software.Services;

namespace Εducational_Software
{
    public partial class ProfileForm : Form
    {
        private AuthenticationService auth;
        private ProgressService progressService;
        private List<double> unitsTestsSuccess;
        private List<double> unitsTestsFailure;
        private double revisionTestSuccess;
        private double revisionTestFailure;
        private List<int> units;

        public ProfileForm(AuthenticationService _auth)
        {
            InitializeComponent();
            this.auth = _auth;
            this.progressService = new ProgressService(auth.GetUser());
        }

        private void ProfileForm_Load(object sender, EventArgs e)
        {
            label_name.Text = auth.GetUser().GetName();
            label_surname.Text = auth.GetUser().GetSurname();
            label_email.Text = auth.GetUser().GetEmail();

            LoadProgress();
            label_unit.Text = units.Count.ToString();
            LoadCharts(unitsTestsSuccess, unitsTestsFailure);
        }

        public void LoadProgress()
        {
            unitsTestsSuccess = progressService.GetUnitTestScore(true);
            unitsTestsFailure = progressService.GetUnitTestScore(false);
            units = progressService.GetUnlockedUnits();
            revisionTestSuccess = progressService.GetRevisionRates(true);
            revisionTestFailure = progressService.GetRevisionRates(false);
        }

        private void LoadCharts(List<double> successRates, List<double> failureRates)
        {
            foreach (int unit in units)
            {
                string quiz_id = unit.ToString();

                //Load rates of Self-assessment tests
                chart_unitRates.Series["Επιτυχία"].Points.AddXY("Ενότητα: "+ quiz_id, successRates.ElementAt(unit-1));
                chart_unitRates.Series["Αποτυχία"].Points.AddXY("Ενότητα: " + quiz_id, failureRates.ElementAt(unit - 1));

                // Load theory revisions
                chart_theoryRevisions
                    .Series["Επαναλήψεις Θεωρίας"]
                    .Points.AddXY(
                        "Προπαίδεια του " + quiz_id,
                        progressService.GetStatistics(quiz_id).GetTheoryRevisions()
                    );

                //Load units that the user faces understanding problems
                if (failureRates.ElementAt(unit - 1) > successRates.ElementAt(unit - 1))
                {
                    chart_unitProblems.Series["Ενότητες"].Points.AddXY("Ενότητα: " + quiz_id, 100);
                }
                else
                {
                    chart_unitProblems.Series["Ενότητες"].Points.AddXY("Ενότητα: " + quiz_id, 0);
                }
            }

            //Load rates of Revision tests
            chart_revisionRates.Series["Revision"].Points.AddXY("Επιτυχία", revisionTestSuccess.ToString());
            chart_revisionRates.Series["Revision"].Points.AddXY("Αποτυχία", revisionTestFailure.ToString());
            chart_revisionRates.Series["Revision"].Points[1].Color = Color.Red;
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
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
            MessageBox.Show("Εδώ παρουσιάζονται τα προσωπικά και τα στατιστικά σου στοιχεία.\n" +
                "Στα προσωπικά στοιχεία είναι εμφανή το 'Όνομα', το 'Επίθετο' και το 'Email'.\n" +
                "Στα στατιστικά στοιχεία εμφανίζεται ο αριθμός των ολοκληρωμένων ενοτήτων και με διαγράμματα " +
                "το ποσοστό των επιτυχιών και αποτυχιών στα 'Τεστ Αυτοαξιολόγησης' κάθε ενότητας, " +
                "ο αριθμός των επαναλήψεων της θεωρίας ανά ενότητα, το ποσοστό των επιτυχιών και αποτυχιών στα " +
                "'Επαναληπτικά Τεστ' και σε ποιες ενότητες υπάρχει πρόβλημα.\n" +
                "Πατώντας το κουμπί 'Βοήθεια' μπορείς να δεις τη βασική λειτουργία της εφαρμογής.");
        }
    }
}
