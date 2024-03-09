using System;


class krozmus_1
{

    enum EFiguraGeometryczna
    {
        Trojkat,
        Prostokat,
        Kwadrat,
        Kolo
    }


    static void LiczPoleObwodFigury(out double obwod, out double pole, EFiguraGeometryczna figura = EFiguraGeometryczna.Trojkat)
    {
        obwod = 0;
        pole = 0;
        double a = 0, b = 0, c = 0, p = 0;

        switch (figura)
        {
            case EFiguraGeometryczna.Trojkat:
                Console.Write("Podaj wartość boku a: ");
                Double.TryParse(Console.ReadLine(), out a);
                Console.Write("Podaj wartość boku b: ");
                Double.TryParse(Console.ReadLine(), out b);
                Console.Write("Podaj wartość boku c: ");
                Double.TryParse(Console.ReadLine(), out c);

                obwod = a + b + c;
                p = (a + b + c) / 2;
                pole = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
                break;

            case EFiguraGeometryczna.Prostokat:
                Console.Write("Podaj wartość boku a: ");
                Double.TryParse(Console.ReadLine(), out a);
                Console.Write("Podaj wartość boku b: ");
                Double.TryParse(Console.ReadLine(), out b);

                obwod = a + b + a + b;
                pole = a * b;
                break;

            case EFiguraGeometryczna.Kwadrat:
                Console.Write("Podaj wartość boku a: ");
                Double.TryParse(Console.ReadLine(), out a);

                obwod = a * 4;
                pole = a * a;
                break;

            case EFiguraGeometryczna.Kolo:
                Console.Write("Podaj wartość promienia r: ");
                Double.TryParse(Console.ReadLine(), out a);

                obwod = 2 * Math.PI * a;
                pole = Math.PI * (a * a);
                break;
        }

    }

    static void Main()
    {
        double obwod = 0;
        double pole = 0;

        LiczPoleObwodFigury(out obwod, out pole, EFiguraGeometryczna.Trojkat);
        Console.WriteLine("Obwód twojej figury wynosi {0}\nPole twojej figury wynosi {1}", obwod, pole);
    }

}