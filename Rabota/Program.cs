// 1.Напишите программу, которая принимает на вход пятизначное число и
// 2.проверяет, является ли оно палиндромом. Выполнить с помощью числовых операций 
// 3.(целочисленное деление, остаток от деления).

// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите Пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int number1 = Math.Abs(number);
if ((number1 < 10000) || (number1 > 100000))
{
Console.WriteLine("Число не пятизначное, введите другое число ");
}
else
{
int num5 = number1 % 10;
int num4 = (number1 % 100) / 10;
int num2 = (number1 / 1000) % 10;
int num1 = number1 / 10000;

if ((num5 == num1) && (num4 == num2))
{
Console.WriteLine($"{number} ---> Да");
}
else
{
Console.WriteLine($"{number} ---> Нет");
}

}
