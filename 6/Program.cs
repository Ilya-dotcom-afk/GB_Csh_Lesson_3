// Задать массив из 12 элементов, заполненных числами из [0,9]. Найти сумму положительных/отрицательных элементов массива
int[] array = new int[12];
int positivSum = 0;
int negativSum = 0;
Random rand = new Random();

for(int i = 0; i<array.Length; i++)
    {
        array[i] = rand.Next(-9, 10);
        if(array[i]>0) positivSum+=array[i];
        else negativSum+=array[i];
    }
Console.WriteLine("Сумма положительных чисел массива равна " + positivSum);
Console.WriteLine("Сумма отритцательных чисел массива равна " + negativSum);