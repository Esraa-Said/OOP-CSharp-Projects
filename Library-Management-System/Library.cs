using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System
{
    public class Library
    {
        public List<Book> Books { get; set; }
        public List<User> Users { get; set; }
        public Library() {
            this.Books = new List<Book>();
            this.Users = new List<User>();
        }

        public void AddBook(Book book) => this.Books.Add(book);
        public void AddUser(User user) => this.Users.Add(user);
        //public void DeleteBook(Book book) => this.Books.Remove(book);

        public List<Book> ReturnBooks() => this.Books;
        public Book SearchBook(string title) 
            {
            if (this.Books != null && this.Books.Any())
            {
                return this.Books.FirstOrDefault(book => book.Title.Equals(title, StringComparison.OrdinalIgnoreCase));
            }
            return null;
        }



}
}
