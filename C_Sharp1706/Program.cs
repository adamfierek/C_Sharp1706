using C_Sharp1706.Model;
using System.Timers;
using Timer = System.Timers.Timer;

namespace C_Sharp1706
{
    internal class Program
    {
        static Timer timer;

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            timer = new Timer();
            timer.Interval = 1_000;
            timer.Elapsed += Timer_Elapsed;
            timer.Start();


            var test = new TestModel();
            _ = test.GetAmount();
            var x = test.Level;


            var testX = test as TestModelBase;
            

            test.WriteAction = WriteAmount;
            test.ProcessFunc = AddTwo;

            test.RunAction();
            test.RunFunc();

            test.PropertyChanged += Test_PropertyChanged;
            test.Level = 5;

            Console.Write("Press ENTER to exit");
            Console.ReadLine();
        }

        private static void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            Console.WriteLine("Tick!");
        }

        private static void Test_PropertyChanged(int propName)
        {
            Console.WriteLine($"Event fired: {propName}");
        }

        static public void WriteAmount(int amount)
        {
            Console.WriteLine($"Amount is: {amount}");
        }

        static public double AddTwo(int a)
        {
            return a + 2; 
        }

    }
}