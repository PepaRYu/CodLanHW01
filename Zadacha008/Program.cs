// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
int start = 1;
Console.WriteLine("Список чётных чисел меньших " + N);
while (start <= N){
    if (start %2 == 0){
        Console.WriteLine(start);
    }
    start++;
}
