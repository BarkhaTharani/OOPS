using System;

namespace OOPSConcepts.Composition
{       
    public class Manager
    {
        public Project project;
        public double salary = 1000;
        public Manager()
        {
            this.project = new Project(this);
        }


       public void howIstheManager (bool good)
       {
           if(good)
           {
               project.IsSuccess = true;
           }
           else 
           {
               project.IsSuccess = false;
           }
       }
       
    }
}