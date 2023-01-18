using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO.Pipes;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;

namespace Data_types
{
    class Data_types
    {
        public static void Main(string[] args)
        {
            int age = 27;

            Console.WriteLine(age);

            char a = 'a';
            Console.WriteLine(a);
            
            string Name = "Raiyad Alam ";

            Console.WriteLine(Name);

            object obj = 50;

            Console.WriteLine(obj);

            DateTime date= DateTime.Now;    

            Console.WriteLine(date);

            string s1 = "raiyad";

            String s2 = s1;

            s1 = "alam";

            Console.WriteLine(s1);

            int d = 10;
            int e = d;

            d = 20;

            Console.WriteLine(d);

            Console.WriteLine(e);

            Person p1 = new Person();

            p1.age = 30;

            Person p2 = new Person();

            p2.age = 60;

            p2 = p1;

            Console.WriteLine(p1.age);    

          

        }

    }
}