//Напишите программу, которая принимает на вход трёхзначное число 
//и на выходе показывает вторую цифру этого числа. 
//456 -> 5
//782 -> 8
//918 -> 1
Console.Write("Введите трёхзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
for (int ii = 1; ii < 3 && (num <= 100 | num > 999); ii++)
if (num <= 100 | num > 999)
{
Console.WriteLine("Чтото пошло не так, программа прервана: ");
}
num = num / 10 % 10;
Console.WriteLine($"Вторая цифра введённого числа: {num}");
