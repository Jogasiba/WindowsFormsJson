using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsProject.Classes;
using WindowsFormsProject.Data;

namespace WindowsFormsProject
{
    public partial class Login : Form
    {

        bool senhaLog = true;
        bool senhaCada = true;
        public string login;
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogar_Click(object sender, EventArgs e)
        {
            if (loginInput.Text == "" || senhaInput.Text == "")
            {
                MessageBox.Show("Login e senha devem ser preenchidos!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Cadastros C = new Cadastros("C:\\Users\\ccoad\\OneDrive\\Desktop\\Itens Área de Trabalho\\Projetos de Programação\\WindowsFormsProject\\Cadastros");
                if (C.status)
                {
                    string json = C.BuscarLogin(loginInput.Text, senhaInput.Text);
                    Usuario.Unit u = new Usuario.Unit();
                    u = Usuario.DesSerializedClassUnit(json);
                    if (json != "")
                    {
                        if (lembreDeMimLog.Checked)
                        {
                            ContasSalvas cs = new ContasSalvas("C:\\Users\\ccoad\\OneDrive\\Desktop\\Itens Área de Trabalho\\Projetos de Programação\\WindowsFormsProject\\ContasSalvas");
                            if (cs.status)
                            {
                                cs.Incluir(loginInput.Text, json);
                            }
                        }
                        DialogResult = DialogResult.OK;
                        MessageBox.Show($"Seja bem vindo {u.Nome}!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        login = loginInput.Text;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Login e/ou senha incorretos!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Não foi possivel acessar os Cadastros!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        Usuario.Unit Leitura()
        {
            Usuario.Unit u = new Usuario.Unit();
            u.Nome = nomeCad.Text;
            u.Email = emailCad.Text;
            u.Telefone = teleCad.Text;
            u.Cpf = cpfCad.Text;
            u.Cep = cepCad.Text;
            u.Login = loginCad.Text;
            u.Senha = senhaCad.Text;

            return u;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (senhaLog)
            {
                senhaInput.PasswordChar = '\0';
                senhaLog = false;
            }
            else
            {
                senhaInput.PasswordChar = '#';
                senhaLog = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (senhaCada)
            {
                senhaInput.PasswordChar = '\0';
                senhaCada = false;
            }
            else
            {
                senhaInput.PasswordChar = '#';
                senhaCada = true;
            }
        }

        private void loginInput_Leave(object sender, EventArgs e)
        {
            senhaInput.Focus();
        }

        private void emailCad_Leave(object sender, EventArgs e)
        {
            teleCad.Focus();
        }

        private void cepCad_Leave(object sender, EventArgs e)
        {
            loginCad.Focus();
        }

        private void btnCad_Click_1(object sender, EventArgs e)
        {
            Cadastros C = new Cadastros("C:\\Users\\ccoad\\OneDrive\\Desktop\\Itens Área de Trabalho\\Projetos de Programação\\WindowsFormsProject\\Cadastros");
            if (C.status)
            {
                Usuario.Unit u = new Usuario.Unit();
                u = Leitura();
                try
                {
                    u.ValidaClasse();
                    string json = Usuario.SerializedClassUnit(u);
                    C.Incluir(loginCad.Text, json);
                    if (C.status)
                    {
                        if (lembreDeMimCad.Checked)
                        {
                            ContasSalvas cs = new ContasSalvas("C:\\Users\\ccoad\\OneDrive\\Desktop\\Itens Área de Trabalho\\Projetos de Programação\\WindowsFormsProject\\ContasSalvas");
                            if (cs.status)
                            {
                                cs.Incluir(loginInput.Text, json);
                            }
                        }
                        DialogResult = DialogResult.OK;
                        MessageBox.Show($"Seu cadastro foi realizado com sucesso!\r\n\r\nSeja bem vindo {u.Nome}!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        login = loginCad.Text;
                        this.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Não foi possivel acessar os Cadastros!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
