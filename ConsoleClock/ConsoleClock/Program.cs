using System;
using System.Threading;

namespace ASCII_Clock
{
    class Program
    {
        static string s;
        static string m;
        static string h;
        static string[] nums = new string[11]
        {
                " 111111111111 \n11111111111111\n11111    11111\n11111    11111\n11111    11111\n11111    11111\n11111    11111\n11111    11111\n11111111111111\n 111111111111 ",
                "111111111     \n111111111     \n     1111     \n     1111     \n     1111     \n     1111     \n     1111     \n     1111     \n11111111111111\n11111111111111",
                "11111111111   \n11111111111111\n         11111\n         11111\n       11111  \n     11111    \n   11111      \n 11111        \n11111111111111\n11111111111111",
                "1111111111111 \n11111111111111\n         11111\n         11111\n   11111111111\n   11111111111\n         11111\n         11111\n11111111111111\n1111111111111 ",
                "11111  11111  \n11111  11111  \n11111  11111  \n11111  11111  \n11111111111111\n11111111111111\n       11111  \n       11111  \n       11111  \n       11111  ",
                " 1111111111111\n11111111111111\n11111         \n11111         \n1111111111111 \n 1111111111111\n         11111\n         11111\n11111111111111\n1111111111111 ",
                " 1111111111111\n11111111111111\n11111         \n11111         \n1111111111111 \n11111111111111\n11111    11111\n11111    11111\n11111111111111\n 111111111111 ",
                "11111111111111\n11111111111111\n11111    11111\n11111    11111\n         11111\n         11111\n         11111\n         11111\n         11111\n         11111",
                " 111111111111 \n11111111111111\n11111    11111\n11111    11111\n11111111111111\n11111111111111\n11111    11111\n11111    11111\n11111111111111\n 111111111111 ",
                " 111111111111 \n11111111111111\n11111    11111\n11111    11111\n11111111111111\n 1111111111111\n         11111\n         11111\n11111111111111\n1111111111111 ",
                "              \n    111111    \n    111111    \n    111111    \n              \n              \n    111111    \n    111111    \n    111111    \n              "

        };

        static void Main(string[] args)
        {
            while (true)
            {
                if (s != DateTime.Now.ToString("ss"))
                    TimeFunc();
            }
        }

        static void TimeFunc()
        {
            h = DateTime.Now.ToString("HH");
            m = DateTime.Now.ToString("mm");
            s = DateTime.Now.ToString("ss");

            Console.Clear();
            for (int i = 0; i < 10; i++)
            {
                Console.Write(nums[int.Parse(h[0].ToString())].Split("\n")[i].Replace("1", h[0].ToString()));
                Console.Write(" ");
                Console.Write(nums[int.Parse(h[1].ToString())].Split("\n")[i].Replace("1", h[1].ToString()));
                Console.Write(" ");
                Console.Write(nums[10].Split("\n")[i].Replace("1", ":"));
                Console.Write(" ");
                Console.Write(nums[int.Parse(m[0].ToString())].Split("\n")[i].Replace("1", m[0].ToString()));
                Console.Write(" ");
                Console.Write(nums[int.Parse(m[1].ToString())].Split("\n")[i].Replace("1", m[1].ToString()));
                Console.Write(" ");
                Console.Write(nums[10].Split("\n")[i].Replace("1", ":"));
                Console.Write(" ");
                Console.Write(nums[int.Parse(s[0].ToString())].Split("\n")[i].Replace("1", s[0].ToString()));
                Console.Write(" ");
                Console.Write(nums[int.Parse(s[1].ToString())].Split("\n")[i].Replace("1", s[1].ToString()));
                Console.WriteLine();
            }
        }
    }
}