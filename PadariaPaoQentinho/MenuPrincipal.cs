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
    public partial class MenuPrincipal : Form
    {
        Model.Usuario usuario = new Model.Usuario();

        public MenuPrincipal(Model.Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
            lblPessoa.Text = usuario.NomeCompleto;
        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            FormUsuario formUsuario = new FormUsuario(usuario);
            formUsuario.ShowDialog(); // mostrar o form
        }

        private void btnComandas_Click(object sender, EventArgs e)
        {
            FormComandas formComandas = new FormComandas(usuario);
            formComandas.ShowDialog();
        }

        private void btnProdutos_Click(object sender, EventArgs e)
        {
            FormProdutos formProdutos = new FormProdutos(usuario);
            formProdutos.ShowDialog();
        }

        private void btnCaixa_Click(object sender, EventArgs e)
        {
            FormCaixa formCaixa = new FormCaixa(usuario);
            formCaixa.ShowDialog();
        }
    }
}
