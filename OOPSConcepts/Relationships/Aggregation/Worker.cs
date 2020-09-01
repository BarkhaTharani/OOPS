using System;

namespace OOPSConcepts.Aggregation
{       
    public class Worker
    {
        private string name;
        public Worker(string name)
        {
            this.name = name;
        }

       public string Name
       {
           get { return name; }
       }
       
    }
}