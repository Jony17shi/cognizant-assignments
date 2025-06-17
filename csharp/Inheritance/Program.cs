// See https://aka.ms/new-console-template for more information
// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program

    {

        static void Main(string[] args)

        {

            //Example of using Autoproperties

            //ContractRecruiter obj = new ContractRecruiter();

            //obj.cName = "abc";

            //obj.vaddress = "NewMumbai";

            //Console.WriteLine(obj.vaddress);

            //Console.WriteLine(obj.cName);

            //Inheritance of Employee form Externalcandidate
            Console.WriteLine("Please select which object you want to create Employe 2 and externalcandidate 1");
            int ans = int.Parse(Console.ReadLine());
            ExternalCandidate obj;
            if (ans == 1)
            {
                obj = new ExternalCandidate();
            }
            else
            {
                obj = new Employee();
            }
            obj.Accept();
            obj.Display();


            //try

            //{

            //

            //Structure are value type proof

            //

            //int a = 10;

            //

            //Console.WriteLine("a is {0}", a);

            //

            //int b = 0;

            //Console.WriteLine("b is (0)", b);

            //a = 20;




            //internal class ContractRecruiter
            // {
            //public string cName {  get; set; }
            //public string vaddress { get; set; }

            //}
        }
    }
}
