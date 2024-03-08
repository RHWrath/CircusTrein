
namespace CircusTrein.Classes
{
   public class Animal
    {
        public CustomEnum.SizePoints SizePoints { get; private set; }
        public CustomEnum.Diet Diet { get; private set; }
        public int Points;
        
        public Animal(CustomEnum.SizePoints size, CustomEnum.Diet diet)
        {
            SizePoints = size;
            Diet = diet;
            Points = (int)SizePoints;

        }

        


    }
}
