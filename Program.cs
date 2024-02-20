// See https://aka.ms/new-console-template for more information
using System;


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
