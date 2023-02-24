Console.Clear();
void FindInArray(string[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3) count++;
    }
    string[] arrayNew = new string[count];
    int k = 0;
    for (int j = 0; j < array.Length; j++)
    {
        if(array[j].Length <= 3) 
        {
            arrayNew[k] = array[j];
            k++;
        }
    }
    Console.WriteLine($"Конечный массив: [{string.Join(", ", arrayNew)}]");
}

Console.WriteLine("Введите кол-во элементов массива : ");
int LengthMassive = Convert.ToInt32(Console.ReadLine());
string[] Massiv = new string[LengthMassive];
for (int i = 0; i < LengthMassive; i++)
{
    Console.WriteLine($"Введите {i+1} элемент массива : ");
    Massiv[i] = Console.ReadLine();   
}
Console.WriteLine($"Начальный масссив: [{string.Join(", ", Massiv)}]");
FindInArray(Massiv);