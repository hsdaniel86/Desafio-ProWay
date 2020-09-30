using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace desafio_publica
{
    public partial class inserirdados : Form
    {
        // metodo que inicializa codigo fonte
        public inserirdados()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // exibe tabela no dataGridView
            funçãosql.carrega(this.dataGridView1);
        }

        // button que com um click retorna maior numero de pontos no textbox
        private void btninserir_Click(object sender, EventArgs e)
        {
            // classe que abre conexão com banco de dados
            funçãosql.cn.Open();
            // comando que insere dados do usuario na tabela
            SqlCommand command = new SqlCommand("insert into Painel values(" + txtplacar.Text + ","+txtmintemp.Text+","+txtmaxtemp.Text+","+txtrecmin.Text+","+txtrecmax.Text+")", funçãosql.cn);
            // comando que executa registro na tabela
            command.ExecuteNonQuery();
            // classe que fecha conexão co banco de dados
            funçãosql.cn.Close();
            // classe que exibe tabela no dataGridView
            funçãosql.carrega(this.dataGridView1);
            
        }

        // button que ao click encerra a interface
        private void btncancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }        
    }
}
