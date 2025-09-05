namespace PadariaPaoQentinho
{
    partial class FormProdutos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProdutos));
            this.dgvProdutos = new System.Windows.Forms.DataGridView();
            this.grbCadastrar = new System.Windows.Forms.GroupBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.cmbCategoriaCadastro = new System.Windows.Forms.ComboBox();
            this.lblCategoriaCadastro = new System.Windows.Forms.Label();
            this.txbPrecoCadastro = new System.Windows.Forms.TextBox();
            this.lblPrecoCadastro = new System.Windows.Forms.Label();
            this.txbNomeCadastro = new System.Windows.Forms.TextBox();
            this.lblNomeCadastro = new System.Windows.Forms.Label();
            this.grbEditar = new System.Windows.Forms.GroupBox();
            this.btnEditar = new System.Windows.Forms.Button();
            this.cmbCategoriaEditar = new System.Windows.Forms.ComboBox();
            this.lblCategoriaEditar = new System.Windows.Forms.Label();
            this.txbPrecoEditar = new System.Windows.Forms.TextBox();
            this.lblPreçoEditar = new System.Windows.Forms.Label();
            this.txbNomeEditar = new System.Windows.Forms.TextBox();
            this.lblNomeEditar = new System.Windows.Forms.Label();
            this.grbApagarProduto = new System.Windows.Forms.GroupBox();
            this.btnApagar = new System.Windows.Forms.Button();
            this.lblSelecioneApagar = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblProdutosTitulo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).BeginInit();
            this.grbCadastrar.SuspendLayout();
            this.grbEditar.SuspendLayout();
            this.grbApagarProduto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProdutos
            // 
            this.dgvProdutos.AllowUserToAddRows = false;
            this.dgvProdutos.AllowUserToDeleteRows = false;
            this.dgvProdutos.AllowUserToResizeColumns = false;
            this.dgvProdutos.AllowUserToResizeRows = false;
            this.dgvProdutos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProdutos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(112)))), ((int)(((byte)(93)))));
            this.dgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdutos.GridColor = System.Drawing.Color.White;
            this.dgvProdutos.Location = new System.Drawing.Point(12, 117);
            this.dgvProdutos.Name = "dgvProdutos";
            this.dgvProdutos.Size = new System.Drawing.Size(703, 249);
            this.dgvProdutos.TabIndex = 0;
            this.dgvProdutos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProdutos_CellClick);
            // 
            // grbCadastrar
            // 
            this.grbCadastrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(112)))), ((int)(((byte)(93)))));
            this.grbCadastrar.Controls.Add(this.btnCadastrar);
            this.grbCadastrar.Controls.Add(this.cmbCategoriaCadastro);
            this.grbCadastrar.Controls.Add(this.lblCategoriaCadastro);
            this.grbCadastrar.Controls.Add(this.txbPrecoCadastro);
            this.grbCadastrar.Controls.Add(this.lblPrecoCadastro);
            this.grbCadastrar.Controls.Add(this.txbNomeCadastro);
            this.grbCadastrar.Controls.Add(this.lblNomeCadastro);
            this.grbCadastrar.ForeColor = System.Drawing.Color.White;
            this.grbCadastrar.Location = new System.Drawing.Point(12, 388);
            this.grbCadastrar.Name = "grbCadastrar";
            this.grbCadastrar.Size = new System.Drawing.Size(200, 162);
            this.grbCadastrar.TabIndex = 1;
            this.grbCadastrar.TabStop = false;
            this.grbCadastrar.Text = "Cadastrar";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.White;
            this.btnCadastrar.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen;
            this.btnCadastrar.FlatAppearance.BorderSize = 2;
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnCadastrar.Location = new System.Drawing.Point(39, 115);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(128, 41);
            this.btnCadastrar.TabIndex = 6;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // cmbCategoriaCadastro
            // 
            this.cmbCategoriaCadastro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategoriaCadastro.FormattingEnabled = true;
            this.cmbCategoriaCadastro.Location = new System.Drawing.Point(67, 81);
            this.cmbCategoriaCadastro.Name = "cmbCategoriaCadastro";
            this.cmbCategoriaCadastro.Size = new System.Drawing.Size(110, 21);
            this.cmbCategoriaCadastro.TabIndex = 5;
            // 
            // lblCategoriaCadastro
            // 
            this.lblCategoriaCadastro.AutoSize = true;
            this.lblCategoriaCadastro.Location = new System.Drawing.Point(5, 89);
            this.lblCategoriaCadastro.Name = "lblCategoriaCadastro";
            this.lblCategoriaCadastro.Size = new System.Drawing.Size(55, 13);
            this.lblCategoriaCadastro.TabIndex = 4;
            this.lblCategoriaCadastro.Text = "Categoria:";
            // 
            // txbPrecoCadastro
            // 
            this.txbPrecoCadastro.Location = new System.Drawing.Point(49, 55);
            this.txbPrecoCadastro.Name = "txbPrecoCadastro";
            this.txbPrecoCadastro.Size = new System.Drawing.Size(128, 20);
            this.txbPrecoCadastro.TabIndex = 3;
            // 
            // lblPrecoCadastro
            // 
            this.lblPrecoCadastro.AutoSize = true;
            this.lblPrecoCadastro.Location = new System.Drawing.Point(5, 62);
            this.lblPrecoCadastro.Name = "lblPrecoCadastro";
            this.lblPrecoCadastro.Size = new System.Drawing.Size(38, 13);
            this.lblPrecoCadastro.TabIndex = 2;
            this.lblPrecoCadastro.Text = "Preço:";
            // 
            // txbNomeCadastro
            // 
            this.txbNomeCadastro.Location = new System.Drawing.Point(49, 29);
            this.txbNomeCadastro.Name = "txbNomeCadastro";
            this.txbNomeCadastro.Size = new System.Drawing.Size(128, 20);
            this.txbNomeCadastro.TabIndex = 1;
            // 
            // lblNomeCadastro
            // 
            this.lblNomeCadastro.AutoSize = true;
            this.lblNomeCadastro.Location = new System.Drawing.Point(5, 36);
            this.lblNomeCadastro.Name = "lblNomeCadastro";
            this.lblNomeCadastro.Size = new System.Drawing.Size(38, 13);
            this.lblNomeCadastro.TabIndex = 0;
            this.lblNomeCadastro.Text = "Nome:";
            // 
            // grbEditar
            // 
            this.grbEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(112)))), ((int)(((byte)(93)))));
            this.grbEditar.Controls.Add(this.btnEditar);
            this.grbEditar.Controls.Add(this.cmbCategoriaEditar);
            this.grbEditar.Controls.Add(this.lblCategoriaEditar);
            this.grbEditar.Controls.Add(this.txbPrecoEditar);
            this.grbEditar.Controls.Add(this.lblPreçoEditar);
            this.grbEditar.Controls.Add(this.txbNomeEditar);
            this.grbEditar.Controls.Add(this.lblNomeEditar);
            this.grbEditar.Enabled = false;
            this.grbEditar.ForeColor = System.Drawing.Color.White;
            this.grbEditar.Location = new System.Drawing.Point(228, 388);
            this.grbEditar.Name = "grbEditar";
            this.grbEditar.Size = new System.Drawing.Size(200, 162);
            this.grbEditar.TabIndex = 7;
            this.grbEditar.TabStop = false;
            this.grbEditar.Text = "Editar";
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.White;
            this.btnEditar.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnEditar.FlatAppearance.BorderSize = 2;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnEditar.Location = new System.Drawing.Point(36, 115);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(128, 41);
            this.btnEditar.TabIndex = 6;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // cmbCategoriaEditar
            // 
            this.cmbCategoriaEditar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategoriaEditar.FormattingEnabled = true;
            this.cmbCategoriaEditar.Location = new System.Drawing.Point(67, 81);
            this.cmbCategoriaEditar.Name = "cmbCategoriaEditar";
            this.cmbCategoriaEditar.Size = new System.Drawing.Size(110, 21);
            this.cmbCategoriaEditar.TabIndex = 5;
            // 
            // lblCategoriaEditar
            // 
            this.lblCategoriaEditar.AutoSize = true;
            this.lblCategoriaEditar.Location = new System.Drawing.Point(5, 89);
            this.lblCategoriaEditar.Name = "lblCategoriaEditar";
            this.lblCategoriaEditar.Size = new System.Drawing.Size(55, 13);
            this.lblCategoriaEditar.TabIndex = 4;
            this.lblCategoriaEditar.Text = "Categoria:";
            // 
            // txbPrecoEditar
            // 
            this.txbPrecoEditar.Location = new System.Drawing.Point(49, 55);
            this.txbPrecoEditar.Name = "txbPrecoEditar";
            this.txbPrecoEditar.Size = new System.Drawing.Size(128, 20);
            this.txbPrecoEditar.TabIndex = 3;
            // 
            // lblPreçoEditar
            // 
            this.lblPreçoEditar.AutoSize = true;
            this.lblPreçoEditar.Location = new System.Drawing.Point(5, 62);
            this.lblPreçoEditar.Name = "lblPreçoEditar";
            this.lblPreçoEditar.Size = new System.Drawing.Size(38, 13);
            this.lblPreçoEditar.TabIndex = 2;
            this.lblPreçoEditar.Text = "Preço:";
            // 
            // txbNomeEditar
            // 
            this.txbNomeEditar.Location = new System.Drawing.Point(49, 29);
            this.txbNomeEditar.Name = "txbNomeEditar";
            this.txbNomeEditar.Size = new System.Drawing.Size(128, 20);
            this.txbNomeEditar.TabIndex = 1;
            // 
            // lblNomeEditar
            // 
            this.lblNomeEditar.AutoSize = true;
            this.lblNomeEditar.Location = new System.Drawing.Point(5, 36);
            this.lblNomeEditar.Name = "lblNomeEditar";
            this.lblNomeEditar.Size = new System.Drawing.Size(38, 13);
            this.lblNomeEditar.TabIndex = 0;
            this.lblNomeEditar.Text = "Nome:";
            // 
            // grbApagarProduto
            // 
            this.grbApagarProduto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(112)))), ((int)(((byte)(90)))));
            this.grbApagarProduto.Controls.Add(this.btnApagar);
            this.grbApagarProduto.Controls.Add(this.lblSelecioneApagar);
            this.grbApagarProduto.Enabled = false;
            this.grbApagarProduto.ForeColor = System.Drawing.Color.White;
            this.grbApagarProduto.Location = new System.Drawing.Point(453, 450);
            this.grbApagarProduto.Name = "grbApagarProduto";
            this.grbApagarProduto.Size = new System.Drawing.Size(262, 100);
            this.grbApagarProduto.TabIndex = 9;
            this.grbApagarProduto.TabStop = false;
            this.grbApagarProduto.Text = "Apagar";
            // 
            // btnApagar
            // 
            this.btnApagar.BackColor = System.Drawing.Color.White;
            this.btnApagar.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.btnApagar.FlatAppearance.BorderSize = 2;
            this.btnApagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApagar.ForeColor = System.Drawing.Color.DarkRed;
            this.btnApagar.Location = new System.Drawing.Point(17, 50);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(239, 44);
            this.btnApagar.TabIndex = 7;
            this.btnApagar.Text = "Apagar";
            this.btnApagar.UseVisualStyleBackColor = false;
            this.btnApagar.Click += new System.EventHandler(this.btnApagar_Click);
            // 
            // lblSelecioneApagar
            // 
            this.lblSelecioneApagar.AutoSize = true;
            this.lblSelecioneApagar.Location = new System.Drawing.Point(33, 27);
            this.lblSelecioneApagar.Name = "lblSelecioneApagar";
            this.lblSelecioneApagar.Size = new System.Drawing.Size(191, 13);
            this.lblSelecioneApagar.TabIndex = 0;
            this.lblSelecioneApagar.Text = "Selecione o usuário que deseja apagar";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PadariaPaoQentinho.Properties.Resources.produtos_removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(12, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(122, 98);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // lblProdutosTitulo
            // 
            this.lblProdutosTitulo.AutoSize = true;
            this.lblProdutosTitulo.Font = new System.Drawing.Font("High Tower Text", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProdutosTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(112)))), ((int)(((byte)(93)))));
            this.lblProdutosTitulo.Location = new System.Drawing.Point(140, 36);
            this.lblProdutosTitulo.Name = "lblProdutosTitulo";
            this.lblProdutosTitulo.Size = new System.Drawing.Size(154, 44);
            this.lblProdutosTitulo.TabIndex = 11;
            this.lblProdutosTitulo.Text = "Produtos";
            // 
            // FormProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(734, 573);
            this.Controls.Add(this.lblProdutosTitulo);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.grbApagarProduto);
            this.Controls.Add(this.grbEditar);
            this.Controls.Add(this.grbCadastrar);
            this.Controls.Add(this.dgvProdutos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormProdutos";
            this.Text = "Produtos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).EndInit();
            this.grbCadastrar.ResumeLayout(false);
            this.grbCadastrar.PerformLayout();
            this.grbEditar.ResumeLayout(false);
            this.grbEditar.PerformLayout();
            this.grbApagarProduto.ResumeLayout(false);
            this.grbApagarProduto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProdutos;
        private System.Windows.Forms.GroupBox grbCadastrar;
        private System.Windows.Forms.Label lblNomeCadastro;
        private System.Windows.Forms.TextBox txbPrecoCadastro;
        private System.Windows.Forms.Label lblPrecoCadastro;
        private System.Windows.Forms.TextBox txbNomeCadastro;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.ComboBox cmbCategoriaCadastro;
        private System.Windows.Forms.Label lblCategoriaCadastro;
        private System.Windows.Forms.GroupBox grbEditar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.ComboBox cmbCategoriaEditar;
        private System.Windows.Forms.Label lblCategoriaEditar;
        private System.Windows.Forms.TextBox txbPrecoEditar;
        private System.Windows.Forms.Label lblPreçoEditar;
        private System.Windows.Forms.TextBox txbNomeEditar;
        private System.Windows.Forms.Label lblNomeEditar;
        private System.Windows.Forms.GroupBox grbApagarProduto;
        private System.Windows.Forms.Button btnApagar;
        private System.Windows.Forms.Label lblSelecioneApagar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblProdutosTitulo;
    }
}