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
        private float score;

        public Statistics() { }

        public Statistics(User user, string quiz_id, int theory_revisions, float score)
        {
            this.user = user;
            this.quiz_id = quiz_id;
            this.theory_revisions = theory_revisions;
            this.score = score;
        }

        public int GetTheoryRevisions()
        {
            return theory_revisions;
        }

        public float GetScore()
        {
            return score;
        }
    }
}
