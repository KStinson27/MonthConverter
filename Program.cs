using System;

namespace MonthConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            int userNumber;
           
            bool exit = false;

            do
            {
                Console.WriteLine("Pick a number between 1-12");
                userNumber = sbyte.Parse(Console.ReadLine());

                if (userNumber >= 1 && userNumber <= 12)
                {

                    switch (userNumber)
                    {
                        case 1:
                            Console.WriteLine("January");
                            exit = true;
                            break;
                        case 2:
                            Console.WriteLine("February");
                            exit = true;
                            break;
                        case 3:
                            Console.WriteLine("March");
                            exit = true;
                            break;
                        case 4:
                            Console.WriteLine("April");
                            exit = true;
                            break;
                        case 5:
                            Console.WriteLine("May");
                            exit = true;
                            break;
                        case 6:
                            Console.WriteLine("June");
                            exit = true;
                            break;
                        case 7:
                            Console.WriteLine("July");
                            exit = true;
                            break;
                        case 8:
                            Console.WriteLine("August");
                            exit = true;
                            break;
                        case 9:
                            Console.WriteLine("September");
                            exit = true;
                            break;
                        case 10:
                            Console.WriteLine("October");
                            exit = true;
                            break;
                        case 11:
                            Console.WriteLine("November");
                            exit = true;
                            break;
                        case 12:
                            Console.WriteLine("December");
                            exit = true;
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Enter a valid number");
                }

            } while (exit != true);
        }
    }
}
