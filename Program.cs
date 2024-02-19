// See https://aka.ms/new-console-template for more information
// using System;
// Console.WriteLine("Hello, World!");


// int a=10;
// Console.WriteLine(a);
// Console.WriteLine("the given number is "+a);

// float b=10.5f;
// double c=10.5d;
// Console.WriteLine(c.GetType());
// Console.WriteLine(b.GetType());




    // class prabhaharn
    // {
    //     static void Main(string[] args)
    //     {
    //         Console.WriteLine("i am learing c#");
    //     }
    // }

using System;

namespace CProgram
{
    class Program  
    {
        static void Main(string[] args) 
        {
            Console.WriteLine("Hello, world!");
            opearation();
            comparison();
            logical();
        }
        static void opearation() 
        {
            // int sum1=100+500;
            // int sum2=1000+555;
            // int sum3=sum1+sum2;
             int a=10;
             int b=20;
            int subract=a-b;
            int multipilcation=a*b;
            int division=a/b;
            int mod=a%b;
            int increment=a++;
            int decrement=a--;
            


            // Console.WriteLine(sum1);
            // Console.WriteLine(sum2);
            // Console.WriteLine(sum3);
            Console.WriteLine(subract);
            Console.WriteLine(multipilcation);
            Console.WriteLine(division);
            Console.WriteLine(mod);
            Console.WriteLine(increment);
            Console.WriteLine(decrement);
        }

static void comparison()
{
    int x=100;
    int y=100;
    Console.WriteLine(y>x);
    Console.WriteLine(y==x);
    Console.WriteLine(y<x);
    Console.WriteLine(y>=x);
    Console.WriteLine(y<=x);

} 

static void logical(){
   int a=100;
   Console.WriteLine(a>60 && a<200);
}
    }
}