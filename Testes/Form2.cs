using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Testes
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                Prestador obj = new Prestador();
                obj.usuario = txtUsuario.Text;
                obj.senha = txtSenha.Text;
                obj.nome = txtNome.Text;
                obj.permissao = txtPermissao.Text;
                PrestadorDAO dao = new PrestadorDAO();
                dao.Cadastrar(obj);
                MessageBox.Show("Sucesso");
                //dgCliente.Columns["id_cliente"].HeaderText = "id";
                //dgCliente.Columns["id_cliente"].Visible = false;
            }
            catch (Exception erro)

            {
                MessageBox.Show("Aconteceu um erro" + erro);
            }
            finally
            {
                txtID.Text = "";
                txtUsuario.Text = "";
                txtSenha.Text = "";
                txtNome.Text = "";
                txtPermissao.Text = "";

            }
        }

        public void UpdateInfo()
        {
            Prestador obj = new Prestador();
            txtID.Text = obj.id_usuario;
            txtUsuario.Text = obj.usuario;
            txtSenha.Text = obj.senha;
            txtNome.Text = obj.nome;
            txtPermissao.Text = obj.permissao;

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                Prestador obj = new Prestador();
                obj.id_usuario = txtID.Text;
                obj.usuario = txtUsuario.Text;
                obj.senha = txtSenha.Text;
                obj.nome = txtNome.Text;
                obj.permissao = txtPermissao.Text;
                PrestadorDAO dao = new PrestadorDAO();
                dao.alterar(obj);

                MessageBox.Show("Sucesso");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro" + ex);
            }
            finally
            {
                txtID.Text = "";
                txtUsuario.Text = "";
                txtSenha.Text = "";
                txtNome.Text = "";
                txtPermissao.Text = "";
            }
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            try
            {
                Prestador obj = new Prestador();
                obj.id_usuario = txtID.Text;
                PrestadorDAO dao = new PrestadorDAO();
                dao.excluir(obj);

                MessageBox.Show("Sucesso");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro" + ex);
            }
            finally
            {

                txtID.Clear();
                //Form1 frm = new Form1();
                //frm.Form1_Activated_1(sender, e);

            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
