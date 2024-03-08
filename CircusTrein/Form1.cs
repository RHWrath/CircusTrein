using CircusTrein.Classes;

namespace CircusTrein
{
    public partial class Form1 : Form
    {
        public List<Animal> animals;
        public Train Train = new Train();
        private bool SuccesFullyAdded = false;
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            FillUIElement();
            animals = new();
        }


        private void AddAnimal_Click(object sender, EventArgs e)
        {
            Animal NewAnimal = new Animal((CustomEnum.SizePoints)comboBoxSize.SelectedItem, (CustomEnum.Diet)comboBoxDiet.SelectedItem);
            animals.Add(NewAnimal);
            AnimalListTxt.Text +=  NewAnimal.SizePoints + " - " + NewAnimal.Diet + Environment.NewLine;

        }



        private void CalculateAnimal_Click(object sender, EventArgs e)
        {
            animals = animals.OrderByDescending(o => (int)o.SizePoints).ToList();
            
            foreach (var animal in animals)
            {
                SuccesFullyAdded = false;
                if (Train.AantalWagens == 0)
                {
                    Train.CreateWagon(animal);
                    
                } else
                {   
                    foreach (var wagen in Train.wagons)
                    {
                        if ((int)animal.Diet == 1)
                        {
                            if (wagen.CarnivorePresent == false && wagen.SmallestHerbivoreSize > (int)animal.SizePoints && wagen.RoomInWagon(animal) == true)
                            {
                                wagen.WagenCurrentCapiciteit = +(int)animal.SizePoints;
                                wagen.CarnivorePresent = true;
                                wagen.CarnivoreSize = (int)animal.SizePoints;
                                SuccesFullyAdded = true;
                                break;
                            }
                        }
                        else
                        {
                            if ((int)animal.Diet == 2)
                            {
                                if (wagen.RoomInWagon(animal) == true && wagen.CarnivorePresent == false)
                                {
                                    wagen.WagenCurrentCapiciteit = +(int)animal.SizePoints;
                                    if (wagen.SmallestHerbivoreSize >= (int)animal.SizePoints)
                                    {
                                        wagen.SmallestHerbivoreSize = (int)animal.SizePoints;
                                    }
                                    SuccesFullyAdded = true;
                                    break;
                                }
                                else if (wagen.CarnivorePresent == true && (int)animal.SizePoints > wagen.CarnivoreSize && wagen.RoomInWagon(animal) == true)
                                {
                                    wagen.WagenCurrentCapiciteit = +(int)animal.SizePoints;
                                    if (wagen.SmallestHerbivoreSize >= (int)animal.SizePoints)
                                    {
                                        wagen.SmallestHerbivoreSize = (int)animal.SizePoints;
                                    }
                                    SuccesFullyAdded = true;
                                    break;
                                }
                            }
                            if (SuccesFullyAdded == true)
                            {
                                break;
                            }
                        }
                    }
                    if (!SuccesFullyAdded)
                    {
                        Train.CreateWagon(animal);
                    }
                }
                
            }
            WagensTxt.Text = Train.wagons.Count.ToString();
        }

        private void ClearWagon_Click(object sender, EventArgs e)
        {
            Train.wagons.Clear();
            WagensTxt.Text = string.Empty;
        }

        private void ClearAnimalListButton_Click(object sender, EventArgs e)
        {
            animals.Clear();
            AnimalListTxt.Text = string.Empty;
        }


        private void FillUIElement()
        {
            FillDietComboBox();
            FillSizeComboBox();
        }

        private void FillSizeComboBox()
        {
            CustomEnum.SizePoints[] sizePointsArray = (CustomEnum.SizePoints[])Enum.GetValues(typeof(CustomEnum.SizePoints));
            for (int i = 0; i < sizePointsArray.Length; i++)
            {
                comboBoxSize.Items.Add(sizePointsArray[i]);
            }
        }

        private void FillDietComboBox()
        {
            CustomEnum.Diet[] dietArray = (CustomEnum.Diet[])Enum.GetValues(typeof(CustomEnum.Diet));
            for (int i = 0; i < dietArray.Length; i++)
            {
                comboBoxDiet.Items.Add(dietArray[i]);
            }
        }

        

    }
}
