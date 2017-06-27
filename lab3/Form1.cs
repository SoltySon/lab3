using lab3.Clothes;
using lab3.Core;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;

namespace lab3
{
    public partial class Form1 : Form
    {
        class Controller
        {
            public string name { get; set; }
            public Creator creator;
        }

        private Dictionary<int, Controller> WearDictionary;
        private List<Wear> wear;
        private Wear currentWear;

        public Form1()
        {
            InitializeComponent();
            WearDictionary = new Dictionary<int, Controller>();
            WearDictionary.Add(0, new Controller() { name = "Dress", creator = new DressCreator() });
            WearDictionary.Add(1, new Controller() { name = "Jacket", creator = new JacketCreator() });
            WearDictionary.Add(2, new Controller() { name = "Pants", creator = new PantsCreator() });
            WearDictionary.Add(3, new Controller() { name = "Shirt", creator = new ShirtCreator() });
            WearDictionary.Add(4, new Controller() { name = "Shorts", creator = new ShortsCreator() });
            WearDictionary.Add(5, new Controller() { name = "Tshirt", creator = new TshirtCreator() });
            wear = new List<Wear>();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    label1.Text = "Color";
                    label2.Text = "Material";
                    label3.Text = "Size";
                    label4.Text = "Chest_girth";
                    label5.Text = "Waist";
                    label6.Text = "Length";
                    label5.Visible = true;
                    label6.Visible = true;
                    textBox5.Visible = true;
                    textBox6.Visible = true;
                    break;
                case 1:
                    label1.Text = "Color";
                    label2.Text = "Material";
                    label3.Text = "Size";
                    label4.Text = "Growth";
                    label5.Text = "Chest_girth";
                    label5.Visible = true;
                    label6.Visible = false;
                    textBox5.Visible = true;
                    textBox6.Visible = false;
                    break;
                case 2:
                    label1.Text = "Color";
                    label2.Text = "Material";
                    label3.Text = "Waist";
                    label4.Text = "Length";
                    label5.Visible = false;
                    label6.Visible = false;
                    textBox5.Visible = false;
                    textBox6.Visible = false;
                    break;
                case 3:
                    label1.Text = "Color";
                    label2.Text = "Material";
                    label3.Text = "Size";
                    label4.Text = "Growth";
                    label5.Text = "Chest_girth";
                    label5.Visible = true;
                    label6.Visible = false;
                    textBox5.Visible = true;
                    textBox6.Visible = false;
                    break;
                case 4:
                    label1.Text = "Color";
                    label2.Text = "Material";
                    label3.Text = "Waist";
                    label4.Text = "Length";
                    label5.Visible = false;
                    label6.Visible = false;
                    textBox5.Visible = false;
                    textBox6.Visible = false;
                    break;
                case 5:
                    label1.Text = "Color";
                    label2.Text = "Material";
                    label3.Text = "Size";
                    label4.Text = "Growth";
                    label5.Text = "Chest_girth";
                    label5.Visible = true;
                    label6.Visible = false;
                    textBox5.Visible = true;
                    textBox6.Visible = false;
                    break;
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Creator currentCreator = WearDictionary[comboBox1.SelectedIndex].creator;
            wear.Add(currentCreator.Create(WearDictionary[comboBox1.SelectedIndex].name));
            refreshListView1();
        }

        private void refreshListView1()
        {
            listBox1.Items.Clear();
            foreach (var item in wear)
            {
                listBox1.Items.Add(item.name);
            }
        }

