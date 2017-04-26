using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceCSharp
{
    public class MainWindowVM : INotifyPropertyChanged
    {
        private string _phNo;

        public string PhNo
        {
            get { return _phNo; }
            set { string _phNo = value; NotifyPropertyChanged("PhNo"); }
        }
        

        private void NotifyPropertyChanged(String info)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
