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

namespace Εducational_Software.Storage
{
    public partial class StatisticsForm : Form
    {
        private StatisticsService statisticsService;

        public StatisticsForm(StatisticsService statisticsService)
        {
            InitializeComponent();
            this.statisticsService = statisticsService;
        }

        private void StatisticsForm_Load(object sender, EventArgs e)
        {
            // TODO Implement statistics screen
        }
    }
}
