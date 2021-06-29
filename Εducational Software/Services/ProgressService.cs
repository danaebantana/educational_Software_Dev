using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Εducational_Software.Models;

namespace Εducational_Software.Services
{
    class ProgressService
    {
        private User user;
        private List<int> units;

        public ProgressService(User user)
        {
            this.user = user;
            units = this.GetUnits();
        }

        private Statistics GetStatistics(string quiz_id)
        {
            DataConnection conn = new DataConnection();
            return conn.GetStatistics(user, quiz_id);
        }

        public List<int> GetUnits()
        {
            DataConnection conn = new DataConnection();
            List<int> units = new List<int>();

            for (int i = 1; i < 10; i++)
            {
                if (conn.GetStatistics(user, i.ToString()).IsUnlocked())
                {
                    units.Add(i);
                }
            }

            return units;
        }

        private List<Statistics> GetUserStatistics()
        {
            List<Statistics> statistics = new List<Statistics>();
 
            foreach (int unit in units)
            {
                statistics.Add(this.GetStatistics(unit.ToString()));
            }

            return statistics;
        }

        private double GetUnitRate(Statistics statistics, bool success)
        {
            List<double> scores = statistics.GetScores();
            int count = 0;
            if (success)
            {
                foreach (double score in scores)
                {
                    if (score >= 50)
                    {
                        count++;
                    }
                }
            } else
            {
                foreach (double score in scores)
                {
                    if (score < 50)
                    {
                        count++;
                    }
                }
            }
            

            return ((double)count / (double)scores.Count) * 100;
        }

        public List<double> GetRates(bool success)
        {
            List<double> rates = new List<double>();
            List<Statistics> statistics = this.GetUserStatistics();

            foreach(Statistics statistic in statistics)
            {
                rates.Add(this.GetUnitRate(statistic, success)); 
            }

            return rates;
        }
    }
}
