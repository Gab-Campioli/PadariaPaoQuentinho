using EasyEncryption;
using MySqlConnector;
using PadariaPaoQentinho.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace PadariaPaoQentinho
{
    public partial class FormProdutos : Form
    {
        Model.Usuario usuario;
        int idselecionado = 0;
        public FormProdutos(Model.Usuario usuario)
        {
            InitializeComponent();
            this.usuario=usuario;
            ListarCategoriasCmb();

            AtualizarDgvProdutos();

        }

        public void AtualizarDgvProdutos()
        {
            Model.Produto produto = new Model.Produto();

            dgvProdutos.DataSource = produto.Listar();
        }

        public void ListarCategoriasCmb()
        {
            Model.Categoria categoria = new Model.Categoria();

            DataTable tabela = categoria.Listar();

            foreach (DataRow dr in tabela.Rows)
            {
                cmbCategoriaCadastro.Items.Add($"{dr["id"]} - {dr["nome"]}");
                cmbCategoriaEditar.Items.Add($"{dr["id"]} - {dr["nome"]}");
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (txbNomeCadastro.Text.Length < 2)
            {
                MessageBox.Show("O nome deve ter no mínimo 2 caracteres.",
                    "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txbPrecoCadastro.Text.Length < 1)
            {
                MessageBox.Show("O preço deve ter no mínimo 1 caracter.",
                    "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (cmbCategoriaCadastro.SelectedIndex == -1)
            {
                MessageBox.Show("A categoria deve estar selecionada.",
                    "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                // Cadastrar
                Model.Produto produtocadastro = new Model.Produto();

                produtocadastro.Nome = txbNomeCadastro.Text;
                produtocadastro.Preco = Convert.ToDouble(txbPrecoCadastro.Text);

                string idCategoria = cmbCategoriaCadastro.Text; // obter o id da categoria
                produtocadastro.idCategoria = int.Parse(idCategoria.Split('-')[0].Trim());

                produtocadastro.idResponsavel = usuario.id;

                // Insert
                if (produtocadastro.Cadastrar())
                {
                    MessageBox.Show("Produto cadastrado com sucesso!",
                    "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    AtualizarDgvProdutos();

                    txbNomeCadastro.Clear();
                    txbPrecoCadastro.Clear();
                    cmbCategoriaCadastro.SelectedIndex = -1;

                }
                else
                {
                    MessageBox.Show("Falha ao cadastrar o produto!",
                    "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void ResetarCampos()
        {
            AtualizarDgvProdutos();

            txbNomeEditar.Clear();
            txbPrecoCadastro.Clear();


            lblSelecioneApagar.Text = "Selecione o produto que deseja apagar.";

            grbApagarProduto.Enabled = false;
            grbEditar.Enabled = false;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (txbNomeEditar.Text.Length < 2)
            {
                MessageBox.Show("O nome deve ter no mínimo 2 caracteres.",
                    "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txbPrecoEditar.Text.Length < 1)
            {
                MessageBox.Show("O preço deve ter no mínimo 1 caracter.",
                    "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (cmbCategoriaEditar.SelectedIndex == -1)
            {
                MessageBox.Show("A categoria deve estar selecionada.",
                    "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                // Editar
                Model.Produto produtoEditar = new Model.Produto();
                produtoEditar.Nome = txbNomeEditar.Text;
                produtoEditar.Preco = Convert.ToDouble(txbPrecoEditar.Text);

                string idCategoria = cmbCategoriaEditar.Text; // obter o id da categoria
                produtoEditar.idCategoria = int.Parse(idCategoria.Split('-')[0].Trim());

                produtoEditar.idResponsavel = usuario.id;
                produtoEditar.id = idselecionado;

                if (produtoEditar.Editar())
                {
                    MessageBox.Show("Produto modificado com sucesso!", "Prosseguir.",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ResetarCampos();
                }
                else
                {
                    MessageBox.Show("Falha ao modificar o produto!", "ERRO!",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void dgvProdutos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int ls = dgvProdutos.SelectedCells[0].RowIndex; // pegar a linha selecionada

            idselecionado = (int)dgvProdutos.Rows[ls].Cells[0].Value; // armazenar o id de quem foi selecionado

            // colocar os valores das celulas nos textbox de seleção
            txbNomeEditar.Text = dgvProdutos.Rows[ls].Cells[1].Value.ToString();
            txbPrecoEditar.Text = dgvProdutos.Rows[ls].Cells[2].Value.ToString();
            cmbCategoriaEditar.SelectedIndex = ls;

            grbEditar.Enabled = true; // ativar o grbEditar

            lblSelecioneApagar.Text = $"Deseja apagar {dgvProdutos.Rows[ls].Cells[1].Value}?"; // Ajustes no grbApagar

            grbApagarProduto.Enabled = true;
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Certeza que deseja apagar este produto?", "Atenção!!",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (r == DialogResult.Yes)
            {
                // apagar
                Model.Produto produtoApagar = new Model.Produto();

                produtoApagar.id = idselecionado;

                if (produtoApagar.Apagar())
                {
                    MessageBox.Show("Produto apagado com sucesso!", "OK.",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ResetarCampos();

                }
                else
                {
                    MessageBox.Show("Falha ao apagar o produto!", "ERRO.",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
