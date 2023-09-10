class Geometrija
{
    static void Main(string[] args)
    {
        // Inicializē mainīgos
        double pi = 3.1415926;
        double R = 0;

        // Paprasa user inputu R mainīgajam, maina vērtību un izvada R

        Console.WriteLine("Ievadiet rinķa rādiusu:");
        R = double.Parse(Console.ReadLine());

        Console.WriteLine("Rādiuss R = " + R);


        // Aprēķina RLG un izvada

        double RLG = 2 * pi * R;
        Console.WriteLine("Riņķa Līnijas Garums = " + Math.Round(RLG, 5));

        // Aprēķina RL un izvada

        double RL = pi * R * R;
        Console.WriteLine("Riņķa Laukums = " + Math.Round(RL, 5));

        // Aprēķina LL un izvada

        double LL = 4 * pi * R * R;
        Console.WriteLine("Lodes Laukums = " + Math.Round(LL, 5));

        // Aprēķina LT un izvada 

        double LT = (4 * pi * Math.Pow(R,3)) / 3;
        Console.WriteLine("Lodes Tilpums = " + Math.Round(LT, 5));
        }
}