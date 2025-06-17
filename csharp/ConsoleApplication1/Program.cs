using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Hello World");

            //funwithoutthread();

            //funwithoutthread2();

            Thread slavel = new Thread(funwithoutthread);

            slavel.Start();

            Thread slave2 = new Thread(funwithoutthread2);

            slave2.Start();

            //fun(3);//1,3

            //funwiththread();//1,1

            //funwiththread2();//1,2*/

            //Thread slavel new Thread(funwiththread);

            //slavel.start();

            //Thread slave2 = new Thread(funwiththread2);

            //slave2.Start();

            //Console.WriteLine("Hello world Again");

            Console.ReadLine();
        }
        public static void funwithoutthread()

        {

            for (int i = 0; i < 10; i++)
            {

                Console.WriteLine(i);

                Thread.Sleep(1000);
            }

        }

        public static void funwithoutthread2()
        {
            for (int i = 11; i < 20; i++)
            {
                Console.WriteLine(i);
                Thread.Sleep(10000);
            }
        }
    }
}