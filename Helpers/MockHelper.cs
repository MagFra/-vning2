using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning2.Helpers
{
    public class MockHelper : IHelper
    {
        public int InputInt { private get; set; } = 1;
        public string InputString { private get; set; } = "Kalle";
        public string? WriteString { get; private set; }
        private int counter = 0;
        int IHelper.GetInputInt(string tag)
        {
            if (counter >= 10) { InputInt = 0; } 
            counter++;
            return InputInt;
        }

        string IHelper.GetInputString(string tag)
        {
            return InputString;
        }

        void IHelper.WriteLine(string text)
        {
            WriteString = text;
        }
    }
}
