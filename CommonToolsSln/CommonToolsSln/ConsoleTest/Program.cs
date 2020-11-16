using ComLibs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            CommonTool tool = new CommonTool();
            var ss = tool.GetHttp();
            Console.WriteLine($"{ss}");
            Console.ReadLine();
        }
    }
}
