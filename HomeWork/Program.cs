using HomeWork;

Console.WriteLine("Enter the car mark from this list");
Console.WriteLine("bmw\nford\nkia\naudi\nhonda\nopel");
string mark = Console.ReadLine();

Cars bmw = new Cars();
Cars ford = new Cars();
Cars kia = new Cars();
Cars audi = new Cars();
Cars honda = new Cars();
Cars opel = new Cars();


switch (mark)
{
    case "bmw":
        bmw.bmw();
        break;
    case "ford":
        ford.ford();
        break;
    case "kia":
        kia.kia();
        break;
    case "audi":
        audi.audi();
        break;
    case "honda":
        honda.honda();
        break;
    case "opel":
        opel.opel();
        break;
}