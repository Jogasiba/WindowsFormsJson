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
    public class ContasSalvas
    {
        public string diretorio;
        public bool status;

        public ContasSalvas(string Diretorio)
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
            catch (Exception ex)
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
                Apagar();
                File.WriteAllText(diretorio + "\\" + Login + ".json", jsonUnit);
            }
            catch (Exception ex)
            {
                status = false;
                MessageBox.Show("Erro na inclusão de usuário:" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public string Buscar()
        {
            status = true;
            try
            {
                Array files = Directory.GetFiles(diretorio);
                if(files.Length > 0)
                {
                    foreach (var file in files)
                    {
                        string json = File.ReadAllText(file.ToString());
                        Usuario.Unit u = new Usuario.Unit();
                        u = Usuario.DesSerializedClassUnit(json);
                        return u.Login;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro na busca de usuário:" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return "";
        }

        public string Apagar()
        {
            status = true;
            try
            {
                Array files = Directory.GetFiles(diretorio);
                if (files.Length > 0)
                {
                    foreach (var file in files)
                    {
                        string json = File.ReadAllText(file.ToString());
                        Usuario.Unit u = new Usuario.Unit();
                        u = Usuario.DesSerializedClassUnit(json);
                        File.Delete(diretorio + "\\" + u.Login + ".json");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro na busca de usuário:" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return "";
        }
    }
}
