using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppLesson2
{
    public partial class Form1 : Form
    {
        // метод инициализации
        public Form1()
        {
            InitializeComponent();
        }
        // метод нажатия на кнопку
        private void button1_Click(object sender, EventArgs e)
        {
            button1.Text = "-";
            button1.BackColor = Color.Blue;
            label1.Text = textBox1.Text;
        }
        // метод загрузки формы
        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Text = "ок";
            label1.Text = "оп оп";
            textBox1.Text = "опля";
        }
        // метод нажатия на кнопку 2
        private void button2_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button1.BackColor = Color.Purple;
            button1.Text = "ок";
        }
    }
}
