using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cadastro_de_Clientes
{
    public partial class Form1 : Form
    {
        public Form1()
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

           // MessageBox.Show($"Nome: {nome}\nSobrenome: {sobrenome}\nEmail: {email}\nIdade: {idade}", "Dados do Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
        
            labelMenssagem0.Text = "Dados do Cliente";
            labelMenssagem1.Text = $"{nome}"; 
            labelMenssagem2.Text = $"{sobrenome}";
            labelMenssagem3.Text = $"{email}";
            labelMenssagem4.Text = $"{idade} Anos";


        }
    }
}
