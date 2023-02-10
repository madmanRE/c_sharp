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

/*
int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int c = int.Parse(Console.ReadLine());

if(a+b > c)
{
  if(a+c > b)
  {
    if (c+b > a)
    {
      Console.WriteLine("YES");
    }
    else
    {
      Console.WriteLine("NO");
    }
  }
  else{
    Console.WriteLine("NO");
  }
}
else
{
  Console.WriteLine("NO");
}
*/


/*
int a = 10;
string q = "";

while (a > 0)
{
  int x = a % 2;
  q += x.ToString();
  a = a / 2;
}

char[] res = q.ToCharArray();
Array.Reverse(res);
Console.WriteLine(res);
*/


//На числах
/*
int a = int.Parse(Console.ReadLine());
int xxx = a;
int size = 0;
while (xxx > 0)
{
  xxx = xxx / 2;
  size += 1;
}

int[] q = new int [size];
int c = 0;
while (a > 0)
{
  q[c] = a%2;
  a = a/2;
  c += 1;
}
int i = q.Length-1;

while (i >= 0) 
{
  Console.Write(q[i]);
  i--;
}
*/



//Домашнее задание к семинару 5.

//Задание 1. Найти точку пересечения двух прямых заданных уравнением y = k1 * x + b1, y = k2 * x + b2, b1 k1 и b2 и k2 заданы.

/*
int k1 = int.Parse(Console.ReadLine());
int k2 = int.Parse(Console.ReadLine());
int b1 = int.Parse(Console.ReadLine());
int b2 = int.Parse(Console.ReadLine());

if (k1 != k2)
{
  int x = (b2 - b1) / (k1 - k2);
  Console.WriteLine($"x = {x}, y = {k1*x+b1}");
}
else
{
  Console.WriteLine("Это параллельные прямые");
}
*/


//Задание 2. Показать числа Фибоначи. 

/*
int [] fib = new int [20];
fib[0] = 0;
fib[1] = 1;
for(int i = 2; i < fib.Length; i++)
{
  fib[i] = fib[i-1] + fib[i-2];
}
for (int i = 0; i<fib.Length; i++)
{
  Console.Write($"{fib[i]} ");
}
*/


//Задание 4.
//Программа копирования массива.
/*
int[] array = new int[10];
Random rand = new Random();
for (int i = 0; i < array.Length; i++)
  array[i] = rand.Next(-990, 990);
Console.WriteLine($"Исходный массив:");
for (int i = 0; i < array.Length; i++)
  Console.Write($"({array[i]})");
int[] newarray = new int[array.Length];
for (int i = 0; i < array.Length; i++)
  newarray[i] = array[i];
Console.WriteLine($"\nКопированная версия массива:");  
for (int i = 0; i < newarray.Length; i++)
  Console.Write($"[{newarray[i]}]");
*/


//Задание 3.
//Написать программу масштабирования фигуры.

//Вершины фигуры:
/*
string koef()
{
  Console.WriteLine("Введите коэффициент:");
  Console.WriteLine("Внимание! Если вводите ДРОБНЫЙ КОЭФФИЦИЕНТ, делайте это через запятую. Пример: 1,8 или 0,5, а не 1.8 иди 0.5!!!");
  string k = Console.ReadLine();
  if(k.Contains('.'))
  {
    Console.WriteLine("Неверный формат ввода, дробные коэффициенты НЕОБХОДИМО ВВОДИТЬ С ЗАПЯТОЙ, А НЕ ТОЧКОЙ!\nВведите коэффициент снова:");
    return (koef());
  }
  else return (k);
}


string fig()
{
  Console.WriteLine("Введите вершины фигуры в формате (0;0) (2;0) (2;2) (0;2)");
  Console.WriteLine("Обратите внимание! Вводить необходимо исключительно в указанном формате: (число,число) (число,число)...\nОбратите внимание! Между парами скобок пробелы, сами же скобки содержат 2 числа, разделенных точкой с запятой!");
  string vershini_figuri = Console.ReadLine();
  if(vershini_figuri.Contains(','))
  {
    Console.WriteLine("Неверный формат ввода. Повторите ввод данных");
    return(fig());
  }
  else return(vershini_figuri);
}

string vershini_figuri = fig();
Console.WriteLine($"Исходные значения: {vershini_figuri}");
int[] array = new int[8];
int x = 0;

for (int i = 0; i<vershini_figuri.Length; i++)
{
  if(vershini_figuri[i] != '(' && vershini_figuri[i] != ')' && vershini_figuri[i] != ' ' && vershini_figuri[i] != ';')
  {
    array[x] = int.Parse(vershini_figuri[i].ToString());
    x += 1;
  }
}

string k = koef();

{
try
{
  int numericValue;
  bool isNumber = int.TryParse(k, out numericValue);
  int z = int.Parse(k.ToString());
  for (int i = 0; i<array.Length; i++) array[i] = array[i] * z;
  Console.WriteLine("Новый масштаб фигуры:");
  for (int i = 0; i<array.Length-1; i+=2) Console.Write($"({array[i]};{array[i+1]}) ");
}
catch
{
  double doubleValue;
  bool isDouble = double.TryParse(k, out doubleValue);
  double l = System.Convert.ToDouble(k.ToString());
  double[] newarray = new double [array.Length];
  for(int i = 0; i<array.Length; i++)
  {
    newarray[i] = double.Parse(array[i].ToString());
    newarray[i] = newarray[i] * l;
  }

  Console.WriteLine("Новый масштаб фигуры:");
  for (int i = 0; i < array.Length - 1; i += 2) Console.Write($"({newarray[i]};{newarray[i + 1]}) ");
}
}
*/


