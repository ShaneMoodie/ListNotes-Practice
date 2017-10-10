using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3Day2_Lists_
{
    class Program
    {
        static void Main(string[] args)
        {
            //   //List always gets <> to define data type (int, string, double, ect.)
            ////class|data|nameoflist                    elements in list
            //   List<int> testScores = new List<int>() { 98, 100, 76, 84, 93 };
            //   testScores.Add(80);
            //   testScores.Add(99); //Adds elements to list

            //   List<int> luckyNumbers = new List<int>();
            //   luckyNumbers.Add(2);
            //   luckyNumbers.Add(3);
            //   luckyNumbers.Add(5);
            //   luckyNumbers.Add(7);
            //   Console.WriteLine(luckyNumbers.Count); //counts number of elements (4) in luckyNumbers

            //   List<string> faveFoods = new List<string>() { "Steak", "Baked Potatoes", "Tilapia", "Bacon", "Popcorn" };
            //   //Individually print each element in list
            //   Console.WriteLine(faveFoods[0]);
            //   Console.WriteLine(faveFoods[1]);
            //   Console.WriteLine(faveFoods[2]);
            //   Console.WriteLine(faveFoods[3]);
            //   Console.WriteLine(faveFoods[4]);

            //   List<string> grossFoods = new List<string>();
            //   grossFoods.Add("Mushrooms");
            //   grossFoods.Add("Stuffing");
            //   grossFoods.Add("Quinoa");
            //   Console.WriteLine(grossFoods[0]);
            //   //Below replaces element [0] with new element. Completely erases OG [0]. Mushrooms no longer exist.
            //   grossFoods[0] = "Definitely not pizza";
            //   Console.WriteLine(grossFoods[0]);

            //   //Loop through lists
            //   List<string> faveFilm = new List<string>() { "LOTR", "Hot Rod", "Zoolander", "Requiem for a Dream" };

            //   for (int i = 0; i < faveFilm.Count; i++)
            //   {
            //       Console.WriteLine(faveFilm[i]);
            //   }

            //   //Adds new elements to existing element numbers w/o replacing OG elements, moves existing ones up.
            //   faveFilm.Insert(0, "The Strangers");
            //   faveFilm.Insert(1, "Treasure Planet");
            //   faveFilm.Insert(2, "The Dark Knight");

            //   foreach (string film in faveFilm)
            //   {
            //       Console.WriteLine(film);
            //   }


            //   //removes FIRST AND ONLY FIRST instance of specified element
            //   faveFilm.Remove("The Strangers");
            //   foreach (string film in faveFilm)
            //   {
            //       Console.WriteLine(film);
            //   }



            //HW Problems
            List<string> animals = new List<string>();
            animals.Add("Sloth");
            animals.Add("Doggie");
            animals.Add("Kitty");
            animals.Add("Penguin");
            animals.Add("Red Panda");


            foreach (string animal in animals)
            {
                Console.WriteLine(animal);
            }

            List<bool> boolList = new List<bool>() { true, false, false, true, false };
            foreach (bool verily in boolList)
            {
                if (verily)
                {
                    Console.WriteLine("Better bring an umbrella.");
                }
                else
                {
                    Console.WriteLine("No rain today. Enjoy the sunshine!");
                }
            }

            List<int> randomNumbers = new List<int>() { 1, 23, 9, 77, 922, 6, 32, 63, 14, 5 };
            Console.WriteLine(randomNumbers.Contains(23));
            Console.WriteLine(randomNumbers.Contains(77));
            Console.WriteLine(randomNumbers.Contains(15));

            randomNumbers.Remove(27);
            randomNumbers.Remove(77);
            randomNumbers.Remove(34);
            randomNumbers.Remove(6);

            Console.WriteLine(randomNumbers.Contains(23));
            Console.WriteLine(randomNumbers.Contains(77));
            Console.WriteLine(randomNumbers.Contains(15));
        }
    }
}
