
namespace CircusTrein.Classes
{
   public class Animal
    {
        private string size;
        public int Punten 
        {
            get
            {
                if (size == "Smoll") { return 1; }
                if (size == "Medium") { return 3; }
                if (size == "Large") { return 5; }
                return 0;
            }
        }
        public string Diet {  get; set; }
        
        public Animal(string size, string diet)
        {
            this.size = size;
            Diet = diet;
        }

        bool AreCompatible(Animal animal)
        {
            if (Diet == "Carnievoor" && Punten >= animal.Punten) { return false; }
            if (animal.Diet == "Carnievoor" && animal.Punten >= Punten) { return false; }
            return true;
        }


    }
}
