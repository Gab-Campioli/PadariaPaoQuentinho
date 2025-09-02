using System;
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
                MessageBox.Show("O email deve ter no mínimo 6 caracteres",
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
    }
}
