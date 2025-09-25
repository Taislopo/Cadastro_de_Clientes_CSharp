using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
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
            listarClientes();
            comboBoxListagem();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            listarClientes();
        }

        private void buttonFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GridClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string conexaoBanco = "server=localhost;user=root;password=;database=db_cliente";

            using (MySqlConnection conexao = new MySqlConnection(conexaoBanco))
            {
                try
                {
                    conexao.Open();
                    string query = "SELECT id,nome,sobrenome,email,idade FROM tb_cliente";


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

        private void buttonApagar_Click(object sender, EventArgs e)
        {
            if (GridClientes.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um cliente.");
            }

            DataGridViewRow linhaSelecionada = GridClientes.SelectedRows[0];
            int idCliente = Convert.ToInt32(linhaSelecionada.Cells["id"].Value);

            DialogResult confirmacao = MessageBox.Show("Tem certeza que deseja apagar o cliente selecionado?", "Confirmação",MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirmacao == DialogResult.Yes)
            {
                string conexaoBanco = "server=localhost;user=root;password=;database=db_cliente";
                using (MySqlConnection conexao = new MySqlConnection(conexaoBanco))
                {
                   
                        try
                        {
                            conexao.Open();
                            string query = "DELETE FROM tb_cliente WHERE id = @id";
                            MySqlCommand comando = new MySqlCommand(query, conexao);
                            
                            comando.Parameters.AddWithValue("@id", idCliente);
                            comando.ExecuteNonQuery();
                            conexao.Close();

                            listarClientes();
                    }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Erro ao apagar cliente: erro na conexao com o banco" + ex.Message);
                        }
                    }
        }

            }


        private void listarClientes()
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

        private void buttonAtualizar_Click(object sender, EventArgs e)
        {

            if (GridClientes.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um cliente.");
                listarClientes();
            }
            

            DataGridViewRow linhaSelecionada = GridClientes.SelectedRows[0];

            int idCliente = Convert.ToInt32(linhaSelecionada.Cells["id"].Value);
            string nome = Convert.ToString(linhaSelecionada.Cells["nome"].Value);
            string sobrenome = Convert.ToString(linhaSelecionada.Cells["sobrenome"].Value);
            string email = Convert.ToString(linhaSelecionada.Cells["email"].Value);
            int idade = Convert.ToInt32(linhaSelecionada.Cells["idade"].Value);

            string conexaoBanco = "server=localhost;user=root;password=;database=db_cliente";

            using (MySqlConnection conexao = new MySqlConnection(conexaoBanco))
            {
                try
                {
                    conexao.Open();
                    string query = "UPDATE tb_cliente SET nome = @nome, sobrenome = @sobrenome, email = @email, idade = @idade WHERE id = @id";


                    MySqlCommand comando = new MySqlCommand(query, conexao);
                    comando.Parameters.AddWithValue("@id", idCliente);
                    comando.Parameters.AddWithValue("@nome", nome);
                    comando.Parameters.AddWithValue("@sobrenome", sobrenome);
                    comando.Parameters.AddWithValue("@email", email);
                    comando.Parameters.AddWithValue("@idade", idade);
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Cliente atualizado com sucesso!");

               
                    conexao.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao cadastrar cliente: erro na conexao com o banco" + ex.Message);
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

           private void comboBoxListagem()
        {


         



            string conexaoBanco = "server=localhost;user=root;password=;database=db_cliente";

            using (MySqlConnection conexao = new MySqlConnection(conexaoBanco))
            {
                try
                {
                    conexao.Open();
                    string query = "SELECT id, nome FROM tb_cliente ORDER BY nome";


                    MySqlCommand comando = new MySqlCommand(query, conexao);
                    MySqlDataAdapter adaptador = new MySqlDataAdapter(comando);
                    DataTable tabela = new DataTable();
                    adaptador.Fill(tabela);

                    comboBoxLista.ValueMember = "id";
                    comboBoxLista.DisplayMember = "nome";
                    comboBoxLista.DataSource = tabela;

                    conexao.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao cadastrar cliente: erro na conexao com o banco" + ex.Message);
                }
            }


        }


    }
    }


