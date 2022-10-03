Console.WriteLine("Введите два числа ");
string a_str = Console.ReadLine();
double a = Convert.ToDouble(a_str);
string b_str = Console.ReadLine();
double b = Convert.ToDouble(b_str);
int summ = Convert.ToInt32(a + b);
double del = a/b;
Console.WriteLine("Сумма чисел " + a + " и " + b + " равна " + summ);
Console.Write("Частное чисел " + a + " и " + b + " равно " + del);
