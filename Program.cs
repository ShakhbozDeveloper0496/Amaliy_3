//1 topshiriq

System.Console.Write("stringni kiriting: ");
string str = Console.ReadLine();

System.Console.Write("raqam kiriting: ");
int son = Convert.ToInt32(Console.ReadLine());

int firtsNum = Convert.ToInt32(str.Length);

string kattaHarf = str.ToUpper();
string kichikHarf = str.ToLower();

string solishtr = 
    firtsNum < son
        ?kattaHarf
        :kichikHarf;
System.Console.WriteLine(solishtr);

//2 topshiriq

int x = 15;
int y = 10;

if(x > y)
{
    System.Console.WriteLine("x is greeter than y");
}
else if(x < y)
{
    System.Console.WriteLine("x is less than y");
}
else if(x == y)
{
    System.Console.WriteLine("x is equal to y");
}
else
{
    System.Console.WriteLine("x and y are not comparable");
}

//3 topshiriq

System.Console.Write("Hafta kunini kiriting: ");
string day = Console.ReadLine();

string weekDay = day switch 
{
    "dushanba" => "Monday",
    "seshanba" => "Tuesday",
    "chorshanba" => "Wednesday",
    "payshanba" => "thursday",
    "juma" => "friday",
    "shanba" => "saturday",
    "yakshanba" => "sunday",
    _ => "there is not week day"
};
System.Console.WriteLine(weekDay);


