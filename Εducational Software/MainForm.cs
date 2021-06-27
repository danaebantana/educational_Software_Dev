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
using Εducational_Software.Storage;

namespace Εducational_Software
{
    public partial class MainForm : Form
    {
        private AuthenticationService auth;
        private StatisticsService statisticsService;

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
        }

        private void αποσύνδεσηToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            auth.Logout();
            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();
            this.Close();
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

        private void OpenStatistcsForm(object sender, EventArgs e)
        {
            this.Hide();
            StatisticsForm statisticsForm = new StatisticsForm(statisticsService);
            statisticsForm.ShowDialog();
            this.Show();
        }
    }
}
