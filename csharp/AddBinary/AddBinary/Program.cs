using System;

namespace AddBinary
{
    class Program
    {
        static void Main(string[] args)
        {
            String expect = "110111101100010011000101110110100000011101000101011001000011011000001100011110011010010011000000000";
            String ans = AddBinary("10100000100100110110010000010101111011011001101110111111111101000000101111001110001111100001101", "110101001011101110001111100110001010100001101011101010000011011011001011101111001100000011011110011");


            Console.WriteLine(ans == expect?("correct"):("incorrect\n"+expect));
            Console.WriteLine(ans);
            String expect2 = "10101";
            Console.WriteLine(AddBinary("1010", "1011") == expect2 ? "correct" : "incorrect");

        }

        public static string AddBinary(string a, string b)
        {
            int aPointer = a.Length - 1;
            int bPointer = b.Length - 1;
            String ans = "";
            int remainder = 0;
            //Console.WriteLine("at start: "+aPointer + " , " + bPointer);
            while (aPointer>=0&&bPointer>=0)
            {
                //Console.WriteLine(aPointer + " , " + bPointer);
                int sum = int.Parse(a[aPointer]+"")+ int.Parse(b[bPointer] + "")+ remainder;
                //Console.WriteLine("sum:" + sum);
                if (sum == 0)
                {
                    ans = "0"+ ans ;
                    remainder = 0;
                }
                else if (sum == 1)
                {
                    ans = "1" + ans;
                    remainder = 0;
                }
                else if (sum == 2)
                {
                    ans = "0" + ans;
                    remainder = 1;
                }
                else
                {
                    ans = "1" + ans;
                    remainder = 1;
                }
                aPointer--;
                bPointer--;
            }
            while (aPointer >= 0)
            {
                if (remainder == 1)
                {
                    int aSum = int.Parse(a[aPointer] + "") + remainder;
                    if (aSum == 0)
                    {
                        ans = "0" + ans;
                        remainder = 0;
                    }
                    else if (aSum == 1)
                    {
                        ans = "1" + ans;
                        remainder = 0;
                    }
                    else if (aSum == 2)
                    {
                        ans = "0" + ans;
                        remainder = 1;
                    }
                    else
                    {
                        ans = "1" + ans;
                        remainder = 1;
                    }
                }
                else
                {
                    ans =a.Substring(0,aPointer)+ ans;
                    break;
                }
                aPointer--;

            }

            while (bPointer >= 0)
            {
                if (remainder == 1)
                {
                    int bSum = int.Parse(a[aPointer] + "") + remainder;
                    if (bSum == 0)
                    {
                        ans = "0" + ans;
                        remainder = 0;
                    }
                    else if (bSum == 1)
                    {
                        ans = "1" + ans;
                        remainder = 0;
                    }
                    else if (bSum == 2)
                    {
                        ans = "0" + ans;
                        remainder = 1;
                    }
                    else
                    {
                        ans = "1" + ans;
                        remainder = 1;
                    }
                }
                else
                {
                    ans = b.Substring(0, bPointer) + ans;
                    break;
                }
                bPointer--;
            }

            if (remainder == 1)
            {
                ans = "1" + ans;
            }
            //Console.WriteLine(ans);
            //Console.WriteLine("a" + aPointer);
            //Console.WriteLine("b" + bPointer);

            return ans;
        }

        public static string bit(int num)
        {
            if (num == 0)
            {
                return "0";
            }
            else if (num == 1)
            {
                return "1";
            }
            else if (num == 2)
            {
                return "0";
            }
            else
            {
                return "0";
            }
        }

    }
}








//in java
//StringBuilder res = new StringBuilder();
//int i = a.length() - 1;
//int j = b.length() - 1;
//int carry = 0;
//while (i >= 0 || j >= 0)
//{
//    int sum = carry;
//    if (i >= 0) sum += a.charAt(i--) - '0';
//    if (j >= 0) sum += b.charAt(j--) - '0';
//    carry = sum > 1 ? 1 : 0;
//    res.append(sum % 2);
//}
//if (carry != 0) res.append(carry);
//return res.reverse().toString();