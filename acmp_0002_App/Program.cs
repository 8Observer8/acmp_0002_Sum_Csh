using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using acmp_0002_Sum;

namespace acmp_0002_App
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 5;
            Sum s = new Sum();
            int result = s.sum(n);
            System.Console.WriteLine(result.ToString());
        }
    }
}
