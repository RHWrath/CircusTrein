using CircusTrein.Classes;

namespace CircusTrein
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public List<Animal> AnimalList = new();
        private List<Trein> TreinenList = new();
        public Trein NewTrein = new Trein();

        private void AddAnimal_Click(object sender, EventArgs e)
        {
            Animal NewAnimal = new Animal(comboBoxSize.SelectedItem.ToString(), comboBoxDiet.SelectedItem.ToString());
            AnimalList.Add(NewAnimal);
            AnimalListTxt.Text += comboBoxSize.SelectedItem.ToString() + " " + NewAnimal.Punten + " " + NewAnimal.Diet + Environment.NewLine;

        }



        private void CalculateAnimal_Click(object sender, EventArgs e)
        {
            if (AnimalList.Count > 0)
            {
                foreach (Animal NewAnimal in AnimalList)
                {
                    NewTrein.WagenCurrentCapiciteit = NewTrein.WagenCurrentCapiciteit + NewAnimal.Punten;

                    if (NewTrein.WagenMaxCapiciteit >= NewTrein.WagenCurrentCapiciteit)
                    {
                        NewTrein.WagenCurrentCapiciteit = NewTrein.WagenCurrentCapiciteit + NewAnimal.Punten;
                        WagensTxt.Text = NewTrein.AantalWagens.ToString();                        
                    }
                    else
                    {
                        NewTrein.AantalWagens++;
                        NewTrein.WagenCurrentCapiciteit = NewAnimal.Punten;
                        WagensTxt.Text = NewTrein.AantalWagens.ToString();                     

                    }
                }
            }
            else
            { WagensTxt.Text = "error"; }
        }

        private void ClearWagon_Click(object sender, EventArgs e)
        {
            NewTrein.AantalWagens = 1;
            WagensTxt.Text= "";
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            AnimalList.Clear();
            AnimalListTxt.Text = "";
        }
    }
}
