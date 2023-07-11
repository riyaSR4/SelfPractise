using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace SelfPractise
{
    public class Palindrome
    {
        public void CheckPalindrome()
        {
            int temp, r, sum=0;
            Console.WriteLine("Enter the number :");
            int n = Convert.ToInt32(Console.ReadLine());
            temp = n;
            while (n > 0)
            {
                r = n % 10;
                sum = (sum * 10) + r;
                n = n / 10;
            }
            if (temp == sum)
                Console.WriteLine("Palindrome Number");
            else
                Console.WriteLine("Not a palindrome Number");
        }
    }
}
