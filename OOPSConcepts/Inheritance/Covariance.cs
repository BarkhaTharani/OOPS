using System;

namespace C_PlayGround {
    public class Animal {
        public Animal () {

        }
        public virtual void walk () {
            System.Console.WriteLine ("Animal walks..");
        }
    }

    public class Dog : Animal {
        public Dog () {

        }
        public override void walk () {
            System.Console.WriteLine ("Dog walks...");

        }
    }

    public class Covariance {
        public Animal testCovarianceComplex () {
            System.Console.WriteLine ("Testing Covraiance");
            return new Dog ();
        }
        public object testCovarianceBuiltIn () {
            System.Console.WriteLine ("Testing Covariance ");
            return new String ("str");
        }
        public static void Main () {
            Dog d = new Dog ();
            d.walk ();

            Animal A = new Animal ();
            A.walk ();

            Animal animal = new Dog ();
            animal.walk ();

            Covariance cv = new Covariance ();
            var dog = cv.testCovarianceComplex ();
            System.Console.WriteLine (dog.ToString ());
            dog.walk ();
            var cvTest = cv.testCovarianceBuiltIn ();
            System.Console.WriteLine (cvTest);
        }
    }
}