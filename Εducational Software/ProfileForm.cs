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
    public partial class ProfileForm : Form
    {
        private AuthenticationService auth;
        private ProgressService progressService;
        private List<double> unitsTestsSuccess;
        private List<double> unitsTestsFailure;
        private List<double> unitsTestsRate;
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
            //Load rates of Self-assessment tests
            foreach (int unit in units)
            {
                chart_unitRates.Series["Επιτυχία"].Points.AddXY("Ενότητα: "+ unit.ToString(), successRates.ElementAt(unit-1));
                chart_unitRates.Series["Αποτυχία"].Points.AddXY("Ενότητα: " + unit.ToString(), failureRates.ElementAt(unit - 1));
            }

            //Load rates of Revision tests
            chart_revisionRates.Series["Revision"].Points.AddXY("Επιτυχία", revisionTestSuccess.ToString());
            chart_revisionRates.Series["Revision"].Points.AddXY("Αποτυχία", revisionTestFailure.ToString());
            chart_revisionRates.Series["Revision"].Points[1].Color = Color.Red;

        }
    }
}
