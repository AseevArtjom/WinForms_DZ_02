namespace WinForms_DZ_02
{
    public partial class BestOil : Form
    {
        double A98_cost = 6.40;
        double A95_cost = 6.20;
        double A92_cost = 5.80;
        double A80_cost = 5.00;
        double DT_cost = 4.40;
        double Gas_cost = 3.60;

        class Fuel
        {
            public string name { get; set; }
            public double cost;
            public Fuel(string name,double cost)
            {
                this.name = name;
                this.cost = cost;
            }
            public override string ToString()
            {
                return name;
            }
        }

        Fuel[] fuels;

        public BestOil()
        {
            InitializeComponent();

            comboBox1.Items.Add("A-98");
            comboBox1.Items.Add("A-95");
            comboBox1.Items.Add("A-92");
            comboBox1.Items.Add("A-80");
            comboBox1.Items.Add("ÄÒ");
            comboBox1.Items.Add("Ãàç");


            fuels = new Fuel[] {
            new Fuel(comboBox1.GetItemText(0),A98_cost),
            new Fuel(comboBox1.GetItemText(1),A95_cost),
            new Fuel(comboBox1.GetItemText(2),A92_cost),
            new Fuel(comboBox1.GetItemText(3),A80_cost),
            new Fuel(comboBox1.GetItemText(4),DT_cost),
            new Fuel(comboBox1.GetItemText(5),Gas_cost)
            };

            TextBox_Price_of_Coffe.Text = CoffeCost.ToString("N2");
            TextBox_Price_of_HotDog.Text = HotDogCost.ToString("N2");
            TextBox_Price_of_Fries.Text = FriesCost.ToString("N2");
            TextBox_Price_of_Crips.Text = CripsCost.ToString("N2");
            TextBox_Price_of_Cola.Text = ColaCost.ToString("N2");


        }


        private void FuelClick(object sender, EventArgs e)
        {
            textBox3.Text = "";
            textBox3.Enabled = false;
            textBox2.Enabled = true;
        }

        private void FuelSum_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            textBox2.Enabled = false;
            textBox3.Enabled = true;
        }

        private void Fuel_SelectedValueChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0) // A-98
            {
                textBox1.Text = fuels[0].cost.ToString("N2");
            }
            else if (comboBox1.SelectedIndex == 1) // A-95
            {
                textBox1.Text = fuels[1].cost.ToString("N2");
            }
            else if (comboBox1.SelectedIndex == 2) // A-92
            {
                textBox1.Text = fuels[2].cost.ToString("N2");
            }
            else if(comboBox1.SelectedIndex == 3) // A-80
            {
                textBox1.Text = fuels[3].cost.ToString("N2");
            }
            else if(comboBox1.SelectedIndex == 4) // DT
            {
                textBox1.Text = fuels[4].cost.ToString("N2");
            }
            else if(comboBox1.SelectedIndex == 5) // Gas
            {
                textBox1.Text = fuels[5].cost.ToString("N2");
            }
            CountOfFuelTextChanged(sender,e);
        }

        private void CountOfFuelTextChanged(object sender, EventArgs e)
        {
            double result = 0;

            double.TryParse(textBox2.Text, out double count);
            double.TryParse(textBox1.Text, out double cost);

            result = count * cost;
            FuelResultCost.Text = result.ToString("N2");
        }

        private void BestOil_Load(object sender, EventArgs e)
        {
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
        }



        // <CheckBoxs Cafe>
        private void CheckBox_of_Coffe_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBox_of_Coffe.Checked == true)
            {
                TextBox_Count_of_Coffe.Enabled = true;
            }
            else
            {
                TextBox_Count_of_Coffe.Text = "";
                TextBox_Count_of_Coffe.Enabled = false;
            }
        }
        private void CheckBox_of_HotDog_CheckedChanged(object sender, EventArgs e)
        {
            if(CheckBox_of_HotDog.Checked == true)
            {
                TextBox_Count_of_HotDog.Enabled = true;
            }
            else
            {
                TextBox_Count_of_HotDog.Text = "";
                TextBox_Count_of_HotDog.Enabled = false;
            }
        }
        private void CheckBox_of_Fries_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBox_of_Fries.Checked == true)
            {
                TextBox_Count_of_Fries.Enabled = true;
            }
            else
            {
                TextBox_Count_of_Fries.Text = "";
                TextBox_Count_of_Fries.Enabled = false;
            }
        }
        private void CheckBox_of_Cola_CheckedChanged(object sender, EventArgs e)
        {
            if(CheckBox_of_Cola.Checked == true)
            {
                TextBox_Count_of_Cola.Enabled = true;
            }
            else
            {
                TextBox_Count_of_Cola.Text = "";
                TextBox_Count_of_Cola.Enabled = false;
            }
        }
        private void CheckBox_of_Crips_CheckedChanged(object sender, EventArgs e)
        {
            if(CheckBox_of_Crips.Checked == true)
            {
                TextBox_Count_of_Crips.Enabled = true;
            }
            else
            {
                TextBox_Count_of_Crips.Text = "";
                TextBox_Count_of_Crips.Enabled = false;
            }
        }

        // <CheckBoxs Cafe/>

        double CoffeCost = 8.70;
        double HotDogCost = 5.30;
        double FriesCost = 7.20;
        double ColaCost = 4.40;
        double CripsCost = 10.50;

        void CalculateCostOfFood(double cost,string string_count)
        {
            int.TryParse(string_count,out int count);
            double res = cost * count;

            double.TryParse(CafeResultCost.Text,out double CafeLastResultCost);
            CafeResultCost.Text = res.ToString("N2");
        }

        private void ResultButton_Click(object sender, EventArgs e)
        {
            double.TryParse(CafeResultCost.Text,out double cafe);
            double.TryParse(FuelResultCost.Text,out double fuel);

            ResultPrice.Text = (cafe + fuel).ToString("N2");
        }
        
        // <TextBox_Count Cafe>
        private void TextBox_Count_of_Coffe_TextChanged(object sender, EventArgs e)
        {
            CalculateCostOfFood(CoffeCost, TextBox_Count_of_Coffe.Text);
            CalculateCafeTotalCost();
        }
        private void TextBox_Count_of_HotDog_TextChanged(object sender, EventArgs e)
        {
            CalculateCostOfFood(HotDogCost, TextBox_Count_of_HotDog.Text);
            CalculateCafeTotalCost();
        }
        private void TextBox_Count_of_Fries_TextChanged(object sender, EventArgs e)
        {
            CalculateCostOfFood(FriesCost, TextBox_Count_of_Fries.Text);
            CalculateCafeTotalCost();
        }
        private void TextBox_Count_of_Cola_TextChanged(object sender, EventArgs e)
        {
            CalculateCostOfFood(ColaCost, TextBox_Count_of_Cola.Text);
            CalculateCafeTotalCost();
        }
        private void TextBox_Count_of_Crips_TextChanged(object sender, EventArgs e)
        {
            CalculateCostOfFood(CripsCost, TextBox_Count_of_Crips.Text);
            CalculateCafeTotalCost();
        }
        // <TextBoxs_Count Cafe/>

        private void CalculateCafeTotalCost()
        {
            double totalCafeCost = 0;

            if (CheckBox_of_Coffe.Checked)
            {
                double.TryParse(TextBox_Count_of_Coffe.Text, out double coffeeCount);
                totalCafeCost += coffeeCount * CoffeCost;
            }

            if (CheckBox_of_HotDog.Checked)
            {
                double.TryParse(TextBox_Count_of_HotDog.Text, out double hotDogCount);
                totalCafeCost += hotDogCount * HotDogCost;
            }

            if (CheckBox_of_Fries.Checked)
            {
                double.TryParse(TextBox_Count_of_Fries.Text, out double friesCount);
                totalCafeCost += friesCount * FriesCost;
            }

            if (CheckBox_of_Cola.Checked)
            {
                double.TryParse(TextBox_Count_of_Cola.Text, out double colaCount);
                totalCafeCost += colaCount * ColaCost;
            }

            if (CheckBox_of_Crips.Checked)
            {
                double.TryParse(TextBox_Count_of_Crips.Text, out double cripsCount);
                totalCafeCost += cripsCount * CripsCost;
            }

            CafeResultCost.Text = totalCafeCost.ToString("N2");
        }
    }
}