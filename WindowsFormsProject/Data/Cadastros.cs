using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsProject.Classes;

namespace WindowsFormsProject.Data
{
    public class Cadastros
    {
        public string diretorio;
        public bool status;

        public Cadastros(string Diretorio)
        {
            status = true;
            try
            {
                if (!(Directory.Exists(Diretorio)))
                {
                    Directory.CreateDirectory(Diretorio);
                }
                diretorio = Diretorio;
            }
            catch(Exception ex)
            {
                status = false;
                MessageBox.Show("Erro na conexão com o Cadastro:" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Incluir(string Login, string jsonUnit)
        {
            status = true;
            try
            {
                if(File.Exists(diretorio + "\\" + Login + ".json"))
                {
                    status = false;
                    MessageBox.Show("Já existe um usuário com esse login", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    File.WriteAllText(diretorio + "\\" + Login + ".json", jsonUnit);
                }
            }
            catch (Exception ex)
            {
                status = false;
                MessageBox.Show("Erro na inclusão de usuário:" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public string Buscar(string Login)
        {
            status = true;
            try
            {
                if (File.Exists(diretorio + "\\" + Login + ".json"))
                {
                    string conteudo = File.ReadAllText(diretorio + "\\" + Login + ".json");
                    return conteudo;
                }
                else
                {
                    status = false;
                    MessageBox.Show("Login e/ou senha incorreto(os)", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro na busca de usuário:" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return "";
        }

        public string BuscarLogin(string Login, string Senha)
        {
            status = true;
            try
            {
                if (File.Exists(diretorio + "\\" + Login + ".json"))
                {
                    string conteudo = File.ReadAllText(diretorio + "\\" + Login + ".json");
                    Usuario.Unit usuario = new Usuario.Unit();
                    usuario = Usuario.DesSerializedClassUnit(conteudo);
                    if (Senha == usuario.Senha)
                    {
                        return conteudo;
                    }
                }
                else
                {
                    status = false;
                    MessageBox.Show("Login e/ou senha incorreto(os)", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro na busca de usuário:" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return "";
        }

        public void Apagar(string Login)
        {
            status = true;
            try
            {
                if(MessageBox.Show("Você deseja realmente remover essa conta?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    File.Delete(diretorio + "\\" + Login + ".json");
                    MessageBox.Show("Conta removida com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    status = false;
                }
            }
            catch (Exception ex)
            {
                status = false;
                MessageBox.Show("Algo deu errado:" + ex.Message);
            }
        }

        public void Editar(string Login, string jsonUnit)
        {
            status = true;
            try
            {
                if (MessageBox.Show("Você deseja realmente editar os dados dessa conta?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    File.Delete(diretorio + "\\" + Login + ".json");
                    Incluir(Login, jsonUnit);
                    MessageBox.Show("Dados editados com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    status = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Algo deu errado:" + ex.Message);
            }
        }
    }
}
