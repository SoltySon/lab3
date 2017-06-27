using System;
using lab3.Clothes;

namespace lab3.Core
{
    public class Table
    {
        public void ChangeIndex(Form1 tb)
        {
            switch (tb.comboBox1.SelectedIndex)
            {
                case 0:
                    tb.label1.Text = "Color";
                    tb.label2.Text = "Material";
                    tb.label3.Text = "Size";
                    tb.label4.Text = "Chest_girth";
                    tb.label5.Text = "Waist";
                    tb.label6.Text = "Length";
                    tb.label5.Visible = true;
                    tb.label6.Visible = true;
                    tb.textBox5.Visible = true;
                    tb.textBox6.Visible = true;
                    break;
                case 1:
                    tb.label1.Text = "Color";
                    tb.label2.Text = "Material";
                    tb.label3.Text = "Size";
                    tb.label4.Text = "Growth";
                    tb.label5.Text = "Chest_girth";
                    tb.label5.Visible = true;
                    tb.label6.Visible = false;
                    tb.textBox5.Visible = true;
                    tb.textBox6.Visible = false;
                    break;
                case 2:
                    tb.label1.Text = "Color";
                    tb.label2.Text = "Material";
                    tb.label3.Text = "Waist";
                    tb.label4.Text = "Length";
                    tb.label5.Visible = false;
                    tb.label6.Visible = false;
                    tb.textBox5.Visible = false;
                    tb.textBox6.Visible = false;
                    break;
                case 3:
                    tb.label1.Text = "Color";
                    tb.label2.Text = "Material";
                    tb.label3.Text = "Size";
                    tb.label4.Text = "Growth";
                    tb.label5.Text = "Chest_girth";
                    tb.label5.Visible = true;
                    tb.label6.Visible = false;
                    tb.textBox5.Visible = true;
                    tb.textBox6.Visible = false;
                    break;
                case 4:
                    tb.label1.Text = "Color";
                    tb.label2.Text = "Material";
                    tb.label3.Text = "Waist";
                    tb.label4.Text = "Length";
                    tb.label5.Visible = false;
                    tb.label6.Visible = false;
                    tb.textBox5.Visible = false;
                    tb.textBox6.Visible = false;
                    break;
                case 5:
                    tb.label1.Text = "Color";
                    tb.label2.Text = "Material";
                    tb.label3.Text = "Size";
                    tb.label4.Text = "Growth";
                    tb.label5.Text = "Chest_girth";
                    tb.label5.Visible = true;
                    tb.label6.Visible = false;
                    tb.textBox5.Visible = true;
                    tb.textBox6.Visible = false;
                    break;
            }
        }
        public void But_change(lab3.Clothes.Wear currentWear, Form1 tb)
        { 
                switch (currentWear.ToString())
                {
                    case "Dress":
                        currentWear.name = tb.textBox7.Text;
                        currentWear.color = tb.textBox1.Text;
                        currentWear.material = tb.textBox2.Text;
                        ((Dress)currentWear).size = tb.textBox3.Text;
                        ((Dress)currentWear).chestGirth = tb.textBox4.Text;
                        ((Dress)currentWear).waist = tb.textBox5.Text;
                        ((Dress)currentWear).length = tb.textBox6.Text;
                        break;
                    case "Jacket":
                        currentWear.name = tb.textBox7.Text;
                        currentWear.color = tb.textBox1.Text;
                        currentWear.material = tb.textBox2.Text;
                        ((Jacket)currentWear).size = tb.textBox3.Text;
                        ((Jacket)currentWear).growth = tb.textBox4.Text;
                        ((Jacket)currentWear).chestGirth = tb.textBox5.Text;
                        break;
                    case "Pants":
                        currentWear.name = tb.textBox7.Text;
                        currentWear.color = tb.textBox1.Text;
                        currentWear.material = tb.textBox2.Text;
                        ((Pants)currentWear).waist = tb.textBox3.Text;
                        ((Pants)currentWear).length = tb.textBox4.Text;
                        break;
                    case "Shirt":
                        currentWear.name = tb.textBox7.Text;
                        currentWear.color = tb.textBox1.Text;
                        currentWear.material = tb.textBox2.Text;
                        ((Shirt)currentWear).size = tb.textBox3.Text;
                        ((Shirt)currentWear).growth = tb.textBox4.Text;
                        ((Shirt)currentWear).chestGirth = tb.textBox5.Text;
                        break;
                    case "Shorts":
                        currentWear.name = tb.textBox7.Text;
                        currentWear.color = tb.textBox1.Text;
                        currentWear.material = tb.textBox2.Text;
                        ((Shorts)currentWear).waist = tb.textBox3.Text;
                        ((Shorts)currentWear).length = tb.textBox4.Text;
                        break;
                    case "Tshirt":
                        currentWear.name = tb.textBox7.Text;
                        currentWear.color = tb.textBox1.Text;
                        currentWear.material = tb.textBox2.Text;
                        ((Tshirt)currentWear).size = tb.textBox3.Text;
                        ((Tshirt)currentWear).growth = tb.textBox4.Text;
                        ((Tshirt)currentWear).chestGirth = tb.textBox5.Text;
                        break;
            }
        }

