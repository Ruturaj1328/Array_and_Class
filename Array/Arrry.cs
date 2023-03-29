using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{// max number of array
    internal class Arrry
    {
        static void Main(string[] args)
        {
            int[] number = {10,29,50,70,7,};
            
            //for(int i=0; i<number.Length; i++) 
            {
                Console.WriteLine("max number is "+number.Max());
               // Console.WriteLine("Min number is " + number.Min());

            }
        }
    }
}
namespace Array
{  // alternate number of array
    internal class Arrr
    {
        static void Main(string[] args)
        {
            int[] number = { 10, 29, 50, 70, 7, };
            int n = number.Length;
            for(int i=0;i<n;i=i+2) 
            {
                Console.WriteLine(number[i]);
            }
        }
    }
}

namespace Array
{   // reverse of array
    internal class Arr
    {
        static void Main(string[] args)
        {
            int[] number = { 10, 29, 20, 50, 60 };
            int n = number.Length;
            for (int i=4; i<=number.Length;i=i-1)
            {
                Console.WriteLine(number[i]);
            }
        }
    }
}


namespace Array
{
    internal class Arm
    {
        static void Main(string[] args)
        {
            int r,sum=0;
            Console.WriteLine("Enter number");
            int n= Convert.ToInt32(Console.ReadLine());
            int temp = n;
            while(n>0)
            {
                r = n % 10;
                sum = sum+r*r*r;
                n = n / 10;
            }

            Console.WriteLine(sum);
            if(temp==sum)
            {
                Console.WriteLine("It is Armstrong number");
            }
            else
            {
                Console.WriteLine("It is Not Armstrong number");
            }
        } 

        
        
    }
}


namespace Array
{
    internal class User
    {
        static void Main(string[] args)
        {
            int[,] num = new int[3,3];
            Console.WriteLine("Enter 9 vaule");
            // int row = Convert.ToInt32(Console.ReadLine());
            // int column=Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < num.GetLength(0); i++)
            {
                for (int j = 0; j < num.GetLength(1); j++)
                {
                    num[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            

            for (int i=0;i<num.GetLength(0);i++) 
            { 
                for (int j=0;j<num.GetLength(1); j++)
                {
                    Console.Write($"num [{i},{j}]={num[i,j]}");
                }

                Console.WriteLine();
            }
        }
    }
}


namespace Array
{   ///           Addition of Two Matrix
    internal class Matrix
    {
        static void Main(string[] args)
        {
            int[,]num= new int[3,3];
            int[,]num1= new int[3,3];
            Console.WriteLine("enter Value of Matrix 1");
            for(int i=0; i<num.GetLength(0);i++)
            {
                for (int j=0;j<num.GetLength(1);j++)
                {
                    num[i,j]= Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine();
            Console.WriteLine("enter Value of Matrix 2");

            for (int i=0;i<num1.GetLength(0);i++)
            {

                for (int j = 0; j < num1.GetLength(1); j++)
                {
                    num1[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("result");
            for (int i = 0; i < num.GetLength(0); i++)
            {

                for (int j = 0; j < num.GetLength(1); j++)
                {
                    Console.WriteLine($"num[{i},{j}]+num1[{i},{j}]= {num[i,j]+num1[i,j]}");
                }
            }

        }
    }
}
namespace Array
{
    internal class Fact
    {
        static void Main(string[] args)
        {
            int num, fact = 1;
            Console.WriteLine("Enter  number");
            num= Convert.ToInt32(Console.ReadLine());   
             for(int i=1;i<=num;i++)
            {
                fact = fact * i;
            }
            Console.WriteLine(fact);
        }
    }
}

namespace Array
{
    internal class Repeat
    {
        static void Main(string[] args)
        {
           
            int[] arr = new int[] { 1, 2, 3, 4, 1, 2, 3, 5, 6, 7 };
            int n= arr.Length;
            int count = 0;
            for(int i=0;i<=n;i++)
            {
                for(int j=0;j<=n;j++)
                {

                    if (arr[i] == arr[j+1]) 
                    {
                        count = count + 1;
                        Console.WriteLine($"the repeated element is {arr[i]} and count {count}");
                    }
                }
               
               
               


               
            }
         


        }


    }
}
