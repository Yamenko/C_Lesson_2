//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// Переменные
int num, digit, spliter;

while (true)
{
    Console.WriteLine("Введите число (0 для выхода):");

    // Проверка числа
    if (!Int32.TryParse(Console.ReadLine(), out num)){
        Console.WriteLine("Не число!"); continue;
    }

    // Выход по условию
    if (num == 0) { break; }

    // Проверка, что 3х значное и выводим 3ю цифру
    digit = Convert.ToInt32(Math.Ceiling(Math.Log10(num))); // Определяем кол-во разрядов через логарифм основания 10
    spliter = Convert.ToInt32(Math.Pow(10 ,(digit-3)));     // Определяем разряд который хотим получить

    // Выводим сообщение на экран
    if (digit < 3) { Console.WriteLine("Третьей цифры нет"); }
    else { Console.WriteLine("Третьей цифры слева = " + ((num / spliter) % 10)); }
}