//Семинар 6.

/*
Console.WriteLine("Введите 2 числа, чтобы задать размерность массива");
int n = int.Parse(Console.ReadLine());
int m = int.Parse(Console.ReadLine());
int flag = 0;
Console.WriteLine("А теперь ПАЖАЛСТА введите ваше число");
int x = int.Parse(Console.ReadLine());
Random random = new Random();
int [,] matrix = new int [n,m];
for(int i = 0; i < matrix.GetLength(0); i++)
{
  for (int j = 0; j < matrix.GetLength(1); j++) 
  {
    matrix[i, j] = random.Next(0 , 9);
  } 

}



Console.WriteLine("Вот ваш массив");
for (int i = 0; i < matrix.GetLength(0); i++)
{
  for (int j = 0; j < matrix.GetLength(1); j++)
  {
    Console.Write(matrix[i,j]);
  }
  Console.WriteLine(" ");
}



int count = 0;

while(flag == 0 || count<matrix.GetLength(0)*matrix.GetLength(1))
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      if(matrix[i, j] == x)
      {
        Console.WriteLine($"Позиция числа в массиве строка: {i} | столбец: {j}");
        flag = 1;
        break;
      }
      else
      {
      count += 1;
      }
    if(flag==1) break;
  }
  }
Console.WriteLine(" ");

if(flag == 0) Console.WriteLine("Числа нет в массиве");




/*
Console.WriteLine("А теперь вот так!");

for (int i = 0; i < matrix.GetLength(0); i++)
{
  for (int j = 0; j < matrix.GetLength(1); j++)
  {
    if(matrix[i, j] % 2 == 0) matrix [i, j] = matrix[i, j] * -1;
    Console.Write($"{matrix[i,j]} ");
  }
  Console.WriteLine();
}
*/


//Домашнее задание к семинару 6.

//Задание 1. Заполнить двумерный массив, размером NxM вещественными числами.

/*
Console.WriteLine("Введите 2 числа: размерность массива");
int n = int.Parse(Console.ReadLine());
int m = int.Parse(Console.ReadLine());

Random random = new Random();
double[,] matrix = new double[n, m];

for (int i = 0; i < matrix.GetLength(0); i++)
{
  for (int j = 0; j < matrix.GetLength(1); j++)
  {
    matrix[i, j] = Math.Round(random.NextDouble()*random.Next(-10, 10),2);
  }

}

Console.WriteLine("А вот и ваш массивчик!");
for (int i = 0; i < matrix.GetLength(0); i++)
{
  for (int j = 0; j < matrix.GetLength(1); j++)
  {
    Console.Write($"{matrix[i,j]} ");
  }
  Console.WriteLine("");

}
*/


//Задание 2. Задать двумерный массив следующим правилом: Aₘₙ = m+n
//Если считать с нуля, как принято в программировании
//Если считать с единицы (присваивая 0 позиции 1, то все аналогично, но формула = m+n+1)

