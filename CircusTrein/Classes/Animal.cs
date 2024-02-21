
namespace CircusTrein.Classes
{
   public class Animal
    {
        public int Punten;
        public string Diet {  get; set; }
        
        public Animal(string size, string diet)
        {
            if (size == "Smoll") { Punten = 1; }
            if (size == "Medium") { Punten = 3; }
            if (size == "Large") { Punten = 5; }

            Diet = diet;
        }

        


    }
}
