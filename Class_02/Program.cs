using System;

namespace Class_02
{
    class Program
    {
        static void Main(string[] args)
        {
            //string userInput = Console.ReadLine();
            //int userNum;
            //bool result = int.TryParse(userInput, out userNum);

            //if (result)
            //{
            //    Console.WriteLine("uspesno");
            //}
            //else
            //{
            //    Console.WriteLine("neuspesno");
            //}


            //Console.WriteLine("hello world");

            //Console.ReadLine();


            //Task 1
            Console.WriteLine("Enter a number:");
            int userInput = int.Parse(Console.ReadLine());
            Console.WriteLine("Output:");
            for (int i = 1; i <= userInput; i++)
            {
             Console.WriteLine(i);
            }

            Console.WriteLine("Enter a second number:");
            int userInput2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Output:");

            for (int i = userInput2; i > 0; i--)
            {
                Console.WriteLine(i);
            }

            //Task 2

            Console.WriteLine("Enter third number:");
            int userInput3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Output even numbers:");

            for (int i = 2; i <= userInput3; i++)
             {
              if (i % 2 == 0) Console.WriteLine(i);
             }

            Console.WriteLine("Enter a fourth number:");

            int userInput4 = int.Parse(Console.ReadLine());
            Console.WriteLine("Output odd numbers:");

            for (int i = 1; i <= userInput4; i++)
            {
                if (i % 2 != 0) Console.WriteLine(i);
            }

            //Task 3

            Console.WriteLine("Enter a fifth number:");
            int userInput5 = int.Parse(Console.ReadLine());
            
            for(int i=1; i < userInput5; i++)
            {
                if (i % 3== 0 || i % 7 == 0)
                {
                    continue;
                }
                if (i==100)
                {
                    Console.WriteLine("Here we stop");

                    break;
                }
                Console.ReadLine();
            }

            Console.ReadLine();
              
            }
        }
    }

