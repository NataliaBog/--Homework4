// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе

Console.Clear();

Console.WriteLine("Введите число");
double digit = Convert.ToInt32(Console.ReadLine());
double count = 0;
while (digit > 0)
{
    count = count + digit % 10;
    digit = (digit - digit % 10)/10;
}
Console.WriteLine("Сумма всех чисел равна " + count);