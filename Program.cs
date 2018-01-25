using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public class Program
    {
        static void Main(string[] args)
        {
            int x;
            bool run = true;
            Console.WriteLine("Welcome to my program; \nThis program displays a table of Power");
            while (run)
            {
                Console.Write("Enter an integer :");
                x = int.Parse(Console.ReadLine());
                DisplayTable(x);
                run = continue_run();
            }

        }

        public static bool continue_run()
        {

            Console.Write("Continue?(Y/N) : ");
            string response = Console.ReadLine();
            response = response.ToLower();
            if (response == "y")
            {
                return true;
            }
            else if (response == "n")
            {
                return false;
            }
            else
        {
        Console.WriteLine("You did not type a recognized caracter, type Y or N");
   
                return continue_run();
        }
              
    }

     public  static void DisplayTable(int number)
        {
            Console.WriteLine( "Number   Squared \tCube");
            Console.WriteLine("=======   ======= \t====");


            for (int i = 1; i <= number; i++)
            {
                Console.WriteLine(i+"\t\t"+ i*i+"\t"+i*i*i);
            }

        }
    }
}
