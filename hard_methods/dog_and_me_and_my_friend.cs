
// Dog and me and my friend

int count = 0;
double distance = 10000;
double firsSpeed = 1;
double seconSpeed = 2;
double dogSpeed = 5;
int flag = 2;

while(distance > 10.0)
if(flag == 2)
{
  double time = distance/(seconSpeed+dogSpeed);
  flag = 1;
  distance = distance - (firsSpeed+seconSpeed)*time;
  count+=1;
}
else
{
  double time = distance / (firsSpeed + dogSpeed);
  flag = 2;
  distance = distance - (firsSpeed + seconSpeed) * time;
  count+=1;
  }


Console.Write("The dog has run ");
Console.Write(count);
Console.Write(" times");