        public void Index_change(lab3.Clothes.Wear currentWear, Form1 tb)
        {
            switch (currentWear.ToString())
            {
                case "Dress":
                    currentWear.name = tb.textBox7.Text;
                    currentWear.color = tb.textBox1.Text;
                    currentWear.material = tb.textBox2.Text;
                    ((Dress)currentWear).size = tb.textBox3.Text;
                    ((Dress)currentWear).chestGirth = tb.textBox4.Text;
                    ((Dress)currentWear).waist = tb.textBox5.Text;
                    ((Dress)currentWear).length = tb.textBox6.Text;
                    break;
                case "Jacket":
                    currentWear.name = tb.textBox7.Text;
                    currentWear.color = tb.textBox1.Text;
                    currentWear.material = tb.textBox2.Text;
                    ((Jacket)currentWear).size = tb.textBox3.Text;
                    ((Jacket)currentWear).growth = tb.textBox4.Text;
                    ((Jacket)currentWear).chestGirth = tb.textBox5.Text;
                    break;
                case "Pants":
                    currentWear.name = tb.textBox7.Text;
                    currentWear.color = tb.textBox1.Text;
                    currentWear.material = tb.textBox2.Text;
                    ((Pants)currentWear).waist = tb.textBox3.Text;
                    ((Pants)currentWear).length = tb.textBox4.Text;
                    break;
                case "Shirt":
                    currentWear.name = tb.textBox7.Text;
                    currentWear.color = tb.textBox1.Text;
                    currentWear.material = tb.textBox2.Text;
                    ((Shirt)currentWear).size = tb.textBox3.Text;
                    ((Shirt)currentWear).growth = tb.textBox4.Text;
                    ((Shirt)currentWear).chestGirth = tb.textBox5.Text;
                    break;
                case "Shorts":
                    currentWear.name = tb.textBox7.Text;
                    currentWear.color = tb.textBox1.Text;
                    currentWear.material = tb.textBox2.Text;
                    ((Shorts)currentWear).waist = tb.textBox3.Text;
                    ((Shorts)currentWear).length = tb.textBox4.Text;
                    break;
                case "Tshirt":
                    currentWear.name = tb.textBox7.Text;
                    currentWear.color = tb.textBox1.Text;
                    currentWear.material = tb.textBox2.Text;
                    ((Tshirt)currentWear).size = tb.textBox3.Text;
                    ((Tshirt)currentWear).growth = tb.textBox4.Text;
                    ((Tshirt)currentWear).chestGirth = tb.textBox5.Text;
                    break;
            }
        }

    }
       
}

