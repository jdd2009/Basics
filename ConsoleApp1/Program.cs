using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    { 
    enum Ages
    {
        oldEnough = 5,
        canDrink = 21,
        tooOld = 90,

    }

    private static void Main(string[] args)
        {
            /*
            int myAge = 21; //not true
            int x = 5;
            double myHourlyRate = 150.00;
            var myName = "Justin";

            Console.WriteLine ($"myAge: {myAge}, x: { x}, myHourlyRate: {myHourlyRate}, myName: {myName}");

            myAge = 35;
            x = 20;
            myHourlyRate = 85.00;
            myName = "Bob Smith";

            Console.WriteLine($"myAge: {myAge}, x: { x}, myHourlyRate: {myHourlyRate}, myName: {myName}");


            int Rachel = 20;
            int Robin = 26;
            int Stacey = 54;
            int Jesse = 60;

            if (Rachel > 18)
            {
                Console.WriteLine("Rachel can vote");

            }
            if (Rachel >= 21 && Robin >= 21)
            {
                Console.WriteLine("Rachel and Robin can drink");

            }
            else if (Rachel >= 21 || Robin >= 21) ;
            {
                Console.WriteLine("At least one can drink");
            }


            for (int i = 0; i < 300; i++)
            {
                Console.WriteLine($"hello {i.ToString()}");
            }




            int myLittleHorses = 0;
            while (myLittleHorses < 10)
            {
                Console.WriteLine($"myLittleHorses = {myLittleHorses }");
                myLittleHorses++;
            }



            const int age = 20;

            if ( age < (int) Ages.oldEnough)
            {
                Console.WriteLine("Sorry, you are too young to play");

            }
            else if (age < (int)Ages.canDrink)
            {
                Console.WriteLine("You can play, but no drinking");

            }

            else if (age < (int) Ages.tooOld )
            {
                Console.WriteLine("have fun!");


            }

            else
            {
                Console.WriteLine("how about a nice nap");

            }
             */

            int num = 5;

            if (num < 10)
                {
                Console.WriteLine(" hello");
                }
            /*
            int testNum = 10;
            Console.WriteLine($"{testNum}");

            int number1, number2, temp;

            Console.Write("\nInput the First Number : ");
            number1 = int.Parse(Console.ReadLine());

            Console.Write("\nInput the Second Number : ");
            number2 = int.Parse(Console.ReadLine());

            temp = number1;
            number1 = number2;
            number2 = temp;

            Console.Write("\nAfter Swapping : ");
            Console.Write("\nFirst Number : " + number1);
            Console.Write("\nSecond Number : " + number2);

            Console.Read();
            */

            Console.ReadKey();

            Console.Beep();


        }
    }
}
