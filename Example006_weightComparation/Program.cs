int a = 3;
Console.WriteLine (a);
int b = 7;
Console.WriteLine (b);
int c = 5;
Console.WriteLine (c);
int d = 9;
Console.WriteLine (d);
int e = 2;
Console.WriteLine (e);

int max = a;

if (a > max) max = a;
if (b > max) max = b;
if (c > max) max = c;
if (d > max) max = d;
if (e > max) max = e;

Console.Write ("Max weight=");
Console.WriteLine (max);
