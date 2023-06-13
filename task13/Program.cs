//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// Переменные
int num;

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
    num = (num / 100) % 10; // дополнительная проверка если будет сотен больше 9
    if (num > 0) { Console.WriteLine("Третья цифра = " + num); }
    else { Console.WriteLine("Третьей цифры нет"); }
}

// Краткая запись без проверок))
//int num;
//Console.WriteLine("Введите число (0 для выхода):");
//Int32.TryParse(Console.ReadLine(), out num);
//num /= 100;
//if (num > 0){   Console.WriteLine("Третьей цифры нет");}
//else{           Console.WriteLine("Третья цифра = " + num);}