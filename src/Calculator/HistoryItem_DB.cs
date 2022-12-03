using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class HistoryItem_DB
    {
        public string QuestionAnswer { get; set; }
        public string DateTime1 { get; set; }
        public HistoryItem_DB()
        {
            DateTime1 = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        }
    }
}
