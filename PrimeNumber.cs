using System;

public class Prime
{
    public static void Main(string [] args)
    {
	Console.WriteLine("Enter a number to check if it is Prime : ");
	int number = int.Parse(Console.ReadLine());
	
	bool isPrime = true;
	
	
	if(number <= 1)
	{
	    isPrime = false;
	}
	else
	{
	    for(int i=2; i<=(number/2); i++)
	    {
		if(number % i == 0)
		{
		    isPrime = false;
		    break;
		}
	    }
	}
	
	if(isPrime)
	    Console.WriteLine(number + " is a Prime Number.");
	else
	    Console.WriteLine(number + " is not a Prime Number.");
    }
}