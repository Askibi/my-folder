int a = 3;
int b = a++; //увеличение после присваивания 
Console.WriteLine($"a is {a} , b is{b}");

int c = 3;
int d = ++c; // увеличение перед присваиванием
Console.WriteLine($"c is {c} , d is {d}");

int e = 12;
int f = 4;
Console.WriteLine($"e + f ={e + f}");
Console.WriteLine($"e - f ={e - f}");
Console.WriteLine($"e * f ={e * f}");
Console.WriteLine($"e / f ={e / f}");
Console.WriteLine($"e % f ={e % f}");
double g = 11.0;
Console.WriteLine($"g is{g:N1} f is {f}");
Console.WriteLine($"g / f ={g / f}");

int p =3;
p += 4;
Console.WriteLine(p);