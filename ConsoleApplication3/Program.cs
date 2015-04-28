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
            //Book b1 = new Book();
            //b1.Author = Console.ReadLine();
            //b1.Books = Console.ReadLine();
            //b1.Pages = Convert.ToInt32(Console.ReadLine());
            //b1.Print();

            Book b2 = new Book();
            b2.Author = Console.ReadLine();
            b2.Books = Console.ReadLine();
            try
            {
                b2.Pages = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Input numbers only");
                System.Environment.Exit(0);
            }

            //სოფო, აქ ამ output-ს გამოაქვს მარტო b2.Author და ვერ გავიგე რატომ
            //ასე თუ დავწერ
            //Console.WriteLine("Avtori aris " + Author + ", wigni:  " + Books + ", gverdebis raodenoba: " + Pages);
            //მაშინ გამოაქვს ჩვეულებრივად და ვერ ვხვდები რატომ
            Console.WriteLine(b2.Author, b2.Books, b2.Pages);




            

        }
    }
}
