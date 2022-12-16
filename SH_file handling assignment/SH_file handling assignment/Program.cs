using System;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SH_file_handling_assignment
{
    internal class Program
    {
        public static void Main(string[] args)
        {

            bool filecreate = true;
            while (filecreate)
            {
                Console.Clear();
                Console.WriteLine("------ Main Menu ------\n");
                Console.WriteLine("choose one options..");
                Console.WriteLine("1.Write a line \n2.Exit");
                string choice = Console.ReadLine();
                if (choice == "1")
                {
                    Createfile cr = new Createfile();
                    cr.Create();

                }
                else if (choice == "2")
                {
                    filecreate = false;
                }
                else
                {
                    Console.WriteLine("\nInvalid Input! Press enter a valid option.");
                    Console.ReadLine();
                }
            }
            Console.WriteLine("Thank You..");
            Console.ReadLine();
        }
    }

    
}
