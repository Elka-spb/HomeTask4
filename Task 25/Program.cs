// task 25
Console.Clear();
Console.Write("Введите число А: ");
double A = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите число B: ");
int B = Convert.ToInt32(Console.ReadLine());
double C = 1;
for (int i = 1; i <= B; i++)
    C = C * A;
Console.WriteLine("А в степени B равно: " + C);