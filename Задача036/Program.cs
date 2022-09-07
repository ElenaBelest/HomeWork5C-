// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


Console.Write("Enter size of array: \t");
int size = Convert.ToInt32(Console.ReadLine());

int [] array = new int[size];

EnterRandomArray();

PrintArray(array);

SumNonEvenNumbers(array);
    


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

 void SumNonEvenNumbers(int [] array)
 {

    int result = 0;

    for(int i = 0; i < array.Length; i++)
    {
        {
            if (array[i] % 2 != 0)
            {
            result = array[i] + result ;
            }
           
        }
    }
    Console.WriteLine("Summ non-even numbers of array: " + result);
 }

