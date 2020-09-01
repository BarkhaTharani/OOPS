using System;

namespace OOPSConcepts {

    public class Properties {
        private int property;

        public int Property { get => property; set => property = value; }
    }

    public class EncapsulationDemo {
        public static void Main () {
            Properties prop = new Properties ();
            prop.Property = 1;
            //prop.property = 2; in accessible / can only be accessed through getters ie property ;
            System.Console.WriteLine (prop.Property);
        }
    }
}