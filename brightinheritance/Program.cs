namespace brightinheritance
{
    class program
    {
        static void Main(string[] args)
        {
             Bright br = new Bright();
             Console.WriteLine("hi we are bright services");
             Console.WriteLine("hi we are bright services and we are located at " + br.getLocation());
             Console.WriteLine("Our morning batch name is  " + br.getMorningshift());
             Console.WriteLine("Our afternoon batch name is  " + br.getNoonshift());
             Console.WriteLine("Our Nightshift service name is  " + br.getNightshift());
             Console.WriteLine("we do services like  " + br.getService1());
             Console.WriteLine("we do services like  " + br.getService2());
             Console.WriteLine("we do services like  " + br.getService3());
             Console.WriteLine("we provide infrastructure like " + br.getRoom1());
             Console.WriteLine("we provide infrastructure like " + br.getRoom2());
             Console.WriteLine("we provide good design furnitures like  " + br.getFurniture1());
             Console.WriteLine("and also we provide good design furnitures like  " + br.getFurniture2());
             Console.WriteLine("we have well experienced staffs consisting of  " + br.getStaff1());
             Console.WriteLine("and motivating and intiative  " + br.getStaff2());

            Console.WriteLine("===============================================================================");
            Console.WriteLine("===============================================================================");
             
             Cadbatch01 cad01 = new Cadbatch01();
             Console.WriteLine("we are cadbatch students and we daily rush to class which is located at "+ cad01.getLocation());
             Console.WriteLine("we can access " + cad01.getService1());
             Console.WriteLine("and we can also access " + cad01.getService3());
             Console.WriteLine(" we can  access " + cad01.getRoom1());
             Console.WriteLine(" And we can also access " + cad01.getRoom2());
             Console.WriteLine("But we cant access class after 6.00 o clock cause of  " + cad01.getService2());
             Console.WriteLine("we can use furnitures like  " + cad01.getFurniture1());
             Console.WriteLine("we can also use furnitures like   " + cad01.getFurniture2());
             Console.WriteLine("At the starting we had  " + cad01.getCadsubject1() + "classes");
             Console.WriteLine("And then we started studying  " + cad01.getCadsubject2() + "classes");
             Console.WriteLine("we had programming language like  " + cad01.getCadsubject3() + "classes");
             Console.WriteLine("we also use " + cad01.getCadai1() + "for hosting our projects");
             Console.WriteLine("And we intiated by installing  " + cad01.getCadsubject5() + "for doing some projects with good finsh");
             Console.WriteLine("we planned to access " + cad01.getCadai2() + "for storing datas by connecting it with "+ cad01.getCadsubject7());


              Console.WriteLine("===============================================================================");
            Console.WriteLine("===============================================================================");

             Aibatch01 ai= new Aibatch01();

             Console.WriteLine("we are aibatch students and we daily rush to class which is located at "+ ai.getLocation());
             Console.WriteLine("we can access " + ai.getService1());
             Console.WriteLine("and we can also access " + ai.getService3());
             Console.WriteLine(" we can  access " + ai.getRoom1());
             Console.WriteLine(" And we can also access " + ai.getRoom2());
             Console.WriteLine("But we cant access class after 2.00 o clock cause of  " + ai.getNoonshift());
             Console.WriteLine("  we can also use furnitures like  " + ai.getFurniture1());
             Console.WriteLine("And we can also use furnitures like   " + ai.getFurniture2());

        }
    }
}