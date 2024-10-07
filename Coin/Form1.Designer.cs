namespace Coin
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            button1 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label2 = new Label();
            plotView1 = new OxyPlot.WindowsForms.PlotView();
            textBox3 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            textBox4 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 39);
            label1.Name = "label1";
            label1.Size = new Size(20, 20);
            label1.TabIndex = 0;
            label1.Text = "N";
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.Location = new Point(12, 179);
            button1.Name = "button1";
            button1.Size = new Size(99, 40);
            button1.TabIndex = 1;
            button1.Text = "Расчитать";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(64, 36);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(124, 27);
            textBox1.TabIndex = 2;
            textBox1.Text = "1000";
            textBox1.KeyPress += textBox1_KeyPress;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(64, 69);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(124, 27);
            textBox2.TabIndex = 3;
            textBox2.Text = "100";
            textBox2.KeyPress += textBox2_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 72);
            label2.Name = "label2";
            label2.Size = new Size(22, 20);
            label2.TabIndex = 0;
            label2.Text = "M";
            label2.Click += label1_Click;
            // 
            // plotView1
            // 
            plotView1.Location = new Point(194, 21);
            plotView1.Name = "plotView1";
            plotView1.PanCursor = Cursors.Hand;
            plotView1.Size = new Size(1007, 748);
            plotView1.TabIndex = 4;
            plotView1.Text = "plotView1";
            plotView1.ZoomHorizontalCursor = Cursors.SizeWE;
            plotView1.ZoomRectangleCursor = Cursors.SizeNWSE;
            plotView1.ZoomVerticalCursor = Cursors.SizeNS;
            plotView1.Click += plotView1_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(64, 102);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(124, 27);
            textBox3.TabIndex = 5;
            textBox3.Text = "0,9";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 105);
            label3.Name = "label3";
            label3.Size = new Size(48, 20);
            label3.TabIndex = 0;
            label3.Text = "Alpha";
            label3.Click += label1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(45, 798);
            label4.Name = "label4";
            label4.Size = new Size(195, 20);
            label4.TabIndex = 6;
            label4.Text = "Результат моделирования:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(246, 798);
            label5.Name = "label5";
            label5.Size = new Size(17, 20);
            label5.TabIndex = 6;
            label5.Text = "0";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 144);
            label6.Name = "label6";
            label6.Size = new Size(42, 20);
            label6.TabIndex = 7;
            label6.Text = "Time";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(64, 141);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(124, 27);
            textBox4.TabIndex = 5;
            textBox4.Text = "0,2";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1213, 848);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(plotView1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label2;
        private OxyPlot.WindowsForms.PlotView plotView1;
        private TextBox textBox3;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox textBox4;
    }
}
