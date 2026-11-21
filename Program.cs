using System;
using System.Text;

namespace Assignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {


            //Q01

            string title = "clean code";
            string upperTitle = title.ToUpper();
            Console.WriteLine(title);
            Console.WriteLine(upperTitle);

            //Q02

            string book1 = "Clean Code";
            string book2 = "Clean Code";
            bool result = ReferenceEquals(book1, book2);
            Console.WriteLine(result);

            //Q03

            StringBuilder sb = new StringBuilder();
            sb.Append("Book List");
            sb.Append(" - Updated");
            Console.WriteLine(sb.ToString());

            //Q04


            sb.Replace("Book List", "Library");
            Console.WriteLine(sb.ToString());


            //Q05

            title = "Clean Code";
            int pages = 464;
            Console.WriteLine("Book: " + title + ", Pages: " + pages);

            //Q06

            Console.WriteLine($"Book: {title}, Pages: {pages} ");

            //Q07

            string foramttingResult = string.Format("Book: {0}, Pages: {1}", title, pages);
            Console.WriteLine(foramttingResult);

            //Q08


            
            if (pages > 300)
            {
                Console.WriteLine("long book");

            }
            else
            {
                Console.WriteLine("short book.");


            }

            //Q09

            bool isAvailable = true;
            if(isAvailable && pages > 300)
            {
                Console.WriteLine("You can borrow this book");
            }

            //Q10

            string title010 = "Refactoring";

            switch (title010)
            {
                case "Clean Code":
                    Console.WriteLine("Great choice!");
                    break;

                case "Refactoring":
                    Console.WriteLine("Nice pick!");
                    break;

                default:
                    Console.WriteLine("Never heard of it");
                    break;
            }



            //Q11


            string sizeLabel = pages > 300 ? "Long Book" : "Short Book";

            Console.WriteLine(sizeLabel);


            //Q12


            string[] books =
            {
             "Clean Code",
             "The Pragmatic Programmer",
             "Refactoring"
            };

            for (int i = 0; i < books.Length; i++)
            {
                Console.WriteLine((i + 1) + ". " + books[i]);
            }

            //Q13


            int i13 = 0;
            while (i13 < books.Length)
            {
                Console.WriteLine(books[i13]);

                i13++;
            }

            //Q14


            int i14 = 0;

            do
            {
                Console.WriteLine("Checking book...");

                i14++;

            } while (i14 < 3);

            //Q15

            foreach (string book in books)
            {
                Console.WriteLine(book);
            }

            //Q16

            foreach (string book in books)
            {
                if (book == "Refactoring")
                {
                    break;
                }

                Console.WriteLine(book);
            }

            //Q17

            foreach (string book in books)
            {
                if (book == "The Pragmatic Programmer")
                {
                    continue;
                }

                Console.WriteLine(book);
            }


            //Q18


            PrintFirstBook(books);

        } 


        static void PrintFirstBook(string[] books)
        {
            if (books.Length == 0)
            {
                return;
            }

            Console.WriteLine(books[0]);
        }

    } 
} 



        
    


