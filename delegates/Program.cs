using System;
using System.Threading;


namespace learning.Delegates
{
    // public delegate int ThisDelegate(int a); //declaire a delegate
    // public delegate int Transformer(int x); //declaire a delagate
    public delegate void ProgressReporter(int PercentComplete);


    public class Program
    {
        static void Main(string[] args)
        {
            //learning delegates

            //create an instance of a delegate
            // ThisDelegate one = Method1; //shorthand
            // ThisDelegate two = new ThisDelegate(Method1);
            //invoke an instance of a delegate
            // int t = one(10); //shorthand
            // int w = one.Invoke(20);
            // Console.WriteLine(w);
            /*
             int[] values = {3,5,7,2};
             Transform(values, Squire);
             Transform(values, Cube); */

             ProgressReporter t = WriteProgressToConsole;
             t += WriteProgressToConsoleAgain;
            Utils.HardWork(t);
            
        }


        //creates our static methods
        // public static int Method1(int one){ return one * 2; }
        // public static int Method2(int ops) => ops * 2;
        // public static int Method3(int one){ return one * 2; }

        public static int Squire(int a){ return a * a; }
        public static int Cube(int x){ return x * x * x; }

        public static void WriteProgressToConsole(int percentcomplete)
        {
            Console.WriteLine(percentcomplete);
        }

        public static void WriteProgressToConsoleAgain(int percentcomplete) => Console.WriteLine($"Again:  {percentcomplete}");

        /*
        public static void Transform(int[] values, Transformer t)
        {
            for(int i = 0; i < values.Length; i++)
            {
                values[i] = t(values[i]);
            }
        } */
    }

    public class Utils
    {
        public static void HardWork(ProgressReporter t )
        {
            for(int i = 0; i < 10; i++)
            {
                t(i * 12); //invoking a delagate
                Thread.Sleep(100);
            }
        }
    }
}