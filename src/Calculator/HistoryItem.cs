using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class HistoryItem : INotifyPropertyChanged
    {
        private string _q;
        private string _dT;

        public string QuestionAnswer
        {
            get => _q;
            set
            {
                if (_q == value) return;
                _q = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(QuestionAnswer)));
            }
        }
        public string DateTime1
        {
            get => _dT; set
            {
                if (_dT == value) return;
                _dT = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(DateTime1)));
            }
        }

        public HistoryItem()
        {
            DateTime1 = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
