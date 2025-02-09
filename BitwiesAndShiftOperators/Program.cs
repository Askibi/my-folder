int a = 12;
int b = 6;
Console.WriteLine($"a={a}");
Console.WriteLine($"b ={b}");
Console.WriteLine($"a & b = {a&b}");
Console.WriteLine($"a | b ={a|b}");
Console.WriteLine($"a ^ b ={a^b}");
Console.WriteLine($"a >> 3 ={a>>3}");// сдиг вправо 
Console.WriteLine($"b << 2 ={b<<2}"); // cдивг влево
Console.WriteLine();
Console.WriteLine("Outputting integers as binary:");
Console.WriteLine($"a = {ToBinaryString(a)}");
Console.WriteLine($"b = {ToBinaryString(b)}");
Console.WriteLine($"a & b = {ToBinaryString(a & b)}");
Console.WriteLine($"a | b = {ToBinaryString(a | b)}");
Console.WriteLine($"a ^ b = {ToBinaryString(a ^ b)}");

string ToBinaryString(int value)
{
  return Convert.ToString(value, toBase: 2).PadLeft(8,'0');
}

