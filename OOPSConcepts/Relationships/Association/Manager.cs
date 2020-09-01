using System;

namespace OOPSConcepts.Association
{   
    
    public class Manager
    {
        private string name;
        public Manager(string name)
        {
            this.name = name;
        }

       public string Name
       {
           get { return name; }
       }
       

        public void logOn(SwipeCard sc)
        {
            sc.swipe(this);
            Console.WriteLine("Logon the manager");
        }
    }
}