/*
Console.WriteLine("Введите 2 числа: размерность массива");
int n = int.Parse(Console.ReadLine());
int m = int.Parse(Console.ReadLine());

int[,] matrix = new int[n, m];

for (int i = 0; i < matrix.GetLength(0); i++)
{
  for (int j = 0; j < matrix.GetLength(1); j++)
  {
    matrix[i, j] = j+i;
  }

}

Console.WriteLine("А вот и ваш массивчик!");
for (int i = 0; i < matrix.GetLength(0); i++)
{
  for (int j = 0; j < matrix.GetLength(1); j++)
  {
    Console.Write($"{matrix[i, j]} ");
  }
  Console.WriteLine("");

}
*/


//Задание 3. В двумерном массиве заменить элементы, у которых оба индекса чётные на их квадраты

/*
Console.WriteLine("Введите 2 числа: размерность массива");
int n = int.Parse(Console.ReadLine());
int m = int.Parse(Console.ReadLine());

Random random = new Random();
int[,] matrix = new int[n, m];

for (int i = 0; i < matrix.GetLength(0); i++)
{
  for (int j = 0; j < matrix.GetLength(1); j++)
  {
    matrix[i, j] = random.Next(0,9);
  }

}

Console.WriteLine("А вот и ваш массивчик!");
for (int i = 0; i < matrix.GetLength(0); i++)
{
  for (int j = 0; j < matrix.GetLength(1); j++)
  {
    Console.Write($"{matrix[i, j]} ");
  }
  Console.WriteLine("");

}

Console.WriteLine("А теперь меняем значения, элементов с четными индексами");

for (int i = 0; i < matrix.GetLength(0); i++)
{
  for (int j = 0; j < matrix.GetLength(1); j++)
  {
    if(i % 2 == 0 && j % 2 == 0) matrix[i,j] = matrix[i,j] * matrix[i,j];
  }

}

Console.WriteLine("\nИзмененный массив!");
for (int i = 0; i < matrix.GetLength(0); i++)
{
  for (int j = 0; j < matrix.GetLength(1); j++)
  {
    Console.Write($"{matrix[i, j]} ");
  }
  Console.WriteLine("");

}
*/


//Задание 4. Написать программу, которая обменивает элементы первой строки и последней строки.

/*
Console.WriteLine("Введите 2 числа: размерность массива");
int n = int.Parse(Console.ReadLine());
int m = int.Parse(Console.ReadLine());

Random random = new Random();
int[,] matrix = new int[n, m];

for (int i = 0; i < matrix.GetLength(0); i++)
{
  for (int j = 0; j < matrix.GetLength(1); j++)
  {
    matrix[i, j] = random.Next(0, 9);
  }

}

Console.WriteLine("А вот и ваш массивчик!");
for (int i = 0; i < matrix.GetLength(0); i++)
{
  for (int j = 0; j < matrix.GetLength(1); j++)
  {
    Console.Write($"{matrix[i, j]} ");
  }
  Console.WriteLine("");

}


Console.WriteLine("\nА теперь изменяем массив, меняя местами элементы первой и последней строки");
for(int j = 0; j<m; j++)
{
  int temp = matrix[0, j];
  matrix[0, j] = matrix[matrix.GetLength(0)-1, j];
  matrix[matrix.GetLength(0)-1, j] = temp;
}

Console.WriteLine("\nИзмененный массив");

for (int i = 0; i < matrix.GetLength(0); i++)
{
  for (int j = 0; j < matrix.GetLength(1); j++)
  {
    Console.Write($"{matrix[i, j]} ");
  }
  Console.WriteLine("");
}
*/


//Семинар 7

/*
Console.WriteLine("Введите 2 числа: размерность массива");
int n = int.Parse(Console.ReadLine());
int m = int.Parse(Console.ReadLine());

Random random = new Random();
int[,] matrix = new int[n, m];

for (int i = 0; i < matrix.GetLength(0); i++)
{
  for (int j = 0; j < matrix.GetLength(1); j++)
  {
    matrix[i, j] = random.Next(0, 9);
  }
}

Console.WriteLine("А вот и ваш массивнчик");

for (int i = 0; i < matrix.GetLength(0); i++)
{
  for (int j = 0; j < matrix.GetLength(1); j++)
  {
    Console.Write($"{matrix[i,j]} ");
  }
  Console.WriteLine("");
}

int res = 0;

for (int i = 0; i < matrix.GetLength(0); i++)
{
  for (int j = 0; j < matrix.GetLength(1); j++)
  {
    if(i == j) res+=matrix[i,j];
  }
}

for (int i = 0; i < matrix.GetLength(0); i++)
{
  res+=matrix[i,i];
}


Console.WriteLine($"Сумма элементов главной диагонали равна: {res}");

*/