        private void buttonChange_Click(object sender, EventArgs e)
        {
            try { 
            switch (currentWear.ToString())
            {
                case "Dress":
                    currentWear.name = textBox7.Text;
                    currentWear.color = textBox1.Text;
                    currentWear.material = textBox2.Text;
                    ((Dress)currentWear).size = textBox3.Text;
                    ((Dress)currentWear).chestGirth = textBox4.Text;
                    ((Dress)currentWear).waist = textBox5.Text;
                    ((Dress)currentWear).length = textBox6.Text;
                    break;
                case "Jacket":
                    currentWear.name = textBox7.Text;
                    currentWear.color = textBox1.Text;
                    currentWear.material = textBox2.Text;
                    ((Jacket)currentWear).size = textBox3.Text;
                    ((Jacket)currentWear).growth = textBox4.Text;
                    ((Jacket)currentWear).chestGirth = textBox5.Text;
                    break;
                case "Pants":
                    currentWear.name = textBox7.Text;
                    currentWear.color = textBox1.Text;
                    currentWear.material = textBox2.Text;
                    ((Pants)currentWear).waist = textBox3.Text;
                    ((Pants)currentWear).length = textBox4.Text;
                    break;
                case "Shirt":
                    currentWear.name = textBox7.Text;
                    currentWear.color = textBox1.Text;
                    currentWear.material = textBox2.Text;
                    ((Shirt)currentWear).size = textBox3.Text;
                    ((Shirt)currentWear).growth = textBox4.Text;
                    ((Shirt)currentWear).chestGirth = textBox5.Text;
                    break;
                case "Shorts":
                    currentWear.name = textBox7.Text;
                    currentWear.color = textBox1.Text;
                    currentWear.material = textBox2.Text;
                    ((Shorts)currentWear).waist = textBox3.Text;
                    ((Shorts)currentWear).length = textBox4.Text;
                    break;
                case "Tshirt":
                    currentWear.name = textBox7.Text;
                    currentWear.color = textBox1.Text;
                    currentWear.material = textBox2.Text;
                    ((Tshirt)currentWear).size = textBox3.Text;
                    ((Tshirt)currentWear).growth = textBox4.Text;
                    ((Tshirt)currentWear).chestGirth = textBox5.Text;
                    break;
            }
            refreshListView1();
            }
            catch (NullReferenceException ex) { MessageBox.Show("No selected elements"); }
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            foreach (var item in WearDictionary)
            {
                comboBox1.Items.Add(WearDictionary[item.Key].name);
            }
            comboBox1.SelectedIndex = 0;
        }


        private void buttonDelete_Click(object sender, EventArgs e)
        {
            wear.Remove(currentWear);
            refreshListView1();
        }

        private void buttonSerialize_Click(object sender, EventArgs e)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream fs = File.Create("wear.dat"))
            {
                formatter.Serialize(fs, wear);
            }

        }

        private void buttonDeserialize_Click(object sender, EventArgs e)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream fs = File.OpenRead("wear.dat"))
            {
                wear.Clear();
                wear = (List<Wear>)formatter.Deserialize(fs);
                refreshListView1();
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int nameOfSelectItem = listBox1.SelectedIndex;
                currentWear = wear[nameOfSelectItem];
            switch (currentWear.ToString())
            {
                case "Dress":
                    comboBox1.SelectedIndex = 0;
                    textBox1.Text = currentWear.color;
                    textBox2.Text = currentWear.material;
                    textBox3.Text = ((Dress)currentWear).size;
                    textBox4.Text = ((Dress)currentWear).chestGirth;
                    textBox5.Text = ((Dress)currentWear).waist;
                    textBox6.Text = ((Dress)currentWear).length;
                    textBox7.Text = currentWear.name;
                    break;
                case "Jacket":
                    comboBox1.SelectedIndex = 1;
                    textBox1.Text = currentWear.color;
                    textBox2.Text = currentWear.material;
                    textBox3.Text = ((Jacket)currentWear).size;
                    textBox4.Text = ((Jacket)currentWear).growth;
                    textBox5.Text = ((Jacket)currentWear).chestGirth;
                    textBox7.Text = currentWear.name;
                    break;
                case "Pants":
                    comboBox1.SelectedIndex = 2;
                    textBox1.Text = currentWear.color;
                    textBox2.Text = currentWear.material;
                    textBox3.Text = ((Pants)currentWear).waist;
                    textBox4.Text = ((Pants)currentWear).length;
                    textBox7.Text = currentWear.name;
                    break;
                case "Shirt":
                    comboBox1.SelectedIndex = 3;
                    textBox1.Text = currentWear.color;
                    textBox2.Text = currentWear.material;
                    textBox3.Text = ((Shirt)currentWear).size;
                    textBox4.Text = ((Shirt)currentWear).growth;
                    textBox5.Text = ((Shirt)currentWear).chestGirth;
                    textBox7.Text = currentWear.name;
                    break;
                case "Shorts":
                    comboBox1.SelectedIndex = 4;
                    textBox1.Text = currentWear.color;
                    textBox2.Text = currentWear.material;
                    textBox3.Text = ((Shorts)currentWear).waist;
                    textBox4.Text = ((Shorts)currentWear).length;
                    textBox7.Text = currentWear.name;
                    break;
                case "Tshirt":
                    comboBox1.SelectedIndex = 5;
                    textBox1.Text = currentWear.color;
                    textBox2.Text = currentWear.material;
                    textBox3.Text = ((Tshirt)currentWear).size;
                    textBox4.Text = ((Tshirt)currentWear).growth;
                    textBox5.Text = ((Tshirt)currentWear).chestGirth;
                    textBox7.Text = currentWear.name;
                    break;
            }
            }
            catch (ArgumentOutOfRangeException ex) { MessageBox.Show("No selected elements"); }
        }
    }
}
