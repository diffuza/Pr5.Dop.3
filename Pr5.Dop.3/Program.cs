using System;
namespace HelloApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Tom"; int age = 34; //Присвоение строкового типа "string" лок.переменной "name"; присвоение целого типа "int" лок.переменной "age".
            double height = 1.7; //присвоение вещественного типа "double" лок.переменной "height".
            Console.WriteLine($"Имя: {name} Возраст: {age} Рост: {height}м"); // вывод на экран имени, возраста и роста с присвоенными им выше значениями.
            Console.ReadKey(); // ожидание нажатия пользователем на любую клавишу для закрытия консоли.
        }
    }
}