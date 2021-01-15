using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace double_Pendulum
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            chart1.Series.Add(new Series());
            chart1.Series[0].ChartType = SeriesChartType.Line;
            chart1.Series[1].ChartType = SeriesChartType.Line;
            chart1.Series[0].Name = "Верхняя нить";
            chart1.Series[1].Name = "Нижняя нить";
            chart1.ChartAreas[0].AxisX.Title = "Время, с";
            chart1.ChartAreas[0].AxisY.Title = "Угол, град";



        }

        float m1, m2, length1,length2,angle1,angle2,angle_velocity1, angle_velocity2, dt, angle_acceleration1, angle_acceleration2, time;


        const float g = 9.8f;
        float dl1, dl2 = 100f;

        Pen pen = new Pen(Color.Blue);
        Pen pen1 = new Pen(Color.Green);
        Pen pen2 = new Pen(Color.Red);
       

        private void initComponents() // Инициализируем все данные с формы
        {
           m1 = float.Parse(m1_text.Text);
           m2 = float.Parse(m2_text.Text);
           length1 = float.Parse(l1_text.Text);
           length2 = float.Parse(l2_text.Text);
           angle1 = float.Parse(angle1_text.Text) * 3.14f / 180f;
           angle2 = float.Parse(angle2_text.Text) * 3.14f / 180f;
           angle_velocity1 = float.Parse(velocity1_text.Text);
           angle_velocity2 = float.Parse(velocity2_text.Text);
           dt = (float)dt_trackbar.Value / 1000f;
        }

        private void secondDerivs(float m1, float m2, float l1, float l2, float a1, float v1, float a2, float v2) {  //решаем уравнения Лагранжа
            float sin1 = (float)Math.Sin(a1);
            float sin2 = (float)Math.Sin(a2);
            float sin12 = (float)Math.Sin(a2 - a1);
            float cos12 = (float)Math.Cos(a2 - a1);

            angle_acceleration1 = (m2 * l1 * v1 * v1 * sin12 * cos12 + m2 * g * sin2 * cos12 + m2 * l2 * v2 * v2 * sin12 - (m1+m2) * g * sin1) / ((m1+m2) * l1 - m2 * l1 * cos12 * cos12);
            angle_acceleration2 = (-m2 * l2 * v2 * v2 * sin12 * cos12 + (m1 + m2) * g * sin1 * cos12 - (m1 + m2) * l1 * v1 * v1 * sin12 - (m1 + m2) * g * sin2) / ((l2 / l1) * ((m1 + m2) * l1 - m2 * l1 * cos12 * cos12));
        
        }

        private void start_button_Click(object sender, EventArgs e) //Передаем значения с текстбоксов в филды
        {
            chart1.Series[0].Points.Clear();
            chart1.Series[1].Points.Clear();
            time = 0f;
            pen2.Width = 2f;
            pen.Width = 4f;
            pen1.DashStyle = System.Drawing.Drawing2D.DashStyle.DashDotDot;
            initComponents();

            if (length1 > length2)
            {
                float scale = length2 / length1;
                dl2 = 100f * scale;
            }

            else if (length1 < length2)
            {
                float scale = length1 / length2;
                dl1 = 100f * scale;
            }

            else dl1 = dl2 = 100f;

            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e) //тик таймера == работы двойного маятника
        {
            dt = (float)dt_trackbar.Value / 1000f;
            dt_text.Text = (dt_trackbar.Value / 1000f).ToString();
            time += dt;
            float x_offset = pictureBox1.Width / 2;
            float y_offset = pictureBox1.Height / 4;

            Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            Graphics graphics = Graphics.FromImage(bmp);

           

            secondDerivs(m1, m2, length1, length2, angle1, angle_velocity1, angle2, angle_velocity2);

            angle_velocity1 += angle_acceleration1 * dt;
            angle1 += angle_velocity1 * dt;
            angle_velocity2 += angle_acceleration2 * dt;
            angle2 += angle_velocity2 * dt;

          
            double x1 = dl1 * Math.Sin(angle1) + x_offset;
            double y1 = dl1 * Math.Cos(angle1) + y_offset;
            double x2 = x1 + dl2 * Math.Sin(angle2);
            double y2 = y1 + dl2 * Math.Cos(angle2);

            //Рисуем отрезки и окружности

            graphics.DrawLine(pen1, x_offset, y_offset, x_offset, pictureBox1.Height);
            graphics.DrawLine(pen, x_offset, y_offset, (float)x1, (float)y1);
            graphics.DrawLine(pen, (float)x1, (float)y1, (float)x2, (float)y2);
            graphics.FillEllipse((new SolidBrush(Color.Blue)), (float)x1 - 5, (float)y1 - 5, 10, 10);
            graphics.DrawEllipse(pen2, (float)x1 - 5, (float)y1 - 5, 10, 10);
            graphics.FillEllipse((new SolidBrush(Color.Blue)), (float)x2 - 5, (float)y2 - 5, 10, 10);
            graphics.DrawEllipse(pen2, (float)x2 - 5, (float)y2 - 5, 10, 10);

            pictureBox1.Image = bmp;

            //отрисовываем график углов отклонения нитей
            chart1.Series[0].Points.AddXY(time, (angle1 * 180 / Math.PI));
            chart1.Series[1].Points.AddXY(time, (angle2 * 180 / Math.PI));

        }

        private void button1_Click(object sender, EventArgs e) //останавливаем таймер
        {
            timer1.Stop();
        }

        private void continue_button_Click(object sender, EventArgs e) //продолжаем работу
        {
            timer1.Start();
            dt = (float)dt_trackbar.Value / 1000f;
            dt_text.Text = (dt_trackbar.Value / 1000f).ToString();
        }
    }
}
