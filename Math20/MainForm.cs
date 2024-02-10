using System;
using System.Collections;
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
    public struct OneQuery
    {
        public OneQuery(string Query, string Answer)
        {
            this.strQuery = Query;
            this.strAnswer = Answer;
        }
        public string strQuery;
        public string strAnswer;

        public string trueAnswer()
        {
            string answer;
            if (strQuery.Contains("_"))
            {
                answer = strQuery.Replace("_", strAnswer);
            }
            else
            {
                answer = strQuery + strAnswer;
            }
            return answer;
        }
    }

    public partial class MainForm : Form
    {
        private ArrayList QueryList = new ArrayList();
        private Random RndGen = new Random();
        private OneQuery curQuery;
        private int NuberInLIst;
        private int int_ErrorAmount = 0;
        private MsgForm messageForm = new MsgForm();
        

        public MainForm()
        {
            InitializeComponent();
        }


        private void InitQueryList()
        {
            this.QueryList.Clear();

            this.NuberInLIst = 0;
            this.int_ErrorAmount = 0;
            int NumerLimit = (this.checkBox_in10Limit.Checked) ? 10 : 20;

            // заповнюємо прикладами на додавання
            for (int dodanok1 = 1; dodanok1 <= NumerLimit; dodanok1++)
            {
                for (int dodanok2 = 0; (dodanok1 + dodanok2) <= NumerLimit; dodanok2++)
                {
                    this.QueryList.Add(new OneQuery(dodanok1.ToString() + "+"
                        + dodanok2.ToString() + "=", (dodanok1 + dodanok2).ToString()));
                }
            }

            // заповнюємо прикладами на віднімання
            if (this.chBoxDeduction.Checked == false)
            {
                for (int zmenshuvane = NumerLimit; zmenshuvane > 0; zmenshuvane--)
                {
                    for (int vidjemnyk = 0; (zmenshuvane - vidjemnyk) >= 1; vidjemnyk++)
                    {
                        this.QueryList.Add(new OneQuery(zmenshuvane.ToString() + "-"
                            + vidjemnyk.ToString() + "=", (zmenshuvane - vidjemnyk).ToString()));
                    }
                }
            }
            // вибираємо у випадковому порядку 20 запитань
            if (this.chBoxTest20question.Checked == true)
            {
                ArrayList truncQueryList = new ArrayList();
                for (int i=0; i < 20; i++)
                {
                    this.NuberInLIst = this.RndGen.Next(this.QueryList.Count);
                    truncQueryList.Add(this.QueryList[NuberInLIst]);
                }
                this.QueryList = truncQueryList;
            }

            if (this.checkBox_equation.Checked == true)
            {
                this.generateEquationList(NumerLimit);
            }

            // Настройка прогрес-бара
            this.progssBar.Maximum = this.QueryList.Count;
            this.progssBar.Value = this.QueryList.Count;
            this.l_QuaryListCount.Text = this.progssBar.Value.ToString();

            /* Виставляємо перший приклад.*/
            this.NuberInLIst = RndGen.Next(this.QueryList.Count);
            this.curQuery = (OneQuery)this.QueryList[this.NuberInLIst];
            this.l_MainShow.Text = this.curQuery.strQuery;
        }

        private void generateEquationList(int numerLimit)
        {
            // numerLimit 10 або 20, тобто операції мають бути в цих межах
            this.QueryList.Clear();

            for (int dodanok1 = 1; dodanok1 < numerLimit; dodanok1++)
            {
                for (int dodanok2 = 1; dodanok2 < numerLimit; dodanok2++)
                {
                    if (dodanok1 + dodanok2 <= numerLimit)
                    {
                        this.QueryList.Add(new OneQuery(dodanok1.ToString() + " + _ = " + (dodanok1 + dodanok2).ToString(), dodanok2.ToString()));
                    }
                }
            }
            
        }

        private void AnaliseBtn(string UserAnser)
        {
            this.l_MainShow.Text = "";
            if (this.curQuery.strAnswer == UserAnser)
            {
                // зміни значень прогрес-бара
                this.progssBar.Value--;
                this.l_QuaryListCount.Text = this.progssBar.Value.ToString();

                this.messageForm.Init_Message(this.curQuery.trueAnswer(), true);

                this.messageForm.ShowDialog();
                
                // видаляєм із списку приклад, на який дали правильну відповідь
                this.QueryList.RemoveAt(NuberInLIst);

                if (this.QueryList.Count > 0)
                {
                    // вибираєм слідуючий приклад
                    this.NuberInLIst = RndGen.Next(this.QueryList.Count);
                    this.curQuery = (OneQuery)this.QueryList[NuberInLIst];
                    this.l_MainShow.Text = this.curQuery.strQuery;
                }
                else
                {
                    if(this.int_ErrorAmount>0)
                        this.messageForm.Init_Message("Всього було помилок: " + this.int_ErrorAmount.ToString(), true);
                    else this.messageForm.Init_Message("Жодної помилки!!!", true);
                    this.messageForm.ShowDialog();
                    this.messageForm.Init_Message("cmd_End", true);
                    this.messageForm.ShowDialog();

                    if (MessageBox.Show("Програма закривається. Чи ти хочеш спробувати ще раз?", "Ти чудово справилася із завданням.", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    {
                        this.Close();
                    }
                    else
                    {
                        this.InitQueryList();
                    }
                }
            }
            else
            {
                this.int_ErrorAmount++;

                this.messageForm.Init_Message(this.curQuery.trueAnswer(), false);

                this.messageForm.ShowDialog();
                // вибираєм слідуючий приклад
                this.NuberInLIst = RndGen.Next(this.QueryList.Count);
                this.curQuery = (OneQuery)this.QueryList[NuberInLIst];
                this.l_MainShow.Text = this.curQuery.strQuery;
            }
        }


        private void MainForm_Load(object sender, EventArgs e)
        {
            this.InitQueryList();
        }

        private void buttonWithNumber_Click(object sender, EventArgs e)
        {
            this.AnaliseBtn(((Button)sender).Text);
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            Size FixSize = new Size(1280, 700);// стандартний розмір.
            if (this.Size == FixSize)
            {
                this.pnl_Main.Location = new Point(0, 0);
            }
            else
            {
                this.pnl_Main.Location = new Point(((this.Size.Width - this.pnl_Main.Size.Width) >> 1)-8, 
                    ((this.Size.Height - this.pnl_Main.Size.Height) >> 1)-22);
            }
        }
    }
}