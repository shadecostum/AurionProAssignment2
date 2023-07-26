using System;
class LoopTest
{
	public static void Main()
	{
		string name = "Akash Santhosh";
        	int count = 5;

                Console.WriteLine("Using for loop:");
                for (int i = 0; i < count; i++)
                {
                Console.WriteLine(name);
                }

                Console.WriteLine("Using while loop:");
                int j = 0;
                while (j < count)
                {
                 	Console.WriteLine(name);
                	j++;
                }
	}
}
