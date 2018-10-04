using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch10_P10_AnonymousMethods
{
    class Program
    {
        private int aPrivateMemberOfClass;

        public static int numbers;
        static void Main(string[] args)
        {
            Console.WriteLine("***** Anonymous Methods *****\n");
            #region event handling without using anonymous methods


            //SomeType t = new SomeType();
            //// Assume "SomeDelegate" can point to methods taking no args and returning void.
            //t.SomeEvent += new SomeType.MyDelegate(MyEventHandler);

            //t.SomeEvent += MyEventHandler; // method group conversion syntax

            #endregion
            #region Car events handling using anonymous methods
            Car c1 = new Car("SlugBug", 100, 10);
            int localvar;

            c1.AboutToBlow += delegate
            {
                int aPrivateMemberOfClass = 3;

                Console.WriteLine(" Eek! going too fast ");
            };

            //localvar = 3;

            int number = 2;

            c1.AboutToBlow += delegate (object sender, CarEventArgs e)
            {
                //int number = 3;
                Console.WriteLine(" Message from car: {0} " , e.msg);
            };

            c1.Exploded += delegate ( object sender , CarEventArgs e )
            {
                Console.WriteLine(" fatal message from car:  {0} " , e.msg );
            };

            // This will eventually trigger the events.
            for (int i = 0; i < 6; i++)
                c1.Accelerate(20);

            #endregion

            Console.ReadLine();
        }
        
        // Typically only called by the SomeDelegate object.
        public static void MyEventHandler()
        {
            // Do something when event is fired.
        }
    }
}
