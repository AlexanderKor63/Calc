using System;
using System.Linq;

namespace KAICalc
{
    public class Calc
    {
        public int Sum(string s)
        {
            int res = -1;

            if (s == String.Empty) res = 0;
            else if (!s.Contains('-'))
            {
                try
                {
                    string[] nums = s.Split(',');

                    if (nums.Length > 2) res = -1;
                    else res = nums.Sum((x) => int.Parse(x));
                }
                catch (Exception ex) { res = -1; }
            }
            return res;
        }

    }
}
