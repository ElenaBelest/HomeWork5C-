// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Console.Write("Enter size of array: \t");
int size = Convert.ToInt32(Console.ReadLine());

int [] array = new int[size];

EnterRandomArray();

PrintArray(array);

CountEvenNumbers(array);
    


int[] EnterRandomArray()
{
for (int i = 0; i < array.Length; i++)
{
array[i] = new Random().Next(100, 1000);
}

return array;
}

 void PrintArray (int [] array)
{
    Console.Write("[");
     for (int i = 0; i < array.Length; i++)
     {
         Console.Write($"{array[i]} ");    
     }
     Console.Write("]");
     Console.WriteLine();

}

 void CountEvenNumbers(int [] array)
 {

    int count = 0;

    for(int i = 0; i < array.Length; i++)
    {
        {
            if (array[i] % 2 == 0)
            {
            count++;
            }
           
        }
    }
    Console.WriteLine("Even numbers of array: " + count);
 }

