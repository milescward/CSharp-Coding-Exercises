namespace CSharp_Practice
{
    public class PlusOne
    {
        public int[] PlusOneDigit(int[] digits) {
        int count = 0;

        for (int i = 0; i < digits.Length; i++)
        {
            if (digits[i] == 9)
            {
                count++;
                continue;
            }
            break;
        }

        if (count == digits.Length && digits[0] == 9)
        {
            int[] arr = new int[digits.Length + 1];
            arr[0] = 1;
            return arr;
        }

        for (int i = digits.Length - 1; i >= 0; i--)
        {
            if (digits[i] == 9)
            {
                digits[i] = 0;
                continue;
            }
            digits[i]++;
            break;
        }
        return digits;
    }
    }
}