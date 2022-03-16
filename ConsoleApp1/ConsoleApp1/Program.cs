using System;

namespace ConsoleApp1

{
    class Program


    { static void Main(string[] args)


        { string Charactername = "subzero";

            int CharacterHeight = 2;

            string CharacterName = "Mario";

            int Characterspeed = 3;

            int subzeroage = 14;

            string superpower1 = "Fly";

            string superpower2 = "invisibility";

            string Charactername2 = "Mario";

            int Characterspeed2 = 3;

            int Marioage = 16;

            string superpower3 = "Fly";

            string superpower4 = "invisibility";
            if (subzeroage > Marioage)
            {
                Console.WriteLine("subzero is older");
            }
            else if (Marioage > subzeroage)
            {
                Console.WriteLine("Mario is older");
            }
            else
            {
                Console.WriteLine("Neither is older");
            }

        }
    }
}