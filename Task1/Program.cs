// Задача 1: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int Enter(string text)
{
    System.Console.WriteLine(text);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

int exponentiation(int firstNum, int secondNum)
{
    int degreeNum = 1;
    for (int i = 1; i <= secondNum; i++)
    {
        degreeNum = degreeNum * firstNum;

    }
    return degreeNum;

}

double Subtraction(double firstNum, int secondNum)
{
    double degreeNum = 1 / firstNum;
       for (int i = secondNum; i < 0; i++)
    {
        degreeNum = degreeNum * (1 / firstNum);
    }
       return degreeNum;

}

bool ValidateNum(int num)
{
    if (num > 0)
    {
        return true;
    }
    System.Console.WriteLine("Введено отрицательное значение");
    return false;
}


int firstNum = Enter("Введите первое число: ");
int secondNum = Enter("Введите второе число: ");

if (ValidateNum(secondNum))
{
    System.Console.WriteLine($"\n{firstNum} в степени {secondNum} = {exponentiation(firstNum, secondNum)}");
    return;
}
System.Console.WriteLine($"\n{firstNum} в степени {secondNum} = {Subtraction(firstNum, secondNum)}");