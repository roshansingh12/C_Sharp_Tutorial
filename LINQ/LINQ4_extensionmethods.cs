using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_tutorial.LINQ
{
    /*public class Program
    {
        public static void Main(string[] args)
        {
            LINQ4_extensionmethods linq = new LINQ4_extensionmethods();
            var _books = 
                linq.books.
                Where(book => book.author == "author1"). // filters the sequence based on conditions
                Select(book =>new {book.name,book.title})//selects and return the item in a new format
                .OrderBy(book=>book.name);               //order result based on given properties
            
            //lets count no. of books by authors
            var books_by_authos = linq.books.GroupBy(book => book.author);
            foreach(var books in books_by_authos)
            {
                //writing author has writtent how many books
                Console.WriteLine(books.Key+" has written "+ books.Count()+" books");
                //writing details of every book written by author
                foreach (var book in books)
                {
                    Console.WriteLine($"{book.name} {book.title}");
                }
            }
            Console.WriteLine(_books.Max(book => book.name));
            Console.WriteLine(_books.Min(book => book.name));
            //Any: return true if any record of sequence setisfies given condition.
            //All: return true if all records of sequence setisfies given condition. 
            Console.WriteLine(_books.Any(item => item.name.Contains("7")));
            Console.WriteLine(_books.Any(item => item.name.Contains("100")));
            Console.WriteLine(_books.All(item => item.name.Contains("book")));
            Console.WriteLine(_books.Any(item => item.name.Contains("title10")));
            //Distinct returns distinct element from sequence
            Console.WriteLine(linq.books.Select(book => new {book.author}).Distinct());
            Console.WriteLine(linq.books.Count());
            //Conditional Count
            Console.WriteLine(linq.books.Count(book => book.author == "author1"));
            //Intersect//union//Exceept
            //intersect
            var res = linq.books.Select(book => new { book.name, book.title, book.author });
            Console.WriteLine("select");
            foreach (var x in res)
            {
                Console.WriteLine(x);
            }
            Console.WriteLine("Intersect");
            res = linq.books.Intersect(linq.books2).Select(book => new { book.name, book.title, book.author });
            foreach (var x in res)
            {
                Console.WriteLine(x);
            }
            Console.WriteLine("Union");
            res = linq.books.Union(linq.books2).Select(book => new { book.name, book.title, book.author });
            foreach (var x in res)
            {
                Console.WriteLine(x);
            }
            Console.WriteLine("Except");
            res = linq.books.Except(linq.books2).Select(book => new { book.name, book.title, book.author });
            foreach (var x in res)
            {
                Console.WriteLine(x);
            }
            //Console.WriteLine(linq.books.Union(linq.books2));
            //Console.WriteLine(linq.books.Except(linq.books2));

        }
    }*/
    public class Book
    {
        public string name="";
        public string title="";
        public string author = "";
    }
    internal class LINQ4_extensionmethods
    {
        public List<Book> books = new List<Book>()
        {
            new Book {name="book1",title="title1",author= "author1" },
            new Book {name="book2",title="title2",author= "author12" },
            new Book {name="book3",title="title3",author= "author1" },
            new Book {name="book4",title="title4",author= "author1" },
            new Book {name="book5",title="title5",author= "author2" },
            new Book {name="book6",title="title6",author= "author1" },
            new Book {name="book7",title="title7",author= "author1" },
            new Book {name="book8",title="title8",author= "author3" },
            new Book {name="book9",title="title9",author= "author1" }
        };
        public List<Book> books2 = new List<Book>()
        {
            new Book {name="book10",title="title1",author= "author1" },
            new Book {name="book2",title="title2",author= "author12" },
            new Book {name="book13",title="title3",author= "author1" },
            new Book {name="book41",title="title4",author= "author1" },
            new Book {name="book5",title="title5",author= "author2" },
            new Book {name="book64",title="title6",author= "author1" },
            new Book {name="book7",title="title7",author= "author1" },
            new Book {name="book8",title="title8",author= "author3" },
            new Book {name="book9",title="title9",author= "author1" }
        };
    }
}
