
namespace HITSEconomic
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonStop = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.buyAndSell = new System.Windows.Forms.NumericUpDown();
            this.AmountOfEuro = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.AmountOfRubles = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonSell = new System.Windows.Forms.Button();
            this.buttonBuy = new System.Windows.Forms.Button();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.daysCount = new System.Windows.Forms.NumericUpDown();
            this.startPrice = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buyAndSell)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.daysCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.startPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonStop);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.buyAndSell);
            this.panel1.Controls.Add(this.AmountOfEuro);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.AmountOfRubles);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.buttonSell);
            this.panel1.Controls.Add(this.buttonBuy);
            this.panel1.Controls.Add(this.buttonCalculate);
            this.panel1.Controls.Add(this.daysCount);
            this.panel1.Controls.Add(this.startPrice);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(925, 95);
            this.panel1.TabIndex = 0;
            // 
            // buttonStop
            // 
            this.buttonStop.Location = new System.Drawing.Point(196, 46);
            this.buttonStop.Margin = new System.Windows.Forms.Padding(2);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(76, 30);
            this.buttonStop.TabIndex = 13;
            this.buttonStop.Text = "Stop";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(316, 9);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "TOTAL:";
            // 
            // buyAndSell
            // 
            this.buyAndSell.DecimalPlaces = 4;
            this.buyAndSell.Location = new System.Drawing.Point(549, 32);
            this.buyAndSell.Margin = new System.Windows.Forms.Padding(2);
            this.buyAndSell.Name = "buyAndSell";
            this.buyAndSell.Size = new System.Drawing.Size(90, 20);
            this.buyAndSell.TabIndex = 11;
            this.buyAndSell.ThousandsSeparator = true;
            // 
            // AmountOfEuro
            // 
            this.AmountOfEuro.AutoSize = true;
            this.AmountOfEuro.Location = new System.Drawing.Point(378, 63);
            this.AmountOfEuro.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AmountOfEuro.Name = "AmountOfEuro";
            this.AmountOfEuro.Size = new System.Drawing.Size(13, 13);
            this.AmountOfEuro.TabIndex = 10;
            this.AmountOfEuro.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(316, 63);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "USD:";
            // 
            // AmountOfRubles
            // 
            this.AmountOfRubles.AutoSize = true;
            this.AmountOfRubles.Location = new System.Drawing.Point(378, 32);
            this.AmountOfRubles.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AmountOfRubles.Name = "AmountOfRubles";
            this.AmountOfRubles.Size = new System.Drawing.Size(31, 13);
            this.AmountOfRubles.TabIndex = 8;
            this.AmountOfRubles.Text = "1000";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(316, 32);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "RUB:";
            // 
            // buttonSell
            // 
            this.buttonSell.Location = new System.Drawing.Point(450, 53);
            this.buttonSell.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSell.Name = "buttonSell";
            this.buttonSell.Size = new System.Drawing.Size(76, 28);
            this.buttonSell.TabIndex = 6;
            this.buttonSell.Text = "Sell";
            this.buttonSell.UseVisualStyleBackColor = true;
            this.buttonSell.Click += new System.EventHandler(this.buttonSell_Click);
            // 
            // buttonBuy
            // 
            this.buttonBuy.Location = new System.Drawing.Point(450, 17);
            this.buttonBuy.Margin = new System.Windows.Forms.Padding(2);
            this.buttonBuy.Name = "buttonBuy";
            this.buttonBuy.Size = new System.Drawing.Size(76, 28);
            this.buttonBuy.TabIndex = 5;
            this.buttonBuy.Text = "Buy";
            this.buttonBuy.UseVisualStyleBackColor = true;
            this.buttonBuy.Click += new System.EventHandler(this.buttonBuy_Click);
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Location = new System.Drawing.Point(196, 6);
            this.buttonCalculate.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(76, 31);
            this.buttonCalculate.TabIndex = 4;
            this.buttonCalculate.Text = "Calculate";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // daysCount
            // 
            this.daysCount.Location = new System.Drawing.Point(73, 53);
            this.daysCount.Margin = new System.Windows.Forms.Padding(2);
            this.daysCount.Name = "daysCount";
            this.daysCount.Size = new System.Drawing.Size(90, 20);
            this.daysCount.TabIndex = 3;
            // 
            // startPrice
            // 
            this.startPrice.DecimalPlaces = 4;
            this.startPrice.Location = new System.Drawing.Point(73, 11);
            this.startPrice.Margin = new System.Windows.Forms.Padding(2);
            this.startPrice.Name = "startPrice";
            this.startPrice.Size = new System.Drawing.Size(90, 20);
            this.startPrice.TabIndex = 2;
            this.startPrice.ThousandsSeparator = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 55);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Days:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Input price:";
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(0, 92);
            this.chart1.Margin = new System.Windows.Forms.Padding(2);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.IsValueShownAsLabel = true;
            series2.LabelFormat = "f4";
            series2.Legend = "Legend1";
            series2.Name = "Euro";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(925, 377);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 468);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buyAndSell)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.daysCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.startPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Panel panel1;

        #endregion

        private System.Windows.Forms.NumericUpDown daysCount;
        private System.Windows.Forms.NumericUpDown startPrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label AmountOfRubles;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonSell;
        private System.Windows.Forms.Button buttonBuy;
        private System.Windows.Forms.Label AmountOfEuro;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown buyAndSell;
        private System.Windows.Forms.Button buttonStop;
    }
}

