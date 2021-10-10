
namespace Project1
{
    partial class Form_Die_Game
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.button_Roll = new System.Windows.Forms.Button();
            this.button_Stats = new System.Windows.Forms.Button();
            this.button_Reset = new System.Windows.Forms.Button();
            this.pictureBox_Die1 = new System.Windows.Forms.PictureBox();
            this.pictureBox_Die2 = new System.Windows.Forms.PictureBox();
            this.textBox_Seed = new System.Windows.Forms.TextBox();
            this.listBox_Rolls = new System.Windows.Forms.ListBox();
            this.label_Num_Rolls = new System.Windows.Forms.Label();
            this.label_Seed = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button_SumOfDice = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Die1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Die2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // button_Roll
            // 
            this.button_Roll.Location = new System.Drawing.Point(34, 174);
            this.button_Roll.Name = "button_Roll";
            this.button_Roll.Size = new System.Drawing.Size(132, 45);
            this.button_Roll.TabIndex = 0;
            this.button_Roll.Text = "ROLL!";
            this.button_Roll.UseVisualStyleBackColor = true;
            this.button_Roll.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_Stats
            // 
            this.button_Stats.Location = new System.Drawing.Point(34, 348);
            this.button_Stats.Name = "button_Stats";
            this.button_Stats.Size = new System.Drawing.Size(132, 45);
            this.button_Stats.TabIndex = 1;
            this.button_Stats.Text = "STATISTICS";
            this.button_Stats.UseVisualStyleBackColor = true;
            this.button_Stats.Click += new System.EventHandler(this.button2_Click);
            // 
            // button_Reset
            // 
            this.button_Reset.Location = new System.Drawing.Point(34, 225);
            this.button_Reset.Name = "button_Reset";
            this.button_Reset.Size = new System.Drawing.Size(132, 45);
            this.button_Reset.TabIndex = 2;
            this.button_Reset.Text = "RESET";
            this.button_Reset.UseVisualStyleBackColor = true;
            this.button_Reset.Click += new System.EventHandler(this.button3_Click);
            // 
            // pictureBox_Die1
            // 
            this.pictureBox_Die1.Image = global::Project1.Properties.Resources.Face_1;
            this.pictureBox_Die1.InitialImage = global::Project1.Properties.Resources.Face_1;
            this.pictureBox_Die1.Location = new System.Drawing.Point(34, 31);
            this.pictureBox_Die1.Name = "pictureBox_Die1";
            this.pictureBox_Die1.Size = new System.Drawing.Size(112, 113);
            this.pictureBox_Die1.TabIndex = 3;
            this.pictureBox_Die1.TabStop = false;
            // 
            // pictureBox_Die2
            // 
            this.pictureBox_Die2.Image = global::Project1.Properties.Resources.Face_1;
            this.pictureBox_Die2.InitialImage = global::Project1.Properties.Resources.Face_1;
            this.pictureBox_Die2.Location = new System.Drawing.Point(193, 31);
            this.pictureBox_Die2.Name = "pictureBox_Die2";
            this.pictureBox_Die2.Size = new System.Drawing.Size(111, 113);
            this.pictureBox_Die2.TabIndex = 4;
            this.pictureBox_Die2.TabStop = false;
            // 
            // textBox_Seed
            // 
            this.textBox_Seed.Location = new System.Drawing.Point(72, 422);
            this.textBox_Seed.Name = "textBox_Seed";
            this.textBox_Seed.Size = new System.Drawing.Size(79, 20);
            this.textBox_Seed.TabIndex = 7;
            this.textBox_Seed.Text = "999";
            // 
            // listBox_Rolls
            // 
            this.listBox_Rolls.FormattingEnabled = true;
            this.listBox_Rolls.Items.AddRange(new object[] {
            "60",
            "600",
            "6000",
            "60000"});
            this.listBox_Rolls.Location = new System.Drawing.Point(181, 313);
            this.listBox_Rolls.Name = "listBox_Rolls";
            this.listBox_Rolls.Size = new System.Drawing.Size(46, 56);
            this.listBox_Rolls.TabIndex = 8;
            // 
            // label_Num_Rolls
            // 
            this.label_Num_Rolls.AutoSize = true;
            this.label_Num_Rolls.Location = new System.Drawing.Point(178, 297);
            this.label_Num_Rolls.Name = "label_Num_Rolls";
            this.label_Num_Rolls.Size = new System.Drawing.Size(50, 13);
            this.label_Num_Rolls.TabIndex = 9;
            this.label_Num_Rolls.Text = "# of rolls:";
            // 
            // label_Seed
            // 
            this.label_Seed.AutoSize = true;
            this.label_Seed.Location = new System.Drawing.Point(31, 425);
            this.label_Seed.Name = "label_Seed";
            this.label_Seed.Size = new System.Drawing.Size(35, 13);
            this.label_Seed.TabIndex = 10;
            this.label_Seed.Text = "Seed:";
            // 
            // chart1
            // 
            chartArea2.AxisX.Maximum = 7D;
            chartArea2.AxisX.Minimum = 0D;
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(344, 138);
            this.chart1.Name = "chart1";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Die 1";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Die 2";
            this.chart1.Series.Add(series3);
            this.chart1.Series.Add(series4);
            this.chart1.Size = new System.Drawing.Size(300, 300);
            this.chart1.TabIndex = 11;
            this.chart1.Text = "chart1";
            // 
            // button_SumOfDice
            // 
            this.button_SumOfDice.Location = new System.Drawing.Point(34, 297);
            this.button_SumOfDice.Name = "button_SumOfDice";
            this.button_SumOfDice.Size = new System.Drawing.Size(132, 45);
            this.button_SumOfDice.TabIndex = 12;
            this.button_SumOfDice.Text = "SUM OF 2 DICE";
            this.button_SumOfDice.UseVisualStyleBackColor = true;
            this.button_SumOfDice.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form_Die_Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_SumOfDice);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.label_Seed);
            this.Controls.Add(this.label_Num_Rolls);
            this.Controls.Add(this.listBox_Rolls);
            this.Controls.Add(this.textBox_Seed);
            this.Controls.Add(this.pictureBox_Die2);
            this.Controls.Add(this.pictureBox_Die1);
            this.Controls.Add(this.button_Reset);
            this.Controls.Add(this.button_Stats);
            this.Controls.Add(this.button_Roll);
            this.Name = "Form_Die_Game";
            this.Text = "Die Game";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Die1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Die2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Roll;
        private System.Windows.Forms.Button button_Stats;
        private System.Windows.Forms.Button button_Reset;
        private System.Windows.Forms.PictureBox pictureBox_Die1;
        private System.Windows.Forms.PictureBox pictureBox_Die2;
        private System.Windows.Forms.TextBox textBox_Seed;
        private System.Windows.Forms.ListBox listBox_Rolls;
        private System.Windows.Forms.Label label_Num_Rolls;
        private System.Windows.Forms.Label label_Seed;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button button_SumOfDice;
    }

}

