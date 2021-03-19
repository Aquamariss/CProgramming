using System;


namespace Calendar
{ 
    class CalendarProgram
    {
        static void Main2(string[] args)
        {
            int digit = 0;
            bool continuer = true;

            string[] monthsNames = { "Janvier", "Février", "Mars", "Avril", "May", "Juin", "July", "Août", "Septembre", "October", "Novembre", "Decembre" };

            do
            {
                Console.WriteLine("Saisiz le numéro do mois (Pour quitter - 100): ");
                digit = int.Parse(Console.ReadLine());

                if (digit == 100)
                {
                    continuer = false; break;
                }
                else if (digit < 13)
                {
                    Console.WriteLine("Le mois est: " + monthsNames[digit-1]);
                }
                else
                {
                    Console.Write("Il n'existe pas de mois numéro: " + digit);
                }

            }
            while (continuer);
        }
    }
}
