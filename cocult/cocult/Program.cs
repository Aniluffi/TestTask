using cocult;

class Program
{
    
    public static void Main()
    {
        double allSumP = 0;
        double allSumS = 0;
        while(true)
        {
            Console.WriteLine("\n1 - квадрат, вводим сторону одну" +
                "\n2 - прямоугольник, вводим два стороны" +
                "\n3 - Круг, вводим радиус" +
                "\n4 - треугольник, вводим три стороны" +
                "\n5 - вывести сумму всех периметров" +
                "\n6 - вывести сумму всех площадей" +
                "\n7 - выйти из программы\n");

            Console.WriteLine("Введите номер действия:");

            int numDeist = Convert.ToInt32(Console.ReadLine());

            switch (numDeist)
            {
                case 1:

                    Console.Clear();

                    Console.WriteLine("Введите сторону квадрата:");

                    double side = Convert.ToDouble(Console.ReadLine());

                    Square sq = new Square(side); 

                    Console.WriteLine("Вы желаете найти S(1) или P(2)");

                    int comand = Convert.ToInt32(Console.ReadLine());

                    if (comand == 1)
                    {
                        allSumS += sq.S();
                        Console.WriteLine($"S = {sq.S()}");
                    }
                    else if (comand == 2)
                    {
                        allSumP += sq.P();
                        Console.WriteLine($"P = {sq.P()}");
                    } 
                    
                    break;
                case 2:
                    Console.Clear();

                    Console.WriteLine("Введите сторону1 прямоугольника:"); 
                    double side1 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Введите сторону2 прямоугольника:");
                    double side2 = Convert.ToDouble(Console.ReadLine());

                    Rectangle rectangle = new Rectangle(side1,side2);

                    Console.WriteLine("Вы желаете найти S(1) или P(2)");

                    int comand1 = Convert.ToInt32(Console.ReadLine());

                    if (comand1 == 1)
                    {
                        allSumS += rectangle.S();
                        Console.WriteLine($"S = {rectangle.S()}");
                    }
                    else if (comand1 == 2)
                    {
                        allSumP += rectangle.P();
                        Console.WriteLine($"P = {rectangle.P()}");
                    }

                    break;
                case 3:

                    Console.Clear();

                    Console.WriteLine("Введите радиус круга:");

                    double radius = Convert.ToDouble(Console.ReadLine());

                    Circle cir = new Circle(radius);

                    Console.WriteLine("Вы желаете найти S(1) или P(2)");

                    int comand2 = Convert.ToInt32(Console.ReadLine());

                    if (comand2 == 1)
                    {
                        allSumS += cir.S();
                        Console.WriteLine($"S = {cir.S()}");
                    }
                    else if (comand2 == 2)
                    {
                        allSumP += cir.P();
                        Console.WriteLine($"P = {cir.P()}");
                    }

                    break;
                case 4:

                    Console.Clear();

                    Console.WriteLine("Введите сторону1 прямоугольника:");
                    double sideTring = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Введите сторону2 прямоугольника:");
                    double sideTring1 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Введите сторону3 прямоугольника:");
                    double sideTring2 = Convert.ToDouble(Console.ReadLine());

                    Triangle tr = new Triangle(sideTring, sideTring1,sideTring2);

                    Console.WriteLine("Вы желаете найти S(1) или P(2)");

                    int comand3 = Convert.ToInt32(Console.ReadLine());

                    if (comand3 == 1)
                    {
                        allSumS += tr.S();
                        Console.WriteLine($"S = {tr.S()}");
                    }
                    else if (comand3 == 2)
                    {
                        allSumP += tr.P();
                        Console.WriteLine($"P = {tr.P()}");
                    }

                    break;
                case 5:
                    Console.Clear();

                    Console.WriteLine($"Сумма всех P = {allSumP}");
                    break;
                case 6:

                    Console.Clear();

                    Console.WriteLine($"Сумма всех S = {allSumS}");
                    break;
                case 7:
                    Console.Clear();

                    Console.WriteLine($"Программа завершена!");
                    return;
                    break;
                default: Console.Clear();
                    Console.WriteLine("Ошибка при вводе!\n"); break; 

            }

        }
    }
}
