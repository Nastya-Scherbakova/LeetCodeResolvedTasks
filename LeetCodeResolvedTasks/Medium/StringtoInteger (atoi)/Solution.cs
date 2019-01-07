using System;

namespace LeetCodeResolvedTasks.Medium.StringtoInteger__atoi_
{
    public class Solution
    {
        public int MyAtoi(string str)
        {
            string result = "";
            bool isNegative = false;
            if ((str.Length > 0 && str[0] != ' ' && str[0] != '+' && str[0] != '-' && !Char.IsDigit(str[0])) ||
              str.Length == 0 || (str.Length > 1 && (str[0] == '+' || str[0] == '-') && !Char.IsDigit(str[1])))
            {
                return 0;
            }
            foreach (char byteR in str)
            {
                if (Char.IsDigit(byteR))
                {
                    result += byteR;
                }
                else if (result.Length > 0 && !Char.IsDigit(byteR))
                {
                    break;
                }
                else if (byteR == '-')
                {
                    if (str.IndexOf(byteR) + 1 < str.Length && Char.IsDigit(str[str.IndexOf(byteR) + 1]))
                        isNegative = true;
                    else return 0;
                }
                else if (byteR == '+')
                {
                    if (str.IndexOf(byteR) + 1 < str.Length && !Char.IsDigit(str[str.IndexOf(byteR) + 1]))
                        return 0;
                }
                else if (result.Length == 0 && !Char.IsDigit(byteR) && byteR != ' ' && byteR != '+' && byteR != '-')
                {
                    return 0;
                }

            }
            try
            {

                var resInt = result.Length > 0 ? checked(int.Parse(result)) : 0;
                return isNegative ? resInt * -1 : resInt;
            }
            catch (Exception)
            {
                return isNegative ? int.MinValue : int.MaxValue;
            }

        }
    }
}
