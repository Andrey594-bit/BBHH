Console.WriteLine("Задание 1");
Console.WriteLine($"Число e с точностью до десятых равно : {Math.Round(Math.E, 1)}"); 
Console.ReadKey();

Console.WriteLine("Задание 2");
Console.WriteLine(50);
Console.WriteLine(10);
Console.ReadKey();

Console.WriteLine("Задание 3");
Random A = new Random();
Console.WriteLine(A.Next());
Console.WriteLine(A.Next());
Console.WriteLine(A.Next());
Console.ReadKey();

Console.WriteLine("Задание 4");
Console.Write("Введите число: ");
string B = Console.ReadLine();
double number = Convert.ToDouble(B);
double result = number + 10;
Console.WriteLine($"Ваше число + 10 = {result}");
Console.ReadKey();

Console.WriteLine("Задание 5");
Console.Write("Введите угол x (в радианах): ");
string C = Console.ReadLine();
double x = Convert.ToDouble(C);
double y = Math.Cos(x);
Console.WriteLine($"cos({x}) = {y}");
Console.ReadKey();

Console.WriteLine("Задание 6");
Console.Write("Введите большее основание a: ");
double a = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите меньшее основание b: ");
double b = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите высоту h: ");
double h = Convert.ToDouble(Console.ReadLine());
double side = Math.Sqrt(Math.Pow((a - b) / 2, 2) + h * h);
double perimeter = a + b + 2 * side;
Console.WriteLine($"Периметр = {perimeter}");
Console.ReadKey();

Console.WriteLine("Задание 7");
Console.WriteLine("Мир Труд Май");
Console.ReadKey();

Console.WriteLine("Задание 8");
Console.Write("Введите первую переменную z: ");
string z = Console.ReadLine();
Console.Write("Введите вторую переменную m: ");
string m = Console.ReadLine();
string temp = z;
z = m;
m = temp;
Console.WriteLine($"После обмена: z = {z}, m = {m}");
Console.ReadKey();

Console.WriteLine("Задание 9");
Console.Write("Введите число: ");
string num = Console.ReadLine();
Console.WriteLine($"Вы ввели число {num}");
Console.ReadKey();

