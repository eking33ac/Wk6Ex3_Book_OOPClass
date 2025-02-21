using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wk6Ex3_Book_OOPClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Goal: Create a class to hold Book information
            // Include a constructor to initialize the properties.
            // Have a method within the class to display Book information.
            // Create two books (objects of the Book class) and display their information.

            
            // Initialize the first book. Set the title to Harriet Porter, set the author to K. L. Growling, set the genre to children's fantasy, and set the price to 12
            Book book1 = new Book("Harriet Porter", "K. L. Growling", "Children's Fantasy", 12);

            // Initialize the second book. Set the title to Lady Valentina's Palace, set the author to Lady Valentina, set the genre to YA Sci-Fi, and set the price to 18.93
            Book book2 = new Book("Lady Valentina's Palace", "Lady Valentina", "YA Sci-Fi", 18.93);


            // display the details for book 1
            book1.ShowBookInfo();

            // display the details for book 2
            book2.ShowBookInfo();


            // pause at the end of the program for user to read
            Console.ReadLine();
        }
    }

    // Book Class

    class Book
    {
        // Properties/Attributes/Field Names
        public string Title;        // Declare an attribute of the class to hold a book's title
        public string Author;          // Declare an attribute of the class to hold a book's author
        public string Genre;          // Declare an attribute of the class to hold a book's genre
        public double Price;          // Declare an attribute of the class to hold a book's price


        // Constructor
        // (Needs to have the same name as the class)
        public Book(string aTitle, string aAuthor, string aGenre, double aPrice)
        {
            Title = aTitle;       // set the title of the book object in the book class to be the title we input
            Author = aAuthor;       // set the author of the book object in the book class to be the author we input
            Genre = aGenre;     // set the genre of the book object in the book class to be the genre we input
            Price = aPrice;       // set the price of the book object in the book class to be the price we input
        }


        // Methods

        // Method to display all student information
        public void ShowBookInfo()
        {
            // print the book's details
            Console.WriteLine($"Book Information\n" +      // title of process
                $"Title: {Title}\n" +     // output title of the Book
                $"Author: {Author}\n" +     // output the Book's author
                $"Genre: {Genre}\n" +       // output the Book's genre
                $"Price: {Price:C2}\n");       // output the Book's price in USD money format. End with a line break for readability
        }
    }
}
