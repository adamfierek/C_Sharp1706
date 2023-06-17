using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp1706.Model
{
    internal class TestModel
    {
        public int Amount;
        private int level;

        public delegate void OnPropertyChanged(int propName);
        public event OnPropertyChanged PropertyChanged;


        public int GetAmount()
        {
            return Amount;
        }

        public void RunAction()
        {
            WriteAction(1104);
        }

        public void RunFunc()
        {
            var result = ProcessFunc(10);
            Console.WriteLine(result);
        }

        public int Level
        {
            get
            {
                return level;
            }
            set
            {
                level = value;
                PropertyChanged?.Invoke(Level);
            }
        }

        public Action<int> WriteAction { get; internal set; }
        public Func<int, double> ProcessFunc { get; internal set; }
    }
}
