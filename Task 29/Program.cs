// task 29
Console.Clear();
Console.Write("Введите кол-во элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
double [] array = new double[n];
Console.WriteLine("Введите элементы массива: ");
for (int i = 0; i < array.Length; i++)
    array[i] = Convert.ToDouble(Console.ReadLine()); 
Console.WriteLine($"[{string.Join("; ", array)}]");
