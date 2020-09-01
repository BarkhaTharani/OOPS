using System;

namespace OOPSConcepts{
    public class Fruit {
        public Fruit () {

        }

        public void cut () {
            System.Console.WriteLine ("Cutting fruit..");
        }

        public int cut (int n) {
            System.Console.WriteLine ("cutting apple in fruit class...");
            return n;
        }
    }

    public class Apple : Fruit {
        public Apple () {

        }

        public void cut (int x, int y) {
            System.Console.WriteLine ("cutting apple in child class...");

        }

    }

    public class MethodOverloading {
        public static void Main () {
            Fruit f = new Apple ();
            f.cut (10);
            f.cut ();
            Apple a = new Apple ();
            a.cut ();
            a.cut (10, 20);
            a.cut (30);
        }
    }
}