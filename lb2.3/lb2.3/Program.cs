using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lb2._3
{
    public class Book
    {
        public string book;
        void Show()
        {
            Console.Write($"\nКнига: {this.book}");
        }
    }

    class Title
    {
        public string title;
        public void Show()
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write($"\nНазва книги: {this.title}");
        }
    }

    class Author
    {
        public string author;
        public void Show()
        {
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write($"\nАвтор: {this.author}");
        }
    }

    class Content
    {
        public string content;
        public void Show()
        {
             Console.BackgroundColor = ConsoleColor.DarkCyan;
             Console.ForegroundColor = ConsoleColor.Red;
             Console.Write($"\nЗмiст: {this.content}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int number = 0;
            while (true)
            {
                Title newtitle = new Title();
                Author newauthor = new Author();
                Content newcontent = new Content();
                number++;

                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;

                Console.Write("\nКнига № " + number);
                Console.ReadLine();
                Console.WriteLine("\nНапишiть назву книги: ");
                newtitle.title = Console.ReadLine();
                Console.WriteLine("Автор книги: ");
                newauthor.author = Console.ReadLine();
                Console.WriteLine("Напишiть змiст книги");
                newcontent.content = Console.ReadLine();

                newtitle.Show();
                newauthor.Show();
                newcontent.Show();

                
                Console.Read();
                
            }
            

        }
    }
}
