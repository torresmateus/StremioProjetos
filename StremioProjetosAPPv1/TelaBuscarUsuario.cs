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
    public partial class TelaBuscarUsuario : Form
    {
        public TelaBuscarUsuario()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Projeto projeto = new Projeto();
            projeto = ProjectRepository.GetByNome(textBox1.Text);
            textBox2.Text = projeto.Nome;
            textBox3.Text = projeto.Gerente;
            textBox4.Text = projeto.Status;
            richTextBox1.Text = projeto.Resumo;
            textBox6.Text = projeto.DataInicio.ToString("yyyy-MM-dd");
            textBox7.Text = projeto.DataFinal?.ToString("yyyy-MM-dd");
            button2.Visible = true;
            button3.Visible = true;
        }

        private void TelaBuscarUsuario_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Projeto projeto = ProjectRepository.GetByNome(textBox1.Text);
            ProjectRepository.Excluir(projeto);
            MessageBox.Show("Projeto" + projeto.Nome + " excluido");
            TelaBuscarUsuario telaBuscarUsuario = new TelaBuscarUsuario();
            telaBuscarUsuario.Show();
            Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            TelaInicial telaInicial = new TelaInicial();
            telaInicial.Show();
            Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TelaEditar telaEditar = new TelaEditar(this);
            telaEditar.Show();
            Visible = false;
        }
    }
}