//Домашнее задание к семинару 7.
//Задача 1. Написать программу, упорядочивания по убыванию элементы каждой строки двумерной массива.

/*
Console.WriteLine("Введите 2 числа: размерность массива");
int n = int.Parse(Console.ReadLine());
int m = int.Parse(Console.ReadLine());

Random random = new Random();
int[,] matrix = new int[n, m];

for (int i = 0; i < matrix.GetLength(0); i++)
{
  for (int j = 0; j < matrix.GetLength(1); j++)
  {
    matrix[i, j] = random.Next(0, 9);
  }
}

Console.WriteLine("А вот и ваш массивнчик");

for (int i = 0; i < matrix.GetLength(0); i++)
{
  for (int j = 0; j < matrix.GetLength(1); j++)
  {
    Console.Write($"{matrix[i, j]} ");
  }
  Console.WriteLine("");
}

Console.WriteLine("-----------------------------------------------");
Console.WriteLine("Решение");
Console.WriteLine("-----------------------------------------------");

int[] tempmatrix = new int[n];


for (int i = 0; i < matrix.GetLength(0); i++)
{
  for (int j = 0; j < matrix.GetLength(1); j++)
  {
    tempmatrix[j] = matrix[i,j];
  }
for (int z = 0; z < tempmatrix.LongLength; z++)
    for (int j = 0; j < tempmatrix.Length-1; j++)
    {
      if (tempmatrix[j] > tempmatrix[j+1])
      {
        int temp = tempmatrix[j+1];
        tempmatrix[j+1] = tempmatrix[j];
        tempmatrix[j] = temp;
      }
    }
  for (int x = 0; x < tempmatrix.Length; x++) Console.Write($"{tempmatrix[x]} ");
  Console.WriteLine("");
  }

*/


//Задание 2. Написать программу, которая в двумерном массиве заменяет строки на столбцы или сообщить, что это невозможно (в случае, если матрица не квадратная).

/*
Console.WriteLine("Введите 2 числа: размерность массива");
int n = int.Parse(Console.ReadLine());
int m = int.Parse(Console.ReadLine());

if (n!=m) Console.WriteLine("Это невозможно!");
else
{
Random random = new Random();
int[,] matrix = new int[n, m];

for (int i = 0; i < matrix.GetLength(0); i++)
{
  for (int j = 0; j < matrix.GetLength(1); j++)
  {
    matrix[i, j] = random.Next(0, 9);
  }
}

Console.WriteLine("А вот и ваш массивнчик");

for (int i = 0; i < matrix.GetLength(0); i++)
{
  for (int j = 0; j < matrix.GetLength(1); j++)
  {
    Console.Write($"{matrix[i, j]} ");
  }
  Console.WriteLine("");
}

Console.WriteLine("-----------------------------------------------");
Console.WriteLine("Решение");
Console.WriteLine("-----------------------------------------------");

  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      Console.Write($"{matrix[j, i]} ");
    }
    Console.WriteLine("");
  }
}
*/


//Задание 3.В прямоугольной матрице найти строку с наименьшей суммой элементов.

/*
Console.WriteLine("Введите 2 числа: размерность массива");
int n = int.Parse(Console.ReadLine());
int m = int.Parse(Console.ReadLine());

Random random = new Random();
int[,] matrix = new int[n, m];

for (int i = 0; i < matrix.GetLength(0); i++)
{
  for (int j = 0; j < matrix.GetLength(1); j++)
  {
    matrix[i, j] = random.Next(0, 9);
  }
}

Console.WriteLine("А вот и ваш массивнчик");

int summa = 0;
int [] arr = new int[n];

for (int i = 0; i < matrix.GetLength(0); i++)
{
  for (int j = 0; j < matrix.GetLength(1); j++)
  {
    Console.Write($"{matrix[i, j]} ");
    summa += matrix[i,j];
  }
  Console.Write($"Сумма элементов строки ===>>> __{summa}__");
  arr[i] = summa;
  Console.WriteLine("");
  summa = 0;
}

int res = 0;
int minimal = 9999999;

for (int i = 0; i < arr.Length; i++)
{
  if (arr[i] < minimal)
  {
    minimal = arr[i];
    res = i;
  }
}

Console.WriteLine($"Строка с наименьшей суммой элементов: {res}");
*/

