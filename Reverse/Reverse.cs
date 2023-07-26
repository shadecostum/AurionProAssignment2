using System;
class PrimeNumber
{
	public static void Main()
	{
		Console.WriteLine("Enter a Positive number to REVERSE ");
		int number1 = int.Parse(Console.ReadLine());
		int result=0;
		int modNumber;
		if(number1<0)
		{
			Console.WriteLine("Enter a Positive Number");
		}
		while(number1>0)
		{
			modNumber=number1%10;
			result=result*10+modNumber;
			number1=number1/10;
			
		}
		Console.WriteLine("The REVERSE number is : "+result);
		
	}
}