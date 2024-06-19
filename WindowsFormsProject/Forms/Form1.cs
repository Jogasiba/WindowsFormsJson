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
using WindowsFormsProject.Forms;

namespace WindowsFormsProject
{
    public partial class Menu : Form
    {
        bool logado;
        string loginLogado;

        public Menu()
        {
            InitializeComponent();

            ContasSalvas cs = new ContasSalvas("C:\\Users\\ccoad\\OneDrive\\Desktop\\Itens Área de Trabalho\\Projetos de Programação\\WindowsFormsProject\\ContasSalvas");
            if (cs.status)
            {
                string login = cs.Buscar();
                if(login != "")
                {
                    loginLogado = login;
                    loginLogadotoolStripMenuItem1.Text = loginLogado;
                    modificaEnabled();
                }
            }
        }

        private void entrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.ShowDialog();
            if(login.DialogResult == DialogResult.OK)
            {
                loginLogado = login.login;
                modificaEnabled();
            }
        }

        private void modificaEnabled()
        {
            if (!logado)
            {
                entrarToolStripMenuItem.Enabled = false;
                removerContasSalvasToolStripMenuItem.Enabled = true;
                gerenciarContaToolStripMenuItem.Enabled = true;
                sairToolStripMenuItem.Enabled = true;

                logado = true;
                loginLogadotoolStripMenuItem1.Text = loginLogado;
            }
            else
            {
                entrarToolStripMenuItem.Enabled = true;
                removerContasSalvasToolStripMenuItem.Enabled = false;
                gerenciarContaToolStripMenuItem.Enabled = false;
                sairToolStripMenuItem.Enabled = false;

                logado = false;
                loginLogadotoolStripMenuItem1.Text = "sem login";
            }
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Você realmente deseja sair de sua conta?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MessageBox.Show("Você saiu da conta!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                modificaEnabled();
            }
        }

        private void fecharToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void gerenciarContaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Conta c = new Conta(loginLogado);
            c.ShowDialog();
            if(c.DialogResult == DialogResult.OK)
            {
                modificaEnabled();
            }
        }

        private void removerContasSalvasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ContasSalvas cs = new ContasSalvas("C:\\Users\\ccoad\\OneDrive\\Desktop\\Itens Área de Trabalho\\Projetos de Programação\\WindowsFormsProject\\ContasSalvas");
            if(MessageBox.Show("Deseja realmente remover todas as contas salvas?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                cs.Apagar();
                if (cs.status)
                {
                    MessageBox.Show("Contas salvas removidas com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
