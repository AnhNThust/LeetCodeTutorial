// See https://aka.ms/new-console-template for more information
namespace _20_Valid_Parentheses
{
    public class Program
    {
        public static void Main()
        {
            bool isValid = IsValid("{()]}");

            Console.WriteLine(isValid);
        }

        public static bool IsValid(string s)
        {
            if (s.Length % 2 != 0)
                return false;

            Stack<char> chars = new();

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '(')
                {
                    chars.Push(')');
                }
                else if (s[i] == '[')
                {
                    chars.Push(']');
                }
                else if (s[i] == '{')
                {
                    chars.Push('}');
                }
                else if (s[i] == ')' || s[i] == ']' || s[i] == '}')
                {
                    if (chars.Count <= 0)
                        return false;
                    if (chars.Pop() == s[i])
                        continue;

                    return false;
                }
            }

            if (chars.Count > 0)
                return false;

            return true;
        }
    }
}
