// See https://aka.ms/new-console-template for more information
Console.WriteLine("Coin Flip Conditional Operator");


//  Conditional Operator
Random rnd = new Random();
int number = rnd.Next(0,2);
Console.WriteLine((number == 0) ? "Heads" : "Tails");


//  Reverse A String

string name = "My Name is Sarfaraz";

char[] convert = name.ToCharArray();

for (int i = 0, j = convert.Length - 1; i < j; i++, j--)
{
    // Swap i with j
    convert[i] = name[j];
    // Swap i with j
    convert[j] = name[i];

}
// Display the reversed string
Console.WriteLine(new string(convert));

//  Second method to reverse a string

string nme = "My Name is Sarfaraz";
string roe = new string(nme.Reverse().ToArray());
Console.WriteLine(roe);

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



