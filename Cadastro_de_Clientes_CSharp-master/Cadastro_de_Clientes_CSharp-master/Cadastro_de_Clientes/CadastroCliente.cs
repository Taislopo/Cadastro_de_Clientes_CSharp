using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using MySql.Data.MySqlClient;

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
            //string nome = textBoxNome.Text;
            //string email = textBoxEmail.Text;
            //string sobrenome = textBoxSobrenome.Text;
            //int idade = int.Parse(textBoxIdade.Text);
            //string conexaoBanco = "server=localhost;user=root;password=;database=db_cliente";

            //using (MySqlConnection conexao = new MySqlConnection(conexaoBanco))
            //{
            //    try
            //    {
            //        conexao.Open();
            //        string query = "INSERT INTO tb_cliente (nome, sobrenome, email, idade) VALUES (@nome, @sobrenome, @email, @idade)";


            //        MySqlCommand comando = new MySqlCommand(query, conexao);
            //        comando.Parameters.AddWithValue("@nome", nome);
            //        comando.Parameters.AddWithValue("@sobrenome", sobrenome);
            //        comando.Parameters.AddWithValue("@email", email);
            //        comando.Parameters.AddWithValue("@idade", idade);
            //        comando.ExecuteNonQuery();
            //        MessageBox.Show("Cliente cadastrado com sucesso!");

            //        textBoxNome.Clear();
            //        textBoxSobrenome.Clear();
            //        textBoxEmail.Clear();
            //        textBoxIdade.Clear();
            //        textBoxNome.Focus();
            //        conexao.Close();
            //    }
            //        catch (Exception ex)
            //    {
            ////        MessageBox.Show("Erro ao cadastrar cliente: erro na conexao com o banco" + ex.Message);
            //    }
            //    }
            //}


            // Verifica se o nome está vazio ou contém apenas espaços em branco
            if (string.IsNullOrWhiteSpace(textBoxNome.Text))
            {
                MessageBox.Show("Por favor, preencha o nome.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //coloca o cursor de volta no campo textBoxNome
                textBoxNome.Focus();
                //para aqui e não continua com as próximas validações.
                return;
            }

            if (string.IsNullOrWhiteSpace(textBoxSobrenome.Text))
            {
                MessageBox.Show("Por favor, preencha o Sobrenome.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxNome.Focus();
                return;
            }


        // Verifica se o email foi preenchido
        if (string.IsNullOrWhiteSpace(textBoxEmail.Text))
        {
            MessageBox.Show("Por favor, preencha o email.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            textBoxEmail.Focus();
            return;
        }

        // Verifica se o email contém "@"
        if (!textBoxEmail.Text.Contains("@"))
        {
            MessageBox.Show("O email deve conter '@'.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            textBoxEmail.Focus();
            return;
        }
        // Verifica se a idade foi preenchida
        if (string.IsNullOrWhiteSpace(textBoxIdade.Text))
        {
            MessageBox.Show("Por favor, preencha a idade.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxIdade.Focus();
                return;
            }

        // Verifica se a idade é um número inteiro e menor que 130
        if (!int.TryParse(textBoxIdade.Text, out int idade))
        //tenta converter o texto do campo textBoxIdade.Text em um número inteiro.
        {
            MessageBox.Show("A idade deve ser um número inteiro.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            textBoxIdade.Focus();
            return;
        }

        if (idade < 0 || idade > 130)
        {
            MessageBox.Show("A idade deve ser menor que 130 e maior ou igual a 0.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            textBoxIdade.Focus();
            return;
        }


        // Se tudo estiver certo
            MessageBox.Show("Dados validados com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
    


        private void CadastroCliente_Load(object sender, EventArgs e)
        {

        }

        private void textBoxNome_TextChanged(object sender, EventArgs e)
        {
            
            {

            }
        }
    }
}
