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
            //action example: always returns void and is a delegate(function pointer).
            Action<int> ActionExample = new Action<int>(Print);
            ActionExample(5);

            //
        }

        private int Add(int a , int b)
        {
            return a + b;
        }
        private void Print(int res)
        {
            Result.Content = res;
        }
    }
}
