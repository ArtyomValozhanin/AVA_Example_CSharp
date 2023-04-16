// 1. Найти позицию мин. элемента в неотсортированной части массива
// 2. Произвести обмен этого элемента со первым неотсортированным элементом
// 3. Повторять цикл пока есть неотсортированные элементы

// 6 8 3 2 1 4 5 7 -> 1 2 3 4 5 6 7 8

// int[] array = {1, 7, 6, 2, 5, 2, 4, 8, 3, 5};

// void PrintArray(int[] arr) // метод вывод массива на экран
// {
//     int count = arr.Length;
//     for(int i = 0; i < count; i++)
//     {
//         Console.Write($"{arr[i]} ");
//     }
//     Console.WriteLine();
// }

// void SelectionSort(int[] arr) // метод сортировки массива
// {
//     for(int i = 0; i < arr.Length - 1; i++)
//     {
//         int minPosition = i;

//         for(int j = i + 1; j < arr.Length; j++)
//         {
//             if(arr[j] < arr[minPosition]) minPosition = j;
//         }

//         int temporary = arr[i]; // swap - хамена одного элемента на другой через "temp"
//         arr[i] = arr[minPosition];
//         arr[minPosition] = temporary;
//     }
// }

// PrintArray(array);

// SelectionSort(array);
// PrintArray(array);

int[] array = {1, 7, 6, 2, 5, 2, 4, 8, 3, 5};

void PrintArray(int[] arr) // метод вывод массива на экран
{
    int count = arr.Length;
    for(int i = 0; i < count; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}

void SelectionSort(int[] arr) // метод сортировки массива
{
    for(int i = 0; i < arr.Length - 1; i++)
    {
        int maxPosition = i; // <- нахождение макс. числа массива

        for(int j = i + 1; j < arr.Length; j++)
        {
            if(arr[j] > arr[maxPosition]) maxPosition = j; // <- замена знака на ">"
        }

        int temporary = arr[i]; // swap - хамена одного элемента на другой через "temp"
        arr[i] = arr[maxPosition];
        arr[maxPosition] = temporary;
    }
}

PrintArray(array);

SelectionSort(array);
PrintArray(array);