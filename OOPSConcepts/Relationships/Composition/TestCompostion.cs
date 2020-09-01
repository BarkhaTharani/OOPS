using System;

namespace OOPSConcepts.Composition {
    public class TestComposition {
        public static void Main (string[] args) {

            // Composition - both objects are dependent on one another; 
            // they have lifecycle dependent of eachother
            // one dies, other dies
            
            Manager mgr = new Manager();
            Project proj = new Project(mgr);
            proj.IsSuccess = true;

            mgr.howIstheManager(false);

        }   
    }
}