using Övning2.Helpers;
using System.Text.RegularExpressions;

namespace Övning2
{
    internal class Program
    {
        internal static IHelperUI? Helper { get; private set; }
        private static MainMenu? runner = null;

        static void Main(string[] args)
        {
            Helper = new HelperUI(); 
            // Helper = new MockHelperUI();

            runner = new();
            runner.StartHere();
        }
    }
}