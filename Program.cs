using System;

namespace UnicamMath
{
    class Program
    {
        static void Main(string[] args)
        {
            //Primo cateto
            Console.WriteLine("Questo programma calcola l'ipotenusa e gli angoli interni fornendo la lunghezza di due cateti");
            double cateto1;
            Console.Write("Inserisci la lunghezza del primo cateto: ");
            bool cateto1pars = Double.TryParse(Console.ReadLine(), out cateto1);
            if(!cateto1pars){
                return;
            }
            //Secondo cateto
            double cateto2;
            Console.Write("Inserisci la lunghezza del secondo cateto: ");  
            bool cateto2pars = Double.TryParse(Console.ReadLine(), out cateto2);
            if(!cateto2pars){
                return;
            }
        
            //Ipotenusa si calcola con a^2+b^2 = c^2
            double ipotenusa = Math.Sqrt(Math.Pow(cateto1,2) + Math.Pow(cateto2,2));
            double angolo1 = 90;
            //Teorema dei seni
            double angolo2 = Math.Asin(cateto1*Math.Round(Math.Sin(angolo1))/ipotenusa)*180/Math.PI;
            //Somma totale degli angolo 180 => 180-angolo1 -angolo2
            double angolo3 = 180 - angolo1 -angolo2;

            Console.WriteLine($"L'ipotenusa misura {ipotenusa.ToString("N2")}");
            Console.WriteLine($"I tre angoli interni misurano {angolo1.ToString("N2")} gradi, {angolo2.ToString("N2")} gradi e {angolo3.ToString("N2")} gradi.");

            Console.ReadKey();
        }
    }
}
