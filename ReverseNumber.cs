using System;

public class ReverseNumber
{
    public static void Main(string [] args)
    {
	Console.WriteLine("Enter a number to reverse : ");
	int number = int.Parse(Console.ReadLine());
	
	int copyOfNumber = number;
	int reversedNumber = 0;
	int remainder;
	
	while (number>0)
	{
	    remainder = number % 10;
	    reversedNumber = reversedNumber * 10 + remainder;
	    number = number / 10;
	}
	
	Console.WriteLine("Original Number : " + copyOfNumber);
	Console.WriteLine("Reversed Number : " + reversedNumber);
    }
}