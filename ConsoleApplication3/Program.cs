using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    public class Book {

        //private ველების შექმნა
        private string _author;
        private string _books;
        private int _pages;
        
        //_author property
        public string Author {
            get {
                return this._author;
            }
            set {
                this._author = value;
            }
        }

        //_book property
        public string Books {
            get {
                return this._books;
            }
            set {
                this._books = value;
            }
        }


        //_pages property
        public int Pages{
            get {
                return this._pages;
            }
            set { //ვამოწმებთ გვერდების რაოდენობას
                if (10 < value && value < 100)
                {
                    this._pages = value;
                }
                else {
                    Console.WriteLine("Number of pages must be from 10 to 100");
                }
            }   
        }


        //Print ფუნქცია
        public void Print()
        {
            Console.WriteLine(_author, _books, _pages);
        }


}


    class Program
    {
        static void Main(string[] args)
        {

            Book b1 = new Book();
            b1.Author = Console.ReadLine();
            b1.Books = Console.ReadLine();
            b1.Pages = Convert.ToInt32(Console.ReadLine());

            



            

        }
    }
}
