using Library_Management_System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Library_Management_System
{
    public class Librarian
    {

        public void Start()
        {
            Library library = new Library();

            Console.WriteLine("Hello World From Our Library");
            Console.WriteLine("-------------------------------");
            while (true)
            {
                Console.WriteLine("Choose Number To Make An Operation: ");
                Console.WriteLine("1: For Add Book");
                Console.WriteLine("2: For Add User");
                Console.WriteLine("3: Search For Book");
                Console.WriteLine("4: Get All Books");
                Console.Write("What is Your Number: ");
                bool isValid = int.TryParse(Console.ReadLine(), out int number);
                if (number > 4 || number < 0 || !isValid)
                {
                    Console.WriteLine("Enter number between 1 to 4");
                    continue;
                }
                if (number == 1)
                {
                    Console.WriteLine("Enter the Title of the Book");
                    string title = Console.ReadLine();
                    Console.WriteLine("Enter the Author of the Book");
                    string author = Console.ReadLine();
                    Book book = new Book(title, author);
                    library.AddBook(book);
                }
                else if (number == 2)
                {

                    Console.WriteLine("Enter the Name of the User");
                    string uname = Console.ReadLine();
                    Console.WriteLine("Enter the Id of the User");
                    int uid = int.Parse(Console.ReadLine());
                    User user = new User(uname, uid);
                    library.AddUser(user);

                }
                else if (number == 3)
                {

                    Console.WriteLine("Enter the Title of the Book");
                    string title = Console.ReadLine();

                    Book book = library.SearchBook(title);
                    if (book != null)
                    {
                        Console.WriteLine($"Your Book with title {book.Title} is Founded with Author {book.Author}");
                    }
                    else
                    {
                        Console.WriteLine($"Book with title {title} is not found");
                    }
                }
                else
                {
                    List<Book> books = library.ReturnBooks();
                    foreach (var book in books)
                    {
                        Console.WriteLine($"{book.Title} Book, {book.Author} Author.");
                    }
                }
                Console.WriteLine("-------------------------------");

            }
        }


    }
}
