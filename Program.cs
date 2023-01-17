// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

string[] array01 = { "12", "Hello", "78", "World", "7531", "789321" };
string[] array02 = new string[array01.Length];

void SecondArray(string[] array01, string[] array02)
{
    int count = 0;
    for (int i = 0; i < array01.Length; i++)
    {
        if (array01[i].Length <= 3)
        {
            array02[count] = array01[i];
            count++;
        }
    }
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
SecondArray(array01, array02);
PrintArray(array02);








