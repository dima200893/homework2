Console.WriteLine("Vvedite chislo :");
int a = Convert.ToInt32(Console.ReadLine());
int number=a%100;
int findNumber= number /10;
if(a>99 && a< 1000)
{
    Console.WriteLine(findNumber);
}
else
{
    Console.WriteLine("chislo ne 3x znachnoe, vvedite drugoe");
}