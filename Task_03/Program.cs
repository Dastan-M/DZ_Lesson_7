// Задайте произвольный массив. Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.

void ShowArray(int[]array, int size)
{
    if(size>=0)
    {
        System.Console.Write(array[size]+" ");
        ShowArray(array, size-1);
    }
}
int []array ={3, 2, 5, 0, 10, 34};
ShowArray(array, array.Length-1);