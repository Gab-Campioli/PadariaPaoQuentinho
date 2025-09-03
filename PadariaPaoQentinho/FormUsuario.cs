using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PadariaPaoQentinho
{
    public partial class FormUsuario : Form
    {
        Model.Usuario usuario;

        int idselecionado = 0; //receber i id do usuario selecionado para manipulação

        public FormUsuario(Model.Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;

            AtualizarDgv();
        }

        public void AtualizarDgv()
        {
            dgvUsuarios.DataSource = usuario.Listar();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (txbNomeCadastro.Text.Length < 5)
            {
                MessageBox.Show("O nome deve ter no mínimo 5 caracteres",
                    "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txbEmailCadastro.Text.Length < 7)
            {
                MessageBox.Show("O email deve ter no mínimo 7 caracteres",
                    "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txbSenhaCadastro.Text.Length < 6)
            {
                MessageBox.Show("A senha deve ter no mínimo 6 caracteres",
                    "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                // Cadastrar
                Model.Usuario usuariocadastro = new Model.Usuario();

                usuariocadastro.NomeCompleto = txbNomeCadastro.Text;
                usuariocadastro.Email = txbEmailCadastro.Text;
                usuariocadastro.Senha = txbSenhaCadastro.Text;

                // Insert
                if (usuariocadastro.Cadastrar())
                {
                    MessageBox.Show("Usuário cadastrado com sucesso!",
                    "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    AtualizarDgv();

                    txbNomeCadastro.Clear();
                    txbSenhaCadastro.Clear();
                    txbEmailCadastro.Clear();

                }
                else
                {
                    MessageBox.Show("Falha ao cadastrar o usuário!",
                    "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void dgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int ls = dgvUsuarios.SelectedCells[0].RowIndex; // pegar a linha selecionada

            // colocar os valores das celulas nos textbox de seleção
            txbEditarNome.Text = dgvUsuarios.Rows[ls].Cells[1].Value.ToString();
            txbEditarEmail.Text = dgvUsuarios.Rows[ls].Cells[2].Value.ToString();

            idselecionado = (int)dgvUsuarios.Rows[ls].Cells[0].Value; // armazenar o id de quem foi selecionado

            grbEditarUsuario.Enabled = true; // ativar o grbEditar

            lblSelecioneApagar.Text = $"Deseja apagar {dgvUsuarios.Rows[ls].Cells[1].Value}?"; // Ajustes no grbApagar

            grbApagarUsuario.Enabled = true;
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            // Confirmar a exclusão
            DialogResult r = MessageBox.Show("Certeza que deseja apagar este usuário?", "Atenção!!",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (r == DialogResult.Yes)
            {
                // apagar
                Model.Usuario usuarioApagar = new Model.Usuario();

                usuarioApagar.id = idselecionado;

                if (usuarioApagar.Apagar())
                {
                    MessageBox.Show("Usuário apagado com sucesso!", "OK.",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ResetarCampos();

                }
                else
                {
                    MessageBox.Show("Falha ao apagar o usuário!", "ERRO.",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void ResetarCampos()
        {
            AtualizarDgv();

            txbEditarEmail.Clear();
            txbEditarNome.Clear();
            txbEditarSenha.Clear();

            idselecionado = 0;

            lblSelecioneApagar.Text = "Selecione o usuário que deseja apagar.";

            grbApagarUsuario.Enabled = false;
            grbEditarUsuario.Enabled = false;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (txbNomeCadastro.Text.Length < 5)
            {
                MessageBox.Show("O nome deve ter no mínimo 5 caracteres",
                    "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txbEmailCadastro.Text.Length < 7)
            {
                MessageBox.Show("O email deve ter no mínimo 7 caracteres",
                    "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txbSenhaCadastro.Text.Length < 6)
            {
                MessageBox.Show("A senha deve ter no mínimo 6 caracteres",
                    "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                // Editar
                Model.Usuario usuarioEditar = new Model.Usuario();
                usuarioEditar.id = idselecionado;
                usuarioEditar.NomeCompleto = txbEditarNome.Text;
                usuarioEditar.Email = txbEmailCadastro.Text;
                usuarioEditar.Senha = txbEditarSenha.Text;

                if (usuarioEditar.Editar())
                {
                    MessageBox.Show("Usuário modificado com sucesso!", "Prosseguir.",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ResetarCampos();
                }
                else
                {
                    MessageBox.Show("Falha ao modificar o usuário!", "ERRO!",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
