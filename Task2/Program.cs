// Задача 2: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int Enter(string text)
{
    System.Console.WriteLine(text);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}


int summInNum(int num, int summDigit)
{

for (int i = num; i > 0; i /= 10)
{
    summDigit = summDigit + i % 10;
}
return summDigit;
}

int num = Enter("Введите число: ");

int summDigit = 0;

System.Console.WriteLine(summInNum(num,summDigit));
