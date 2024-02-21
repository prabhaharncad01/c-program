// class kalingar{

//     public string location;
//     public kalingar()
//     {
//         Console.WriteLine("welcome to kalingar family");

//     }

//     public string partyname(string ppartyname)
//     {
//         return "i have a political party "+ppartyname;
//     }
// }

// class mkstalin: kalingar{
//     public mkstalin(string name){
//         location = "gopalapuram";
//         Console.WriteLine(partyname(name)+ " at  " + location);
//     }
// }
// class mkalagiri: kalingar{
//     public mkalagiri(string name){
//         location="madurai";
//         Console.WriteLine(partyname(name)+ " at " + location);
//     }
// }




// class family{
//     static void Main(string[] args){
//         kalingar kr = new  kalingar();
//             mkstalin stalin = new mkstalin("dmk");
//             mkalagiri alagiri = new mkalagiri("dmk");

//     }
// }


 class Car 
  {
    string color;
    int maxSpeed;
     string companyname;

    static void Main(string[] args)
    {
      Car myObj = new Car();
      myObj.color = "red";
      myObj.maxSpeed = 200;
      myObj.companyname = "maruthi";
      Console.WriteLine("the color of the car is " + myObj.color);
      Console.WriteLine("the maxspeed of the car is " +  myObj.maxSpeed);
      Console.WriteLine("the company name is " + myObj.companyname);
    }
  }