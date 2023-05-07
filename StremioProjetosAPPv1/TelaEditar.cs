using StremioProjetos.BLL;
using StremioProjetos.MODEL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StremioProjetosAPPv1
{
    public partial class TelaEditar : Form
    {
        TelaBuscarUsuario telaBuscarUsuario;
        public TelaEditar(TelaBuscarUsuario telaBuscarUsuario)
        {
            InitializeComponent();
            this.telaBuscarUsuario = telaBuscarUsuario;
            textBox1.Text = telaBuscarUsuario.textBox2.Text;
            textBox2.Text = telaBuscarUsuario.textBox3.Text;
            comboBox1.Text = telaBuscarUsuario.textBox4.Text;
            richTextBox1.Text = telaBuscarUsuario.richTextBox1.Text;
            monthCalendar1.SetDate(DateTime.Parse(telaBuscarUsuario.textBox7.Text));
        }


        private void TelaEditar_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TelaBuscarUsuario telaBuscarUsuario = new TelaBuscarUsuario();
            telaBuscarUsuario.Show();
            Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Projeto projeto = new Projeto();
            projeto = ProjectRepository.GetByNome(telaBuscarUsuario.textBox2.Text);
            projeto.Nome = textBox1.Text;
            projeto.Gerente = textBox2.Text;
            projeto.Status = comboBox1.SelectedItem.ToString();
            projeto.Resumo = richTextBox1.Text;
            projeto.DataFinal = DateTime.Parse(monthCalendar1.SelectionRange.Start.ToShortTimeString());
            ProjectRepository.Update(projeto);
            MessageBox.Show("Projeto Atualizado !");
        }
    }
}
