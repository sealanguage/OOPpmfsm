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
            //Console.WriteLine("Hey big brother!");
        }
    }

    public class FactoryWorker
    { 
        public FactoryWorker ()
        {
            public void Count (int number)
            {
                // every time count is run add one to Total
                if (Total == null)
                    Total = 0;
                Total = Total + number;
                Console.WriteLine(Total.ToString());
            }
            public int Total( get: set: )

             

        }

    }

}
