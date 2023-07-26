using System;
class Factorial
{
	public static void Main()
	{
		Console.WriteLine("Enter a Number ");
		int number1 = int.Parse(Console.ReadLine());
		int result=1;
		for(int i=1;i<=number1;i++)
		{
			result=result*i;
		}
		Console.Write("Factorial of " +number1+ " is:" +result);
	}
}