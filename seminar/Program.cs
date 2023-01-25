//СЕМИНАР 1 (БАЗОВЫЕ НАВЫКИ)

/*
//Вывести квадрат числа:

int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(a*a);
*/



/*
//По двум заданным числам проверять явлется ли одно из чисел квадратом другого:

int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());

if(a*a == b || b*b == a)
{
  Console.WriteLine("YES");
}
else
{
  Console.WriteLine("NO");
}
*/



/*
//По заданному номеру дня недели вывести его название:

void pr(string x)
{
  Console.WriteLine(x);
}

int a = Convert.ToInt32(Console.ReadLine());
if(a==0)
{
pr("Понедельник");
}
if(a==1)
{
  pr("Вторник");
}
if (a == 2)
{
  pr("Среда");
}if (a == 3)
{
  pr("Чертверг");
}if (a == 4)
{
  pr("Пятница");
}if (a == 5)
{
  pr("Суббота");
}
if (a == 6)
{
  pr("Воскресенье");
}
*/


/*
//Найти максимальное из 3х чисел:

int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToInt32(Console.ReadLine());

int max = a;

if (b > max) max = b;
if (c > max) max = c;
Console.Write(max);
*/



/*
//Определить четность числа:

int a = new Random().Next(1, 100);
Console.WriteLine(a);

if (a % 2 == 0)
{
  Console.Write("Чет");
}
else
{
  Console.Write("Нечет");
}
*/



/*
//Найти все четные числа от 1 до N:

int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(N);
int x = 1;

while (x <= N)
{
  if (x % 2 == 0)
  {
    Console.WriteLine(x);
    x += 2;
  }
  else
  {
    x += 1;
  }
}
*/



/*
//Показать последнюю цифру 3х значного числа:

int n = new Random().Next(100, 999);
Console.WriteLine(n);
Console.Write("Последняя цифра 3х значного числа, это: ");
Console.WriteLine(n%10);
*/



/*
//Показать вторую цифру 3х значного числа:

int n = new Random().Next(100, 999);
Console.WriteLine(n);
Console.Write("Вторая цифра 3х значного числа, это: ");
n = n/10;
Console.WriteLine(n % 10);
*/



/*
//Показать наибольшее из 2х цифр числа:

int x = new Random().Next(10, 100);
Console.WriteLine(x);
Console.WriteLine("-----------------------------------------------------");
int a = x%10;
int b = x/10%10;
if(a>b)
{
  Console.Write(a);
}
else
{
  Console.Write(b);
}
*/



/*
//Удалить вторую цифру из числа:
//Строковый вариант:

int n = new Random().Next(100, 999);
string x = n.ToString();
Console.WriteLine(x);
Console.WriteLine("-------------------------");
Console.Write(x[0]);
Console.Write(x[2]);
*/


/*
//Выяснить кратнл ли одно число другому:

int n = Convert.ToInt32(Console.ReadLine());
int m = Convert.ToInt32(Console.ReadLine());

if(n%m==0)
{
  Console.WriteLine("YES");
}
else
{
  Console.WriteLine(n%m);
}
*/


/*
//Найти третью цифру числа или сообщить, что её нет

int n = Convert.ToInt32(Console.ReadLine());
string x = n.ToString();
if(x.Length >= 3)
{
Console.WriteLine(x[2]);
}
else
{
  Console.WriteLine("Désolé, le nombre n'a pas la valeur souhaitée");
}
*/

//СЕМИНАР 2 (МАССИВЫ, ФУНКЦИИ)

/*
int a = int.Parse(Console.ReadLine());
if(a % 7 == 0)
{
 if(a % 23 == 0)
 {
  Console.WriteLine("YES");
 }
  else
  {
    Console.Write("NO");
  }
}
else
{
  Console.WriteLine("NO");
}
*/

