using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            
            Console.WriteLine("Welcome to the Calculator!");

            Console.WriteLine("");

            Menu();

        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("1. Add");
            Console.WriteLine("2. Subtract");
            Console.WriteLine("3. Multiply");
            Console.WriteLine("4. Divide");
            Console.WriteLine("5. Exit");
            Console.WriteLine("--------------------");
            Console.WriteLine("Enter a number:");
            short res = short.Parse(Console.ReadLine());

            switch (res)
            {
                case 1: Sum(); break;
                case 2: Subtract(); break;
                case 3: Multiply(); break;
                case 4: Divide(); break;
                case 5: System.Environment.Exit(0); break;
                default: Menu(); break;
            }
        }

        static void Sum ()
        {
            Console.Clear();
            Console.WriteLine("Enter a number:");
            float num1 = float.Parse(Console.ReadLine());
            
            Console.WriteLine("Enter another number:");
            float num2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float result = num1 + num2;
            Console.WriteLine("The sum of " + num1 + " and " + num2 + " is " + result + ".");
            Console.ReadKey();
            Menu();
        }

        static void Subtract ()
        {
            Console.Clear();
            Console.WriteLine("Enter a number:");
            float num1 = float.Parse(Console.ReadLine());
            
            Console.WriteLine("Enter another number:");
            float num2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float result = num1 - num2;
            Console.WriteLine("The difference of " + num1 + " and " + num2 + " is " + result + ".");
            Console.ReadKey();
            Menu();
        }

        static void Multiply ()
        {
            Console.Clear();
            Console.WriteLine("Enter a number:");
            float num1 = float.Parse(Console.ReadLine());
            
            Console.WriteLine("Enter another number:");
            float num2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float result = num1 * num2;
            Console.WriteLine("The product of " + num1 + " and " + num2 + " is " + result + ".");
            Console.ReadKey();
            Menu();
        }

        static void Divide ()
        {
            Console.Clear();
            Console.WriteLine("Enter a number:");
            float num1 = float.Parse(Console.ReadLine());
            
            Console.WriteLine("Enter another number:");
            float num2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float result = num1 / num2;
            Console.WriteLine("The quotient of " + num1 + " and " + num2 + " is " + result + ".");
            Console.ReadKey();
            Menu();
        }
    }
}