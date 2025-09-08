// See https://aka.ms/new-console-template for more information
Console.WriteLine("Welcome to our Budget Tracker!");

double groceryBudget = 200.00;
double entertainmentBudget = 250.00;

Console.WriteLine($"Grocery budget: {groceryBudget}");
Console.WriteLine($"Entertainment budget: {entertainmentBudget}");

List<double> fixedExpenses = new List<double> { 1200.00, 150.00, 50.00 };
// double[] fixedExpenses = { 1200.00, 150.00, 50.00 };
Console.WriteLine("Fixed expenses: ");
Console.WriteLine("Rent: " + fixedExpenses[0]);
Console.WriteLine("Electricity: " + fixedExpenses[1]);
Console.WriteLine("Water: " + fixedExpenses[2]);

fixedExpenses.Add(35);
fixedExpenses.Add(9.99);
Console.WriteLine("Internet: " + fixedExpenses[3]);
Console.WriteLine("Spotify: " + fixedExpenses[4]);

double grocerySpent = 350.00;
double entertainmentSpent = 100.00;

if (grocerySpent > groceryBudget)
{
    Console.WriteLine("You are over budget on groceries!");
}
else
{
    Console.WriteLine("You are within budget for groceries");
}

if (entertainmentSpent > entertainmentBudget)
{
    Console.WriteLine("You are over budget on entertainment!");
}
else
{
    Console.WriteLine("You are within budget for entertainment");
}

double remainingGroceryBudget = groceryBudget - grocerySpent;
double remainingEntertainmentBudget = entertainmentBudget - entertainmentSpent;

Console.WriteLine($"Remaining grocery budget: {remainingGroceryBudget}");
Console.WriteLine($"Remaining entertainment budget: {remainingEntertainmentBudget}");

if (grocerySpent <= groceryBudget && entertainmentSpent <= entertainmentBudget)
{
    Console.WriteLine("You are within budget");
}
else if (grocerySpent <= groceryBudget || entertainmentSpent <= entertainmentBudget)
{
    Console.WriteLine("You are in budget for one of your spending limits");
}
else
{
    Console.WriteLine("You are over budget for all your expenses!");
}