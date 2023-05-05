// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте,
// сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

Console.WriteLine("Введите число до 5: ");
int number = FindNumbersMoreThanZero();
Console.WriteLine($" число больше 0 -> {number}");

int FindNumbersMoreThanZero()
{
    int count = 0;
    for(int i = 0; i<5; i++)
    {
        int number = int.Parse(Console.ReadLine() ?? "");
        if(number>0) 
        {
            count++;
        }
        
    }
    return count;
}


