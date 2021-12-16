using System;
using System.Collections.Generic;
using System.Text;

namespace IOT_1030_Final_Project_Sandeep_Kaur
{
    // derived class
    public class Book_info : Abstract_E_book
    {
        List<Book_options> book_info = new List<Book_options>();

        // here i will derived add new book details method from abstract class
        public override void add_new_book_details()
        {
            Console.Write("Book ID: ");
            var id = Convert.ToInt32(Console.ReadLine());
            Console.Write("Book name: ");
            var book_name = Convert.ToString(Console.ReadLine());
            Console.Write("Author name: ");
            var author_name = Convert.ToString(Console.ReadLine());
            Console.Write("Book Category: ");
            var book_category = Convert.ToString(Console.ReadLine());
            Console.Write("Book Price $: ");
            var price = Convert.ToDouble(Console.ReadLine());
            Console.Write("ISBN number: ");
            var isbn = Convert.ToDouble(Console.ReadLine());
            Console.Write("Year of Lunched: ");
            var year_of_lunched = Convert.ToDateTime(Console.ReadLine());

            book_info.Add(new Book_options(id, book_name, author_name, book_category, price, isbn, year_of_lunched));

        }

        // here i will derived view all book details method from abstract class
        public override void view_all_book_details()
        {
            if (book_info.Count > 0)
            {
                foreach (var show_book_details in book_info)
                {
                    Console.WriteLine("");
                    Console.WriteLine($"Book ID: {show_book_details.ID}");
                    Console.WriteLine($"Book name: {show_book_details.Book_name}");
                    Console.WriteLine($"Author name: {show_book_details.Author_name}");
                    Console.WriteLine($"Book category: {show_book_details.Book_Category}");
                    Console.WriteLine($"Book Price $: {show_book_details.Book_price}");
                    Console.WriteLine($"ISBN number: {show_book_details.ISBN_number}");
                    Console.WriteLine($"Year of Lunched: {show_book_details.Year_of_Lunched}");
                    Console.WriteLine("");
                }
            }
            else
            {
                no_book_details();
            }
            any_key();
        }

        // here i will derived first intro method from abstract class
        public override void first_intro()
        {
            Console.Clear();
            Console.WriteLine("Book Infomation Database ");
            Console.WriteLine("");

            Console.WriteLine("Please choose any option: ");
        }

        // here i will derived menu options method from abstract class
        public override void menu_options()
        {
            Console.WriteLine("1 : Add new book information");
            Console.WriteLine("2 : List all the books infromation");
            Console.WriteLine("3 : Exit the program");
            Console.WriteLine("");
        }

        // here i will derived any key method from abstract class
        public override void any_key()
        {
            Console.WriteLine("");
            Console.WriteLine("Press any key continue this console application....");
            Console.ReadLine();
        }

        // here i will derived invalid menu option method from abstract class
        public override void invalid_menu_option()
        {
            Console.WriteLine("Sorry! your option is not valid, please enter valid option (between 1 and 3)");
        }

        // here i will derived no book details method from abstract class
        public override void no_book_details()
        {
            Console.WriteLine("Sorry you didn't enter any book details yet");
        }
    }
}
