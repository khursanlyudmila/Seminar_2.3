/*Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/

Console.WriteLine("Введите положительное пятизначное число: ");

int number = int.Parse(Console.ReadLine());
string str = number.ToString();

{
if(number < 0 )
    Console.WriteLine("Вы ввели отрицательное число!");

else if(number > 99999)
    Console.WriteLine("Вы ввели не пятизначное число!");

else if(number < 10000)
    Console.WriteLine("Вы ввели не пятизначное число!");

else if(str[0] == str[4] && str[1] == str[3])
    Console.WriteLine($"Число {number} - полиндром.");

else
    Console.WriteLine($"Число {number} - не полиндром.");
}