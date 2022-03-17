// Подсчитать сумму цифр в числе
Console.WriteLine("Введите число");
int n = Convert.ToInt32(Console.ReadLine());
int order = (int)Math.Log10(n) + 1;
int[] array = new int[order];
int sum = 0;
for (int i=0; i<array.Length; i++)
    {
    int a = n%(int)Math.Pow(10, order-i);
    int b = n%(int)Math.Pow(10, order-i-1);
    int c = (int)Math.Pow(10, order-i-1);
    array[i] = (a-b)/c;
    sum += array[i];
    }
Console.Write(sum);