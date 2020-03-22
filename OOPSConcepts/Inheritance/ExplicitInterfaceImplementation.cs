using System;

namespace C_PlayGround {
    interface IBird {
        static int p;
        const int q = 1;
        void sing ();

        void Fly () {

            System.Console.WriteLine ("Bird flying " + p + " " + q);
        }
        public static void staticFly () {
            p = 1;
            System.Console.WriteLine ("Static Bird flying " + p);
        }

    }

    interface IBird2 {
        void sing ();
         void Fly () {

            System.Console.WriteLine ("Bird flying in bird 2");
        }
    }
    public class Sparrow : IBird, IBird2 {
        public Sparrow () {

        }
        public void sing () {
            System.Console.WriteLine("sing sing");
        }
        // public void Fly () {
        //     Console.WriteLine ("flying");
        // }

        public static void staticFly () {
            System.Console.WriteLine ("sparrow static  flying.");
        }

    }

    public class ExplicitInterfaceImplementation {
        public static void Main () {
            IBird sparrow = new Sparrow ();
            sparrow.Fly ();
            Sparrow s = new Sparrow();
            s.sing();           
            IBird.staticFly ();
            IBird.p = 1;
            Console.WriteLine (IBird.p);
            Sparrow.staticFly ();

            // Sparrow s = new Sparrow();
            // s.Fly();
        }
    }
}