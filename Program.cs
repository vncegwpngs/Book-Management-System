using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BookManagementSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            string optionSelected = "okay", bookInfo, borrowerInfo, dateInfo, editedInfo;
            List<string> editInfo = new List<string>() { "English", "Vince", "10-10-10" };
            int infoIndex, numInfo;

            string textToShow = "WELCOME TO BOOK MANGEMENT SYSTEM\n\n";
            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (textToShow.Length / 2)) + "}", textToShow));

            Console.Write("TAP ANYTHING TO CONTINUE\n\n");
            Console.ReadKey();

            Console.WriteLine("Log-in Form");
            Console.WriteLine("-----------\n");

            int loginAttempts = 0;

            for (int i = 0; i < 3; i++)
            {
                Console.Write("Input your Username: ");
                String username = Console.ReadLine();

                Console.Write("Input your Password: ");
                String password = Console.ReadLine();

                if (username != "admin" || password != "admin")
                    loginAttempts++;
                else
                    break;
            }

            if (loginAttempts > 2)
            {
                Console.WriteLine("Failed to Login!");
                Console.WriteLine("-------------\n");
            }
            else
            {

                Console.WriteLine("\nLogin Successfully!");
                Console.WriteLine("-------------------\n\n");
                Console.WriteLine("TAP ANYTHING TO CONTINUE\n");
                Console.ReadKey();


                do
                {
                    Console.WriteLine("Pick a number to continue\t");
                    Console.WriteLine("===========================\n");

                    Console.WriteLine("1. Book Borrower's Information");
                    Console.WriteLine("2. Edit/Update Information");
                    Console.WriteLine("3. Search for Borrowed Books");
                  

                    Console.Write("\nEnter your choice: ");
                    String choice = Console.ReadLine();

                    if (choice == "1")
                    {
                        Console.WriteLine("\nBorrower's Information");
                        Console.WriteLine("----------------------\n\n");
                        Console.Write("Enter Book's Name: ");
                        bookInfo = Console.ReadLine();
                        Console.Write("Enter Borrower's Name: ");
                        borrowerInfo = Console.ReadLine();
                        Console.Write("Enter date borrowed: ");
                        dateInfo = Console.ReadLine();

                        Console.WriteLine("\n\nName of the book: " + bookInfo);
                        Console.WriteLine("Borrower's Name: " + borrowerInfo);
                        Console.WriteLine("Date Borrowed: " + dateInfo);

                        Console.Write("\nType okay to go back to menu: ");
                        optionSelected = Console.ReadLine().ToLower();

                    }

                    if (choice == "2")
                    {
                        Console.WriteLine("\nEdit/Update Information");
                        Console.WriteLine("-------------------------\n\n");
                        numInfo = 1;
                        foreach (var infolist in editInfo)
                        {

                        Console.WriteLine(numInfo + "-" + infolist);
                        numInfo++;

                        }
                        Console.Write("\nEnter number to edit: ");
                        infoIndex = int.Parse(Console.ReadLine());


                        Console.Write("Enter your new info: ");
                        editedInfo = Console.ReadLine();
                        editInfo.RemoveAt(infoIndex - 1);
                        editInfo.Insert(infoIndex - 1, editedInfo);

                        Console.Write("\nType okay to go back to menu: ");
                        optionSelected = Console.ReadLine().ToLower();
                    }


                    if (choice == "3")
                    {
                        Console.WriteLine("\nSearch for Borrowed Books");
                        Console.WriteLine("-------------------------\n\n");
                        Console.WriteLine("Enter Book's name to view Information");
                        bookInfo = Console.ReadLine();
                        borrowerInfo = Console.ReadLine();
                        dateInfo = Console.ReadLine();

                        Console.WriteLine("\nThe book " + bookInfo + borrowerInfo + dateInfo);

                        Console.Write("Type okay to go back to menu: ");
                        optionSelected = Console.ReadLine().ToLower();
                    }

                } while (optionSelected.Equals("okay"));

            }

            Console.ReadKey();

        }
    }
}