namespace brightinheritance
{

    class Bright
    {
        string morningshift,noonshift,nightshift,service1,service2,service3,room1,room2,furniture1,furniture2,staff1,staff2,
        location;
        public  Bright()
        {
             morningshift = "aibatch01";
             noonshift = "cadbatch01";
             nightshift = "callcenter";
             service1 = "internetservice";
             service2 = "callcentre";
            service3 = "softskilltraining";
             room1 = "lab";
             room2 = "classroom";
             furniture1 = "chairs";
             furniture2 = "tables";
             staff1 = "trainer";
             staff2 = "hr";
             location = "trichy";
       
        }
              
        public string getMorningshift()
        {
            return morningshift;
        }
        public string  getNoonshift()
        {
            return noonshift;
        }
        public string  getNightshift()
        {
            return nightshift;
        }
        public string  getService1()
        {
            return service1;
        }
        public string getService2()
        {
            return service2;
        }
        public string getService3()
        {
            return service3;
        }
        public string  getRoom1()
        {
            return room1;
        }
        public string getRoom2()
        {
            return room2;
        }
        public string getFurniture1()
        {
            return furniture1;
        }
        public string getFurniture2()
        {
            return furniture2;
        }
        public string getStaff1()
        {
            return staff1;
        }
        public string getStaff2()
        {
            return staff2;
        }
           public string getLocation()
        {
            return location;
        }


    }
     
    }
