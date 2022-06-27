Console.WriteLine("vvedite chislo ot 1-7:");
int a =Convert.ToInt32(Console.ReadLine());
if(a<0 || a>7)
{
    Console.WriteLine("nevernii diapozon");
}
else
{
    if (a==6 ||a==7 )
    {
        Console.WriteLine("da");
    }
    else
    {   
        Console.WriteLine("net");
    }
}