//Метод создания массива
/*
int [,] MakeArray()
{
  Console.WriteLine("Введите 2 числа: размерность массива");
  int n = int.Parse(Console.ReadLine());
  int m = int.Parse(Console.ReadLine());

  Random random = new Random();
  int[,] matrix = new int[n, m];

  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      matrix[i, j] = random.Next(0, 9);
    }
  }
  return matrix;
}

int [,] matrix = MakeArray();
*/

//Семинар 8



/*

Составить частотный словарь элементов двумерного массива

Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.

Пример: Есть набор данных

{ 1, 9, 9, 0, 2, 8, 0, 9 }

частотный массив может быть представлен так:

0 встречается 2 раза
1 встречается 1 раз
2 встречается 1 раз
8 встречается 1 раз
9 встречается 3 раза

Если набор данных - таблица

1, 2, 3
4, 6, 1
2, 1, 6

на выходе ожидаем получить

1 встречается 3 раза
2 встречается 2 раз
3 встречается 1 раз
4 встречается 1 раз
6 встречается 2 раза

Пример частотного массива для текстовых данных: Входные данные:

Частотный анализ – это один из методов криптоанализа, основывающийся на предположении о существовании нетривиального статистического распределения отдельных символов и их последовательностей как в открытом тексте, так и шифрованном тексте, которое с точностью до замены символов будет сохраняться в процессе шифрования и дешифрования.
Символ я встречается 6 раз.   Частота 1.80%
Символ м встречается 6 раз.   Частота 1.80%
Символ ь встречается 5 раз.   Частота 1.50%
Символ ы встречается 5 раз.   Частота 1.50%
Символ з встречается 4 раза.  Частота 1.20%
Символ х встречается 3 раза.  Частота 0.90%
Символ ш встречается 3 раза.  Частота 0.90%
Символ ф встречается 3 раза.  Частота 0.90%
Символ ч встречается 3 раза.  Частота 0.90%
Символ й встречается 3 раза.  Частота 0.90%
Символ , встречается 3 раза.  Частота 0.90%
Символ щ встречается 2 раза.  Частота 0.60%
Символ ю встречается 2 раза.  Частота 0.60%
Символ у встречается 2 раза.  Частота 0.60%
Символ г встречается 2 раза.  Частота 0.60%
Символ ж встречается 1 раз.   Частота 0.30%
Символ э встречается 1 раз.   Частота 0.30%
Символ – встречается 1 раз.   Частота 0.30%
Символ б встречается 1 раз.   Частота 0.30%
Символ ц встречается 1 раз.   Частота 0.30%
Символ . встречается 1 раз.   Частота 0.30%
*/



//Задача 1 на одномерном массиве

/*
Random random = new Random();
int [] array = new int [30];
for (int i = 0; i<array.Length; i++) array[i] = new Random().Next(0,9);
Console.WriteLine("А вот и массив");
for (int i = 0; i < array.Length; i++) Console.Write($"{array[i]} ");


Array.Sort(array);
Console.WriteLine("");
for (int i = 0; i < array.Length; i++) Console.Write($"{array[i]} ");
Console.WriteLine("");


string x = String.Empty;
int counter = 1;

for (int i = 0; i < array.Length-1; i++)
{
  if (array[i] == array[i+1]) counter += 1;
  else
  {
    x+= $"Элемент {array[i].ToString()}";
    x+= " встречается ";
    x+= counter.ToString();
    x+= "\n";
    counter = 1;
  }
}

counter = 1;

Array.Reverse(array);
for (int i = 0; i < array.Length - 1; i++)
{
  if (array[i] == array[i + 1]) counter += 1;
  else
  {
    x += $"Элемент {array[i].ToString()}";
    x += " встречается ";
    x += counter.ToString();
    x += " ";
    counter = 1;
    break;
  }
}


string[] res = x.Split(" ");
for (int i = 0; i<res.Length; i++) Console.Write($"{res[i]} ");
*/

//Задача 2 на двумерном массиве

