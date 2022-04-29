using TwoWords; //Why it doesn't work?

Console.WriteLine("Please, enter first word.");
var firstWord = Console.ReadLine();
Console.WriteLine("Please, enter second word.");
var secondWord = Console.ReadLine();

Console.WriteLine("Intersection of two words = ");
foreach (var ch in TwoWords.TwoWords.FindIntersection(firstWord, secondWord))
{
    Console.Write(" " + ch);
}

Console.WriteLine("\nYou can" + (TwoWords.TwoWords.CheckForReconstruction(firstWord, secondWord)? "":"'t")
    + " make second word of letters taken from first word.");