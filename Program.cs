using Övning2.Helpers;
using System.Text.RegularExpressions;

namespace Övning2
{
    internal class Program
    {
        private static IHelper helper = new Helper();
        // private static IHelper helper = new MockHelper();
        private static MainMenu runner = new MainMenu(helper);
        static void Main(string[] args)
        {
            runner.StartHere();
        }
    }
}