/*

int[,] MakeArray()
{
  Console.WriteLine("Введите 2 числа: размерность массива");
  int n = int.Parse(Console.ReadLine());
  int m = int.Parse(Console.ReadLine());

  Random random = new Random();
  int[,] matrix = new int[n, m];

  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      matrix[i, j] = random.Next(0, 9);
    }
  }
  return matrix;
}

int[,] matrix = MakeArray();
int coun = 0;

for (int i = 0; i<matrix.GetLength(0); i++)
{
  for (int j = 0; j<matrix.GetLength(1); j++)
  {
    Console.Write($"{matrix[i,j]} ");
    coun += 1;
  }
  Console.WriteLine("");
}


int[] array = new int[coun];
int counNewMaasive = 0;

for (int i = 0; i < matrix.GetLength(0); i++)
{
  for (int j = 0; j < matrix.GetLength(1); j++)
  {
    array[counNewMaasive] = matrix[i,j];
    counNewMaasive += 1;
  }
}




Array.Sort(array);
Console.WriteLine("");
for (int i = 0; i < array.Length; i++) Console.Write($"{array[i]} ");
Console.WriteLine("");


string x = String.Empty;
int counter = 1;

for (int i = 0; i < array.Length - 1; i++)
{
  if (array[i] == array[i + 1]) counter += 1;
  else
  {
    x += $"Элемент {array[i].ToString()}";
    x += " встречается ";
    x += counter.ToString();
    x += "\n";
    counter = 1;
  }
}

counter = 1;

Array.Reverse(array);
for (int i = 0; i < array.Length - 1; i++)
{
  if (array[i] == array[i + 1]) counter += 1;
  else
  {
    x += $"Элемент {array[i].ToString()}";
    x += " встречается ";
    x += counter.ToString();
    x += " ";
    counter = 1;
    break;
  }
}


string[] res = x.Split(" ");
for (int i = 0; i < res.Length; i++) Console.Write($"{res[i]} ");

*/


//Задача 3 на строках


/*
string text = Console.ReadLine();
string[]x = text.Split(" ");
string newx = string.Join("",x);
Console.WriteLine(newx);

string res = string.Empty;

for (int i = 0; i<newx.Length; i++) res += newx[i].ToString().ToLower();

Console.WriteLine(res);

string [] array = new string [res.Length];
for (int i = 0; i<res.Length; i++) array[i] = res[i].ToString();

Array.Sort(array);


Console.WriteLine("----Решение---------");


string tempx = String.Empty;
int counter = 1;

for (int i = 0; i < array.Length - 1; i++)
{
  if (array[i] == array[i + 1]) counter += 1;
  else
  {
    tempx += $"Элемент {array[i]}";
    tempx += " встречается ";
    tempx += counter.ToString();
    tempx += " Частота элемента = ";
    tempx += (counter % array.Length).ToString();
    tempx += "% ";
    tempx += "\n";
    counter = 1;
  }
}

counter = 1;

Array.Reverse(array);
for (int i = 0; i < array.Length - 1; i++)
{
  if (array[i] == array[i + 1]) counter += 1;
  else
  {
    tempx += $"Элемент {array[i]}";
    tempx += " встречается ";
    tempx += counter.ToString();
    tempx += " Частота элемента = ";
    tempx += (counter % array.Length).ToString();
    tempx += "% ";
    counter = 1;
    break;
  }
}


string[] tempres = tempx.Split(" ");
for (int i = 0; i < tempres.Length; i++) Console.Write($"{tempres[i]} ");

*/


// Алгоритм на строках с пробелами и Большими буквами

/*
string text = Console.ReadLine();
string[] array = new string [text.Length];
for (int i = 0; i < text.Length; i++) array[i] = text[i].ToString();
for (int i = 0; i<array.Length; i++) Console.Write($"{array[i]} ");

Array.Sort(array);


Console.WriteLine("\n---------Решение---------");


string tempx = String.Empty;
int counter = 1;

for (int i = 0; i < array.Length - 1; i++)
{
  if (array[i] == array[i + 1]) counter += 1;
  else
  {
    tempx += $"Элемент {array[i]}";
    tempx += " встречается ";
    tempx += counter.ToString();
    tempx += ". Частота элемента = ";
    tempx += ((float)counter / array.Length*100).ToString();
    tempx += "% ";
    tempx += "\n";
    counter = 1;
  }
}

counter = 1;

Array.Reverse(array);
for (int i = 0; i < array.Length - 1; i++)
{
  if (array[i] == array[i + 1]) counter += 1;
  else
  {
    tempx += $"Элемент {array[i]}";
    tempx += " встречается ";
    tempx += counter.ToString();
    tempx += ". Частота элемента = ";
    tempx += ((float)counter / array.Length * 100).ToString();
    tempx += "% ";
    counter = 1;
    break;
  }
}


string[] tempres = tempx.Split(" ");
for (int i = 0; i < tempres.Length; i++) Console.Write($"{tempres[i]} ");
*/

