using System;

namespace VariableInterpolation
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Bob";
            int age = 41;
            string name2 = "Doug";
            int age2 = 56;

            int olderAge = age2 - age;

            // Shows syntax for interpolation
            string msg_interpolated = $"{name} is {age} years old.";
            // Shows syntax for non-interpolated strings
            string msg_normalFormat = string.Format("{0} is {1} years old.", name2, age2);

            string msg_olderInterpolated = $"{name2} is {olderAge} years older than {name}";

            Console.WriteLine(msg_interpolated);
            Console.WriteLine(msg_normalFormat);
            Console.WriteLine(msg_olderInterpolated);
        }
    }
}