using System;

namespace C_PlayGround {

    public class Students {
        public int rollNo;
        public string Name;
        public Students (int rn, string name) {
            rollNo = rn;
            Name = name;
        }
    }

    public class VariableTypes {
        public static int i;
        public const string str = "CONSTANT_STRING";
        public readonly bool test;

        public static readonly int j;

        public static readonly Students s = new Students (111, "abc");

        public VariableTypes (bool val) {
            test = val;
        }

        static VariableTypes () {
            j = 1;
            s = new Students (112, "abcd");
        }

    }

    public class VariableTypes2 {
        static void Main (string[] args) {
            VariableTypes.i = 1;
            VariableTypes varTypes = new VariableTypes (true);
            System.Console.WriteLine (VariableTypes.i + " " + varTypes.test + " " + VariableTypes.str);
            VariableTypes varTypes2 = new VariableTypes (false);
            VariableTypes.i++;
            System.Console.WriteLine (VariableTypes.i + " " + varTypes2.test + " " + VariableTypes.str);
            System.Console.WriteLine (VariableTypes.j);
            //  VariableTypes.s.rollNo = 101;

            System.Console.WriteLine (VariableTypes.s.rollNo + " " + VariableTypes.s.Name);
            VariableTypes.s.rollNo = 102;
            System.Console.WriteLine (VariableTypes.s.rollNo);
        }
    }

}