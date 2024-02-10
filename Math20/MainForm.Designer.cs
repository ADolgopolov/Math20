namespace Math20
{
    partial class MainForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnl_Main = new System.Windows.Forms.Panel();
            this.checkBox_in10Limit = new System.Windows.Forms.CheckBox();
            this.chBoxTest20question = new System.Windows.Forms.CheckBox();
            this.chBoxDeduction = new System.Windows.Forms.CheckBox();
            this.progssBar = new System.Windows.Forms.ProgressBar();
            this.l_QuaryListCount = new System.Windows.Forms.Label();
            this.button20 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.l_MainShow = new System.Windows.Forms.Label();
            this.checkBox_equation = new System.Windows.Forms.CheckBox();
            this.pnl_Main.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Main
            // 
            this.pnl_Main.Controls.Add(this.checkBox_equation);
            this.pnl_Main.Controls.Add(this.checkBox_in10Limit);
            this.pnl_Main.Controls.Add(this.chBoxTest20question);
            this.pnl_Main.Controls.Add(this.chBoxDeduction);
            this.pnl_Main.Controls.Add(this.progssBar);
            this.pnl_Main.Controls.Add(this.l_QuaryListCount);
            this.pnl_Main.Controls.Add(this.button20);
            this.pnl_Main.Controls.Add(this.button19);
            this.pnl_Main.Controls.Add(this.button18);
            this.pnl_Main.Controls.Add(this.button17);
            this.pnl_Main.Controls.Add(this.button16);
            this.pnl_Main.Controls.Add(this.button15);
            this.pnl_Main.Controls.Add(this.button14);
            this.pnl_Main.Controls.Add(this.button13);
            this.pnl_Main.Controls.Add(this.button12);
            this.pnl_Main.Controls.Add(this.button11);
            this.pnl_Main.Controls.Add(this.button10);
            this.pnl_Main.Controls.Add(this.button9);
            this.pnl_Main.Controls.Add(this.button8);
            this.pnl_Main.Controls.Add(this.button7);
            this.pnl_Main.Controls.Add(this.button6);
            this.pnl_Main.Controls.Add(this.button5);
            this.pnl_Main.Controls.Add(this.button4);
            this.pnl_Main.Controls.Add(this.button3);
            this.pnl_Main.Controls.Add(this.button2);
            this.pnl_Main.Controls.Add(this.button1);
            this.pnl_Main.Controls.Add(this.l_MainShow);
            this.pnl_Main.Location = new System.Drawing.Point(0, 0);
            this.pnl_Main.Name = "pnl_Main";
            this.pnl_Main.Size = new System.Drawing.Size(1260, 656);
            this.pnl_Main.TabIndex = 25;
            // 
            // checkBox_in10Limit
            // 
            this.checkBox_in10Limit.AutoSize = true;
            this.checkBox_in10Limit.Checked = true;
            this.checkBox_in10Limit.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_in10Limit.Location = new System.Drawing.Point(241, 605);
            this.checkBox_in10Limit.Name = "checkBox_in10Limit";
            this.checkBox_in10Limit.Size = new System.Drawing.Size(83, 17);
            this.checkBox_in10Limit.TabIndex = 45;
            this.checkBox_in10Limit.Text = "в межах 10";
            this.checkBox_in10Limit.UseVisualStyleBackColor = true;
            this.checkBox_in10Limit.CheckedChanged += new System.EventHandler(this.MainForm_Load);
            // 
            // chBoxTest20question
            // 
            this.chBoxTest20question.AutoSize = true;
            this.chBoxTest20question.Checked = true;
            this.chBoxTest20question.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chBoxTest20question.Location = new System.Drawing.Point(140, 605);
            this.chBoxTest20question.Name = "chBoxTest20question";
            this.chBoxTest20question.Size = new System.Drawing.Size(101, 17);
            this.chBoxTest20question.TabIndex = 44;
            this.chBoxTest20question.Text = "тест 20 питань";
            this.chBoxTest20question.UseVisualStyleBackColor = true;
            this.chBoxTest20question.CheckedChanged += new System.EventHandler(this.MainForm_Load);
            // 
            // chBoxDeduction
            // 
            this.chBoxDeduction.AutoSize = true;
            this.chBoxDeduction.Checked = true;
            this.chBoxDeduction.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chBoxDeduction.Location = new System.Drawing.Point(12, 605);
            this.chBoxDeduction.Name = "chBoxDeduction";
            this.chBoxDeduction.Size = new System.Drawing.Size(131, 17);
            this.chBoxDeduction.TabIndex = 43;
            this.chBoxDeduction.Text = "Тільки на додавання";
            this.chBoxDeduction.UseVisualStyleBackColor = true;
            this.chBoxDeduction.CheckedChanged += new System.EventHandler(this.MainForm_Load);
            // 
            // progssBar
            // 
            this.progssBar.Location = new System.Drawing.Point(12, 635);
            this.progssBar.Name = "progssBar";
            this.progssBar.Size = new System.Drawing.Size(1240, 15);
            this.progssBar.Step = 1;
            this.progssBar.TabIndex = 42;
            // 
            // l_QuaryListCount
            // 
            this.l_QuaryListCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 5F);
            this.l_QuaryListCount.Location = new System.Drawing.Point(1238, 0);
            this.l_QuaryListCount.Name = "l_QuaryListCount";
            this.l_QuaryListCount.Size = new System.Drawing.Size(22, 17);
            this.l_QuaryListCount.TabIndex = 41;
            this.l_QuaryListCount.Text = "0";
            this.l_QuaryListCount.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // button20
            // 
            this.button20.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold);
            this.button20.Location = new System.Drawing.Point(1137, 487);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(120, 100);
            this.button20.TabIndex = 40;
            this.button20.Text = "20";
            this.button20.UseVisualStyleBackColor = true;
            this.button20.Click += new System.EventHandler(this.buttonWithNumber_Click);
            // 
            // button19
            // 
            this.button19.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold);
            this.button19.Location = new System.Drawing.Point(1011, 487);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(120, 100);
            this.button19.TabIndex = 39;
            this.button19.Text = "19";
            this.button19.UseVisualStyleBackColor = true;
            this.button19.Click += new System.EventHandler(this.buttonWithNumber_Click);
            // 
            // button18
            // 
            this.button18.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold);
            this.button18.Location = new System.Drawing.Point(885, 487);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(120, 100);
            this.button18.TabIndex = 38;
            this.button18.Text = "18";
            this.button18.UseVisualStyleBackColor = true;
            this.button18.Click += new System.EventHandler(this.buttonWithNumber_Click);
            // 
            // button17
            // 
            this.button17.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold);
            this.button17.Location = new System.Drawing.Point(759, 487);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(120, 100);
            this.button17.TabIndex = 37;
            this.button17.Text = "17";
            this.button17.UseVisualStyleBackColor = true;
            this.button17.Click += new System.EventHandler(this.buttonWithNumber_Click);
            // 
            // button16
            // 
            this.button16.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold);
            this.button16.Location = new System.Drawing.Point(633, 487);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(120, 100);
            this.button16.TabIndex = 36;
            this.button16.Text = "16";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.buttonWithNumber_Click);
            // 
            // button15
            // 
            this.button15.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold);
            this.button15.Location = new System.Drawing.Point(507, 487);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(120, 100);
            this.button15.TabIndex = 35;
            this.button15.Text = "15";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.buttonWithNumber_Click);
            // 
            // button14
            // 
            this.button14.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold);
            this.button14.Location = new System.Drawing.Point(381, 487);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(120, 100);
            this.button14.TabIndex = 34;
            this.button14.Text = "14";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.buttonWithNumber_Click);
            // 
            // button13
            // 
            this.button13.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold);
            this.button13.Location = new System.Drawing.Point(255, 487);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(120, 100);
            this.button13.TabIndex = 33;
            this.button13.Text = "13";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.buttonWithNumber_Click);
            // 
            // button12
            // 
            this.button12.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold);
            this.button12.Location = new System.Drawing.Point(129, 487);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(120, 100);
            this.button12.TabIndex = 32;
            this.button12.Text = "12";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.buttonWithNumber_Click);
            // 
            // button11
            // 
            this.button11.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold);
            this.button11.Location = new System.Drawing.Point(3, 487);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(120, 100);
            this.button11.TabIndex = 31;
            this.button11.Text = "11";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.buttonWithNumber_Click);
            // 
            // button10
            // 
            this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button10.Location = new System.Drawing.Point(1137, 316);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(120, 100);
            this.button10.TabIndex = 30;
            this.button10.Text = "10";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.buttonWithNumber_Click);
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button9.Location = new System.Drawing.Point(1011, 316);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(120, 100);
            this.button9.TabIndex = 29;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.buttonWithNumber_Click);
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button8.Location = new System.Drawing.Point(885, 316);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(120, 100);
            this.button8.TabIndex = 28;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.buttonWithNumber_Click);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button7.Location = new System.Drawing.Point(759, 316);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(120, 100);
            this.button7.TabIndex = 27;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.buttonWithNumber_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button6.Location = new System.Drawing.Point(633, 316);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(120, 100);
            this.button6.TabIndex = 26;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.buttonWithNumber_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button5.Location = new System.Drawing.Point(507, 316);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(120, 100);
            this.button5.TabIndex = 25;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.buttonWithNumber_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Location = new System.Drawing.Point(381, 316);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(120, 100);
            this.button4.TabIndex = 24;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.buttonWithNumber_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(255, 316);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(120, 100);
            this.button3.TabIndex = 23;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.buttonWithNumber_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(129, 316);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 100);
            this.button2.TabIndex = 22;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.buttonWithNumber_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(3, 316);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 100);
            this.button1.TabIndex = 21;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.buttonWithNumber_Click);
            // 
            // l_MainShow
            // 
            this.l_MainShow.BackColor = System.Drawing.Color.AliceBlue;
            this.l_MainShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l_MainShow.Location = new System.Drawing.Point(10, 60);
            this.l_MainShow.Name = "l_MainShow";
            this.l_MainShow.Size = new System.Drawing.Size(1240, 160);
            this.l_MainShow.TabIndex = 8;
            this.l_MainShow.Text = "10+10=";
            this.l_MainShow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // checkBox_equation
            // 
            this.checkBox_equation.AutoSize = true;
            this.checkBox_equation.Checked = true;
            this.checkBox_equation.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_equation.Location = new System.Drawing.Point(330, 605);
            this.checkBox_equation.Name = "checkBox_equation";
            this.checkBox_equation.Size = new System.Drawing.Size(70, 17);
            this.checkBox_equation.TabIndex = 46;
            this.checkBox_equation.Text = "рівняння";
            this.checkBox_equation.UseVisualStyleBackColor = true;
            this.checkBox_equation.CheckedChanged += new System.EventHandler(this.MainForm_Load);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 662);
            this.Controls.Add(this.pnl_Main);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Математика 20";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.pnl_Main.ResumeLayout(false);
            this.pnl_Main.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Main;
        private System.Windows.Forms.CheckBox chBoxTest20question;
        private System.Windows.Forms.CheckBox chBoxDeduction;
        private System.Windows.Forms.ProgressBar progssBar;
        private System.Windows.Forms.Label l_QuaryListCount;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label l_MainShow;
        private System.Windows.Forms.CheckBox checkBox_in10Limit;
        private System.Windows.Forms.CheckBox checkBox_equation;
    }
}

