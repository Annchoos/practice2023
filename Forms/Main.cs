using System;
using System.Windows.Forms;

namespace practice
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            comboBox1.Items.Add("sin");
            comboBox1.Items.Add("cos");
            comboBox1.Items.Add("tg");
            comboBox1.Items.Add("ctg");

            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedItem = comboBox1.SelectedItem.ToString();

            // Обработка выбора элемента ComboBox
            if (selectedItem == "sin")
            {
                
            }
            else if (selectedItem == "cos")
            {
                
            }
            else if (selectedItem == "tg")
            {
                
            }
            else if (selectedItem == "ctg")
            {
            }
        }

		private void Main_Load(object sender, EventArgs e)
		{

		}
	}
}