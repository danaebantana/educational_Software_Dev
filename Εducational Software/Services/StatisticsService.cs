using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Εducational_Software.Models;

namespace Εducational_Software.Services
{
    public class StatisticsService
    {
        private User user;
        public StatisticsService(User user)
        {
            this.user = user;
        }

        /// <summary>
        /// Get statistics for a quiz.
        /// </summary>
        /// <param name="quiz_id">The id of the quiz</param>
        /// <returns>Educational_Sostware.Models.Statistics</returns>
        public Statistics GetStatistics(string quiz_id)
        {
            DataConnection conn = new DataConnection();
            return conn.GetStatistics(user, quiz_id);
        }

        /// <summary>
        /// Increases theory revisions of a quiz by 1.
        /// </summary>
        /// <param name="quiz_id">The id of the quiz.</param>
        public void AddTheoryRevision(string quiz_id)
        {
            DataConnection conn = new DataConnection();
            Statistics statistics = conn.GetStatistics(user, quiz_id);

            int theory_revisions = statistics.GetTheoryRevisions();
            float score = statistics.GetScore();

            conn.UpdateStatistics(user, quiz_id, ++theory_revisions, score);
        }

        /// <summary>
        /// Updates the score of a quiz.
        /// </summary>
        /// <param name="quiz_id">The id of the quiz.</param>
        /// <param name="score">The new score for the quiz.</param>
        public void UpdateScore(string quiz_id, double score)
        {
            DataConnection conn = new DataConnection();
            Statistics statistics = conn.GetStatistics(user, quiz_id);

            int theory_revisions = statistics.GetTheoryRevisions();

            if (score > statistics.GetScore())
                conn.UpdateStatistics(user, quiz_id, theory_revisions, score);
        }
    }
}
