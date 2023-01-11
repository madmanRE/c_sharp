// Trying convers 10_number into 2_nimber

int a = 10;
double q = 0;
Console.Write(q);

while(a>0)
{
  q += a%2;
  a = a/2;
}

Console.Write(q);