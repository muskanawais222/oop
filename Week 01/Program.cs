using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project2
{
    class Program
    {
        static void Main(string[] args)
        {
            //  task01();
            // task02();
            // task03();
            //  task04();
            // task05();
            task06();

        }
        static void task01()
        {
            string input;
            float marks;
            Console.Write("Enter the Marks: ");
            input = Console.ReadLine();
            marks = float.Parse(input);
            if (marks>50)
            {
                Console.WriteLine("You are passed");
            }
            else
            {
                Console.WriteLine("You are failed");
            }
            Console.Read();
        }
        static void task02()
        {
            for(int i =0; i<5; i++)
            {
                Console.WriteLine("Welcome Jack!");
            }
            Console.Read();
        }
        static void task03()
        {
            int num;
            int sum = 0;
            Console.Write("Enter Number: ");
            num = int.Parse(Console.ReadLine());
            while (num != -1)
            {
                sum = sum + num;
                Console.Write("Enter Number: ");
                num = int.Parse(Console.ReadLine());
            }

             Console.WriteLine("The total Sum is {0}" , sum);
            Console.Read();
        }
        static void task04()
        {
            int num;
            int sum = 0;
            do
            {
                Console.Write("Enter Number: ");
                num = int.Parse(Console.ReadLine());
                sum = sum + num;

            }
            while (num != -1);
                sum = sum + 1;
            Console.WriteLine("The total Sum is {0}", sum);
            Console.Read();
        }
        static void task05()
        {//taking input
            int[] numbers = new int[3];
                for (int idx = 0; idx<3;idx++)
            {
                Console.WriteLine("Enter the {0} number : ", idx);
                numbers[idx] = int.Parse(Console.ReadLine());
            }
            // finding the latrgest
            int largest = -1;
            for (int idx = 0; idx < 3; idx++)
            {
                if(numbers[idx]> largest)
                {
                    largest = numbers[idx];
                }
            }
            Console.WriteLine("Largest is {0}", largest);
            Console.Read();
        }
        // take away task
        static void task06()
        {
            int age;
            float machine_price;
            float toy_price;
            float brdyMoney = 0.0F;
            int brdyCount = 1;
            float totalMoney = 0.0F;
            float collectedMoney;
            Console.WriteLine("Enter the age of Lily: ");
           age = int.Parse( Console.ReadLine());
            Console.WriteLine("Enter the price of Macine: ");
            machine_price = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Price of Toy: ");
           toy_price = float.Parse( Console.ReadLine());
            for(int x=1; x<=age; x++)
            {
                if(x % 2 == 0)
                {
                    brdyMoney = (brdyMoney + (brdyCount * 10)-1);
                    brdyCount++;
                }
                else
                {
                    totalMoney = totalMoney + toy_price;
                }
            }
            collectedMoney = brdyMoney + totalMoney;
            Console.WriteLine("total amount: " + (collectedMoney));

            if (collectedMoney > machine_price)
            {
                Console.WriteLine("Yes! lily money's is enough to buy machine");
                Console.WriteLine("Remaing amount is: " + (collectedMoney - machine_price));

            }
            else if(collectedMoney < machine_price)
            {
                Console.WriteLine("No! lily money's is insufficient to buy machine");
                Console.WriteLine("Remaing amount is: " + ( machine_price - collectedMoney));
            }

            Console.Read();

        }



    }
}
