// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите три числа");
int firstNumber = Convert.ToInt32(Console.ReadLine());
int secondNumber = Convert.ToInt32(Console.ReadLine());
int therdNumber = Convert.ToInt32(Console.ReadLine());

int maxNumber = firstNumber;
if (maxNumber < secondNumber){
    maxNumber = secondNumber;
}
if (maxNumber < therdNumber){
    maxNumber = therdNumber;
}
Console.WriteLine("Максимальное число: " + maxNumber);