/*
int x = int.Parse(Console.ReadLine());
int y = int.Parse(Console.ReadLine());

if (x == 0 | y == 0) 
{
  Console.WriteLine($"{0} Вводить нельзя");
}
else{
if (x>0 && y>0) Console.WriteLine("1");
if (x>0 && y<0) Console.WriteLine("4");
if (x<0 && y>0) Console.WriteLine("2");
if (x<0 && y<0) Console.WriteLine("3");
    }
//        2 ___|___ 1
//        3    |    4
*/


/*
string x = Console.ReadLine();
char[] z = x.ToCharArray();
char[] y = x.ToCharArray().Reverse().ToArray();

int i = 0;

while(i < y.Length)
{
  if(z[i] == y[i])
  { 
  i+=1;
  }
  else
  {
    Console.WriteLine("NO");
    break;
  }
  Console.WriteLine("YES");
  break;
}
*/

//Домашнее задание к семинару 2

//Задача 1 (дни недели), если названия дней недели идут с 1
/*
int day = int.Parse(Console.ReadLine());
if (day == 6 | day == 7)
{
  Console.WriteLine("YES");
}
else
{
  Console.WriteLine("NO");
}
*/


//Задача 2 (проверка квадратов)
/*
int x = int.Parse(Console.ReadLine());
int y = int.Parse(Console.ReadLine());

if (x*x == y | y*y == x)
{
  Console.WriteLine("YES");
}
else
{
  Console.WriteLine("NO");
}
*/


//Задача 3 (задать номера четверти и показать диапазоны)
/*
int part = int.Parse(Console.ReadLine());
Console.WriteLine("Введите название четверти плоскости кординат (1-4)");
if (part == 0) Console.WriteLine("Сказали же, от 1 до 4!!!");
else
{
Console.WriteLine();
Console.WriteLine("------------------------------");
Console.WriteLine();
Console.WriteLine($"{2}___|___ {1}");
Console.WriteLine($"{3}   |    {4}");
Console.WriteLine("------------------------------");
Console.WriteLine();
if (part == 1) Console.WriteLine($"Четверть 1, координаты: x>{0}, y>{0}");
if (part == 2) Console.WriteLine($"Четверть 2, координаты: x<{0}, y>{0}");
if (part == 3) Console.WriteLine($"Четверть 3, координаты: x<{0}, y<{0}");
if (part == 4) Console.WriteLine($"Четверть 4, координаты: x>{0}, y<{0}");
Console.WriteLine();
}
*/


//Задача 4 (Найти расстояние между точками в пространстве 2D/3D)

/*
//2D
Console.WriteLine("Даны 2 точки в пространстве. Каждую точку обозначаем координатами х, у");

int x1 = int.Parse(Console.ReadLine());
int y1 = int.Parse(Console.ReadLine());

int x2 = int.Parse(Console.ReadLine());
int y2 = int.Parse(Console.ReadLine());

Console.WriteLine($"Координаты точки А = {x1},{y1}");
Console.WriteLine($"Координаты точки А = {x2},{y2}");
Console.WriteLine($"Расстояние равно: {Math.Abs(Math.Pow((x1-x2)*(x1 - x2) + (y1 - y2)*(y1 - y2), 0.5))}");

//Формулу подсмотрел, но алгоритм решения верный.
*/

/*
//3D
Console.WriteLine("Даны 3 точки в пространстве. Каждую точку обозначаем координатами x, y, z");

int x1 = int.Parse(Console.ReadLine());
int y1 = int.Parse(Console.ReadLine());
int z1 = int.Parse(Console.ReadLine());


int x2 = int.Parse(Console.ReadLine());
int y2 = int.Parse(Console.ReadLine());
int z2 = int.Parse(Console.ReadLine());

Console.WriteLine($"Координаты точки А = {x1},{y1},{z1}");
Console.WriteLine($"Координаты точки А = {x2},{y2},{z2}");

Console.WriteLine($"Расстояние равно: {Math.Abs(Math.Pow((x1-x2)*(x1-x2)+(y1-y2)*(y1-y2)+(z1-z2)*(z1-z2), 0.5))}");

//Формулу подсмотрел, но алгоритм решения верный.
//Функцию Math.Abs - знаю. 
//Не знаю как возводить в степень, конструкция ** не работает, мб есть удобный формат без встроенной функции Math.Pow?
*/
/*
int n = int.Parse(Console.ReadLine());

for (int i=1; i <= n; i++)
{
  Console.WriteLine($"Квадрат числа {i} равен:_________{i*i}");
}

*/
/*
int sum = 0;
int n = int.Parse(Console.ReadLine());
for(int i = 1; i<=n; i++)
{
  sum+=i;
}
Console.WriteLine(sum);
*/

