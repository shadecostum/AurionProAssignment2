using System;
class PrimeNumber
{
	public static void Main()
	{
		Console.WriteLine("Enter a number to check Prime or Not");
		int number1 = int.Parse(Console.ReadLine());
		bool flag=false;
		if(number1<2)
		{
			Console.WriteLine("Enter a positive number greater than one");
		}
		
		for(int i=2;i<= Math.Sqrt(number1);i++)
		{
			if(number1 % i==0)
			{
				flag=true;
				break;
			}
		}
		if(flag)
		{
			Console.WriteLine("Not a Prime Number : "+number1);
		}
		else
		{
			
			Console.WriteLine("it's a Prime Number : "+number1);
		}
	}
}