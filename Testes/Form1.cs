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
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

            }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            new Form2().ShowDialog();
        }

        public void Form1_Activated_1(object sender, EventArgs e)
        {
            PrestadorDAO dao = new PrestadorDAO();
            dataGridPrestador.DataSource = dao.ListarTodosClientes();
        }

        private void dataGridPrestador_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (checkTeste.Checked)
            {
                if (e.ColumnIndex == 0)
                {
                    //Edit
                    //form.Clear();
                    Form2 form = new Form2();
                    Prestador pres = new Prestador();
                    pres.id_usuario = dataGridPrestador.Rows[e.RowIndex].Cells[1].Value.ToString();
                    pres.usuario = dataGridPrestador.Rows[e.RowIndex].Cells[2].Value.ToString();
                    pres.senha = dataGridPrestador.Rows[e.RowIndex].Cells[3].Value.ToString();
                    pres.nome = dataGridPrestador.Rows[e.RowIndex].Cells[4].Value.ToString();
                    pres.permissao = dataGridPrestador.Rows[e.RowIndex].Cells[5].Value.ToString();
                    form.UpdateInfo();
                    PrestadorDAO presDAO = new PrestadorDAO();
                    presDAO.ListarTodosClientes();
                    new Form2().ShowDialog();
                    return;
                }
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            /*string id = "Administrador";
            BindingSource bs = new BindingSource();
            bs.DataSource = dataGridPrestador.DataSource;
            //bs.Filter = "Usuario like '%" + txtSearch.Text + "%'";
            bs.Filter = "Usuario like '%" + txtSearch.Text + "%' AND permissao " + id;
            dataGridPrestador.DataSource = bs;*/
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            
            /*try
            {
                Form1_Activated_1(sender, e);
                Clear_TextBox();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorre erro" + ex.Message);
            }*/
        }

        private void btnPres_Click(object sender, EventArgs e)
        {
            new Form3().ShowDialog();
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            string id = "Administrador";
            BindingSource bs = new BindingSource();
            bs.DataSource = dataGridPrestador.DataSource;
            //bs.Filter = "Usuario like '%" + txtSearch.Text + "%'";
            bs.Filter = "Usuario like '%" + txtSearch.Text + "%' AND permissao like '%" + id + "%'";
            dataGridPrestador.DataSource = bs;
        }
    }
}
