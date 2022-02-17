using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ///-------------------- N1
            // 1 - переменная для числа оборотов
            double N1 = 0;
            // 2 - пробуем преобразовать текст в число и проверить результат
            bool res = double.TryParse(textBox1.Text, out N1);
            // 3 - если результат с ошибкой
            if (res!=true)
            {
                // 4 считаем, что задано 1000 об/мин
                N1 = 1000;
            }
            // 5 Проверяем, что заданы правлильные частоты
            if (N1 < 500) N1 = 500;
            if (N1 > 1500) N1 = 1500;
            // 6 Пишем "настоящие" частоты в textBox1
            textBox1.Text = N1.ToString();

            ///-------------------- N2
            // 1 - переменная для числа оборотов
            double N2 = 0;
            // 2 - пробуем преобразовать текст в число и проверить результат
            res = double.TryParse(textBox2.Text, out N2);
            // 3 - если результат с ошибкой
            if (res != true)
            {
                // 4 считаем, что задано 200 об/мин
                N2 = 200;
            }
            // 5 Проверяем, что заданы правлильные частоты
            if (N2 < 10) N1 = 10;
            if (N2 > 250) N1 = 250;
            // 6 Пишем "настоящие" частоты в textBox2
            textBox2.Text = N2.ToString();

            //----------------------- Расчеты
            // округляем до 2-х знаков
            double U = Math.Round(N1 / N2, 2);
            double U1 = Math.Round(Math.Sqrt(U) * 1.25);
            double U2 = Math.Round(U/U1,2);

            //----------------------- Вывод
            textBox3.Text = U.ToString();
            textBox4.Text = U1.ToString();
            textBox5.Text = U2.ToString();
        }
    }
}
