namespace C_PlayGround {
    public class Pen {
        public void write () {
            System.Console.WriteLine ("writing with pen..");
        }
    }

    public class BallPen : Pen {
        public new void write () {
            System.Console.WriteLine ("writing with ball pen..");
        }

    }

    public class MethodHiding {
        public static void Main () {
            BallPen bp = new BallPen ();
            bp.write ();

            Pen p = new Pen ();
            p.write ();

            Pen pp = new BallPen ();
            pp.write ();

        }
    }
}