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
        private List<double> unitsSuccessRates;
        private List<double> unitsFailureRates;
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
            LoadCharts(unitsSuccessRates, unitsFailureRates);
        }

        public void LoadProgress()
        {
            unitsSuccessRates = progressService.GetRates(true);
            unitsFailureRates = progressService.GetRates(false);
            units = progressService.GetUnits();
        }

        private void LoadCharts(List<double> successRates, List<double> failureRates)
        {
            foreach (int unit in units)
            {
                chart_unitRates.Series["Επιτυχία"].Points.AddXY(unit.ToString(), successRates.ElementAt(unit-1));
                chart_unitRates.Series["Αποτυχία"].Points.AddXY(unit.ToString(), failureRates.ElementAt(unit - 1));
            }
            
        }
    }
}
