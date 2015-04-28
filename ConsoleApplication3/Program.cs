using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    public class Book {

        //private ველების შექმნა
        private string author;
        private string book;
        private int _pages;

        //Print ფუნქცია
        public void Print() { 
            Console.WriteLine(_pages);
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
            Book b1 = new Book();
            int inp1 = Convert.ToInt32(Console.ReadLine());

            b1.Print();

        }
    }
}
