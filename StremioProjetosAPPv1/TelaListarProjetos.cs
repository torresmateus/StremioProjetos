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
    public partial class TelaListarProjetos : Form
    {
        public TelaListarProjetos()
        {
            InitializeComponent();
        }

        private void TelaListarProjetos_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Projeto> projetos = ProjectRepository.GetAll();
            dataGridView1.DataSource = projetos;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TelaInicial telaInicial = new TelaInicial();
            telaInicial.Show();
            Visible = false;
        }
    }
}
