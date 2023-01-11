// trying recursion - this func can evaluate n(a number) to grade x(a grading-number)

int rec(int n, int x)
{
  if (x == 0)
  {
    return 1;
  }
  else
  {
    return n * rec(n, x - 1);
  }
}

Console.Write(rec(3, 3));
