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
   Console.WriteLine(a>60 || a<200);
   Console.WriteLine (!(a>60 && a<200));
}
static void Ifelse(){
    int a=10;
    int b=20;
    if(a>b)
    {
        Console.WriteLine(a+"is greater than"+b);
    }

    }



static void Main(string [] args){

Console.WriteLine("added value is : " + add(5,6));
Console.WriteLine("added value is : " + add(5,6,7));
Console.WriteLine("added value is : " + add(5.4,6.1));
Console.WriteLine("Concatenated value is : " + add("Bright","Services"));
demo1();
 constructordemo cd=new constructordemo();
 constructordemo cd1=new constructordemo(10,20);
 cd.demo();


}

static int add(int a, int b){
    return a+b;
}



static int add(int a, int b,int c){
    
    return a+b+c;
}


static double add(double a, double b){
    return a+b;
}


static string add(string a, string b){
    return a+b;
}

 static void demo1(){
        Console.WriteLine("normal Method in main class");

    }




}



class constructordemo{

    public void demo(){
        Console.WriteLine("normal Method in another class");

    }
    public constructordemo(){
        Console.WriteLine("Welcome to Constructor Demo in C#");
    }
    public constructordemo(int a, int b){
        Console.WriteLine("Welcome to Constructor Demo in C# with addition of two values through arguments" + (a+b));
    }
}






// class Program{

// static void Main(string [] args){
//     Console.WriteLine("Welcome to C# class");
//     PrintMsg();
//     Console.WriteLine(PrintMsg1());

// }

// static void PrintMsg(){
//     Console.WriteLine("Welcome to C# method");
// }

// static string PrintMsg1(){
//     return "Welcome to C# string return method ";
// }


// }

}