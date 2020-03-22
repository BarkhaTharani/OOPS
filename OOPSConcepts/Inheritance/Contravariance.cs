using System;

namespace C_PlayGround {
    public class Flower {
        public Flower () {

        }

        public virtual void smell () {
            System.Console.WriteLine ("flower smells..");
        }

    }

    public class Rose : Flower {
        public Rose () {

        }

        public override void smell () {
            System.Console.WriteLine ("Rose smells...");

        }

    }

    public class ContraVariance {
        public void testComplexContaVariance (Flower flower) {
            System.Console.WriteLine ("Testing ContraVariance " + flower.ToString ());
        }
         public void testBuiltInContaVariance (object obj) {
            System.Console.WriteLine ("Testing ContraVariance " + obj.ToString ());
        }
         public static void Main () {
            ContraVariance cv = new ContraVariance ();
            cv.testComplexContaVariance (new Rose ());
            cv.testBuiltInContaVariance(new string("abcd"));           
        }
    }
}