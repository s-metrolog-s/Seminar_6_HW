// Задача 41: Пользователь вводит с клавиатуры M чисел
// Посчитайте, сколько чисел больше 0 ввёл пользователь

Console.Clear();
Console.WriteLine("**********************************************");
Console.WriteLine("Введите число ограничения ввода:");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("**********************************************");
Console.WriteLine($"Было введено {CountInput(number)} числа (-ел) > 0");
Console.WriteLine("**********************************************");

int CountInput(int num)
{
    Console.WriteLine("Введите любые целые числа:");
    int count = 0;
    int number = 0;
    for (int i = 0; i < num; i++)
    {
        number = Convert.ToInt32(Console.ReadLine());
        if (number > 0) count++;
    }
    return count;
}