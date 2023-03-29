using Array;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    public class Product
    {
        private int id, price;
        private string name;

        public Product(int id, int price, string name)
        {
            this.id = id;
            this.price = price;
            this.name = name;
        }
        public override string ToString()
        {
            return $"product id ={id}, product name ={name},  product price={price}";
        }
    }
}
public class Class1
{

    static void Main(string[] args)
    {
        int[] arr = new int[3] { 1, 2, 3 };
        Product[] productlist = new Product[3]
        {
            new Product(101, 899, "Mouse"),
            new Product(102, 100000, "MAC book"),
            new Product(103, 799, "Keyboard"),

        };
        for (int i = 0; i < productlist.Length; i++)
        {
            Console.WriteLine(productlist[i]);
        }

        Console.WriteLine("-------------------------------");


        foreach (Product product in productlist)
        {
            Console.WriteLine(product);
        }
    }

}

