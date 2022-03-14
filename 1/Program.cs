//Найти кубы чисел от 1 до N
Console.WriteLine("Введите целое число");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
CreateArray(array);

void CreateArray(int[] arr)
{
    for (int i=0; i<arr.Length; i++)
    {
        arr[i] = (int)Math.Pow(i+1, 3);
        Console.Write(arr[i] + " ");
    }
}