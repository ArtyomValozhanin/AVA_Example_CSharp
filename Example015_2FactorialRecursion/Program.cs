// Факториал и Рекурсия
// int Factorial(int n)
// {
//     if(n == 1) return 1;        // 1! = 1; 0! = 1
//     else return n * Factorial(n-1);   //Рекурсия - вызов фунции самой себя            
// }
// Console.WriteLine(Factorial(3)); // 1*2*3 = 6

double Factorial(int n) // double - позволяет хранить больший объем вычисляемых данных.
{
    if(n == 1) return 1;        
    else return n * Factorial(n-1);       
}
for (int i = 1; i < 40; i++)
{
    Console.WriteLine($"{i}! = {Factorial(i)}");
}
 