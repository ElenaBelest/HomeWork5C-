// Найдите произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д.
//  Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

Console.Write("Enter size of array: \t");
int size = Convert.ToInt32(Console.ReadLine());

int [] array = new int[size];

EnterRandomArray();

PrintArray(array);

ProdactNumbers (array);

    


int[] EnterRandomArray()
{
for (int i = 0; i < array.Length; i++)
{
array[i] = new Random().Next(1, 100);
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

void ProdactNumbers (int [] array)
{
    int result = 0;

    int n = array.Length / 2;

    Console.Write("The product of the array numbers: " + "[");

    for (int i=0; i < n ; i++)
    {
        result = array[i] * array[array.Length-1-i];
        Console.Write( result + " ");
    }

    if (array.Length % 2 == 0)
    {
        Console.Write("]");
    }
     else
     {
        Console.Write(array[n] + "]");
     }
}