//Домашнее задание к семинару 8.

//Задача 1. Найти произведение двух матриц

/*
Console.WriteLine("Создаем 2 матрицы: matrixA & matrixB\nПредпологается, что размерность матриц должна быть одинаковой, т.к. не сказано иного\n");

int[,] MakeArray(int n, int m)
{
  Random random = new Random();
  int[,] matrix = new int[n, m];

  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      matrix[i, j] = random.Next(0, 9);
    }
  }
  return matrix;
}

Console.WriteLine("Введите 2 числа: размерность массива");
int n = int.Parse(Console.ReadLine());
int m = int.Parse(Console.ReadLine());

int[,] matrixA = MakeArray(n, m);
int[,] matrixB = MakeArray(n, m);

Console.WriteLine("\nПечатаем обе матрицы");
Console.WriteLine("");

for (int i = 0; i < matrixA.GetLength(0); i++)
{
  for (int j = 0; j < matrixB.GetLength(1); j++)
  {
    Console.Write($"{matrixA[i,j]} ");
  }
  Console.WriteLine(" ");
}

Console.WriteLine("");

for (int i = 0; i < matrixA.GetLength(0); i++)
{
  for (int j = 0; j < matrixB.GetLength(1); j++)
  {
    Console.Write($"{matrixB[i,j]} ");
  }
  Console.WriteLine(" ");
}

Console.WriteLine("\n__________________Решение__________________\n");

int[,] matrixC = new int[n, m];
for (int i = 0; i < matrixA.GetLength(0); i++)
{
  for (int j = 0; j < matrixA.GetLength(1); j++) matrixC[i,j] = matrixA[i,j] * matrixB[i,j];
}


for (int i = 0; i < matrixA.GetLength(0); i++)
{
  for (int j = 0; j < matrixA.GetLength(1); j++) 
  {
  Console.Write($"{matrixC[i,j]} ");
  }
  Console.WriteLine("");
}
Console.WriteLine("");

*/


//Задание 2. В двумерном массиве целых чисел. Удалить строку и столбец, на пересечении которых расположен наименьший элемент.

/*
int[,] MakeArray()
{
  Console.WriteLine("Введите 2 числа: размерность массива");
  int n = int.Parse(Console.ReadLine());
  int m = int.Parse(Console.ReadLine());

  Random random = new Random();
  int[,] matrix = new int[n, m];

  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      matrix[i, j] = random.Next(-100, 999);
    }
  }
  return matrix;
}

int[,] matrix = MakeArray();

Console.WriteLine("\nПечатаем массив\n");

for (int i = 0; i < matrix.GetLength(0); i++)
{
  for (int j = 0; j < matrix.GetLength(1); j ++)
  {
    Console.Write($"{matrix[i,j]} ");
  }
  Console.WriteLine("");
}

int len = 0;
int hight = 0;
int minnum = matrix[0,0];

for (int i = 0; i < matrix.GetLength(0); i++)
{
  for (int j = 0; j < matrix.GetLength(1); j++)
  {
    if (matrix[i,j] < minnum)
    {
      minnum = matrix[i,j];
      len = i;
      hight = j;
    }
  }
}

Console.WriteLine($"\nНаименьший элемент массива {minnum} располагается в строке {len} столбце {hight}\n");
Console.WriteLine("\n__________________Решение__________________\n");

for (int i = 0; i < matrix.GetLength(0); i++)
  if (i == len) continue;
  else{
{
  for (int j = 0; j < matrix.GetLength(1); j++)
  if (j == hight) continue;
  else
  {
  {
    Console.Write($"{matrix[i, j]} ");
  }
  }
  Console.WriteLine("");
}
}

*/

//Задание 3. Сформировать трехмерный массив не повторяющимися двузначными числами показать его построчно на экран выводя индексы соответствующего элемента

