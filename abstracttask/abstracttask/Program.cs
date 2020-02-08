using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstracttask
{
    class Program
    {
        static void Main(string[] args)
        {
            shape s = new circle(4);//creating the object to shape class it also a instance to circle
            Console.WriteLine(s.area());
            Console.ReadKey();
        }
    }
}
