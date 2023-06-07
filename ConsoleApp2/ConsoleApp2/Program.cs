double fn;
double sn;
string o;
double answ;
Console.Clear();
Console.WriteLine("Первое число: ");
fn = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Действие %, *, /, +, - : ");
o = Convert.ToString(Console.ReadLine());

Console.WriteLine("Второе число: ");
sn = Convert.ToDouble(Console.ReadLine());
if (o == "+")
{

    answ = fn + sn;
    Console.WriteLine("Результат: " + answ);

}

if (o == "-")
{
    if (sn==38)
        Console.WriteLine("Любимое число автора");
    answ = fn - sn;
    Console.WriteLine("Результат: " + answ);

}

if (o == "*")
{

    answ = fn * sn;
    Console.WriteLine("Результат: " + answ);

}

if (o == "/")
{
    if (sn==0)
        Console.WriteLine("Делить на ноль нельзя");
    answ = fn / sn;
    Console.WriteLine("Результат: " + answ);

}

if (o == "%")
{

    answ = fn % sn;
    Console.WriteLine("Результат: " + answ);

}
