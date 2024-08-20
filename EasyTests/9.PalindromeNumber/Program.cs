namespace LeetCode.Test
{
    public class Solution
    {
        public bool IsPalindrome(int x)
        {
            string stringNumber = Convert.ToString(x);
            char[] arrayString = stringNumber.ToCharArray();
            List<char> reverse = new List<char>();
            for(int i = arrayString.Length - 1; i >= 0; i--)
            {
                reverse.Add(arrayString[i]); 
            } 
            String stringReverse = string.Join("", reverse);
            if(!stringReverse.Equals(stringNumber))
            {
                return false;
            }
            return true;
        }

        public static void Main(string[] args)
        {
            Solution solution = new Solution();
            bool result = solution.IsPalindrome(121);
            Console.WriteLine(result);
        }
    }
}

