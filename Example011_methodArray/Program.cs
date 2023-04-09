// найти первый элемент соответвующий значению "find" 
// и показать его index в массиве

int[] array = { 10, 21, 43, 4, 52, 16, 75, 38, 52 };

int n = array.Length; // Length - возвращает длину элементов массива
int find = 52;

int index = 0;

while (index < n)
{
        if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++; // index = Index + 1
}