using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace AdvanceCSharp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            printName userName;
            printName fName = new printName(FirstName);
            printName lName = new printName(LastName);
            userName = fName;
            userName += lName;
            //userName("JIm");
            BtnResult.Click += new RoutedEventHandler((object obj, RoutedEventArgs e) => { fName("Jim"); });
            BtnResult.Click += new RoutedEventHandler((object obj, RoutedEventArgs e) => { lName("Gurm"); });
            BtnResult.Click += new RoutedEventHandler((object obj, RoutedEventArgs e) => { Result.Content = PrintUserName(); });



        }
        private string LName;
        private string FName;
        //delegate
        public delegate string printName(string name);

        public string FirstName(string firstName)
        {
            FName = firstName;
            return FName;
        }
        public string LastName(string lastName)
        {
            LName = lastName;
            return LName;
        }

        public string PrintUserName()
        {
            return FName + " " + LName;
        }
    }
}
