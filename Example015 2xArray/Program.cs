// двумерные массивы. Рекурсия
string [,] table = new string[2,5]; // 2 строки, 5 столбцов (table наименование массива)
// table [0,0] table [0,1] table [0,2] table [0,3] table [0,5]
// table [1,0] table [1,1] table [1,2] table [1,3] table [1,5]

// Пример
// table[1, 2] = "привет"; // обращение к элементу массива расположенному в 1 строке и 2 столбце.
// for (int rows = 0; rows < 2; rows++) // вывод массива на экран
// {
//     for (int columns = 0; columns < 5; columns++)
//     {
//         Console.Write($"-{table[rows, columns]}-");
//     }
//  Console.WriteLine();
// }

void FillArray(int[,] matr) // заполнение двумерного массива
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i,j] = new Random().Next(1,10);
        }
    }
}

void PrintArray(int[,] matr) 
{
// for (int i = 0; i < 3; i++) 
    for (int i = 0; i < matr.GetLength(0); i++) // универсальная запись вывода строк
    {
        // for (int j = 0; j < 4; j++)
        for (int j = 0; j < matr.GetLength(1); j++) // универсальная запись вывода колонок
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine(); // особенность вывода двумерного массива
    }
}

int[,] matrix = new int [3, 4];
PrintArray(matrix); // без заполнения
Console.WriteLine();
FillArray(matrix); // с заполнением
PrintArray(matrix);