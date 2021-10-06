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
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            aDie die = new aDie();
            int[] face = die.Roll();
            switch(face[0])
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

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int numberRolls = int.Parse(textBox1.Text);
            aDie die = new aDie();
            for (int i = 0; i <= numberRolls; i++)
            {
                
                int[] face = die.Roll();
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
}
