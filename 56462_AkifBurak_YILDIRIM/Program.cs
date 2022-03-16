using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _56462_AkifBurak_YILDIRIM
{
    class Program
    {
        // menu1
        static int menu1()
        {
            int a;
            Console.WriteLine("1. Calculator");
            Console.WriteLine("2. Metric Conversation");
            Console.WriteLine("3. Mathematical Formula");
            Console.WriteLine("4. Exit");
            
            Console.WriteLine("");

            Console.Write("Please choose operation: ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("");
            
            return a;

        }

        // Calculator menu
        static int calculatin_menu()
        {
            int a;
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Substraction");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("4. Division");
            Console.WriteLine("5. Modules");
            Console.WriteLine("");

            Console.Write("Please choose operation: ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("");

            if (a>5)
            {
                Console.WriteLine("Please enter a valid number\a"); Environment.Exit(0);
            }

            return a;
        }

        //Metric Conversation
        static int metric_menu()
        {
            int a;
            Console.WriteLine("1. Inches to Centimetres");
            Console.WriteLine("2. Centimetres to Inches");
            Console.WriteLine("3. Feet to Centimetres");
            Console.WriteLine("4. Centimetres to Feet");
            Console.WriteLine("5. Yards to Metres");
            Console.WriteLine("6. Metres to Yards");
            Console.WriteLine("7. Miles to Kilometres");
            Console.WriteLine("8. Kilometres to Miles");
            Console.WriteLine("");

            Console.Write("Please choose operation: ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("");

            if (a > 8)
            {
                Console.WriteLine("\nPlease enter a valid number\a"); Environment.Exit(0);
            }

            return a;
        }

        //Formula menu
        static int formula_menu()
        {
            int a;
            Console.WriteLine("1. Power");
            Console.WriteLine("2. Permutation");
            Console.WriteLine("3. Combination");
            
            
            Console.WriteLine("");

            Console.Write("Please choose operation: ");
            a = Convert.ToInt32(Console.ReadLine());

            if (a > 3)
            {
                Console.WriteLine("\nPlease enter a valid number\a"); Environment.Exit(0);
            }

            return a;

        }

        // Addition
        static int addition()
        {
            int a,b,c=0;
            Console.Write("Please enter first number: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please enter second number: ");
            b = Convert.ToInt32(Console.ReadLine());
            c = a + b;
            return c;
        }
        
        //Substruction
        static int substruction()
        {
            int a, b, c;
            Console.Write("Please enter 1st number: ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Please enter 2nd number: ");
            b = Convert.ToInt32(Console.ReadLine());

            c = a - b;
            return c;
        }

        //Multiplication
        static int multiplication()
        {
            int a, b, c;
            Console.Write("Please enter 1st number: ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Please enter 2nd number: ");
            b = Convert.ToInt32(Console.ReadLine());

            c = a * b;
            return c;
        }

        //Division
        static float division()
        {
            int a, b;
            float c;
            Console.Write("Please enter 1st number: ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Please enter 2nd number: ");
            b = Convert.ToInt32(Console.ReadLine());

            c = (float)a / (float)b;
            return c;
        }

        //Modules
        static float modules()
        {
            int a, b;
            float c;
            Console.Write("Please enter 1st number: ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Please enter 2nd number: ");
            b = Convert.ToInt32(Console.ReadLine());

            c = (float)a % (float)b;
            return c;
        }

        // first results
        static float result(int choice2)
        {
            float result=0;
            switch (choice2)
            {
                case 1: result = addition(); break;
                case 2: result = substruction(); break;
                case 3: result = multiplication(); break;
                case 4: result = division(); break;
                case 5: result = modules(); break;
                default:
                    break;
            }


            return result;
        }

        //second results
        static double result2(int choice3)
        {
            double result = 0,a;
            switch (choice3)
            {
                case 1: Console.Write("Please enter a value:");  a = Convert.ToInt32(Console.ReadLine()); result = a * (2.54); break;
                case 2: Console.Write("Please enter a value:");  a = Convert.ToInt32(Console.ReadLine()); result = a / (2.54); break;
                case 3: Console.Write("Please enter a value:");  a = Convert.ToInt32(Console.ReadLine()); result = a * (30); break;
                case 4: Console.Write("Please enter a value:");  a = Convert.ToInt32(Console.ReadLine()); result = a / (30); break;
                case 5: Console.Write("Please enter a value:");  a = Convert.ToInt32(Console.ReadLine()); result = a * (0.91); break;
                case 6: Console.Write("Please enter a value:");  a = Convert.ToInt32(Console.ReadLine()); result = a / (0.91); break;
                case 7: Console.Write("Please enter a value:");  a = Convert.ToInt32(Console.ReadLine()); result = a * (1.6); break;
                case 8: Console.Write("Please enter a value:");  a = Convert.ToInt32(Console.ReadLine()); result = a / (1.6); break;
                default:
                    break;
            }
            return result;
        }

        //third results
        static double result3(int choice4)
        {
            double result=1;
            switch (choice4)
            {
                case 1: 
                    {
                        int x, y;
                        Console.Write("\nPlease enter a number: ");
                        x = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Please enter power: ");
                        y = Convert.ToInt32(Console.ReadLine());

                        for (int i = 1; i <= y; i++)
                        {
                            result *= x;
                        }

                    } break;
                case 2:
                    {
                        int x, y;
                        Console.Write("\nPlease enter 1st number: ");
                        x = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Please enter 2nd number: ");
                        y = Convert.ToInt32(Console.ReadLine());

                        result = factfc(x) / factfc(x - y);
                    }
                    break;
                case 3: {
                        int x, y;
                        Console.Write("\nPlease enter 1st number: ");
                        x = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Please enter 2nd number: ");
                        y = Convert.ToInt32(Console.ReadLine());

                        result= factfc(x) / (factfc(y) * factfc(x - y));

                        
                        
                    } break;
                default: break;
            }

            return result;
        }

        // fact caculator
        static int factfc(int x)
        {
            int f = 1;
            for (int i = x; i >= 1; i--)
            {
                f *= i;
            }
            return f;

        }

        static void Main(string[] args)
        {
            int choice1 = 0;
            int choice2 = 0;
            int choice3 = 0;
            int choice4 = 0;

            while (choice1 !=4) 
            {
                Console.Clear();
                choice1 = menu1();

                if (choice1<=4 && choice1>0)
                {
                    if (choice1 == 4)
                    {
                        Console.WriteLine("Thanks for using my app :))\n"); Environment.Exit(0);
                    }

                    if (choice1==1)
                    {
                        choice2 = calculatin_menu();

                        
                        Console.WriteLine("\nResult: " + result(choice2));

                        Console.ReadLine();

                    }

                    else if (choice1==2)
                    {
                        choice3 = metric_menu();

                        
                        Console.WriteLine("\nResult: " + result2(choice3));

                        Console.ReadLine();

                    }

                    else if (choice1 == 3)
                    {
                        choice4 = formula_menu();

                        
                        Console.WriteLine("\nResult: " + result3(choice4));

                        Console.ReadLine();
                    }

                    


                    
                }

                else
                {
                    Console.WriteLine("Please enter a valid number!!!\a");
                    Console.WriteLine("");
                    Console.ReadLine();
                }
            }

        }
    }
}
