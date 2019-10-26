namespace CSharp_Practice
{
    public class lcValidPerfectSquare
    {
        public bool IsPerfectSquare(int num) {
        for (int i = 1; i <= (num+1)/2; i++)
        {
            if (i * i == num)
            {
                return true;
            }
        }
        return false;
    }
    }
}