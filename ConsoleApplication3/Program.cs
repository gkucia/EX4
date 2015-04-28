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
        
        //Print ფუნქცია
        public void Print (string a, string b, int c) {
            a = _author;
            b = _books;
            c = _pages;
            Console.WriteLine(_author, _books, _pages);
        }

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
                    Console.WriteLine("Number of pages must be from 10 to 100");
                }
                else {
                    this._pages = value;
                }
            }   
        }


}


    class Program
    {
        static void Main(string[] args)
        {
            

        }
    }
}
