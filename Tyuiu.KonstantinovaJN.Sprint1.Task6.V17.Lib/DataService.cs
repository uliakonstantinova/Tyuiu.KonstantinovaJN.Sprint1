using System.Runtime.InteropServices;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.KonstantinovaJN.Sprint1.Task6.V17.Lib
{
    public class DataService : ISprint1Task6V17
    {
        public bool CheckPalindrome(string value)
        {
            string e = value.Replace(" ", "").ToLower();
            string x = ReverseString(e);
            return e == x;
        }
        private string ReverseString(string value)
        {
            char[] chars = value.ToCharArray();
            Array.Reverse(chars);
            return new string(chars);
        }
    }
}
