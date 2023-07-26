using System;
class CommandLineArgument
{
	public static void Main(string [] arg )
	{
		int[] arr = new int[arg.Length];

                for (int i = 0; i < arg.Length; i++)
                {
                	arr[i] = int.Parse(arg[i]);
                }
		int count=0;
		int sum=0;
		int min=arr[0];
		int max=arr[0];
		
	        for(int i=0;i<arr.Length;i++)
	        {
			count=count+1;
			sum += arr[i];
			if(min > arr[i])
			{
				min=arr[i];
			}
			else if(max < arr[i])
			{
				max=arr[i];
			}
			
		}
		 float average = (float)sum / count;
		Console.WriteLine("The COUNT number is : "+count);
		Console.WriteLine("The SUM number is : "+sum);
		Console.WriteLine("The AVERAGE number is : "+average);
		Console.WriteLine("The MIN number is : "+min);
		Console.WriteLine("The MAX number is : "+max);
		
			
	}
}