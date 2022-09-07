// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

Console.Write("Enter size of array: \t");
int size = int.Parse(Console.ReadLine());

double [] array = new double[size];

EnterRandomArray();

PrintArray(array);

MinMaxNumbers(array);

double [] EnterRandomArray()
{
for (int i = 0; i < array.Length; i++)
{
array[i] = new Random().Next(0,100);
}

return array;
}

 void PrintArray (double [] array)
{
    Console.Write("[");
     for (int i = 0; i < array.Length; i++)
     {
         Console.Write($"{array[i]} ");    
     }
     Console.Write("]");
      Console.WriteLine();

}

void MinMaxNumbers (double [] array)
{
    double MinNumber = array[0];
    double MaxNumber = array[0];

    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < MinNumber)
        {
            MinNumber = array[i];
        }
        
        for (int j = 1; j < array.Length; j++)
       {
        if (array[j] >= MaxNumber)
        {
            MaxNumber = array[j];  
        }
       }
    }

    double result = (MaxNumber - MinNumber);

    Console.WriteLine("The difference between the maximum and minimum array element: " + result);
}