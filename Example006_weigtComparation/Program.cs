int a = 3;
int b = 7;
int c = 5;
int d = 9;
int e = 2;

int max = a;

if (a > max) max = a;
if (b > max) max = b;
if (c > max) max = c;
if (d > max) max = d;
if (e > max) max = e;

Console.Write ("Max weight=");
Console.WriteLine (max);
