using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Εducational_Software.Models
{
    public class Statistics
    {
        private User user;
        private string quiz_id;
        private int theory_revisions;
        private List<double> scores;

        public Statistics() { }

        public Statistics(User user, string quiz_id, int theory_revisions)
        {
            this.user = user;
            this.quiz_id = quiz_id;
            this.theory_revisions = theory_revisions;
            this.scores = new List<double>();
        }

        public string GetQuizID()
        {
            return this.quiz_id;
        }

        public int GetTheoryRevisions()
        {
            return theory_revisions;
        }

        public List<double> GetScores()
        {
            return scores;
        }

        public bool HasScores()
        {
            return scores.Count() > 0;
        }

        public void AddScore(double score) {
            scores.Add(score);
        }

    }
}
