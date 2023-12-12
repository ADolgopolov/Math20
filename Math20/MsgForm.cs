using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Math20
{
    public partial class MsgForm : Form
    {
        private string[] str_goodmark = 
        { 
        "Молодець!",
        "Відміно!",
        "Молодчинка!",
        "Умнічка!",
        "Просто геній!",
        "Відмінниця!",
        "Дуже добре!",
        "Талант!",
        "Чудово!",
        "Геніально!",
        "Правильно!",
        "Угадала!",
        "Супер!",
        "Ти знала!",
        "Добре!",
        "Вся в папу!"
        };
        private string[] str_bedmark = 
        { 
        "Будь уважною.",
        "Неправильно.",
        "Не поспішай.",
        "Зконцентруйся.",
        "Не попала.",
        "Подумай.",
        "Помилка.",
        "Правильно так:",
        "Ні! Ні! Ні!",
        "Не вгадала.",
        "Порахуй.",
        "Погано.",
        "Пригадай.",
        "Запамятай:",
        "Ти можеш краще.",
        "Мені сумно.",
        "Не спи!"
        };
        private Random RndGen = new Random();
        public MsgForm()
        {
            InitializeComponent();
        }

        public void Init_Message(string str_Examle, bool b_Good)
        {
            this.l_Example.Text = str_Examle;
            if (b_Good)
            {
                this.l_mark.Text = str_goodmark[this.RndGen.Next(16)];
                this.l_mark.ForeColor = Color.Red;

                this.l_Example.BackColor = System.Drawing.Color.AliceBlue;

                if (str_Examle == "cmd_End")
                {
                    this.l_Example.Text = "Відпочинь і спробуй пізніше.";
                    this.l_Example.Font = new Font(this.l_Example.Font.Name, 48.0f, this.l_Example.Font.Style, this.l_Example.Font.Unit);
                }
            }
            else
            {
                this.l_mark.Text = str_bedmark[this.RndGen.Next(17)];
                this.l_mark.ForeColor = Color.Purple;
                this.l_Example.BackColor = System.Drawing.Color.YellowGreen;
            }
        }
        private void MsgForm_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
        }

        private void MsgForm_KeyDown(object sender, KeyEventArgs e)
        {
            this.Close();
        }

        private void l_Example_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void l_mark_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
