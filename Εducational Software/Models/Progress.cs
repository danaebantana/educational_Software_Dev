using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Εducational_Software.Models
{
    class Progress
    {
        private User user;
        private List<Statistics> statistics;

        public Progress() { }

        public Progress(User _user, List<Statistics> _statistics)
        {
            this.user = _user;
            this.statistics = _statistics;
        }
    }
}