/*
int n = int.Parse(Console.ReadLine());
int z = int.Parse(Console.ReadLine());
int res = 1;

for (int i = 1; i<=z; i++)
{
  res=(res*n);
}

Console.WriteLine(res);
*/

/*
int res = int.Parse(Console.ReadLine());
int s = 0;

while (res != 0)
{
  res/=10;
  s+=1;
}

Console.WriteLine(s);
*/

//Домашнее задание к семинару 3

/*
//Найти кубы чисел от о до N

int N = int.Parse(Console.ReadLine());

for (int i=1; i<=N; i++)
{
  Console.WriteLine($"Число {i} в кубе равно:_________  {i*i*i}");
}
*/


/*
//Посчитать сумму цифр в числе

int N = int.Parse(Console.ReadLine());
int res = 0;

while(N>0)
{
  res+=N%10;
  N/=10;
}

Console.WriteLine(res);
*/


/*
//Написать программу вычисления произведения чисел от 1 до N

int res = 1;
int N = int.Parse(Console.ReadLine());

for (int i = 1; i<=N; i++)
{
  res*=i;
}
Console.WriteLine(res);
*/

/*
//Показать кубы чисел, заканчивающихся на четную цифру

int N = int.Parse(Console.ReadLine());
if(N%2==0)
{
  Console.Write(N*N*N);
}
*/


/*
int [] array = {1,2,3,4,5,6,7,8};
Console.WriteLine("{0}", string.Join("XXXX", array));
*/

/*
int [] array = {3,3,5,6,8,9,2,8,6,4,3,2};
int count = 0;
for (int i=0; i < array.Length; i++)
{
  if (array[i]%2==0)
  {
    count+=array[i];
  }
}

Console.WriteLine(count);
*/

/*
int[] array = { 6,5,3,7,9,0,4,2,1,5,6,7,89, -9, -12, -22, -112 };
for (int i = 0; i<array.Length; i++)
{
  Console.Write($"___{array[i]*-1}___");
}
*/



//Домашнее задание к 4 семинару.


//Задание 1
//Заполнить массив размером 8 элементов нулями и единицами и вывести на экран.

/*
int[] array = new int[8];
Random rand = new Random();
for (int i = 0; i < array.Length; i++)
  array[i] = rand.Next(0,2);
for (int i=0; i < array.Length; i++)
{
  Console.Write(array[i]);
}
*/


//Задание 2
//Определить, присутствует ли в массиве некоторое число

/*
int flag = 0;
int[] array = new int[20];
Random rand = new Random();
for (int i = 0; i < array.Length; i++)
  array[i] = rand.Next(0, 33);
Console.WriteLine("Ваш массив:");
for (int i = 0; i < array.Length; i++)
{
  Console.Write($"_{array[i]}_");
}
Console.WriteLine("");
Console.WriteLine("Введите число, чтобы проверить, содержится ли оно в массиве");
int n = int.Parse(Console.ReadLine());

for (int i = 0; i<array.Length; i++)
{
  if (array[i] == n)
  flag += 1;
}

if (flag == 0)
{
  Console.WriteLine("Числа в массиве нет!");
}
else
{
  Console.WriteLine($"Ваше число встречается в массиве {flag} раз/а");
}
*/


//Задание 3. 
//Задать массив, заполнить случайными 3х значными числами и посчитать кол-во чет/нечет.

