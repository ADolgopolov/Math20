namespace Math20
{
    partial class MsgForm
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
            this.l_Example = new System.Windows.Forms.Label();
            this.l_mark = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // l_Example
            // 
            this.l_Example.BackColor = System.Drawing.Color.YellowGreen;
            this.l_Example.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold);
            this.l_Example.Location = new System.Drawing.Point(12, 140);
            this.l_Example.Name = "l_Example";
            this.l_Example.Size = new System.Drawing.Size(1240, 160);
            this.l_Example.TabIndex = 0;
            this.l_Example.Text = "10+10=";
            this.l_Example.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.l_Example.Click += new System.EventHandler(this.l_Example_Click);
            // 
            // l_mark
            // 
            this.l_mark.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l_mark.Location = new System.Drawing.Point(12, 18);
            this.l_mark.Name = "l_mark";
            this.l_mark.Size = new System.Drawing.Size(1240, 117);
            this.l_mark.TabIndex = 1;
            this.l_mark.Text = "Mark";
            this.l_mark.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.l_mark.Click += new System.EventHandler(this.l_mark_Click);
            // 
            // MsgForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1260, 620);
            this.ControlBox = false;
            this.Controls.Add(this.l_mark);
            this.Controls.Add(this.l_Example);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MsgForm";
            this.Opacity = 0.9D;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MsgForm";
            this.TopMost = true;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MsgForm_KeyDown);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.MsgForm_MouseClick);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label l_Example;
        private System.Windows.Forms.Label l_mark;
    }
}