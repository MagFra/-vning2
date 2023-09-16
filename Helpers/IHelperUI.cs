namespace Övning2.Helpers
{
    public interface IHelperUI
    {
        int GetInputInt(string text, bool cls = false);
        string GetInputString(string text, bool cls = false);
        void WriteLine(string text, bool cls = false);
        void WaitForUser(string text);
        void Clear();
    }
}