using System;
class Fibonacci
{
	public static void Main()
	{
		int number1=8;
		int number2=0;
		int number3=1;
	for (int i=0;i<number1;i++)
	{
    		Console.Write(number2 + " ");
    		int temp=number2;
    		number2=number3;
    		number3=temp+number3;
}

	}
}