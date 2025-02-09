
bool a = true;
bool b = false;
/*
Console.WriteLine($"AND|    a   |  b "); // AND - &
Console.WriteLine($"a | {a & a,-5} | {a & b,-5} ");
Console.WriteLine($"b | {b & a,-5} | {b & b,-5} ");
Console.WriteLine();
Console.WriteLine($"OR | a | b ");  // OR - |
Console.WriteLine($"a | {a | a,-5} | {a | b,-5} ");
Console.WriteLine($"b | {b | a,-5} | {b | b,-5} ");
Console.WriteLine();
Console.WriteLine($"XOR | a | b "); // XOR - ^
Console.WriteLine($"a | {a ^ a,-5} | {a ^ b,-5} ");
Console.WriteLine($"b | {b ^ a,-5} | {b ^ b,-5} ");
*/
 bool DoStuff()
{
    Console.WriteLine("I am doing some stuff.");
Console.WriteLine();
Console.WriteLine($"a && DoStuff() = {a && DoStuff()}");
Console.WriteLine($"b && DoStuff() = {b && DoStuff()}");
   return true;
}


