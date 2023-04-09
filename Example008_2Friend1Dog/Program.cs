int FFS = 1;
Console.WriteLine ($"First friend speed: {FFS}");
int SFS = 2;
Console.WriteLine ($"Second friend speed: {SFS}");
int DS = 5;
Console.WriteLine ($"Dog speed {DS}");
int Time = 0;
int Friend = 1;
int distance = 1000;
int count = 0;

while (distance > 10)
{
    if (FFS == 1)
    {
        Time = distance / (FFS + DS);
        Friend = 2;
    }

    else
    {    
        Time = distance / (SFS + DS);
        Friend = 1;
    }

    distance = distance - (FFS + SFS) * Time;
    Console.WriteLine(count);
    count++;
}