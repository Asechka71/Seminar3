/* Задача 23
Напишите программу, которая принимает на вход число (N) 
и выдаёт таблицу кубов чисел от 1 до N.
*/
Console.WriteLine("Введите число: ");
int length = Convert.ToInt32(Console.ReadLine());
void CubeArray(int [] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
      collection [index] = (index + 1)*(index + 1)*(index + 1);
      index ++;
    }
Console.WriteLine(String.Join(" ", collection));
}
int arraySize = length;
int [] array = new int[arraySize];
CubeArray(array);