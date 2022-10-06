/* // Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16 */

// Написать число
/* Console.Clear();
Console.WriteLine("Напишите первое число ");
int num = int.Parse(Console.ReadLine());
Console.WriteLine("Напишите второе число ");
int num2 = int.Parse(Console.ReadLine());
Console.Write(Math.Pow(num, num2)); */

Console.Clear();
Console.WriteLine("Напишите первое число ");
int num = int.Parse(Console.ReadLine());
Console.WriteLine("Напишите второе число ");
int num2 = int.Parse(Console.ReadLine());
int[] array = new int[num2];

int sum = 1;

for (int i = 0; i < num2; i++)
{
    array [i] = i + 1; 
    sum = sum * num;
}
Console.WriteLine(sum);








