using System;

namespace C_PlayGround {
    class Pizza {

        virtual public Object CreateCrust () {
            Console.WriteLine ("Creating Crust");
            return null;
        }

    }

    class VegPizza : Pizza {

        override public object CreateCrust () {
            Console.WriteLine ("Creating veg pizza Crust");
            return null;
        }
        public void CreateDough () {
            Console.WriteLine ("Creating veg pizza Dough");
        }

    }
    class OverRidingSample {
        static void Main (string[] args) {
            Pizza P = new Pizza ();
            P.CreateCrust ();

            VegPizza VP = new VegPizza ();
            VP.CreateCrust ();

            Pizza P1 = new VegPizza ();
            P1.CreateCrust (); // drawback: can't call  CreateDough of derived class with reference variable of base class.

        }
    }
}