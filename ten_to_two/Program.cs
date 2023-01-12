// Trying convers 10_number into 2_nimber
using System.Linq;

int a = 10;
string q = "";
Console.Write(q);

while(a>0)
{
  int x = a%2;
  q += x.ToString();
  a = a/2;
}


char[] res = q.ToCharArray();
Array.Reverse(res);
Console.WriteLine(res);