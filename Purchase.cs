using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _170204100
{
    public partial class Purchase : Form
    {
        public Purchase()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double unit1 = double.Parse(textBox4.Text);
                double amount1 = double.Parse(textBox9.Text);
                double unit2 = double.Parse(textBox5.Text);
                double amount2 = double.Parse(textBox10.Text);
                double unit3 = double.Parse(textBox6.Text);
                double amount3 = double.Parse(textBox11.Text);
                double unit4 = double.Parse(textBox7.Text);
                double amount4 = double.Parse(textBox12.Text);
                double unit5 = double.Parse(textBox8.Text);
                double amount5 = double.Parse(textBox13.Text);

                double total = (unit1 * amount1) + (unit2 * amount2) + (unit3 * amount3) + (unit4 * amount4) + (unit5 * amount5);


                int selectedIndex = comboBox1.SelectedIndex;
                Object selectedItem = comboBox1.SelectedItem;

                if (selectedIndex == 0)
                {
                    textBox3.Text = Convert.ToString(total);
                }
                else if (selectedIndex == 1)
                {
                    textBox3.Text = Convert.ToString(total * 0.86);
                }
                else if (selectedIndex == 2)
                {
                    textBox3.Text = Convert.ToString(total * 0.012);
                }
                else if (selectedIndex == 3)
                {
                    textBox3.Text = Convert.ToString(total * 0.015);
                }
                else if (selectedIndex == 4)
                {
                    textBox3.Text = Convert.ToString(total * 1.22);
                }

                if (unit1 < 1 || unit1 > 100)
                    MessageBox.Show("Introduce the note between 1-100", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (amount1 < 1 || amount1 > 10)
                    MessageBox.Show("Introduce the note between 1-10", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);



                if (unit2 < 1 || unit2 > 100)
                    MessageBox.Show("Introduce the note between 1-100", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (amount2 < 1 || amount2 > 10)
                    MessageBox.Show("Introduce the note between 1-10", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);


                if (unit3 < 1 || unit3 > 100)
                    MessageBox.Show("Introduce the note between 1-100", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (amount3 < 1 || amount3 > 10)
                    MessageBox.Show("Introduce the note between 1-10", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);


                if (unit4 < 1 || unit4 > 100)
                    MessageBox.Show("Introduce the note between 1-100", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (amount4 < 1 || amount4 > 10)
                    MessageBox.Show("Introduce the note between 1-10", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);


                if (unit5 < 1 || unit5 > 100)
                    MessageBox.Show("Introduce the note between 1-100", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (amount5 < 1 || amount5 > 10)
                    MessageBox.Show("Introduce the note between 1-10", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            }
            catch (Exception)
            {
                MessageBox.Show("Error entering the data fields!","error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }

            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Purchase_Load(object sender, EventArgs e)
        {
            textBox1.Text = Form1.user;
            textBox2.Text = Form1.pass;
        }
    }
}
