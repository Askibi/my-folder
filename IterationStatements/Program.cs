/*
int x = 0;
while(x<10)
{
    Console.WriteLine(x);
    x++;
}
*/
using Microsoft.VisualBasic;
/*
string? password;
do
{
  Console.Write("Enter your password: ");
 password = Console.ReadLine();

}
while (password != "Pa$$w0rd");
Console.WriteLine("Correct!");
*/
// Где ставить if оператора , для добавления попыток ввода и какая операнда нужна ?

for (int y = 1; y <= 10; y++)
{
 Console.WriteLine(y);
}

string[] names = { "Adam", "Barry", "Charlie" };
foreach (string name in names)
{
 Console.WriteLine($"{name} has {name.Length} characters.");
}