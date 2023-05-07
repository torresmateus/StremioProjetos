namespace StremioProjetosAPPv1
{
    partial class TelaBuscarUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaBuscarUsuario));
            textBox1 = new TextBox();
            label1 = new Label();
            button1 = new Button();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            button2 = new Button();
            button3 = new Button();
            richTextBox1 = new RichTextBox();
            pictureBox1 = new PictureBox();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 35);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(128, 23);
            textBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 17);
            label1.Name = "label1";
            label1.Size = new Size(98, 15);
            label1.TabIndex = 1;
            label1.Text = "Nome do Projeto";
            // 
            // button1
            // 
            button1.Location = new Point(160, 35);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "Buscar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox2
            // 
            textBox2.Enabled = false;
            textBox2.Location = new Point(14, 116);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(117, 23);
            textBox2.TabIndex = 3;
            // 
            // textBox3
            // 
            textBox3.Enabled = false;
            textBox3.Location = new Point(137, 116);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(118, 23);
            textBox3.TabIndex = 4;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // textBox4
            // 
            textBox4.Enabled = false;
            textBox4.Location = new Point(261, 116);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 5;
            // 
            // textBox6
            // 
            textBox6.Enabled = false;
            textBox6.Location = new Point(14, 174);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(131, 23);
            textBox6.TabIndex = 7;
            // 
            // textBox7
            // 
            textBox7.Enabled = false;
            textBox7.Location = new Point(196, 174);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(136, 23);
            textBox7.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 91);
            label2.Name = "label2";
            label2.Size = new Size(98, 15);
            label2.TabIndex = 9;
            label2.Text = "Nome do Projeto";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(135, 91);
            label3.Name = "label3";
            label3.Size = new Size(48, 15);
            label3.TabIndex = 10;
            label3.Text = "Gerente";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(259, 91);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 11;
            label4.Text = "Status";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(9, 216);
            label5.Name = "label5";
            label5.Size = new Size(58, 15);
            label5.TabIndex = 12;
            label5.Text = "Descrição";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(14, 156);
            label6.Name = "label6";
            label6.Size = new Size(79, 15);
            label6.TabIndex = 13;
            label6.Text = "Data de Inicio";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(196, 156);
            label7.Name = "label7";
            label7.Size = new Size(108, 15);
            label7.TabIndex = 14;
            label7.Text = "Data de Finalização";
            // 
            // button2
            // 
            button2.Location = new Point(9, 386);
            button2.Name = "button2";
            button2.Size = new Size(100, 36);
            button2.TabIndex = 15;
            button2.Text = "Editar";
            button2.UseVisualStyleBackColor = true;
            button2.Visible = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(121, 386);
            button3.Name = "button3";
            button3.Size = new Size(102, 36);
            button3.TabIndex = 16;
            button3.Text = "Excluir";
            button3.UseVisualStyleBackColor = true;
            button3.Visible = false;
            button3.Click += button3_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Enabled = false;
            richTextBox1.Location = new Point(9, 234);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(214, 96);
            richTextBox1.TabIndex = 17;
            richTextBox1.Text = "";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(356, -22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(608, 444);
            pictureBox1.TabIndex = 18;
            pictureBox1.TabStop = false;
            // 
            // button4
            // 
            button4.Location = new Point(229, 386);
            button4.Name = "button4";
            button4.Size = new Size(103, 36);
            button4.TabIndex = 19;
            button4.Text = "Inicio";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // TelaBuscarUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(800, 450);
            Controls.Add(button4);
            Controls.Add(richTextBox1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox7);
            Controls.Add(textBox6);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(pictureBox1);
            Name = "TelaBuscarUsuario";
            Text = " ";
            FormClosing += TelaBuscarUsuario_FormClosing;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Button button1;
        private TextBox textBox6;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button button2;
        private Button button3;
        private PictureBox pictureBox1;
        private Button button4;
        public TextBox textBox1;
        public TextBox textBox2;
        public TextBox textBox3;
        public TextBox textBox4;
        public TextBox textBox7;
        public RichTextBox richTextBox1;
    }
}