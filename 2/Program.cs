// Найти сумму чисел от 1 до А
Console.WriteLine("Введите целое положительное число");
int a = Convert.ToInt32(Console.ReadLine());
int[] array = new int[a];
int sum = 0;
for(int i=0; i<array.Length; i++)
{
array[i] = i+1;
sum+=array[i];
}
Console.WriteLine(sum);
