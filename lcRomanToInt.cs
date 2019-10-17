using System;

namespace Practice
{
    public class lcRomanToInt
    {
        static int RomanToInt(string s)
        {
            int value = 0;
            char[] arr = s.ToCharArray();
            for (int i = 0; i < arr.Length; i++)
            {
                switch (arr.GetValue(i))
                {
                    case 'M':
                        value += 1000;
                        continue;
                    case 'D':
                        value += 500;
                        continue;
                    case 'C':
                        try
                        {
                            if (arr[i + 1] == 'M')
                            {
                                i++;
                                value += 900;
                                continue;
                            }
                            else if (arr[i + 1] == 'D')
                            {
                                i++;
                                value += 400;
                                continue;
                            }
                            else
                            {
                                value += 100;
                                continue;
                            }
                        }
                        catch (IndexOutOfRangeException)
                        {
                            value += 100;
                            continue;
                        }

                    case 'L':
                        value += 50;
                        continue;

                    case 'X':
                        try
                        {
                            if (arr[i + 1] == 'C')
                            {
                                i++;
                                value += 90;
                                continue;
                            }
                            else if (arr[i + 1] == 'L')
                            {
                                i++;
                                value += 40;
                                continue;
                            }
                            else
                            {
                                value += 10;
                                continue;
                            }
                        }
                        catch (IndexOutOfRangeException)
                        {
                            value += 10;
                            continue;
                        }

                    case 'V':
                        value += 5;
                        continue; ;
                    case 'I':
                        try
                        {
                            if (arr[i + 1] == 'X')
                            {
                                i++;
                                value += 9;
                                continue;
                            }
                            else if (arr[i + 1] == 'V')
                            {
                                i++;
                                value += 4;
                                continue;
                            }
                            else
                            {
                                value += 1;
                                continue;
                            }
                        }
                        catch (IndexOutOfRangeException)
                        {
                            value += 1;
                            continue;
                        }

                }
            }
            return value;
        }
    }
}