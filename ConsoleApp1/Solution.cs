using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Solution
    {
        public string AddBinary(string a, string b)
        {
            int aIndx = a.Length - 1;
            int bIndx = b.Length - 1;
            char carry = '0';
            StringBuilder result = new StringBuilder();
            while (aIndx >= 0 && bIndx >= 0)
            {
                if (a[aIndx] == b[bIndx])
                {
                    if (carry == '0')
                        result.Insert(0, "0");
                    else
                        result.Insert(0, "1");
                    carry = a[aIndx];
                }
                else
                {
                    if (carry == '0')
                        result.Insert(0, "1");
                    else
                        result.Insert(0, "0");
                }
                aIndx--;
                bIndx--;
            }
            if (aIndx >= 0 && carry == '0')
                result.Insert(0, a.Substring(0, aIndx+1));
            else
            {
                while (aIndx >= 0)
                {
                    if (a[aIndx] == '1' && carry == '1')
                        result.Insert(0, "0");
                    else
                    {
                        result.Insert(0, "1");
                        carry = '0';
                        break;
                    }
                    aIndx--;
                }
                if (aIndx >= 0 && carry == '0')
                    result.Insert(0, a.Substring(0, aIndx));
            }
            if (bIndx >= 0 && carry == '0')
                result.Insert(0, b.Substring(0, bIndx+1));
            else
            {
                while (bIndx >= 0)
                {
                    if (b[bIndx] == '1' && carry == '1')
                        result.Insert(0, "0");
                    else
                    {
                        result.Insert(0, "1");
                        carry = '0';
                        break;
                    }
                    bIndx--;
                }
                if (bIndx >= 0 && carry == '0')
                    result.Insert(0, b.Substring(0, bIndx));
            }
            if (carry == '1')
                result.Insert(0, "1");
            return result.ToString();
        }
    }
}
