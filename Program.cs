using Övning2.Helpers;
using System.Text.RegularExpressions;

namespace Övning2
{
    internal class Program
    {
        internal static IHelperUI Helper = new HelperUI();
        // internal static IHelperUI Helper = new MockHelperUI();
        private static MainMenu runner = new();
        static void Main(string[] args)
        {
            runner.StartHere();
        }
    }
}