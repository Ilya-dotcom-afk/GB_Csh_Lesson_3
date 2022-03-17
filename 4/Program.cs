// Написать программу вычисления произведения чисел от 1 до N
Console.WriteLine("Введите целое положительное число");
int n = Convert.ToInt32(Console.ReadLine());
int s = 1;
for(int i = 1; i<=n; i++)
    {
        s = s*i;
    }
Console.WriteLine(s);
