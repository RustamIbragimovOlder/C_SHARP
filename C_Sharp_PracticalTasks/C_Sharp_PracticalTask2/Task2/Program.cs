// Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

int number = new Random().Next(100, 1000);            // Генерация случайного 3-х значного числа

int DecompositionNumber(int number)                    // Функция разложения 3-х значного числа по разрядам
{
    int number3 = number % 10;                         // Определение 3 цифры
    // int number2 = number / 10 % 10;                 // Определение 2 цифры
    int number1 = number / 100 % 10;                   // Определение 1 цифры
    int result = number1 * 10 + number3;               // Определение суммы 1 и 3
    // int result = number2 * 10 + number3;            // Определение суммы 2 и 3
    // int result = number3 * 100 + number2 * 10 + number3; //  Определение суммы 3, 2 и 1 ("перевернуть" число)
    // и так далее в том же духе
    return result;                                    // Возвращение результата
}
System.Console.WriteLine($"{number} -> {DecompositionNumber(number)}"); // Вывод результата