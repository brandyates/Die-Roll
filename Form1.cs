using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project1
{
    /// <summary>
    /// Class Declaration for Form1, the main form used in the program.
    /// </summary>
    public partial class Form1 : Form
    {
        /// <summary>
        /// Initializes the form that contains all information.
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            listBox1.SelectedIndex = 0;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            aDie die = new aDie();
            int[] face = die.Roll();
            updateFaces(face);
        }



        private void button2_Click(object sender, EventArgs e)
        {
            int seed;
            chart1.ChartAreas[0].AxisX.Maximum = 7;
            chart1.ChartAreas[0].AxisX.Minimum = 0;
            if (String.IsNullOrEmpty(textBox2.Text) || textBox2.Text == "999")
            {
                seed = 999;
            }
            if(textBox2.Text.Length > 9 || !int.TryParse(textBox2.Text, out int j))
            {
                MessageBox.Show("Seed was either too long or contained characters other " +
                    "than numbers. Seed changed to default value (999).");
                seed = 999;
                textBox2.Text = "999";
            }
            else
            {
                seed = int.Parse(textBox2.Text); 
            }

            aDie die = new aDie(seed);

            int[] die1 = new int[6];
            int[] die2 = new int[6];
            int numberRolls = int.Parse(listBox1.GetItemText(listBox1.SelectedItem));
            
            int interval = numberRolls / 100;
            if(interval == 0)
            {
                interval = 1;
            }
            chart1.ChartAreas[0].AxisY.Maximum = numberRolls/3;
            int[] face = die.Roll(seed);
            die1[face[0] - 1]++;
            die2[face[1] - 1]++;
            

            for (int i = 0; i < numberRolls; i++)
            {
                face[0] = aDie.rand.Next(1, 7);
                face[1] = aDie.rand.Next(1, 7);
                die1[face[0]-1]++;
                die2[face[1]-1]++;
                chart1.Series[0].Points.AddXY(face[0], die1[face[0]-1]);
                chart1.Series[1].Points.AddXY(face[1], die2[face[1]-1]);
                if (i % interval  == 0)
                {
                    chart1.Update();
                }
                updateFaces(face);
            }
            chart1.Update();
            int[] min = new int[2];
            min = findMin(die1, die2);
            int[] max = new int[2];
            max = findMax(die1, die2);
            double mean = findMean(die1, die2, numberRolls);
 

            MessageBox.Show("MEAN: " + mean.ToString("0.##") + "\n" + 
                          "MINIMUM COUNT: " + min[0].ToString() + " (FACE " + min[1].ToString() + ")\n" + 
                          "MAXIMUM COUNT: " + max[0].ToString() + " (FACE " + max[1].ToString() + ")");
        }



        private void button3_Click(object sender, EventArgs e)
        {
            //Reset Dice
            pictureBox1.Image = Project1.Properties.Resources.Face_1;
            pictureBox2.Image = Project1.Properties.Resources.Face_1;

            //Reset Chart
            chart1.Series[0].Points.Clear();
            chart1.Series[1].Points.Clear();
            chart1.ChartAreas[0].AxisX.Maximum = 7;
            chart1.ChartAreas[0].AxisX.Minimum = 0;

            //Reset Seed Text
            textBox2.Text = "999";

            //Reset Selected # of rolls
            listBox1.SelectedIndex = 0;

            
        }
        
        private int[] findMax(int[] array1, int[]array2)
        {
            int[] max = new int[2];
            for(int i = 0; i < array1.Length; i++)
            {
                if(array1[i] > max[0] && array1[i] >= array2[i])
                {
                    max[0] = array1[i];
                    max[1] = i + 1;
                }
                if(array2[i] > max[0] && array2[i] >= array1[i])
                {
                    max[0] = array2[i];
                    max[1] = i + 1;
                }
            }
            return max;
        }

        private double findMean(int[] array1, int[] array2, int iterations)
        {
            double mean = 0;
            int total = 0;
            for(int i = 0; i < array1.Length; i++)
            {
                total += (array1[i] * (i+1));
                total += (array2[i] * (i+1));
            }
            mean = (double)total / ((double)iterations * 2.0);
            
            return mean;
        }

        private int[] findMin(int[] array1, int[] array2)
        {
            int[] min = new int[2];
            min[0] = 999999999;
            for (int i = 0; i < array1.Length; i++)
            {
                if (array1[i] < min[0] && array1[i] <= array2[i])
                {
                    min[0] = array1[i];
                    min[1] = i + 1;
                }
                if (array2[i] < min[0] && array2[i] <= array1[i])
                {
                    min[0] = array2[i];
                    min[1] = i + 1;
                }
            }
            return min;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int seed;
            if (String.IsNullOrEmpty(textBox2.Text) || textBox2.Text == "999")
            {
                seed = 999;
            }
            if(textBox2.Text.Length > 9 || !int.TryParse(textBox2.Text, out int j))
            {
                MessageBox.Show("Seed was either too long or contained characters other " +
                    "than numbers. Seed changed to default value (999).");
                seed = 999;
                textBox2.Text = "999";
            }
            else
            {
                seed = int.Parse(textBox2.Text);
            }

            aDie die = new aDie(seed);

            int[] sum = new int[12];
            int numberRolls = int.Parse(listBox1.GetItemText(listBox1.SelectedItem));

            int interval = numberRolls / 100;
            if (interval == 0)
            {
                interval = 1;
            }
            chart1.ChartAreas[0].AxisY.Maximum = numberRolls / 3;
            chart1.ChartAreas[0].AxisX.Maximum = 13;
            chart1.ChartAreas[0].AxisX.Minimum = 1;
            int[] face = die.Roll(seed);
            sum[face[0] + face[1]-1]++;


            for (int i = 0; i < numberRolls; i++)
            {
                face[0] = aDie.rand.Next(1, 7);
                face[1] = aDie.rand.Next(1, 7);
                updateFaces(face);
                sum[face[0] + face[1]-1]++;
                chart1.Series[0].Points.AddXY(face[0] + face[1], sum[face[0] + face[1]-1]);
                if (i % interval == 0 || i + 1 == numberRolls)
                {
                    chart1.Update();
                    
                }
                
            }
            chart1.Update();
        }

        private void updateFaces(int [] face)
        {
            switch (face[0])
            {
                case 1:
                    pictureBox1.Image = Project1.Properties.Resources.Face_1;
                    break;
                case 2:
                    pictureBox1.Image = Project1.Properties.Resources.Face_2;
                    break;
                case 3:
                    pictureBox1.Image = Project1.Properties.Resources.Face_3;
                    break;
                case 4:
                    pictureBox1.Image = Project1.Properties.Resources.Face_4;
                    break;
                case 5:
                    pictureBox1.Image = Project1.Properties.Resources.Face_5;
                    break;
                case 6:
                    pictureBox1.Image = Project1.Properties.Resources.Face_6;
                    break;
            }
            switch (face[1])
            {
                case 1:
                    pictureBox2.Image = Project1.Properties.Resources.Face_1;
                    break;
                case 2:
                    pictureBox2.Image = Project1.Properties.Resources.Face_2;
                    break;
                case 3:
                    pictureBox2.Image = Project1.Properties.Resources.Face_3;
                    break;
                case 4:
                    pictureBox2.Image = Project1.Properties.Resources.Face_4;
                    break;
                case 5:
                    pictureBox2.Image = Project1.Properties.Resources.Face_5;
                    break;
                case 6:
                    pictureBox2.Image = Project1.Properties.Resources.Face_6;
                    break;
            }
        }
    }
}
