Console.WriteLine("vvedite chislo:");
int a =Convert.ToInt32(Console.ReadLine());
int number3=a%10;
if(a>99 && a<1000)
{
    Console.WriteLine(number3);
}
else
{
    if(a<100)
    {
        Console.WriteLine("v dannom chisle net 3 cifri");
    }
    else
    {
    while(a>=1000)
    {
        a=a/10;
    }
    number3=a%10;
    Console.WriteLine(number3);
    }
   
}




