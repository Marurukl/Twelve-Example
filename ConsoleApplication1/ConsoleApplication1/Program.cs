using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace First

{
    class Program
    {
        static void Main(string[] args)
        {
            //1.С помощью рефлексии получить список методов класса Console и вывести на экран.
            Type myType = Type.GetType("System.Console", false, true);

            foreach (MemberInfo mi in myType.GetMembers())
            {
                Console.WriteLine(mi.DeclaringType + " " + mi.MemberType + " " + mi.Name);
            }

            Console.ReadLine();

        }
    }
}
