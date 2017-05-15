using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceCSharp
{
    public class MainWindowVM: INotifyPropertyChanged
    {
        public MainWindowVM()
        {
            Persons = new List<Person>();
            Persons.Add(new Person{FirstName = "Jagmeet", LastName ="Gurm", age = 28});
            Persons.Add(new Person { FirstName = "Jim", LastName = "Gill", age = 20 });
            Persons.Add(new Person { FirstName = "Joe", LastName = "John", age = 24 });
            Persons.Add(new Person { FirstName = "Anmol", LastName = "Anand", age = 38 });
            var temp = Persons.Where(p => p.FirstName == "Jim");
            var temp2 = temp.Count();
        }

        private List<Person> _persons;
        public List<Person> Persons
        {
            get { return _persons; }
            set { _persons = value; OnPropertyChanged("Persons"); }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string name)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(name));
            }
        }
    }
}
