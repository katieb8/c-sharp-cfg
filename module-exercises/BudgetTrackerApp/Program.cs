// See https://aka.ms/new-console-template for more information
Console.WriteLine("Welcome to our Budget Tracker!");

double groceryBudget = 200.00;
double entertainmentBudget = 250.00;

Console.WriteLine($"Grocery budget: {groceryBudget}");
Console.WriteLine($"Entertainment budget: {entertainmentBudget}");

double[] fixedExpenses = { 1200.00, 150.00, 50.00 };
Console.WriteLine("Fixed expenses: ");
Console.WriteLine("Rent: " + fixedExpenses[0]);
Console.WriteLine("Electricity: " + fixedExpenses[1]);
Console.WriteLine("Water: " + fixedExpenses[2]);