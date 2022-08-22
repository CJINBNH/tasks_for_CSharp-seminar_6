// Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник со сторонами такой длины
// Необходимые условия существования треугольника a+b>c, a+c>b, b+c>a

Console.Clear();
Console.WriteLine("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число: ");
int third = Convert.ToInt32(Console.ReadLine());

if (a + b > third && a + third > b && b + third > a)
{
    Console.WriteLine("Треугольник со сторонами a, b и c существовать может");
}
else Console.WriteLine("Треугольник существовать не может");