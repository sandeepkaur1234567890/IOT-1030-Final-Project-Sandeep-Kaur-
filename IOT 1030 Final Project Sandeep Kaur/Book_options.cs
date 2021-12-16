using System;
using System.Collections.Generic;
using System.Text;

namespace IOT_1030_Final_Project_Sandeep_Kaur
{
    // this is my base class
    public class Book_options
    {
        public int ID { get; set; }
        public string Book_name { get; set; }
        public string Author_name { get; set; }
        public string Book_Category { get; set; }
        public double Book_price { get; set; }
        public double ISBN_number { get; set; }
        public DateTime Year_of_Lunched { get; set; }

        //this is the constructor 
        public Book_options(int id, string book_name, string author_name, string book_category, double price, double isbn, DateTime year_of_lunched)
        {
            ID = id;
            Book_name = book_name;
            Author_name = author_name;
            Book_Category = book_category;
            Book_price = price;
            ISBN_number = isbn;
            Year_of_Lunched = year_of_lunched;
        }

        public Book_options()
        { }
    }
}
