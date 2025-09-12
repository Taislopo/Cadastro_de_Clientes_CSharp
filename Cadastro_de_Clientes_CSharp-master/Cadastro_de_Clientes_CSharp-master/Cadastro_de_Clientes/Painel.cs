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
    public partial class Painel : Form
    {
        public Painel()
        {
            InitializeComponent();
        }

        private void buttonCadastroCliente_Click(object sender, EventArgs e)
        {
            CadastroCliente cadastroCliente = new CadastroCliente();
            cadastroCliente.Show();
        }

        private void buttonConsultaCliente_Click(object sender, EventArgs e)
        {
            ConsultaCliente consultaCliente = new ConsultaCliente();
            consultaCliente.Show();
        }

        private void buttonFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
