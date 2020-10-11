using System;

namespace OOPpmfsm
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var worker = new FactoryWorker();
            worker.Count(4);
            worker.Count(5);

            worker.Count(4.5f);
        }
    }

    public class FactoryWorker
    { 
        public FactoryWorker ()
        {
            //  polyorphis = 2 methods each with a different input type that allow you to do the same thing
            //  shown here, 2 counts; 1 counts ints, other counts floats and adds them to a total
            public void Count (int number)
            {
                // every time count is run add one to Total
                if (Total == null)
                    Total = 0;
                Total = Total + Cconvert.ToSingle (number);
                Console.WriteLine(Total.ToString());
            }

            public void Count ( float number)
            {
                Total = Total + number;
                Console.WriteLine(Total.ToString);
            }

            public void Count ( int num1, float num2, float num3)
            {
                //  code to all all three numbers
                //  add to total
            }
            public float Total( get: set: )

             

        }

    }

}
