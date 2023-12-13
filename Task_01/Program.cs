// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. 
// Использовать рекурсию, не использовать циклы

Console.Write("Enter m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter n: ");
int n = Convert.ToInt32(Console.ReadLine());
void ShowNums (int m, int n)
{
    if(m<=n)
    {
        System.Console.Write(m+",");
        ShowNums(m+1, n);
    }
}
ShowNums(m,n);