using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    //public class HistoryItems : INotifyPropertyChanged
    //{
    //    private List<HistoryItem> _items;
    //    public List<HistoryItem> Items
    //    {
    //        get => _items;
    //        set
    //        {
    //            if (_items == value) return;
    //            _items = value;
    //            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Items)));
    //        }
    //    }
    //    public HistoryItems()
    //    {
    //        Items = new List<HistoryItem>();
    //    }
    //    public event PropertyChangedEventHandler PropertyChanged;
    //}
    //public class HistoryItem
    //{
    //    public string QuestionAnswer { get; set; }
    //    public string DateTime1 { get; set; }
    //}
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
            DateTime1 = DateTime.Now.ToShortTimeString();
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
