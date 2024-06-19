using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsProject.Classes;
using WindowsFormsProject.Data;

namespace WindowsFormsProject.Forms
{
    public partial class Conta : Form
    {
        bool senhaChar = true;
        bool editando = false;
        string loginLogado;

        public Conta(string Login)
        {
            InitializeComponent();

            loginLogado = Login;
            Escrever();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (senhaChar)
            {
                senha.PasswordChar = '\0';
                senhaChar = false;
            }
            else
            {
                senha.PasswordChar = '#';
                senhaChar = true;
            }
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            Cadastros C = new Cadastros("C:\\Users\\ccoad\\OneDrive\\Desktop\\Itens Área de Trabalho\\Projetos de Programação\\WindowsFormsProject\\Cadastros");
            C.Apagar(loginLogado);
            if (C.status)
            {
                DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (editando)
            {
                Cadastros C = new Cadastros("C:\\Users\\ccoad\\OneDrive\\Desktop\\Itens Área de Trabalho\\Projetos de Programação\\WindowsFormsProject\\Cadastros");
                Usuario.Unit u = new Usuario.Unit();
                u = Leitura();
                string json = Usuario.SerializedClassUnit(u);
                C.Editar(loginLogado, json);
            }
            Escrever();
            modificaEnabled();
        }

        private void modificaEnabled()
        {
            if (!editando)
            {
                nome.Enabled = true;
                email.Enabled = true;
                tele.Enabled = true;
                cpf.Enabled = true;
                cep.Enabled = true;
                login.Enabled = true;
                senha.Enabled = true;

                editando = true;
                btnEditar.Text = "Confirmar";
            }
            else
            {
                nome.Enabled = false;
                email.Enabled = false;
                tele.Enabled = false;
                cpf.Enabled = false;
                cep.Enabled = false;
                login.Enabled = false;
                senha.Enabled = false;

                editando = false;
                btnEditar.Text = "Editar Dados";
            }
        }

        Usuario.Unit Leitura()
        {
            Usuario.Unit u = new Usuario.Unit();
            u.Nome = nome.Text;
            u.Email = email.Text;
            u.Telefone = tele.Text;
            u.Cpf = cpf.Text;
            u.Cep = cep.Text;
            u.Login = login.Text;
            u.Senha = senha.Text;

            return u;
        }

        private void Escrever()
        {
            Cadastros c = new Cadastros("C:\\Users\\ccoad\\OneDrive\\Desktop\\Itens Área de Trabalho\\Projetos de Programação\\WindowsFormsProject\\Cadastros");
            if (c.status)
            {
                Usuario.Unit u = new Usuario.Unit();
                string json = c.Buscar(loginLogado);
                u = Usuario.DesSerializedClassUnit(json);

                nome.Text = u.Nome;
                email.Text = u.Email;
                tele.Text = u.Telefone;
                cpf.Text = u.Cpf;
                cep.Text = u.Cep;
                login.Text = u.Login;
                senha.Text = u.Senha;
            }
        }
    }
}
