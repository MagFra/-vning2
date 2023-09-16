using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Övning2.Helpers
{
    public class MockHelperUI : IHelperUI
    {
        public int InputInt { private get; set; } = 1;
        public string InputString { private get; set; } = "Kalle";
        public string? WriteString { get; private set; }
        private int counter = 0;
        int IHelperUI.GetInputInt(string text, bool cls = false)
        {
            if (counter >= 10) { InputInt = 0; } 
            counter++;
            return InputInt;
        }

        string IHelperUI.GetInputString(string text, bool cls = false)
        {
            return InputString;
        }

        void IHelperUI.WriteLine(string text, bool cls = false)
        {
            WriteString = text;
        }

        public void WaitForUser(string text)
        {
            WriteString = text;
        }

        public void Clear()
        {
            // Do nothing.
        }
    }
}
