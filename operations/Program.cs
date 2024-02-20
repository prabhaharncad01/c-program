// See https://aka.ms/new-console-template for more information
using System;



    class Program  
    {
//         static void Main(string[] args) 
//         {
//             Console.WriteLine("Hello, world!");
//             opearation();
//             comparison();
//             logical();
//         }
//         static void opearation() 
//         {
//             // int sum1=100+500;
//             // int sum2=1000+555;
//             // int sum3=sum1+sum2;
//              int a=10;
//              int b=20;
//             int subract=a-b;
//             int multipilcation=a*b;
//             int division=a/b;
//             int mod=a%b;
//             int increment=a++;
//             int decrement=a--;
            


//             // Console.WriteLine(sum1);
//             // Console.WriteLine(sum2);
//             // Console.WriteLine(sum3);
//             Console.WriteLine(subract);
//             Console.WriteLine(multipilcation);
//             Console.WriteLine(division);
//             Console.WriteLine(mod);
//             Console.WriteLine(increment);
//             Console.WriteLine(decrement);
//         }

// static void comparison()
// {
//     int x=100;
//     int y=100;
//     Console.WriteLine(y>x);
//     Console.WriteLine(y==x);
//     Console.WriteLine(y<x);
//     Console.WriteLine(y>=x);
//     Console.WriteLine(y<=x);

// } 

// static void logical(){
//    int a=100;
//    Console.WriteLine(a>60 && a<200);
//    Console.WriteLine(a>60 || a<200);
//    Console.WriteLine (!(a>60 && a<200));
// }
// static void Ifelse(){
//     int a=10;
//     int b=20;
//     if(a>b)
//     {
//         Console.WriteLine(a+"is greater than"+b);
//     }

//     }



static void Main(string [] args){

Console.WriteLine("added value is : " + add(5,6));
Console.WriteLine("subracted value is : " + sub(10,6));
Console.WriteLine("multiplied value is : " + mul(25,5));
Console.WriteLine("divided value is : " + div(100,5));
Console.WriteLine("mod value is : " + mod(121,6));
Console.WriteLine("increment value : " + incre(121,6));
Console.WriteLine("decrement value is : " + decre(121,6));
Console.WriteLine("increment value is : " + add(5,6,7));
Console.WriteLine("decrement value is : " + add(5.4,6.1));
Console.WriteLine("decrement value is : " + add(5.4,6.1));
Console.WriteLine("decrement value is : " + add(5.4,6.1));
Console.WriteLine("decrement value is : " + add(5.4,6.1));
Console.WriteLine("decrement value is : " + add(5.4,6.1));
Console.WriteLine("decrement value is : " + add(5.4,6.1));
Console.WriteLine("decrement value is : " + add(5.4,6.1));
Console.WriteLine("decrement value is : " + add(5.4,6.1));
Console.WriteLine("decrement value is : " + add(5.4,6.1));
Console.WriteLine("Concatenated value is : " + add("prabhaharn","software-engineer"));


demo1();
 constructordemo cd=new constructordemo();
 constructordemo cd1=new constructordemo(10,20);
 cd.demo();
ifelsestatement(10,50);

}



static int add(int a, int b){
    return a+b;
}
static int sub(int a, int b){
    return a-b;
}
static int mul(int a, int b){
    return a*b;
}
static int div(int a, int b){
    return a/b;
}
static int mod(int a, int b){
    return a%b;
}
static int incre(int a, int b){
    return a++;
}
static int decre(int a, int b){
    return a--;
}



static int add(int a, int b,int c){
    
    return a+b+c;
}


static double add(double a, double b){
    return a+b;
}

// static double add(double a, double b){
//     return a-b;
// }

// static double add(double a, double b){
//     return a*b;
// }

// static double add(double a, double b){
//     return a/b;
// }

// static double add(double a, double b){
//     return a%b;
// }

// static double add(double a, double b){
//     return a++;
// }


static string add(string a, string b){
    return a+b;
}

 static void demo1(){
        Console.WriteLine("normal Method in main class");

    }

static bool  ifelsestatement(int a,int b){
    if(a>b){
        Console.WriteLine("a is greater than b");
    }

    else
    {
            Console.WriteLine("a is  not greater than b");
    }
    return(a>b);
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

=======
// Console.WriteLine("Hello, World!");

namespace MyApplication
{


class switchstatement
{
   static void Main(string[] args)
   {
    switchstate();
    int day=5;
    switch (day)
    {
        case 1:
        Console.WriteLine("monday");
        break; 
        case 2:
        Console.WriteLine("tueday");
        break; 
        case 3:
        Console.WriteLine("wednesday");
        break; 
        case 4:
        Console.WriteLine("thusday");
        break; 
        case 5:
        Console.WriteLine("friday");
        break; 
        case 6:
        Console.WriteLine("saturday");
        break; 
        case 7:
        Console.WriteLine("sunday");
        break; 
        
    }
   }  

   static void  switchstate(){
    int day =3;
    switch(day)
    {
         case 6:
         Console.WriteLine("today is saturday");
         break;
         case 7:
         Console.WriteLine("today is sunday");
         break;
         default:
         Console.WriteLine("looking forward to the weekend");
         break;
    }
   }  
}
}

