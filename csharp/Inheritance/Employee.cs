using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Employee : ExternalCandidate
    {
        string Employecode;
        public override void Accept()
        {
            Console.WriteLine("This is Employee Accept");
            base.Accept();//4 properties
            Console.WriteLine("Enter Employeecode");
            Employecode = Console.ReadLine();

        }
        public override void Display()
        {
            Console.WriteLine("This is Employee Display");
            base.Display();
            Console.WriteLine("Employee:- {0}", Employecode);
        }
    }
}