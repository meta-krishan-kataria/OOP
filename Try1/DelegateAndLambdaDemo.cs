using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Try1
{
    class DelegateAndLambdaDemo
    {
        // 
        public delegate void Del(string msg);
        public delegate int Del2(int i);

        //
        public static void DelegateMethod(string message)
        {
            Console.WriteLine("Method 1 "+message);
        }

        //
        public static void DelegateMethod2(string message)
        {
            Console.WriteLine("Method 2 " + message);
        }

        //
        public static void TestingCallback(string name, Del callbackMethod)
        {
            Console.WriteLine("hii " + name);
            Console.WriteLine("some operation");
            callbackMethod("its done " + name);
        }

        static void Main()
        {
            //
            Del handler = DelegateMethod;
            Del handler2 = DelegateMethod2;

            // adding two delegates: "multicasting"
            // both method will be invoked
            handler += handler2;


            handler("Hello krish");

            TestingCallback("krishan", handler);

            // Lambda expression

            //public delegate int Del2(int i);      //error cannot be declared in method

            Del2 myDel = x => x * x;
            int j = myDel(5);
            Console.WriteLine("Square is "+j);


        }


        

    }
}
