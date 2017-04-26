using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;


namespace AdvanceCSharp
{
    public class MainVM: INotifyPropertyChanged
    {
        public MainVM()
        {
            Persons = new List<Person>();
            Persons.Add(new Person { FName = "Jim", LName = "Gurm", Age = 28 });
            Persons.Add(new Person { FName = "Garry", LName = "Gill", Age = 35 });
            Persons.Add(new Person { FName = "Jag", LName = "Singh", Age = 25 });

            //
        }

        private List<Person> _persons;
        public List<Person> Persons
        {
            get { return _persons; }
            set { _persons = value; NotifyPropertyChanged("Persons"); }
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
