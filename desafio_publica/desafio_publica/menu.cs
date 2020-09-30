using System;
using System.Windows.Forms;

namespace desafio_publica
{
    public partial class menu : Form
    {
        // metodo que inicializa codigo fonte
        public menu()
        {
            InitializeComponent();
        }

        // button que ao click abre a interface para inserir dados
        public void btninserirdados_Click(object sender, EventArgs e)
        {
            inserirdados insere = new inserirdados();
            insere.ShowDialog();
        }
        
        // button que ao click abre a interface para calcular dados
        private void btncalculardados_Click(object sender, EventArgs e)
        {
            calcular soma = new calcular();
            soma.ShowDialog();
        }
        
        // button que ao click abre a interface para consulta de dados
        private void btntabela_Click(object sender, EventArgs e)
        {
            Painel tabela = new Painel();
            tabela.ShowDialog();
        }
        
        // button que ao click encerra a interface
        private void btnfechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
