// See https://aka.ms/new-console-template for more information
Console.WriteLine("Coin Flip Conditional Operator");


//  Conditional Operator
Random rnd = new Random();
int number = rnd.Next(0,2);
Console.WriteLine((number == 0) ? "Heads" : "Tails");



//  Another Task
string permission = "Admin|Manager";
int level = 55;

if (permission.Contains("Admin"))
{
    if (level > 55)
    {
        Console.WriteLine("Welcome, Super Admin user.");
    }
    else
    {
        Console.WriteLine("Welcome, Admin user.");
    }
}
if (permission.Contains("Manager"))
{
    if (level >= 20)
    {
        Console.WriteLine("Contact an Admin for access.");
    }
    else if (level < 20)
    {
        Console.WriteLine("You do not have sufficient privileges.");
    }
    else
    {
        Console.WriteLine("You do not have sufficient privileges.");
    }
}



