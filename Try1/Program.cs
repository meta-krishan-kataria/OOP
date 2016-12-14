using System;
using cc = System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Try1
{
    class Program
    {
        int a;

        static  void Main5()
        {
            Test obj = new Test();
            Console.WriteLine("Hello world !! A is {0}",obj.A);

            Shape ob = new Rectangle(10, 5);    // Liskov's substitution.
            //ob.L=10;                  //Shape refernce cannot be used to refer B,L
            Console.WriteLine("Area is {0}", ob.Area());


            Rectangle rectangle = new Rectangle();
            rectangle.L = 20;
            rectangle.B = 30;

            // Object initializer
            Shape ob2 = new Rectangle { L = 20, B = 30 };
           
            Console.WriteLine(ob2.Area());

        }
    }
    
    
    class Test
    {
        public int A {  get; set; }     // Default private.

        public Test()
        {
            A = 10;
        }
    }

    /**************/
    interface Shape
    {
        int Area();
    }

    interface Shape2
    {
        int Perimeter();
    }



    class Rectangle : Shape, Shape2         // Multiple interfaces
    {
        public int L { get; set; }          //public 
        public int B { get; set; }

        public Rectangle()
        {

        }

        public Rectangle(int l,int b)
        {
            L = l;
            B = b;
        }

        public int Area()
        {
            return L * B;
        }

         public int Perimeter()
         {
             return 2*(L + B);
         }

    }




}
