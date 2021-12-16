using System;

namespace IOT_1030_Final_Project_Sandeep_Kaur
{
    class Program
    {
        static void Main(string[] args)
        {
            Book_info book = new Book_info();

            while (true)
            {
                // here i will call first intro method from book info class file 
                book.first_intro();

                // here i will call menu option method from book info class file 
                book.menu_options();

                // enter option from user 
                Console.Write("Enter your option: ");
                int option = Convert.ToInt32(Console.ReadLine());

                // here i will use switch-case 
                switch (option)
                {
                    // if user enter "1" this case run 
                    case 1:

                        Console.WriteLine("");
                        Console.WriteLine("Add new book information");
                        Console.WriteLine("");

                        book.add_new_book_details();
                        Console.Clear();

                        break;

                    // if user enter "2" this case run
                    case 2:

                        Console.WriteLine("");
                        Console.WriteLine("List all the books infromation");
                        Console.WriteLine("");

                        book.view_all_book_details();
                        Console.Clear();

                        break;

                    // if user enter "3" this case run
                    case 3:

                        // this function ise for exit code 
                        Environment.Exit(1);
                        break;

                    default:

                        book.invalid_menu_option();
                        book.any_key();
                        break;
                }
            }
        }
    }
}
