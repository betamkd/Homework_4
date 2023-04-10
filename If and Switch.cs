// Vezba 1
using System.Diagnostics;
using System.Reflection.Metadata;
using System.Threading.Tasks.Sources;

Console.WriteLine("Enter the first number:");
int a = int.Parse(Console.ReadLine());

Console.WriteLine("Enter the second number:");
int b = int.Parse(Console.ReadLine());


Console.WriteLine("Enter the third number:");
int c = int.Parse(Console.ReadLine());

Console.WriteLine("***************************************************\n");
if (a > b && a > c)
	Console.WriteLine($"The highest number is: {a}");

else if (b > a && b > c)
	Console.WriteLine($"The highest number is: {b}");

else if (c > a && c > b)
	Console.WriteLine($"The highest number is: {c}");

// Vezba 2
Console.WriteLine("***************************************************\n");
Console.WriteLine("Enter a character:");

string symbol = Console.ReadLine();

switch (symbol)
{
	case "a":
	case "e":
	case "i":
	case "o": 
	case "u":
		Console.WriteLine("The character is a vowel");
		break;

	case "b":
	case "c":
	case "d":
	case "f":
	case "g":
	case "h":
	case "j":
	case "k":
	case "l":
	case "m":
	case "n":
	case "p":
	case "q":
	case "r":
	case "s":
	case "t":
	case "v":
	case "w":
	case "x":
	case "y":
	case "z":
		Console.WriteLine("The character is a consonant.");
		break;

	default:
		Console.WriteLine("The character is not a vowel or a consonant.");
		break;
}


// Vezba 3

Console.WriteLine("***************************************************\n");
Console.WriteLine("Enter the student's grade (A-F): ");

String grade = Console.ReadLine();


double score;
switch (grade)
{
	case "A": Console.WriteLine("5.0"); break;
	case "B": Console.WriteLine("4.0"); break;
	case "C": Console.WriteLine("3.0"); break;
	case "D": Console.WriteLine("2.0"); break;
	case "F": Console.WriteLine("1.0"); break;
	
	default:
		Console.WriteLine("Invalid grade.");
		break;

}
