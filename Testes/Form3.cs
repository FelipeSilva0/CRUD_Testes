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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                Pres obj = new Pres();
                obj.Apelido = txtApelido.Text;
                obj.Nome = txtNome.Text;
                obj.CNPJ = txtCNPJ.Text;
                PresDAO dao = new PresDAO();
                dao.CadastrarPres(obj);
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
                txtApelido.Text = "";
                txtNome.Text = "";
                txtCNPJ.Text = "";
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                Pres obj = new Pres();
                obj.idPrestador = txtID.Text;
                obj.Apelido = txtApelido.Text;
                obj.Nome = txtNome.Text;
                obj.CNPJ = txtCNPJ.Text;
                PresDAO dao = new PresDAO();
                dao.alterarPres(obj);
                MessageBox.Show("Sucesso");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro" + ex);
            }
            finally
            {
                txtID.Text = "";
                txtApelido.Text = "";
                txtNome.Text = "";
                txtCNPJ.Text = "";
            }
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            try
            {
                Pres obj = new Pres();
                obj.idPrestador = txtID.Text;
                PresDAO dao = new PresDAO();
                dao.excluirPres(obj);

                MessageBox.Show("Sucesso");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro" + ex);
            }
            finally
            {

                txtID.Clear();
            }
        }


        private void btnAtualizar_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Activated(object sender, EventArgs e)
        {
            PresDAO dao = new PresDAO();
            dataGridPres.DataSource = dao.ListarTodosClientesPres();
        }
    }
}
