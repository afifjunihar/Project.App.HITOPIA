// See https://aka.ms/new-console-template for more information
using Project.App.HITOPIA.Repository;

Console.WriteLine("HITOPIA Test Problem no 1");
WeightedStrings weightedStrings = new WeightedStrings();
//U can replaced this into string or queries u desired 
string inputString = "abbcccd";
int[] queries = { 1, 3, 9, 8 };
Console.WriteLine(@$"Input ({inputString}, [{string.Join("," , queries)}])");
var results = weightedStrings.CheckQueries(inputString, queries);
Console.WriteLine("Result : " + string.Join(", ", results));

Console.WriteLine("\nHITOPIA Test Problem no 2");
BalancedBraket balancedBraket = new BalancedBraket();
//U can replaced this into string u desired
string inputBracket = "{ ( ( [ ] ) [ ] ) [ ] }";
Console.WriteLine(@$"Input ({inputBracket})");
string resultBalancedBraket = balancedBraket.IsBalanced(inputBracket);
Console.WriteLine("Result : " + resultBalancedBraket);

Console.WriteLine("\nHITOPIA Test Problem no 3");
HighestPolidrome highestPolidrome = new HighestPolidrome();
//U can replaced this into string u desired
string inputPolidrome = "932239";
int k = 2;
Console.WriteLine(@$"Input ({inputPolidrome}, {k})");
string resultPolidrome = highestPolidrome.FindHighestPalindrome(inputPolidrome, k);
Console.WriteLine("Result : " + resultPolidrome);


