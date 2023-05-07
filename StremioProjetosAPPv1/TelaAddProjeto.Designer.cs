namespace StremioProjetosAPPv1
{
    partial class TelaAddProjeto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaAddProjeto));
            label1 = new Label();
            label2 = new Label();
            comboBox1 = new ComboBox();
            monthCalendar1 = new MonthCalendar();
            monthCalendar2 = new MonthCalendar();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            richTextBox1 = new RichTextBox();
            label5 = new Label();
            label6 = new Label();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(365, 39);
            label1.Name = "label1";
            label1.Size = new Size(45, 15);
            label1.TabIndex = 0;
            label1.Text = "Projeto";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(530, 39);
            label2.Name = "label2";
            label2.Size = new Size(48, 15);
            label2.TabIndex = 1;
            label2.Text = "Gerente";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Em andamento", "Concluido", "Cancelado" });
            comboBox1.Location = new Point(654, 57);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 2;
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(324, 282);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 3;
            // 
            // monthCalendar2
            // 
            monthCalendar2.Location = new Point(569, 282);
            monthCalendar2.Name = "monthCalendar2";
            monthCalendar2.ShowTodayCircle = false;
            monthCalendar2.TabIndex = 4;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(486, 57);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(143, 23);
            textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(324, 57);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(142, 23);
            textBox2.TabIndex = 6;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(690, 39);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 7;
            label3.Text = "Status";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(520, 126);
            label4.Name = "label4";
            label4.Size = new Size(58, 15);
            label4.TabIndex = 8;
            label4.Text = "Descrição";
            label4.Click += label4_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(324, 144);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(451, 96);
            richTextBox1.TabIndex = 9;
            richTextBox1.Text = "";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(398, 258);
            label5.Name = "label5";
            label5.Size = new Size(79, 15);
            label5.TabIndex = 10;
            label5.Text = "Data de Inicio";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(638, 258);
            label6.Name = "label6";
            label6.Size = new Size(108, 15);
            label6.TabIndex = 11;
            label6.Text = "Data de Finalização";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-32, -9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(467, 463);
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.Location = new Point(78, 409);
            button1.Name = "button1";
            button1.Size = new Size(175, 35);
            button1.TabIndex = 13;
            button1.Text = "Cadastrar Projeto";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(78, 364);
            button2.Name = "button2";
            button2.Size = new Size(175, 31);
            button2.TabIndex = 14;
            button2.Text = "Inicio";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // TelaAddProjeto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(richTextBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(monthCalendar2);
            Controls.Add(monthCalendar1);
            Controls.Add(comboBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "TelaAddProjeto";
            Text = "TelaAddProjeto";
            FormClosing += TelaAddProjeto_FormClosing;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox comboBox1;
        private MonthCalendar monthCalendar1;
        private MonthCalendar monthCalendar2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label3;
        private Label label4;
        private RichTextBox richTextBox1;
        private Label label5;
        private Label label6;
        private PictureBox pictureBox1;
        private Button button1;
        private Button button2;
    }
}