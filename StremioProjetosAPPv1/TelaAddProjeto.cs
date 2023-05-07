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
    public partial class TelaAddProjeto : Form
    {
        public TelaAddProjeto()
        {
            InitializeComponent();
        }

        private void TelaAddProjeto_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Projeto projeto = new Projeto();
            projeto.Nome = textBox2.Text;
            projeto.Gerente = textBox1.Text;
            projeto.Resumo = richTextBox1.Text;
            projeto.Status = comboBox1.SelectedItem.ToString();
            projeto.DataInicio = DateTime.Parse(monthCalendar1.SelectionRange.Start.ToShortDateString());
            projeto.DataFinal = DateTime.Parse(monthCalendar2.SelectionRange.Start.ToShortDateString());
            ProjectRepository.Add(projeto);
            MessageBox.Show("Projeto Adicionado !");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TelaInicial telaInicial = new TelaInicial();
            telaInicial.Show();
            Visible = false;
        }
    }
}
