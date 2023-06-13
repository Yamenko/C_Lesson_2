//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

int num;

while (true)
{
    Console.WriteLine("Введите номер деня недели (0 для выхода):");

    // Проверка числа
    if (!Int32.TryParse(Console.ReadLine(), out num))
    {
        Console.WriteLine("Не число!"); continue;
    }

    // Выход по условию
    if (num == 0) { break; }

    // Выводим сообщение на экран
    if      (num <= 0 || num > 7) {     Console.WriteLine("Такого дня нет"); }
    else if (num == 6 || num == 7) {    Console.WriteLine("Выходной"); }
    else {                              Console.WriteLine("Будний день"); }
}