using System;


namespace Voyage
{ 
    class VoyageProgram
    {
        static void Main(string[] args)
        {
            char direction;
            bool continuer = true;
            int x = 0, y=0;
            int limitPoints = 10;

            string Path = "";

            for (int i=0; i<limitPoints; i++)
            {
                Console.WriteLine("Saisiz le symbol de direction: N/n, S/s, E/e, O/o (Pour quitter - x): ");
                direction = char.ToLower(char.Parse(Console.ReadLine()));

                switch (direction)
                {
                    case 'x' : continuer = false; break;
                    case 'n' : x = x+1; break;
                    case 's' : x = x-1; break;
                    case 'o' : y = y+1; break;
                    case 'e' : y = y-1; break;
                    default: { Console.WriteLine("There is no such direction!"); break; }
                }
                Path = Path + "" + direction + ", ";
                Console.WriteLine(Path + ", x=" + x + ", y=" + y);
                if (!(continuer) ) break;
              
            }
            float distance;
            distance = (float) Math.Sqrt(x*x+y*y);

            Console.WriteLine("The Path is: " + Path + ". X="+x+", Y="+y+". The distance is: " +distance);
        }
    }
}
