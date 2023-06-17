using C_Sharp1706.Model;

namespace C_Sharp1706
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            var test = new TestModel();
            _ = test.GetAmount();
            var x = test.Level;



            test.WriteAction = WriteAmount;
            test.ProcessFunc = AddTwo;

            test.RunAction();
            test.RunFunc();

            test.PropertyChanged += Test_PropertyChanged;
            test.Level = 5;
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