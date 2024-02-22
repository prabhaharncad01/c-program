
namespace inheritancefamily
{
class program
{
    static void Main(string[] args)
    {
        Murugesan mr=new Murugesan();

        Console.WriteLine("hi am murugesan");
        Console.WriteLine("I was working in "+mr.getcompanyname());
        Console.WriteLine("My position was "+mr.getposition());
        Console.WriteLine("My house is in  "+mr.gethouse());

  Prabhaharn mp=new Prabhaharn();
  Console.WriteLine("i can access my father's house at " +mp.gethouse());
  Console.WriteLine("i can't get my father's job at " +mp.getcompanyname());
  Console.WriteLine("But,I can access my  father's house at " +mp.gethouse());


  Banumathi mb=new Banumathi();
   Console.WriteLine("i can access my husbands house at " +mb.gethouse());

    }
}

}


