using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practice
{
    public partial class Form1 : Form
    {
        public Form1()
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

       
    }
}