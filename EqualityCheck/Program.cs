using System;


namespace EqualityCheck
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CheckEquality(6,6));
        }

        public static bool CheckEquality(object a, object b)
        {
          bool check= a.Equals(b);
          return check;
        }
    }
}
