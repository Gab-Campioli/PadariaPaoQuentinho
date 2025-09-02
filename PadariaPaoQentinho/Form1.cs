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
    public partial class Acesso : Form
    {
        public Acesso()
        {
            InitializeComponent();
        }

        private void btnLogar_Click(object sender, EventArgs e)
        {
            // Verificação de email e senha
            if (txbEmail.Text.Length < 6)
            {
                MessageBox.Show("Digite um email válido.",
                    "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txbSenha.Text.Length < 4)
            {
                MessageBox.Show("Digite uma senha válida.",
                    "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Prosseguir
                Model.Usuario usuario = new Model.Usuario();

                // Colocar os valores dos campos nos atributos do usuário
                usuario.Email = txbEmail.Text;
                usuario.Senha = txbSenha.Text;

                // Tabela que vai receber o resultado do SELECT
                DataTable resultado = usuario.Logar();

               // Verificar se acertou o acesso
               if (resultado.Rows.Count == 0)
                {
                    MessageBox.Show("Email ou senha inválidos!",
                    "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
               else
                {
                    // Armazenar as infos vindas do bd no objeto "usuario"
                    usuario.id = int.Parse(resultado.Rows[0]["id"].ToString());
                    usuario.NomeCompleto = resultado.Rows[0]["nome_completo"].ToString();

                    // Mudar para o menu principal
                    MenuPrincipal menuprincipal = new MenuPrincipal(usuario);
                    Hide();
                    menuprincipal.ShowDialog();

                    Show();
                }
            }
        }
    }
}
