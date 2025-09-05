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
    public partial class CadastroCliente : Form
    {
        public CadastroCliente()
        {
            InitializeComponent();
        }

        private void buttonFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonEnviar_Click(object sender, EventArgs e)
        {
            string nome = textBoxNome.Text;
            string email = textBoxEmail.Text;
            string sobrenome = textBoxSobrenome.Text;
            int idade = int.Parse(textBoxIdade.Text);
            string conexaoBanco = "server=localhost;user=root;password=;database=db_cliente";

            using (MySqlConnection conexao = new MySqlConnection(conexaoBanco))
            {
                try
                {
                    conexao.Open();
                    string query = "INSERT INTO tb_cliente (nome, sobrenome, email, idade) VALUES (@nome, @sobrenome, @email, @idade)";
               
                    
                    MySqlCommand comando = new MySqlCommand(query, conexao);
                    comando.Parameters.AddWithValue("@nome", nome);
                    comando.Parameters.AddWithValue("@sobrenome", sobrenome);
                    comando.Parameters.AddWithValue("@email", email);
                    comando.Parameters.AddWithValue("@idade", idade);
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Cliente cadastrado com sucesso!");

                    textBoxNome.Clear();
                    textBoxSobrenome.Clear();
                    textBoxEmail.Clear();
                    textBoxIdade.Clear();
                    textBoxNome.Focus();
                    conexao.Close();
                }
                    catch (Exception ex)
                {
                    MessageBox.Show("Erro ao cadastrar cliente: erro na conexao com o banco" + ex.Message);
                }




                }
            }


        

        private void CadastroCliente_Load(object sender, EventArgs e)
        {

        }

        private void textBoxNome_TextChanged(object sender, EventArgs e)
        {
            if (textBoxNome, textBoxSobrenome, textboxEmail, textBoxIdade == null)
            {

            }
        }
    }
}
