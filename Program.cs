namespace klassenarbeit
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //variablendeklaration
            double umsatzVorjahr;
            double umsatzAktuell;
            double umsatzentwicklung;
            bool schleife = true;

            //Programmschleife
            do
            {
                //Eingabe des Umsatzes aus dem Vorjahres und dem aktuellen Jahr
                System.Console.WriteLine("Umsatz aus dem Vorjahr eingeben:");
                umsatzVorjahr = Convert.ToDouble(Console.ReadLine());
                System.Console.WriteLine("Umsatz aus dem aktuellen Jahr eingeben:");
                umsatzAktuell = Convert.ToDouble(Console.ReadLine());

                //Berechnung und Rundung der Umsatzermittlung
                umsatzentwicklung = ((umsatzAktuell / umsatzVorjahr) - 1) * 100;

                System.Console.WriteLine("Umsatzentwicklung: " + umsatzentwicklung + "%");
                
                //Ausgabe der Meldung abhängig der Umsatzermittlung
                if (umsatzentwicklung < 0)
                {
                    System.Console.WriteLine("Woher kommt der Umsatzrückgang");
                }
                else if (umsatzentwicklung > 0 && umsatzentwicklung < 5)
                {
                    System.Console.WriteLine("mittelmäßige Umsatzentwicklung");
                }
                else if (umsatzentwicklung >= 5 && umsatzentwicklung < 7)
                {
                    System.Console.WriteLine("gute Umsatzentwicklung");
                }
                else if (umsatzentwicklung >= 7 && umsatzentwicklung < 10)
                {
                    System.Console.WriteLine("sehr gute Umsatzentwicklung");
                }
                else
                {
                    System.Console.WriteLine("top");
                }

                //Abfrage für neue Werte oder beenden des Progamms
                System.Console.WriteLine("Neue Eingabe? Drücke j");
                if(!Console.ReadLine().ToLower().Equals("j")){
                    schleife = false;
                    System.Console.WriteLine("Programm wird beendet");
                }

            } while (schleife);
        }
    }
}
