namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Draw();
        }

        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);

            Graphics graph = Graphics.FromImage(bmp);

            Pen pen1 = new Pen(Color.Blue, 2);

            Pen pen2 = new Pen(Color.Red, 4);

            SolidBrush bg = new SolidBrush(Color.Black);

            Font font = new Font("Arial", 10);

            graph.DrawLine(pen1, 50, 20, 50, 200);
            graph.DrawLine(pen1, 50, 20, 200, 200);
            graph.DrawLine(pen1, 50, 200, 200, 200);

            pictureBox1.Image = bmp;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string astr, bstr, cstr;

            astr = ainput.Text;
            bstr = binput.Text;
            cstr = cinput.Text;

            int a, b, c;

            if (int.TryParse(astr, out a) && int.TryParse(bstr, out b) && int.TryParse(cstr, out c))
            {
                if (a * a + b * b == c * c || a * a + c * c == b * b || b * b + c * c == a * a)
                {
                    if (c > a && c > b)
                    {
                        aresult.Text = "Катет";
                        bresult.Text = "Катет";
                        cresult.Text = "Гипотенуза";
                    }
                    else if (b > a && b > c)
                    {
                        aresult.Text = "Катет";
                        bresult.Text = "Гипотенуза";
                        cresult.Text = "Катет";
                    }
                    else
                    {
                        aresult.Text = "Гипотенуза";
                        bresult.Text = "Катет";
                        cresult.Text = "Катет";
                    }
                }
                else
                {
                    MessageBox.Show("Треугольник не является прямоугольным.");
                }
            }
            else
            {

                MessageBox.Show("Ошибка ввода. Пожалуйста, введите только цифры.");
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Коваль Ангеліна КН21\nМовою програмування  C#  написати  програму  з  графічним  інтерфейсом. Результат  роботи програми повинен відповідати наведеному в прикладі. ");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
