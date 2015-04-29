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
                if (10 < value && value < 1000)
                {
                    this._pages = value;
                }
                else {
                    Console.WriteLine("Number of pages must be from 10 to 1000");
                    System.Environment.Exit(0);
                }
            }   
        }


        //Print ფუნქცია
        public void Print()
        {
            
            Console.WriteLine("Avtori aris " + Author + ", wigni:  " + Books + ", gverdebis raodenoba: " + Pages);
        }


}


    class Program
    {
        static void Main(string[] args)
        {
            //first class
            Book b1 = new Book();
            Console.WriteLine("Shemoitanet avtori: ");
            b1.Author = Console.ReadLine();
            Console.WriteLine("Shemoitanet wigni: ");
            b1.Books = Console.ReadLine();
            Console.WriteLine("Shemoitanet gverdebis raodenoba: ");
            try
            {
                b1.Pages = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Input numbers only");
                System.Environment.Exit(0);
            }
            b1.Print();



            //second class
            Book b2 = new Book();
            Console.WriteLine("Shemoitanet avtori: ");
            b2.Author = Console.ReadLine();
            Console.WriteLine("Shemoitanet wigni: ");
            b2.Books = Console.ReadLine();
            Console.WriteLine("Shemoitanet gverdebis raodenoba: ");
            try
            {
                b2.Pages = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Input numbers only");
                System.Environment.Exit(0);
            }

            Console.WriteLine("Avtori aris " + b2.Author + ", wigni:  " + b2.Books + ", gverdebis raodenoba: " + b2.Pages);

                       

        }
    }
}
