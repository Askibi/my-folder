Console.Write("Enter a number between 0 and 255: ");
string n1 = Console.ReadLine()!;

Console.Write("Enter another number between 0 and 255: ");
string n2 = Console.ReadLine()!;

try
{
  int a = int.Parse(n1);
  int b = int.Parse(n2);

  int answer = a / b;

  Console.WriteLine($"{a} divided by {b} is {answer}");
}
catch (Exception ex)
{
  Console.WriteLine($"{ex.GetType().Name}: {ex.Message}");
}
//я знаю , что здесь можно заменить инт на байт , сейчас можно ставить значения > 255 