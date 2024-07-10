using System;
public class Program {
    static void Main(string [] args){
	int number;
	Console.WriteLine("Enter a Number : ");
	number = int.Parse(Console.ReadLine());
	if(number%2==0){
	    Console.WriteLine("The Number "+number+" is Even");
	}
	else{
	    Console.WriteLine("The Number "+number+" is Odd");
	}
    }
}