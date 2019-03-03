/// <summary>
/// Problem Statement :  reverse string 
/// Examples : 
/// reverse => esrever
/// hello => olleh
/// </summary>


using System;
using System.Diagnostics;
using System.Linq;

namespace AlgonDS
{
    public class ReverseString
    {
        public string ReverseMe(string toBeReversed)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            if (string.IsNullOrEmpty(toBeReversed)) return toBeReversed;

            string reversed = new string(toBeReversed.Reverse().ToArray());

            sw.Stop();
            Console.WriteLine(sw.ElapsedMilliseconds);

            return reversed;
        }

        public  string ReverseMeOption1(string toBeReversed)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            if (string.IsNullOrEmpty(toBeReversed)) return toBeReversed;

            string reversed = string.Empty;

            for (int i = toBeReversed.Length - 1; i >= 0; i--)
            {
                reversed += toBeReversed[i];
            }

            sw.Stop();
            Console.WriteLine(sw.ElapsedMilliseconds);

            return reversed;
        }

        public  string ReverseMeOption2(string toBeReversed)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            if (string.IsNullOrEmpty(toBeReversed)) return toBeReversed;

            string reversed = string.Empty;

            // this was posted by petebob as well 
            char[] array = toBeReversed.ToCharArray();
            Array.Reverse(array);
            reversed = new String(array);

            sw.Stop();
            Console.WriteLine(sw.ElapsedMilliseconds);

            return reversed;
        }

        public string ReverseMeOption3(string toBeReversed)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            if (string.IsNullOrEmpty(toBeReversed)) return toBeReversed;

            string reversed = string.Empty;

            foreach (var c in toBeReversed)
            {
                reversed = c + reversed;
            }

            sw.Stop();
            Console.WriteLine(sw.ElapsedMilliseconds);

            return reversed;
        }

    }
}
