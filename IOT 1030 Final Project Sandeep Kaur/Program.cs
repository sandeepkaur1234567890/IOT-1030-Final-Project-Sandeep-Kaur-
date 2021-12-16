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
                book.first_intro();

                book.menu_options();

                Console.Write("Enter your option: ");
                int option = Convert.ToInt32(Console.ReadLine());

                switch (option)
                {
                    case 1:

                        Console.WriteLine("");
                        Console.WriteLine("Add new book information");
                        Console.WriteLine("");

                        book.add_new_book_details();
                        Console.Clear();

                        break;

                    case 2:

                        Console.WriteLine("");
                        Console.WriteLine("List all the books infromation");
                        Console.WriteLine("");

                        book.view_all_book_details();
                        Console.Clear();

                        break;

                    case 3:

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
