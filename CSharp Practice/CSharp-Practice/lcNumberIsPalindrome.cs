namespace Practice
{
    public class lcNumberIsPalindrome
    {
         public bool IsPalindrome(int x)
        {
            if (x < 0)
            {
                return false;
            }
            int rev = 0;
            int originalNum = x;
            while (originalNum > 0)
            {
                rev = (rev * 10) + (originalNum % 10);
                originalNum /= 10;
            }

            if (x == rev)
            {
                return true;
            }
            return false;
        }
    }
}