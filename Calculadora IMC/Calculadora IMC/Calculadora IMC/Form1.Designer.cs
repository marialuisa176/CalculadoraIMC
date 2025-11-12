namespace Calculadora_IMC
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
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label14 = new Label();
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            txtIMC = new TextBox();
            txtAltura = new TextBox();
            txtPeso = new TextBox();
            label3 = new Label();
            label12 = new Label();
            label13 = new Label();
            label2 = new Label();
            label16 = new Label();
            label11 = new Label();
            label10 = new Label();
            label15 = new Label();
            panel2 = new Panel();
            btnCalcularIMC = new Button();
            button12 = new Button();
            button11 = new Button();
            button10 = new Button();
            button9 = new Button();
            button8 = new Button();
            button7 = new Button();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            lblSituacao = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(125, 113);
            label4.Name = "label4";
            label4.Size = new Size(0, 15);
            label4.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(125, 145);
            label5.Name = "label5";
            label5.Size = new Size(0, 15);
            label5.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(264, 80);
            label6.Name = "label6";
            label6.Size = new Size(0, 15);
            label6.TabIndex = 5;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(264, 113);
            label7.Name = "label7";
            label7.Size = new Size(0, 15);
            label7.TabIndex = 6;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(264, 145);
            label8.Name = "label8";
            label8.Size = new Size(0, 15);
            label8.TabIndex = 7;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(29, 196);
            label9.Name = "label9";
            label9.Size = new Size(0, 15);
            label9.TabIndex = 8;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Verdana", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label14.ForeColor = Color.DimGray;
            label14.Location = new Point(55, 326);
            label14.Name = "label14";
            label14.Size = new Size(0, 25);
            label14.TabIndex = 13;
            label14.Click += label14_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(lblSituacao);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(txtIMC);
            panel1.Controls.Add(txtAltura);
            panel1.Controls.Add(txtPeso);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label12);
            panel1.Controls.Add(label13);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label16);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(label15);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(320, 212);
            panel1.TabIndex = 14;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources._2738981;
            pictureBox2.Location = new Point(41, 101);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(45, 47);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 27;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._10053576;
            pictureBox1.Location = new Point(41, 54);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(45, 44);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 26;
            pictureBox1.TabStop = false;
            // 
            // txtIMC
            // 
            txtIMC.Location = new Point(146, 152);
            txtIMC.Name = "txtIMC";
            txtIMC.Size = new Size(87, 23);
            txtIMC.TabIndex = 25;
            txtIMC.TextChanged += txtIMC_TextChanged;
            // 
            // txtAltura
            // 
            txtAltura.Location = new Point(146, 114);
            txtAltura.Name = "txtAltura";
            txtAltura.Size = new Size(87, 23);
            txtAltura.TabIndex = 24;
            txtAltura.TextChanged += txtAltura_TextChanged;
            txtAltura.Enter += txtAltura_Enter;
            // 
            // txtPeso
            // 
            txtPeso.Location = new Point(146, 65);
            txtPeso.Name = "txtPeso";
            txtPeso.Size = new Size(87, 23);
            txtPeso.TabIndex = 23;
            txtPeso.TextChanged += txtPeso_TextChanged;
            txtPeso.Enter += txtPeso_Enter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.ForeColor = Color.DimGray;
            label3.Location = new Point(239, 68);
            label3.Name = "label3";
            label3.Size = new Size(24, 16);
            label3.TabIndex = 19;
            label3.Text = "kg";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Verdana", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label12.ForeColor = Color.DimGray;
            label12.Location = new Point(239, 117);
            label12.Name = "label12";
            label12.Size = new Size(21, 16);
            label12.TabIndex = 20;
            label12.Text = "m";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Verdana", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label13.ForeColor = Color.DimGray;
            label13.Location = new Point(61, 35);
            label13.Name = "label13";
            label13.Size = new Size(194, 16);
            label13.TabIndex = 21;
            label13.Text = "Informe seu Peso e Altura";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(67, 10);
            label2.Name = "label2";
            label2.Size = new Size(185, 25);
            label2.TabIndex = 22;
            label2.Text = "Cálculo de IMC";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Verdana", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label16.ForeColor = Color.DimGray;
            label16.Location = new Point(101, 154);
            label16.Name = "label16";
            label16.Size = new Size(35, 16);
            label16.TabIndex = 16;
            label16.Text = "IMC";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Verdana", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label11.ForeColor = Color.DimGray;
            label11.Location = new Point(92, 116);
            label11.Name = "label11";
            label11.Size = new Size(50, 16);
            label11.TabIndex = 17;
            label11.Text = "Altura";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Verdana", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label10.ForeColor = Color.DimGray;
            label10.Location = new Point(100, 68);
            label10.Name = "label10";
            label10.Size = new Size(42, 16);
            label10.TabIndex = 18;
            label10.Text = "Peso";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Verdana", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label15.ForeColor = Color.DimGray;
            label15.Location = new Point(23, 174);
            label15.Name = "label15";
            label15.Size = new Size(113, 25);
            label15.TabIndex = 15;
            label15.Text = "Situação";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Black;
            panel2.Controls.Add(btnCalcularIMC);
            panel2.Controls.Add(button12);
            panel2.Controls.Add(button11);
            panel2.Controls.Add(button10);
            panel2.Controls.Add(button9);
            panel2.Controls.Add(button8);
            panel2.Controls.Add(button7);
            panel2.Controls.Add(button6);
            panel2.Controls.Add(button5);
            panel2.Controls.Add(button4);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button1);
            panel2.Location = new Point(12, 230);
            panel2.Name = "panel2";
            panel2.Size = new Size(320, 279);
            panel2.TabIndex = 23;
            // 
            // btnCalcularIMC
            // 
            btnCalcularIMC.BackColor = Color.Gold;
            btnCalcularIMC.FlatStyle = FlatStyle.Flat;
            btnCalcularIMC.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnCalcularIMC.Location = new Point(26, 239);
            btnCalcularIMC.Name = "btnCalcularIMC";
            btnCalcularIMC.Size = new Size(266, 29);
            btnCalcularIMC.TabIndex = 12;
            btnCalcularIMC.Text = "Calcular Índice de Massa Corporal";
            btnCalcularIMC.UseVisualStyleBackColor = false;
            btnCalcularIMC.Click += btnCalcularIMC_Click;
            // 
            // button12
            // 
            button12.BackColor = Color.Gold;
            button12.FlatStyle = FlatStyle.Flat;
            button12.Font = new Font("Verdana", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            button12.Location = new Point(217, 181);
            button12.Name = "button12";
            button12.Size = new Size(75, 50);
            button12.TabIndex = 11;
            button12.Text = "Del";
            button12.UseVisualStyleBackColor = false;
            button12.Click += button12_Click;
            // 
            // button11
            // 
            button11.BackColor = Color.Gold;
            button11.FlatStyle = FlatStyle.Flat;
            button11.Font = new Font("Verdana", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            button11.Location = new Point(121, 181);
            button11.Name = "button11";
            button11.Size = new Size(75, 50);
            button11.TabIndex = 10;
            button11.Text = "0";
            button11.UseVisualStyleBackColor = false;
            button11.Click += addNumber;
            // 
            // button10
            // 
            button10.BackColor = Color.Gold;
            button10.FlatStyle = FlatStyle.Flat;
            button10.Font = new Font("Verdana", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            button10.Location = new Point(26, 181);
            button10.Name = "button10";
            button10.Size = new Size(75, 50);
            button10.TabIndex = 9;
            button10.Text = ",";
            button10.UseVisualStyleBackColor = false;
            button10.Click += addNumber;
            // 
            // button9
            // 
            button9.BackColor = Color.Gold;
            button9.FlatStyle = FlatStyle.Flat;
            button9.Font = new Font("Verdana", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            button9.Location = new Point(217, 125);
            button9.Name = "button9";
            button9.Size = new Size(75, 50);
            button9.TabIndex = 8;
            button9.Text = "3";
            button9.UseVisualStyleBackColor = false;
            button9.Click += addNumber;
            // 
            // button8
            // 
            button8.BackColor = Color.Gold;
            button8.FlatStyle = FlatStyle.Flat;
            button8.Font = new Font("Verdana", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            button8.Location = new Point(121, 125);
            button8.Name = "button8";
            button8.Size = new Size(75, 50);
            button8.TabIndex = 7;
            button8.Text = "2";
            button8.UseVisualStyleBackColor = false;
            button8.Click += addNumber;
            // 
            // button7
            // 
            button7.BackColor = Color.Gold;
            button7.FlatStyle = FlatStyle.Flat;
            button7.Font = new Font("Verdana", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            button7.Location = new Point(26, 125);
            button7.Name = "button7";
            button7.Size = new Size(75, 50);
            button7.TabIndex = 6;
            button7.Text = "1";
            button7.UseVisualStyleBackColor = false;
            button7.Click += addNumber;
            // 
            // button6
            // 
            button6.BackColor = Color.Gold;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Verdana", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            button6.Location = new Point(217, 69);
            button6.Name = "button6";
            button6.Size = new Size(75, 50);
            button6.TabIndex = 5;
            button6.Text = "6";
            button6.UseVisualStyleBackColor = false;
            button6.Click += addNumber;
            // 
            // button5
            // 
            button5.BackColor = Color.Gold;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Verdana", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            button5.Location = new Point(121, 69);
            button5.Name = "button5";
            button5.Size = new Size(75, 50);
            button5.TabIndex = 4;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = false;
            button5.Click += addNumber;
            // 
            // button4
            // 
            button4.BackColor = Color.Gold;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Verdana", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            button4.Location = new Point(26, 69);
            button4.Name = "button4";
            button4.Size = new Size(75, 50);
            button4.TabIndex = 3;
            button4.Text = "4";
            button4.UseVisualStyleBackColor = false;
            button4.Click += addNumber;
            // 
            // button3
            // 
            button3.BackColor = Color.Gold;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Verdana", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(217, 13);
            button3.Name = "button3";
            button3.Size = new Size(75, 50);
            button3.TabIndex = 2;
            button3.Text = "9";
            button3.UseVisualStyleBackColor = false;
            button3.Click += addNumber;
            // 
            // button2
            // 
            button2.BackColor = Color.Gold;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Verdana", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(121, 13);
            button2.Name = "button2";
            button2.Size = new Size(75, 50);
            button2.TabIndex = 1;
            button2.Text = "8";
            button2.UseVisualStyleBackColor = false;
            button2.Click += addNumber;
            // 
            // button1
            // 
            button1.BackColor = Color.Gold;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Verdana", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(26, 13);
            button1.Name = "button1";
            button1.Size = new Size(75, 50);
            button1.TabIndex = 0;
            button1.Text = "7";
            button1.UseVisualStyleBackColor = false;
            button1.Click += addNumber;
            // 
            // lblSituacao
            // 
            lblSituacao.AutoSize = true;
            lblSituacao.Location = new Point(146, 183);
            lblSituacao.Name = "lblSituacao";
            lblSituacao.Size = new Size(13, 15);
            lblSituacao.TabIndex = 28;
            lblSituacao.Text = "..";
            lblSituacao.Click += label1_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gold;
            ClientSize = new Size(344, 521);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label14);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Name = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label14;
        private Panel panel1;
        private Label label15;
        private Label label16;
        private Label label11;
        private Label label10;
        private Label label3;
        private Label label12;
        private Label label13;
        private Label label2;
        private Panel panel2;
        private Button button1;
        private Button btnCalcularIMC;
        private Button button12;
        private Button button11;
        private Button button10;
        private Button button9;
        private Button button8;
        private Button button7;
        private Button button6;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private TextBox txtIMC;
        private TextBox txtAltura;
        private TextBox txtPeso;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Label lblSituacao;
    }
}