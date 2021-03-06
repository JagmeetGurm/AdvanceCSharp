﻿using System;
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
            //action example: always returns void and is a delegate(function pointer).
            Action<int> ActionExample = new Action<int>(Print);
            // ActionExample(5);

            //Func example
            Func<int, int, int> FuncExample = new Func<int, int, int>(Add);
            FuncExample(4, 5);
            ActionExample(result);

            //Predicate Example
            Predicate<int> PredicateExample = new Predicate<int>(Greater);
            Result.Content = PredicateExample(8);

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
        private int result;
        private int Add(int a, int b)
        {
            result = a + b;
            return result;
        }
        private void Print(int res)
        {
            Result.Content = res;
        }

        private bool Greater(int val1)
        {
            return val1 > result;
        }
    }
}
