using Array;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    public class Book
    {
        private int bookid,price;
        private string bookname, bookauther;
        
        public Book(int bookid,int price,string bookname,string bookauther)
        {
            this.bookid = bookid;
            this.bookname = bookname;
            this.bookauther = bookauther;
            this.price = price;

        }

        public override string ToString()
        {
            return $"bookid={bookid},bookname={bookname},bookauther={bookauther},price{price}";
        }
    }
}
public class Class2
{
    static void Main(string[] args)
    {
        int[] arr = new int[4] { 1, 2, 3, 4 };
        Book[] Booklist = new Book[4]
        {
            new Book(101, 899, "Littel", "XYZ"),
            new Book(102, 555, "Rules", "XYZ"),
            new Book(103, 850, "Big", "XYZ"),
            new Book(104, 999, "watch", "XYZ"),
        };

        for (int i = 0; i < Booklist.Length; i++)
        {
            Console.WriteLine(Booklist[i]);
        }
        Console.WriteLine("------------------------------------");

        foreach (Book B in Booklist)
        {
            Console.WriteLine(B);
        }
    }
}
