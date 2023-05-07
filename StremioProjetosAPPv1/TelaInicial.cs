namespace StremioProjetosAPPv1
{
    public partial class TelaInicial : Form
    {
        public TelaInicial()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TelaAddProjeto telaAddProjeto = new TelaAddProjeto();
            telaAddProjeto.Show();
            Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TelaListarProjetos telaListarProjetos = new TelaListarProjetos();
            telaListarProjetos.Show();
            Visible = false;
        }

        private void TelaInicial_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TelaBuscarUsuario telaBuscarUsuario = new TelaBuscarUsuario();
            telaBuscarUsuario.Show();
            Visible = false;
        }
    }
}