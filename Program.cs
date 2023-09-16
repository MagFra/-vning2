using Övning2.Helpers;
using System.Text.RegularExpressions;

namespace Övning2
{
    internal class Program
    {
        private static IHelperUI helper = new HelperUI();
        // private static IHelperUI helper = new MockHelperUI();
        private static MainMenu runner = new MainMenu(helper);
        static void Main(string[] args)
        {
            runner.StartHere();
        }
    }
}