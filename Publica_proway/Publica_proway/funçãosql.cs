using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Publica_proway
{
    class funçãosql
    {
        // metodo sql que conecta ao banco de dados
        static public SqlConnection cn = new SqlConnection(@"Data Source=HSDANIEL86\SQLEXPRESS;Initial Catalog=Pro_way;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

        static public void carrega(DataGridView grid)
        {
            try
            {
                // campo que abre conexão com banco de dados
                cn.Open();
                // comando sql que selciona colunas e tabela do banco de dados
                SqlDataAdapter adapter = new SqlDataAdapter("select * from Painel", cn);
                // biblioteca que preenche dataGridView
                DataTable table = new DataTable();
                // variavel que adapta tabela na biblioteca dataTable
                adapter.Fill(table);
                // comando de carrega variavel table no dataDridView
                grid.DataSource = table;
            }
            catch(FormatException fex)
            {   
                // caso o usuario inserir dado
                MessageBox.Show(fex.ToString());
            }
            catch (Exception ex)
            {
                // caso o codigo não execute retorna o motivo da falha 
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                // campo que encerra conexão com banco de dados
                cn.Close();
            }
        }
    }
}
