using System.Web;

namespace CoffeeMachine
{
    public partial class Form1 : Form
    {
        static int orderCount = 0;
        static string size = "small";
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() == "Tea")
            {
                pictureBox1.Image = Properties.Resources.pngtree_steaming_tea_in_a_transparent_glass_mug_with_subtle_reflections_png_image_15314690__1_;
            }
            else if (comboBox1.SelectedItem.ToString() == "Beer")
            {
                pictureBox1.Image = Properties.Resources.image_2025_06_09_225447005;
            }
            else if (comboBox1.SelectedItem.ToString() == "Coffee")
            {
                pictureBox1.Image = Properties.Resources.image_2025_06_09_225336641;
            }
            else if (comboBox1.SelectedItem.ToString() == "Juice")
            {
                pictureBox1.Image = Properties.Resources.image_2025_06_09_225529420;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            size = "medium";
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            size = "small";
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            size = "large";
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Please enter your name.", "Error!");
                return;
            }
            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Please select a drink.", "Error!");
                return;
            }
            if (!radioButton1.Checked && !radioButton2.Checked && !radioButton3.Checked)
            {
                MessageBox.Show("Please select a size.", "Error!");
                return;
            }
            Thread.Sleep(100);
            while (progressBar1.Value < 100) progressBar1.Increment(1);
            Thread.Sleep(100);
            orderCount++;
            textBox2.Text = orderCount.ToString();
            string drink = comboBox1.SelectedItem.ToString();
            string sugar;
            string milk;
            string ice;
            if (checkBox1.Checked)
            {
                sugar = "with milk ";
            }
            else
            {
                sugar = "without milk ";
            }
            if (checkBox2.Checked)
            {
                milk = "with sugar ";
            }
            else
            {
                milk = "without sugar ";
            }
            if (checkBox3.Checked)
            {
                ice = "with ice";
            }
            else
            {
                ice = "without ice";
            }
            MessageBox.Show($"{textBox1.Text} ordered a {size} {drink} {sugar}, {milk}, {ice}.", "Order");
            progressBar1.Value = 0;
        }
    }
}
