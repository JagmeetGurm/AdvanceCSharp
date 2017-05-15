using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Shapes;

namespace AdvanceCSharp
{
    public class CallerFilePathTest
    {
        public CallerFilePathTest(string name, [CallerFilePath] string fileName = "")
        {
            var file = System.IO.Path.GetFileNameWithoutExtension(fileName);
            System.Console.WriteLine("{0}", file);
        }
    }
}
