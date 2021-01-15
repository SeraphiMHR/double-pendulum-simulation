namespace double_Pendulum
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.start_button = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.dt_text = new System.Windows.Forms.TextBox();
            this.l1_text = new System.Windows.Forms.TextBox();
            this.velocity1_text = new System.Windows.Forms.TextBox();
            this.angle1_text = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.m1_text = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.m2_text = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.l2_text = new System.Windows.Forms.TextBox();
            this.angle2_text = new System.Windows.Forms.TextBox();
            this.velocity2_text = new System.Windows.Forms.TextBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.continue_button = new System.Windows.Forms.Button();
            this.dt_trackbar = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_trackbar)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(297, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(776, 431);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // start_button
            // 
            this.start_button.BackColor = System.Drawing.Color.White;
            this.start_button.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.start_button.Location = new System.Drawing.Point(8, 12);
            this.start_button.Name = "start_button";
            this.start_button.Size = new System.Drawing.Size(79, 23);
            this.start_button.TabIndex = 1;
            this.start_button.Text = "Пуск";
            this.start_button.UseVisualStyleBackColor = false;
            this.start_button.Click += new System.EventHandler(this.start_button_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(103, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Стоп";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dt_text
            // 
            this.dt_text.BackColor = System.Drawing.Color.PeachPuff;
            this.dt_text.Location = new System.Drawing.Point(8, 66);
            this.dt_text.Name = "dt_text";
            this.dt_text.Size = new System.Drawing.Size(45, 20);
            this.dt_text.TabIndex = 3;
            this.dt_text.Text = "0,005";
            this.dt_text.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // l1_text
            // 
            this.l1_text.BackColor = System.Drawing.Color.PeachPuff;
            this.l1_text.Location = new System.Drawing.Point(191, 12);
            this.l1_text.Name = "l1_text";
            this.l1_text.Size = new System.Drawing.Size(88, 20);
            this.l1_text.TabIndex = 4;
            this.l1_text.Text = "1";
            this.l1_text.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // velocity1_text
            // 
            this.velocity1_text.BackColor = System.Drawing.Color.PeachPuff;
            this.velocity1_text.Location = new System.Drawing.Point(191, 64);
            this.velocity1_text.Name = "velocity1_text";
            this.velocity1_text.Size = new System.Drawing.Size(88, 20);
            this.velocity1_text.TabIndex = 6;
            this.velocity1_text.Text = "0";
            this.velocity1_text.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // angle1_text
            // 
            this.angle1_text.BackColor = System.Drawing.Color.PeachPuff;
            this.angle1_text.Location = new System.Drawing.Point(191, 38);
            this.angle1_text.Name = "angle1_text";
            this.angle1_text.Size = new System.Drawing.Size(88, 20);
            this.angle1_text.TabIndex = 5;
            this.angle1_text.Text = "70";
            this.angle1_text.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(13, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 28);
            this.label1.TabIndex = 7;
            this.label1.Text = "dt";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(4, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 28);
            this.label2.TabIndex = 8;
            this.label2.Text = "Длина нити";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Print", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(4, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 28);
            this.label3.TabIndex = 9;
            this.label3.Text = "Угол отклонения";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.m1_text);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.l1_text);
            this.panel1.Controls.Add(this.angle1_text);
            this.panel1.Controls.Add(this.velocity1_text);
            this.panel1.Location = new System.Drawing.Point(8, 110);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(283, 144);
            this.panel1.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe Print", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(4, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 28);
            this.label5.TabIndex = 12;
            this.label5.Text = "Масса";
            // 
            // m1_text
            // 
            this.m1_text.BackColor = System.Drawing.Color.PeachPuff;
            this.m1_text.Location = new System.Drawing.Point(191, 90);
            this.m1_text.Name = "m1_text";
            this.m1_text.Size = new System.Drawing.Size(88, 20);
            this.m1_text.TabIndex = 11;
            this.m1_text.Text = "1";
            this.m1_text.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe Print", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(3, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(181, 28);
            this.label4.TabIndex = 10;
            this.label4.Text = "Начальная скорость";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.m2_text);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.l2_text);
            this.panel2.Controls.Add(this.angle2_text);
            this.panel2.Controls.Add(this.velocity2_text);
            this.panel2.Location = new System.Drawing.Point(8, 284);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(283, 149);
            this.panel2.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe Print", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(4, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 28);
            this.label6.TabIndex = 12;
            this.label6.Text = "Масса";
            // 
            // m2_text
            // 
            this.m2_text.BackColor = System.Drawing.Color.PeachPuff;
            this.m2_text.Location = new System.Drawing.Point(191, 90);
            this.m2_text.Name = "m2_text";
            this.m2_text.Size = new System.Drawing.Size(88, 20);
            this.m2_text.TabIndex = 11;
            this.m2_text.Text = "1";
            this.m2_text.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe Print", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(3, 62);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(181, 28);
            this.label7.TabIndex = 10;
            this.label7.Text = "Начальная скорость";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe Print", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(4, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(116, 28);
            this.label8.TabIndex = 8;
            this.label8.Text = "Длина нити";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe Print", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(4, 38);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(153, 28);
            this.label9.TabIndex = 9;
            this.label9.Text = "Угол отклонения";
            // 
            // l2_text
            // 
            this.l2_text.BackColor = System.Drawing.Color.PeachPuff;
            this.l2_text.Location = new System.Drawing.Point(191, 12);
            this.l2_text.Name = "l2_text";
            this.l2_text.Size = new System.Drawing.Size(88, 20);
            this.l2_text.TabIndex = 4;
            this.l2_text.Text = "1";
            this.l2_text.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // angle2_text
            // 
            this.angle2_text.BackColor = System.Drawing.Color.PeachPuff;
            this.angle2_text.Location = new System.Drawing.Point(191, 38);
            this.angle2_text.Name = "angle2_text";
            this.angle2_text.Size = new System.Drawing.Size(88, 20);
            this.angle2_text.TabIndex = 5;
            this.angle2_text.Text = "45";
            this.angle2_text.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // velocity2_text
            // 
            this.velocity2_text.BackColor = System.Drawing.Color.PeachPuff;
            this.velocity2_text.Location = new System.Drawing.Point(191, 64);
            this.velocity2_text.Name = "velocity2_text";
            this.velocity2_text.Size = new System.Drawing.Size(88, 20);
            this.velocity2_text.TabIndex = 6;
            this.velocity2_text.Text = "0";
            this.velocity2_text.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.DarkSalmon;
            this.chart1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.VerticalCenter;
            this.chart1.BackHatchStyle = System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle.BackwardDiagonal;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(8, 439);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(1065, 300);
            this.chart1.TabIndex = 14;
            this.chart1.Text = "chart1";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(72, 83);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(145, 24);
            this.label10.TabIndex = 15;
            this.label10.Text = "Верхняя нить";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(72, 257);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(138, 24);
            this.label11.TabIndex = 16;
            this.label11.Text = "Нижняя нить";
            // 
            // continue_button
            // 
            this.continue_button.BackColor = System.Drawing.Color.White;
            this.continue_button.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.continue_button.Location = new System.Drawing.Point(199, 12);
            this.continue_button.Name = "continue_button";
            this.continue_button.Size = new System.Drawing.Size(88, 23);
            this.continue_button.TabIndex = 17;
            this.continue_button.Text = "Продолжить";
            this.continue_button.UseVisualStyleBackColor = false;
            this.continue_button.Click += new System.EventHandler(this.continue_button_Click);
            // 
            // dt_trackbar
            // 
            this.dt_trackbar.Location = new System.Drawing.Point(66, 41);
            this.dt_trackbar.Maximum = 100;
            this.dt_trackbar.Name = "dt_trackbar";
            this.dt_trackbar.Size = new System.Drawing.Size(225, 45);
            this.dt_trackbar.TabIndex = 18;
            this.dt_trackbar.Value = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Salmon;
            this.ClientSize = new System.Drawing.Size(1082, 751);
            this.Controls.Add(this.dt_trackbar);
            this.Controls.Add(this.continue_button);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dt_text);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.start_button);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Двойной Маятник";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_trackbar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button start_button;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox dt_text;
        private System.Windows.Forms.TextBox l1_text;
        private System.Windows.Forms.TextBox velocity1_text;
        private System.Windows.Forms.TextBox angle1_text;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox m1_text;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox m2_text;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox l2_text;
        private System.Windows.Forms.TextBox angle2_text;
        private System.Windows.Forms.TextBox velocity2_text;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button continue_button;
        private System.Windows.Forms.TrackBar dt_trackbar;
    }
}

