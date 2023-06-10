using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project1
{
    class Program
    {
        static void Main(string[] args)
        {
            //  task01();
            // task02();
            // task03();
          // task04();
           // task05();
          //  task06();
           // task07();
           // task08();
           // task09();
            task10();
        }
        static void task01()
        {
            for (int i = 0; i < 2; i++)
            {
                Console.Write("Hello World!");
            }
            Console.Read();
        }
        static void task02()
        {
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Hello World!");
            }
            Console.Read();
        }
        static void task03()
        {
            int variable = 5;
            Console.WriteLine("The valus is: " );
            Console.Write(variable);
                Console.ReadKey();
        }
        static void task04()
        {
            string variable = "I am string";
            Console.WriteLine("The string is: ");
            Console.Write(variable);
            Console.ReadKey();
        }
        static void task05()
        {
            char variable = 'A';
            Console.WriteLine("Char: ");
            Console.Write(variable);
            Console.ReadKey();
        }
        static void task06()
        {
            float variable = 2.2F;
            Console.WriteLine("The Float is: ");
            Console.Write(variable);
            Console.ReadKey();
        }
        static void task07()
        {
            string str;
            str = Console.ReadLine();
            Console.WriteLine("You are inputted: ");
            Console.WriteLine(str);
            Console.ReadKey();
        }
        static void task08()
        {
            string str;
            str = Console.ReadLine();
            Console.WriteLine("You are inputted: ");
            int num = int.Parse(str);
            Console.WriteLine("The number is: ");
            Console.Write(num);
            Console.ReadKey();
        }
        static void task09()
        {
            string str;
           
            Console.WriteLine("Enter floating point value ");
            str = Console.ReadLine();
            float num = float.Parse(str);
            Console.WriteLine("The number is: ");
            Console.Write(num);
            Console.ReadKey();
        }
        static void task10()
        {
            float length;
            float area;
            string str;

            Console.WriteLine("Enter length: ");
            str = Console.ReadLine();
            length  = float.Parse(str);
            area = length * length;
            Console.WriteLine("The Area is: ");
            Console.Write(area);
            Console.ReadKey();
        }

    }
}