/*
Console.WriteLine("\n");
Console.WriteLine("Задайте размер массива");
int size = int.Parse(Console.ReadLine());
int[] array = new int[size];
Random rand = new Random();
for (int i = 0; i < array.Length; i++)
  array[i] = rand.Next(100, 999);

Console.WriteLine("А вот и ваш массивчик!");
for (int i = 0; i < array.Length; i++)
{
  Console.Write($"_{array[i]}_");
}
int chet = 0;
int nexhet = 0;

for (int i = 0; i<array.Length; i++)
{
  if (array[i] % 2 == 0) chet += 1;
  else nexhet += 1;
}
Console.WriteLine("\n");
Console.WriteLine($"Сумма четных чисел в массиве = {chet}\nСумма нечетных = {nexhet}");
Console.WriteLine("\n");
*/

//Задание 4.
//В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99].

/*
int[] array = new int[123];
Random rand = new Random();
for (int i = 0; i < array.Length; i++)
array[i] = rand.Next(0, 150);
int count = 0;
Console.WriteLine("А вот и ваш массивчик!\n");
for (int i = 0; i < array.Length; i++)
{
  Console.Write($"_{array[i]}_");
  if (array[i] <= 99 && 10 <= array[i]) count+=1;
}
Console.WriteLine("\n");
Console.WriteLine($"\nКоличество элементов, которые входят в множество [10, 99] равно {count}");
*/


//Задание 5.
//Найти сумму чисел одномерного массива стоящих на нечетной позиции

/*
int[] array = new int[10];
Random rand = new Random();
for (int i = 0; i < array.Length; i++)
  array[i] = rand.Next(0, 9);
int count = 0;
Console.WriteLine("А вот и ваш массивчик!\n");
for (int i = 0; i < array.Length; i++)
{
  Console.Write($"_{array[i]}_");
  if (i % 2 != 0) count += array[i];
}
Console.WriteLine("\n");
Console.WriteLine(count);
*/


//Задание 6.
//Найти произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д.

/*
Console.WriteLine("Введите размер массива");
int size = int.Parse(Console.ReadLine());
int[] array = new int[size];
Random rand = new Random();
for (int i = 0; i < array.Length; i++)
  array[i] = rand.Next(0, 9);
int a = 0;
int b = array.Length-1;
Console.WriteLine("А вот и ваш массивчик!\n");
for (int i = 0; i < array.Length; i++)
{
  Console.Write($"_{array[i]}_");
}
Console.Write("\n");
if (array.Length % 2 == 0)
{
  for (int i = 0; i < array.Length / 2; i++)
  {
    Console.WriteLine(array[a] + array[b]);
    a += 1;
    b -= 1;
  }
}
else
{
  for (int i = 0; i < array.Length / 2; i++)
  {
    Console.WriteLine(array[a] + array[b]);
    a += 1;
    b -= 1;
  }
  Console.WriteLine($"Число посредине (индекс {array.Length/2+1}): {array[a]}");
}
*/

//Задание 7.
//В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом.
//Вещественные числа — это числа, у которых есть дробная часть (она может быть нулевой).
/*
double[] array = new double[10];
Random rand = new Random();
for (int i = 0; i < array.Length; i++)
  array[i] = rand.Next(-990, 990)/10.0;
double mi = 9999999999999999.0;
double ma = -9999999999999999.0;
Console.WriteLine("А вот и ваш массивчик!\n");
for (int i = 0; i < array.Length; i++)
{
  Console.Write($"_{array[i]}_");
  if (array[i] < mi) mi = array[i];
  if (array[i] > ma) ma = array[i];
}
Console.WriteLine($"\nРазница числен между максимальным ({ma}) и минимальным элементами массива ({mi}) равна {ma-mi}");
Console.WriteLine($"\nРазница абсолютных значений между максимальным ({ma}) и минимальным элементами массива ({mi}) равна {Math.Abs(Math.Abs(ma) - Math.Abs(mi))}");
*/