using CalculatorFunctions;
using System;

namespace Calculator
{
    class Program
    {
        public  Program() { }
        static void Main(string[] args)
        {
            Functions f;                                            //Calculator instance object 
            int numbQ = 1;                                          //Programm stater
            Program p = new Program();                              // Instance of the Program object
            String select;

            while (true) 
            {
                p.menu();
                while (true) 
                {
                    try
                    {
                        select = Console.ReadLine();
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Press the keys displayed on the menu.");
                        continue;
                    }
                    Console.WriteLine();
                    Console.WriteLine("Press Any two numbers in each line.");
                    Console.WriteLine();
                    if (select == "A")
                    {
                        int num1 = Convert.ToInt32(Console.ReadLine());
                        int num2 = Convert.ToInt32(Console.ReadLine());
                        f = new Functions(num1, num2); ;
                        Console.WriteLine("-> The result of this addition:     ___" + f.getSum() + "__");
                        Console.WriteLine();
                    }
                    if (select == "B")
                    {
                        int num1 = Convert.ToInt32(Console.ReadLine());
                        int num2 = Convert.ToInt32(Console.ReadLine());
                        f = new Functions(num1, num2);
                        Console.WriteLine("-> The result of this subtraction:     ___" + f.getSub() + "__");
                        Console.WriteLine();
                    }
                    if (select == "M")
                    {
                        int num1 = Convert.ToInt32(Console.ReadLine());
                        int num2 = Convert.ToInt32(Console.ReadLine());
                        f = new Functions(num1, num2);
                        Console.WriteLine("-> The result of this Multiplication:     ___" + f.getMult() + "__");
                        Console.WriteLine();
                    }
                    if (select == "D")
                    {
                        int num1 = Convert.ToInt32(Console.ReadLine());
                        int num2 = Convert.ToInt32(Console.ReadLine());
                        f = new Functions(num1, num2);
                        Console.WriteLine("-> The result of this Division:     ___" + f.getDiv() + "__");
                        Console.WriteLine();
                    }
                    if (select == "E")
                    {
                        break;
                    }
                }
                break;
                
            }



        }
        public int getFib(int n)
        {
            if ((n == 0) || (n == 1))
            {
                return n;
            }
            else
                return getFib(n - 1) + getFib(n - 2);
        }
        public void menu()                                          //A menu function.
        {
            Console.WriteLine("*********************************************************************|");
            Console.WriteLine("|     Good day, hello how are you. I am happy to finally meet you.   |");
            Console.WriteLine("|     My name is Josh and I am a computer program. I can do a the    |");
            Console.WriteLine("|     following things for you.                                      |");
            Console.WriteLine("***************************************************************      |");
            Console.WriteLine("|Give you a sum of numbers (press)__________________________A        |");
            Console.WriteLine("|Give you a division of numbers (press)_____________________D        |");
            Console.WriteLine("|Give you a difference of numbers (press)___________________S        |");
            Console.WriteLine("|Give you a multiplication of numbers (press)_______________M        |");
            Console.WriteLine("|Give you a fibonacci of numbers (press)____________________F        |");
            Console.WriteLine("|Press Escape to Exit_______________________________________Esc      |");
            Console.WriteLine("|Press W to Diplay this menu again__________________________W        |");
            Console.WriteLine("*********************************************************************|");
        }
    }
}
