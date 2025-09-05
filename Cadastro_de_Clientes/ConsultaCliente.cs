using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Cadastro_de_Clientes
{
    public partial class ConsultaCliente : Form
    {
        public ConsultaCliente()
        {
            InitializeComponent();
        }

        private void ConsultaCliente_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string conexaoBanco = "server=localhost;user=root;password=;database=db_cliente";

            using (MySqlConnection conexao = new MySqlConnection(conexaoBanco))
            {
                try
                {
                    conexao.Open();
                    string query = "SELECT * FROM tb_cliente";


                    MySqlCommand comando = new MySqlCommand(query, conexao);
                    MySqlDataAdapter adaptador = new MySqlDataAdapter(comando);
                    DataTable tabela = new DataTable();
                    adaptador.Fill(tabela);

                    GridClientes.DataSource = tabela;

                    conexao.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao cadastrar cliente: erro na conexao com o banco" + ex.Message);
                }
            }
        }

        private void buttonFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

