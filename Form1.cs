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
    public partial class Form_Die_Game : Form
    {
        /// <summary>
        /// Initializes the form that contains all information.
        /// </summary>
        public Form_Die_Game()
        {
            InitializeComponent();
            listBox_Rolls.SelectedIndex = 0;
        }

        /// <summary>
        /// Event Handler for a Click of the button_Roll button. Rolls two random numbers on the dice.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            aDie die = new aDie();
            int[] face = die.Roll();
            updateFaces(face);
        }


        /// <summary>
        /// Event handler for a click of <see cref="button_Roll"/>. Interfaces with listBox_Rolls to determine number of rolls and calculates statistics
        /// such as maximum count, minimum count, and the mean of all dice.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {

            //Set maximum and minimum chart areas
            chart1.ChartAreas[0].AxisX.Maximum = 7;
            chart1.ChartAreas[0].AxisX.Minimum = 0;

            int seed = getSeed();


            //create a new die object that uses the seed to determine the rolls
            aDie die = new aDie(seed);
            //die1 is all of the first die's rolls, die2 is all of the second die's rolls
            int[] die1 = new int[6];
            int[] die2 = new int[6];
            //get number of rolls from listbox
            int numberRolls = int.Parse(listBox_Rolls.GetItemText(listBox_Rolls.SelectedItem));
            
            //chooses how often to update the chart. Sets interval to 1 if interval is smaller than 1
            //if interval == 1, then the chart will update every iteration of a roll
            int interval = numberRolls / 100;
            if(interval == 0)
            {
                interval = 1;
            }

            //Shrink max y value of chart
            chart1.ChartAreas[0].AxisY.Maximum = numberRolls/3;

            //roll the dice
            int[] face = die.Roll(seed);

            //update face count of each die
            die1[face[0] - 1]++;
            die2[face[1] - 1]++;
            

            for (int i = 0; i < numberRolls; i++)
            {
                //get next faces
                face[0] = aDie.rand.Next(1, 7);
                face[1] = aDie.rand.Next(1, 7);
                //update faces
                die1[face[0]-1]++;
                die2[face[1]-1]++;

                //add new faces to chart
                chart1.Series[0].Points.AddXY(face[0], die1[face[0]-1]);
                chart1.Series[1].Points.AddXY(face[1], die2[face[1]-1]);

                //update chart every interval
                if (i % interval  == 0)
                {
                    chart1.Update();
                }

                updateFaces(face);
            }

            //update chart at the end of the rolls
            chart1.Update();

            //calculate minimum count of the rolls
            int[] min = new int[2];
            min = findMin(die1, die2);

            //calculate max count of the rolls
            int[] max = new int[2];
            max = findMax(die1, die2);

            //calculate mean of all rolls
            double mean = findMean(die1, die2, numberRolls);
 
            //print results
            MessageBox.Show("MEAN: " + mean.ToString("0.##") + "\n" + 
                          "MINIMUM COUNT: " + min[0].ToString() + " (FACE " + min[1].ToString() + ")\n" + 
                          "MAXIMUM COUNT: " + max[0].ToString() + " (FACE " + max[1].ToString() + ")");
        }


        /// <summary>
        /// Event handler for button click for <see cref="button_Reset"/>. Resets everything in the form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            //Reset Dice
            pictureBox_Die1.Image = Project1.Properties.Resources.Face_1;
            pictureBox_Die2.Image = Project1.Properties.Resources.Face_1;

            //Reset Chart
            chart1.Series[0].Points.Clear();
            chart1.Series[1].Points.Clear();
            chart1.ChartAreas[0].AxisX.Maximum = 7;
            chart1.ChartAreas[0].AxisX.Minimum = 0;

            //Reset Seed Text
            textBox_Seed.Text = "999";

            //Reset Selected # of rolls
            listBox_Rolls.SelectedIndex = 0;

            
        }
        
        /// <summary>
        /// Finds the maximum count of each dice.
        /// </summary>
        /// <param name="array1">Represents Die 1 and its counts for each face.</param>
        /// <param name="array2">Represents Die2 and its counts for each face.</param>
        /// <returns>An array where max[0] = the count and max[1] = the face</returns>
        private int[] findMax(int[] array1, int[]array2)
        {
            //max[0] = count, max[1] = face
            int[] max = new int[2];
            for(int i = 0; i < array1.Length; i++)
            {
                //array 1[i] is the new max
                if(array1[i] > max[0] && array1[i] >= array2[i])
                {
                    max[0] = array1[i];
                    max[1] = i + 1;
                }
                //array2[i] is the new max
                if(array2[i] > max[0] && array2[i] >= array1[i])
                {
                    max[0] = array2[i];
                    max[1] = i + 1;
                }
            }
            return max;
        }

        /// <summary>
        /// Calculates the mean value of all die rolls.
        /// </summary>
        /// <param name="array1">Represents die1 and its counts.</param>
        /// <param name="array2">Represents die2 and its counts.</param>
        /// <param name="iterations">How many rolls that are selected.</param>
        /// <returns>A double value of all rolls.</returns>
        private double findMean(int[] array1, int[] array2, int iterations)
        {
            double mean = 0;
            int total = 0;

            //add all numbers of the dice together
            for(int i = 0; i < array1.Length; i++)
            {
                total += (array1[i] * (i+1));
                total += (array2[i] * (i+1));
            }
            //calculate mean
            mean = (double)total / ((double)iterations * 2.0);
            
            return mean;
        }

        /// <summary>
        /// Calculates the minimum count of all faces in both dice.
        /// </summary>
        /// <param name="array1">Represents die1 and its counts.</param>
        /// <param name="array2">Represents die2 and its counts.</param>
        /// <returns>An array where min[0]= count and min[1] = face.</returns>
        private int[] findMin(int[] array1, int[] array2)
        {
            //min[0] = count, min[1] = face
            int[] min = new int[2];
            //maximum value for an integer
            min[0] = 999999999;

            for (int i = 0; i < array1.Length; i++)
            {
                //array1[i] is new min
                if (array1[i] < min[0] && array1[i] <= array2[i])
                {
                    min[0] = array1[i];
                    min[1] = i + 1;
                }
                //array2[i] is new min
                if (array2[i] < min[0] && array2[i] <= array1[i])
                {
                    min[0] = array2[i];
                    min[1] = i + 1;
                }
            }
            return min;
        }

        /// <summary>
        /// Event Handler for button click for <see cref="button_SumOfDice"/>. Calculates the sum of all die faces and displays the sums in a chart.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button4_Click(object sender, EventArgs e)
        {
            int seed = getSeed();
            
            //Create new die
            aDie die = new aDie(seed);

            int[] sum = new int[12];

            //get number of rolls
            int numberRolls = int.Parse(listBox_Rolls.GetItemText(listBox_Rolls.SelectedItem));

            //set interval to update chart. If interval is less than 1, set it to 1 so it updates every iteration
            int interval = numberRolls / 100;
            if (interval == 0)
            {
                interval = 1;
            }
            
            //set boundaries of chart
            chart1.ChartAreas[0].AxisY.Maximum = numberRolls / 3;
            chart1.ChartAreas[0].AxisX.Maximum = 13;
            chart1.ChartAreas[0].AxisX.Minimum = 1;

            //roll dice and get faces
            int[] face = die.Roll(seed);

            //update sum counts
            sum[face[0] + face[1]-1]++;


            for (int i = 0; i < numberRolls; i++)
            {
                //get next faces
                face[0] = aDie.rand.Next(1, 7);
                face[1] = aDie.rand.Next(1, 7);

                //update die faces
                updateFaces(face);

                //update sum counts
                sum[face[0] + face[1]-1]++;

                //update chart counts
                chart1.Series[0].Points.AddXY(face[0] + face[1], sum[face[0] + face[1]-1]);

                //update chart every interval
                if (i % interval == 0 || i + 1 == numberRolls)
                {
                    chart1.Update();
                    
                }
                
            }

            //update chart at end of rolls
            chart1.Update();
        }

        /// <summary>
        /// Visually updates the die faces.
        /// </summary>
        /// <param name="face">Contains the face for both dice.</param>
        private void updateFaces(int [] face)
        {
            //update die 1
            switch (face[0])
            {
                case 1:
                    pictureBox_Die1.Image = Project1.Properties.Resources.Face_1;
                    break;
                case 2:
                    pictureBox_Die1.Image = Project1.Properties.Resources.Face_2;
                    break;
                case 3:
                    pictureBox_Die1.Image = Project1.Properties.Resources.Face_3;
                    break;
                case 4:
                    pictureBox_Die1.Image = Project1.Properties.Resources.Face_4;
                    break;
                case 5:
                    pictureBox_Die1.Image = Project1.Properties.Resources.Face_5;
                    break;
                case 6:
                    pictureBox_Die1.Image = Project1.Properties.Resources.Face_6;
                    break;
            }

            //update die 2
            switch (face[1])
            {
                case 1:
                    pictureBox_Die2.Image = Project1.Properties.Resources.Face_1;
                    break;
                case 2:
                    pictureBox_Die2.Image = Project1.Properties.Resources.Face_2;
                    break;
                case 3:
                    pictureBox_Die2.Image = Project1.Properties.Resources.Face_3;
                    break;
                case 4:
                    pictureBox_Die2.Image = Project1.Properties.Resources.Face_4;
                    break;
                case 5:
                    pictureBox_Die2.Image = Project1.Properties.Resources.Face_5;
                    break;
                case 6:
                    pictureBox_Die2.Image = Project1.Properties.Resources.Face_6;
                    break;
            }
        }

        /// <summary>
        /// Gets input from the input box <see cref="textBox_Seed"/>.
        /// </summary>
        /// <returns>The seed used to generate the random numbers.</returns>
        private int getSeed()
        {
            int seed;
            //Sets to default seed if textBox_Seed is empty or equal to 999
            if (String.IsNullOrEmpty(textBox_Seed.Text) || textBox_Seed.Text == "999")
            {
                seed = 999;
            }
            //If seed is longer than a max int or if it contains any non-digits, set it to default value
            if (textBox_Seed.Text.Length > 9 || !int.TryParse(textBox_Seed.Text, out int j))
            {
                MessageBox.Show("Seed was either too long or contained characters other " +
                    "than numbers. Seed changed to default value (999).");
                seed = 999;
                textBox_Seed.Text = "999";
            }
            else
            {
                seed = int.Parse(textBox_Seed.Text); //get seed
            }
            return seed;
        }
    }
}
