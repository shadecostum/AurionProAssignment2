using System;
class ArrayTest
{
	public static void Main(string[] args)
	{
		string[] names = { "Akash", "24", "male", "Kerala" };

            Console.WriteLine("Using for loop:");
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine("  "+names[i]);
            }

            Console.WriteLine("Using foreach loop:");
            int j = 0;
            foreach (string name in names)
            {
                Console.WriteLine("  "+names[j]);
                j++;
            }
	}
}