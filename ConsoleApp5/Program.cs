// 4-х значное  
//Console.Write("Введите четырехзначное число: ");
//     string input = Console.ReadLine();
//     if (input.Length != 4)
//     {
//         Console.WriteLine("Ошибка! Вы ввели не четырехзначное число.");
//         return;
//     }

//     int sum = 0;
//     foreach (char digit in input)
//     {
//         int number = digit - '0';
//         sum += number;
//     }
//     Console.WriteLine($"Сумма цифр введенного числа: {sum}");
// 5 значное 
Console.Write("Введите пятизначное число: ");
string input = Console.ReadLine();
if (input.Length != 5)
{
    Console.WriteLine("Ошибка! Вы ввели не пятизначное число.");
    return;
}

int sum = 0;
foreach (char digit in input)
{
    int number = digit - '0';
    sum += number;
}
Console.WriteLine($"Сумма цифр введенного числа: {sum}");