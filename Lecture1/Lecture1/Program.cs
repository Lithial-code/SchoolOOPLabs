using System;

namespace Lecture1
{
    class Program
    {
        static void Main(string[] args)
        {
     
            var quit = true;
            while (quit)
            {
                Console.WriteLine("What would you like to do? (a)dd|(s)ubtract|(e)2|(ee)2|(l)eapyear|(q)uit");
                var input = Console.ReadLine();
                switch (input)
                {
                    case "a":
                        
                        Console.WriteLine(addFunction());
                        break;
                    case "s":
                        Console.WriteLine(subtractNumber());
                        break;
                    case "e":
                        Console.WriteLine(e2());
                        break;
                    case "ee":
                        Console.WriteLine(e2point5());
                        break;
                    case "q":
                        quit = false;
                        break;
                    case "l":
                        Console.WriteLine(leapYear());
                        break;
                    case "f":
                        FizzBuzz();
                        break;
                    default:
                        break;
                }
            }
            
            
            //FizzBuzz();
        }
        static int getNumber()
        {
            string input = Console.ReadLine();


            int id = 0;

            while (!int.TryParse(input, out id))
            {
                Console.WriteLine("Please Enter a valid numerical value!");
                input = Console.ReadLine();
            }
            return id;

        }
        static int addFunction()
        {
            Console.WriteLine("enter a value");
            int var1 = getNumber();
            Console.WriteLine("enter a second value");
            int var2 = getNumber();
            return var1 + var2;
        }
        static int subtractNumber()
        {
            Console.WriteLine("enter a value");
            int var1 = getNumber();
            Console.WriteLine("enter a second value");
            int var2 = getNumber();
            return var1 - var2;
        }
        static string e2()
        {
            Console.WriteLine("enter a value");
            int var1 = getNumber();
            Console.WriteLine("enter a second value");
            int var2 = getNumber();
            Console.WriteLine("enter a third value");
            int var3 = getNumber();
            return String.Format("({0} + {1})*{2} = {3}",var1,var2,var3,(var1+var2)*var3);
        }
        static string e2point5()
        {
            Console.WriteLine("enter a value");
            int var1 = getNumber();
            Console.WriteLine("enter a second value");
            int var2 = getNumber();
            Console.WriteLine("enter a third value");
            int var3 = getNumber();
            return String.Format("({0}*{1})+({1}*{2}) = {3}", var1, var2, var3, (var1 * var2) + (var2 * var3));
        }
        static string leapYear()
        {
            Console.WriteLine("What year is it?");
            int var1 = getNumber();
            if(var1 % 4 == 0 && var1 % 100 == 0)
            {
                if(var1 % 400 == 0)
                {
                    return "This is a leap year.";
                }
                else
                {
                    return "This is not a leap year.";
                }
            }
            else
            {
                return "This is not a leap year.";
            }
        }
        static void FizzBuzz()
        {
            string number = "";
            for (int i = 1; i < 101; i++)
            {
                number += i % 3 == 0 ? "Fizz" : "";
                number += i % 5 == 0 ? "Buzz" : "";
                if (number == "")
                {
                    number = i.ToString();
                }
                Console.WriteLine(number);
                number = "";
            }
        }
    }
}
