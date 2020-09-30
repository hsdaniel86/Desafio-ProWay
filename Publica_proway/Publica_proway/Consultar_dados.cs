using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Publica_proway
{
    public partial class Consultar_dados : Form
    {
        // metodo que inicializa codigo fonte
        public Consultar_dados()
        {
            InitializeComponent();
        }

        private void Consultar_dados_Load(object sender, EventArgs e)
        {
            // exibe tabela no dataGrid
            funçãosql.carrega(this.dataGridView2);
        }

        // button que com um click retorna maior numero de pontos no textbox
        private void btnmaior_Click(object sender, EventArgs e)
        {
            // classe que abre conexão com banco de dados
            funçãosql.cn.Open();
            // comando sql que retorna maior valor da coluna placar na tabela painel
            SqlCommand command = new SqlCommand("select max (Placar) from Painel", funçãosql.cn);
            // comando que exibe resultado da consulta no textbox
            txtconsulta.Text = command.ExecuteScalar().ToString();
            // classe que fecha conexão co banco de dados
            funçãosql.cn.Close();
        }

        // button que com um click retorna menor numero de pontos no textbox
        private void btnmenor_Click(object sender, EventArgs e)
        {
            // classe que abre conexão com banco de dados
            funçãosql.cn.Open();
            // comando sql que retorna menor valor da coluna placar na tabela painel
            SqlCommand command = new SqlCommand("select min (Placar) from Painel", funçãosql.cn);
            // comando que exibe resultado da consulta no textbox
            txtconsulta.Text = command.ExecuteScalar().ToString();
            // classe que fecha conexão co banco de dados
            funçãosql.cn.Close();
        }

        // button que com um click retorna total de jogos no textbox
        private void btntotal_Click(object sender, EventArgs e)
        {
            // classe que abre conexão com banco de dados
            funçãosql.cn.Open();
            // comando sql que retorna total de linhas coluna jogo na tabela painel
            SqlCommand command = new SqlCommand("select count (Jogo) from Painel", funçãosql.cn);
            // comando que exibe resultado da consulta no textbox
            txtconsulta.Text = command.ExecuteScalar().ToString();
            // classe que fecha conexão co banco de dados
            funçãosql.cn.Close();
        }

        // button que ao click encerra a interface
        private void btncancela_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
