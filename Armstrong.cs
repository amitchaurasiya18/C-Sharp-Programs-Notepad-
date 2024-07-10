using System;

public class Armstrong
{
    public static void Main(string [] args)
    {
        Console.WriteLine("Enter a number to check if it is an Armstrong Number :");
	int number = int.Parse(Console.ReadLine());
	
	int sum=0;
	int copyOfNumber = number;
	int digit;
	
	while(number>0)
	{
	    digit = number % 10;
	    sum = sum + (int)Math.Pow(digit,3);
	    number = number / 10;
	}

	if (sum == copyOfNumber)
	    Console.WriteLine(copyOfNumber +" is an Armstrong Number");
	else
	    Console.WriteLine(copyOfNumber +" is not an Armstrong Number");
    }
}