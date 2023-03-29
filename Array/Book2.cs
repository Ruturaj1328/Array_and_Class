using Array;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    public class Book2
    {
        private int bookid  { get; set; }
        private string  bookname { get; set; }
        private string bookauthoer { get; set; }
        private int price { get; set; }

        public override string ToString()
        {
            return $"bookid = {bookid} ,bookname={bookname} ,bookauthor{bookauthoer}, bookprice{price}";
        }
    }
}
public class Class3
{
    static void Main(string[] args)
    {
        Book2[] Booklist = new Book2[4];
       /* {
            new Book2{bookid=101, price=899, bookname="Littel", bookauthoer="XYZ" },
            new Book2{bookid=102, price=799, bookname="Littel", bookauthoer="XYZ" },
            new Book2{bookid=103, price=999, bookname="Littel", bookauthoer="XYZ" },
            new Book2{bookid=104, price=599, bookname="Littel", bookauthoer="XYZ" },
        };*/
        for (int i = 0; i < Booklist.Length; i++)
        {
            Console.WriteLine(Booklist[i]);
        }
        Console.WriteLine("------------------------------------");

        foreach (Book2 B in Booklist)
        {
            Console.WriteLine(B);
        }
    }
}