/*
bool validationelement(int num, int [,,] matrix)
{
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      for (int k = 0; k < matrix.GetLength(2); k++)
      {
        if (matrix[i,j,k] == num) return false;
      }
    }
  }
  return true;
}


int recursionvalidate(int [,,] matrix)
{
  Random random = new Random();
  int x = random.Next(10,99);
  if (validationelement(x, matrix) == false)
  return recursionvalidate(matrix);
  else return x;
}





int [,,] MakeArray()
{
  Console.WriteLine("Введите 3 числа: размерность массива\nВнимание!!! Максимальное кол-во уникальных элементов не может превышать 89 штук!!! Иначе будет перегрузка системы!!!");
  int n = int.Parse(Console.ReadLine());
  int m = int.Parse(Console.ReadLine());
  int z = int.Parse(Console.ReadLine());

  Random random = new Random();
  int[,,] matrix = new int[n, m, z];

  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      for (int k = 0; k < matrix.GetLength(2); k++)
      {
       matrix[i,j,k] = recursionvalidate(matrix); 
      }
    }
  }
  return matrix;
}

int [,,] matrix = MakeArray();

Console.WriteLine("\nПопробуем вывести массив\n");

for (int i = 0; i < matrix.GetLength(0); i++)
{
  Console.WriteLine("***");
  for (int j = 0; j < matrix.GetLength(1); j++)
  {
    for (int k = 0; k < matrix.GetLength(2); k++)
    {
      Console.Write($"{matrix[i, j, k]} ");
    }
    Console.WriteLine("");
  }
  Console.WriteLine("***\n");
}

Console.WriteLine("Покажем все элементы на своих позициях\n");


for (int i = 0; i < matrix.GetLength(0); i++)
{
  for (int j = 0; j < matrix.GetLength(1); j++)
  {
    for (int k = 0; k < matrix.GetLength(2); k++)
    {
      Console.WriteLine($"Элемент под индексом {i},{j},{k} -->  {matrix[i, j, k]} ");
    }
  }
}

Console.WriteLine("\nУбедимся в том, что у нас нет повторяющихся значений\n");

int size = matrix.GetLength(0) * matrix.GetLength(1) * matrix.GetLength(2);
int [] array = new int [size];
int coun = 0;
for (int i = 0; i < matrix.GetLength(0); i++)
{
  for (int j = 0; j < matrix.GetLength(1); j++)
  {
    for (int k = 0; k < matrix.GetLength(2); k++)
    {
      array[coun] = matrix[i,j,k];
      coun += 1;
    }
  }
}

Array.Sort(array);

for (int i = 0; i < array.Length; i++) Console.Write($"{array[i]} ");
*/


//Задание 4. Показать треугольник Паскаля *Сделать вывод в виде равнобедренного треугольника

/*
Console.WriteLine("Введите высоту (ширину основания треугольника)");

int plat = int.Parse(Console.ReadLine());
int counter = plat-2;


Console.WriteLine("\nПолучается такой треугольник\n");
for (int i = 0; i < plat; i++)
{
  for (int j = 0; j < plat; j++)
  {
    if (j <= counter)
    {
      Console.Write(" ");
    }
    else Console.Write($"* ");
  }
  Console.WriteLine("");
  counter -= 1;
}
Console.WriteLine("");

*/


//Семинар 9.

//Задача 1. Вывод числа от 1 до N включительно.

/*
void recursion(int n)

{ 
  if(n==0) return; 
  recursion(n-1);
  Console.WriteLine(n);
}

recursion(int.Parse(Console.ReadLine()));
*/

/*
int sumrec(int n)
{
  int res = 0;
  void recursion(int x)
  {
    if(x==0) return;
    res += x%10;
    recursion(x/10);
  }
  recursion(n);
  return res;
}

Console.WriteLine(sumrec(int.Parse(Console.ReadLine())));
*/

//----------------------------------------------------------------------------

/*
int recursion(int a, int b)
{
  int res = a;
  int rec(int a, int b)
    {
      if(b==1)return a;
      res *= a;
      return rec(a, b-1);
    }
  rec(a,b);
  return res;
}
*/

/*
int recursion(int a, int b)
{
  if(b==0)return 1;
  return a * recursion(a, b-1);
}

Console.WriteLine($"Введите число и степень: ");
int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());

Console.WriteLine(recursion(a, b));
*/

//-----------------------------------------------------------------------------