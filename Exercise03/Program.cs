for (int X = 1; X <= 100; X++)
{
  if (X % 15 == 0)
  {
    Console.Write("FizzBuzz");
  }
  else if (X % 5 == 0)
  {
    Console.Write("Buzz");
  }
  else if (X % 3 == 0)
  {
    Console.Write("Fizz");
  }
  else
  {
    Console.Write(X);
  }
  if (X < 100) Console.Write(", ");
  if (X % 10 == 0) Console.WriteLine();
}


