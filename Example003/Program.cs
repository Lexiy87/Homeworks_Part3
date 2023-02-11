// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

int GetNumber(string message)
{
    int number = 0;
    System.Console.WriteLine(message);

    while (true)
    {
        if (int.TryParse(Console.ReadLine(), out number) && number >= 1)
        {
            break;
        }
        else System.Console.WriteLine("Вы ввели неверное число, повторите ввод");
    }
    return number;
}


    

int number = GetNumber("Введите любое число от 1");

for (int i = 1; i <= number; i++)
    {
        System.Console.Write($" {Math.Pow(i, 3)}");
    }
