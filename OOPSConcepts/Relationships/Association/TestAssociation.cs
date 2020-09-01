using System;

namespace OOPSConcepts.Association {
    public class TestAssociation {
        public static void Main (string[] args) {

            // Association - both objects uses one another(in methods) but still they are independent; 
            // ie, we can create objects without any errors
            // they have lifecycle independent of eachther
            Manager mgr = new Manager ("Amit");
            SwipeCard sc = new SwipeCard("MasterCard");
            Console.WriteLine("Mgr name is " + mgr.Name);
            Console.WriteLine("card is " + sc.MadeOfCard);

            mgr.logOn(sc);

        }   
    }
}