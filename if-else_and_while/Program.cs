// If / else / while operations
// Simple programm about a python hucker

Console.WriteLine("Identification...wait...");
Console.WriteLine("waiting...43%");
Console.WriteLine("waiting...97%");
Console.Write("Enter Password: ");
string password = Console.ReadLine();

if(password.ToLower() != "hardpassword")
{
  Console.WriteLine("Yor are hucker! Alarm! Alarm! ");
}
else
{
  Console.WriteLine("Hellow, dr. John, nice to meet u!");
}

//when hucker enter the guard_system, he will have a little chance to robe a briliant!

int seconds = 10;

while (seconds > 0)
{
  seconds -= 1;
}

if (1-2 == 3)
{
  Console.WriteLine("Catch him!");
}
else
{
  Console.WriteLine("Python hucker has robbed a laboratory and run away!");
}