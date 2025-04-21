using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System
{
    public class User
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public List<Book> BorrowedBooks { get; set; }
        public User(string name, int id) {
            this.Name = name;
            this.Id = id;
            this.BorrowedBooks = new List<Book>();
        }

        public void BorrowBook(Book book)
        {
            if (book.IsBorrowed)
            {
                Console.WriteLine($"Book {book.Title} is borrowed");
            }
            else
            {
                BorrowedBooks.Add(book);
                book.IsBorrowed = true;
                Console.WriteLine($"{Name} borrowed {book.Title}");
            }
        }


        public void ReturnBook(Book book)
        {
            if (BorrowedBooks.Contains(book))
            {
                BorrowedBooks.Remove(book);
                book.IsBorrowed= false;
                Console.WriteLine($"{Name} returned {book.Title}");
            }
            else {
                Console.WriteLine($"{Name} did not borrow {book.Title}");

            }

        }


    }


}
