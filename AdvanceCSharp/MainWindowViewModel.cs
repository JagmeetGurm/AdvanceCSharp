using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Input;

namespace AdvanceCSharp
{
    public class MainWindowViewModel: INotifyPropertyChanged
    {
        public MainWindowViewModel()
        {
            Model = new Student();//{FirstName = "Jagmeet", LastName = "Gurm" };
            Thread.Sleep(4000);
           // EditStudent(Model);
        }
        private void EditStudent(Student student)
        {
            
            student.LastName = "Gill";
        }
        private Student _model;
        public Student Model
        {
            get { return _model; }
            set { _model = value; NotifyPropertyChanged("Model"); }
        }
        
        private void Test()
        {

        }
        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged(String info)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
        }

    }
}
