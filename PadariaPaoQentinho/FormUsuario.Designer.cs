namespace PadariaPaoQentinho
{
    partial class FormUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUsuario));
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.grbCadastro = new System.Windows.Forms.GroupBox();
            this.lblNomeCadastro = new System.Windows.Forms.Label();
            this.lblEmailCadastro = new System.Windows.Forms.Label();
            this.lblSenhaCadastro = new System.Windows.Forms.Label();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.txbNomeCadastro = new System.Windows.Forms.TextBox();
            this.txbEmailCadastro = new System.Windows.Forms.TextBox();
            this.txbSenhaCadastro = new System.Windows.Forms.TextBox();
            this.grbEditarUsuario = new System.Windows.Forms.GroupBox();
            this.txbEditarSenha = new System.Windows.Forms.TextBox();
            this.txbEditarEmail = new System.Windows.Forms.TextBox();
            this.txbEditarNome = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.grbApagarUsuario = new System.Windows.Forms.GroupBox();
            this.lblSelecioneApagar = new System.Windows.Forms.Label();
            this.btnApagar = new System.Windows.Forms.Button();
            this.lblCadastrarTitulo = new System.Windows.Forms.Label();
            this.lblEditarTitulo = new System.Windows.Forms.Label();
            this.lblApagarTitulo = new System.Windows.Forms.Label();
            this.lblGerenciamento = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.grbCadastro.SuspendLayout();
            this.grbEditarUsuario.SuspendLayout();
            this.grbApagarUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.AllowUserToAddRows = false;
            this.dgvUsuarios.AllowUserToDeleteRows = false;
            this.dgvUsuarios.AllowUserToResizeColumns = false;
            this.dgvUsuarios.AllowUserToResizeRows = false;
            this.dgvUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUsuarios.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(112)))), ((int)(((byte)(90)))));
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.Location = new System.Drawing.Point(12, 85);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.ReadOnly = true;
            this.dgvUsuarios.Size = new System.Drawing.Size(404, 640);
            this.dgvUsuarios.TabIndex = 0;
            // 
            // grbCadastro
            // 
            this.grbCadastro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(112)))), ((int)(((byte)(90)))));
            this.grbCadastro.Controls.Add(this.txbSenhaCadastro);
            this.grbCadastro.Controls.Add(this.txbEmailCadastro);
            this.grbCadastro.Controls.Add(this.txbNomeCadastro);
            this.grbCadastro.Controls.Add(this.btnCadastrar);
            this.grbCadastro.Controls.Add(this.lblSenhaCadastro);
            this.grbCadastro.Controls.Add(this.lblEmailCadastro);
            this.grbCadastro.Controls.Add(this.lblNomeCadastro);
            this.grbCadastro.ForeColor = System.Drawing.Color.White;
            this.grbCadastro.Location = new System.Drawing.Point(436, 88);
            this.grbCadastro.Name = "grbCadastro";
            this.grbCadastro.Size = new System.Drawing.Size(264, 174);
            this.grbCadastro.TabIndex = 1;
            this.grbCadastro.TabStop = false;
            this.grbCadastro.Text = "Cadastro";
            // 
            // lblNomeCadastro
            // 
            this.lblNomeCadastro.AutoSize = true;
            this.lblNomeCadastro.Location = new System.Drawing.Point(7, 32);
            this.lblNomeCadastro.Name = "lblNomeCadastro";
            this.lblNomeCadastro.Size = new System.Drawing.Size(85, 13);
            this.lblNomeCadastro.TabIndex = 0;
            this.lblNomeCadastro.Text = "Nome Completo:";
            // 
            // lblEmailCadastro
            // 
            this.lblEmailCadastro.AutoSize = true;
            this.lblEmailCadastro.Location = new System.Drawing.Point(57, 57);
            this.lblEmailCadastro.Name = "lblEmailCadastro";
            this.lblEmailCadastro.Size = new System.Drawing.Size(35, 13);
            this.lblEmailCadastro.TabIndex = 1;
            this.lblEmailCadastro.Text = "Email:";
            // 
            // lblSenhaCadastro
            // 
            this.lblSenhaCadastro.AutoSize = true;
            this.lblSenhaCadastro.Location = new System.Drawing.Point(51, 83);
            this.lblSenhaCadastro.Name = "lblSenhaCadastro";
            this.lblSenhaCadastro.Size = new System.Drawing.Size(41, 13);
            this.lblSenhaCadastro.TabIndex = 2;
            this.lblSenhaCadastro.Text = "Senha:";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.ForeColor = System.Drawing.Color.Black;
            this.btnCadastrar.Location = new System.Drawing.Point(10, 115);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(239, 44);
            this.btnCadastrar.TabIndex = 3;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // txbNomeCadastro
            // 
            this.txbNomeCadastro.Location = new System.Drawing.Point(99, 24);
            this.txbNomeCadastro.Name = "txbNomeCadastro";
            this.txbNomeCadastro.Size = new System.Drawing.Size(150, 20);
            this.txbNomeCadastro.TabIndex = 4;
            // 
            // txbEmailCadastro
            // 
            this.txbEmailCadastro.Location = new System.Drawing.Point(99, 50);
            this.txbEmailCadastro.Name = "txbEmailCadastro";
            this.txbEmailCadastro.Size = new System.Drawing.Size(150, 20);
            this.txbEmailCadastro.TabIndex = 5;
            // 
            // txbSenhaCadastro
            // 
            this.txbSenhaCadastro.Location = new System.Drawing.Point(99, 76);
            this.txbSenhaCadastro.Name = "txbSenhaCadastro";
            this.txbSenhaCadastro.Size = new System.Drawing.Size(150, 20);
            this.txbSenhaCadastro.TabIndex = 6;
            // 
            // grbEditarUsuario
            // 
            this.grbEditarUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(112)))), ((int)(((byte)(90)))));
            this.grbEditarUsuario.Controls.Add(this.txbEditarSenha);
            this.grbEditarUsuario.Controls.Add(this.txbEditarEmail);
            this.grbEditarUsuario.Controls.Add(this.txbEditarNome);
            this.grbEditarUsuario.Controls.Add(this.button1);
            this.grbEditarUsuario.Controls.Add(this.label1);
            this.grbEditarUsuario.Controls.Add(this.label2);
            this.grbEditarUsuario.Controls.Add(this.label3);
            this.grbEditarUsuario.Enabled = false;
            this.grbEditarUsuario.ForeColor = System.Drawing.Color.White;
            this.grbEditarUsuario.Location = new System.Drawing.Point(436, 348);
            this.grbEditarUsuario.Name = "grbEditarUsuario";
            this.grbEditarUsuario.Size = new System.Drawing.Size(264, 174);
            this.grbEditarUsuario.TabIndex = 7;
            this.grbEditarUsuario.TabStop = false;
            this.grbEditarUsuario.Text = "Editar";
            // 
            // txbEditarSenha
            // 
            this.txbEditarSenha.Location = new System.Drawing.Point(99, 76);
            this.txbEditarSenha.Name = "txbEditarSenha";
            this.txbEditarSenha.Size = new System.Drawing.Size(150, 20);
            this.txbEditarSenha.TabIndex = 6;
            // 
            // txbEditarEmail
            // 
            this.txbEditarEmail.Location = new System.Drawing.Point(99, 50);
            this.txbEditarEmail.Name = "txbEditarEmail";
            this.txbEditarEmail.Size = new System.Drawing.Size(150, 20);
            this.txbEditarEmail.TabIndex = 5;
            // 
            // txbEditarNome
            // 
            this.txbEditarNome.Location = new System.Drawing.Point(99, 24);
            this.txbEditarNome.Name = "txbEditarNome";
            this.txbEditarNome.Size = new System.Drawing.Size(150, 20);
            this.txbEditarNome.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(10, 115);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(239, 44);
            this.button1.TabIndex = 3;
            this.button1.Text = "Editar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(22, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nova Senha:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(57, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Email:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(7, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nome Completo:";
            // 
            // grbApagarUsuario
            // 
            this.grbApagarUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(112)))), ((int)(((byte)(90)))));
            this.grbApagarUsuario.Controls.Add(this.btnApagar);
            this.grbApagarUsuario.Controls.Add(this.lblSelecioneApagar);
            this.grbApagarUsuario.Enabled = false;
            this.grbApagarUsuario.ForeColor = System.Drawing.Color.White;
            this.grbApagarUsuario.Location = new System.Drawing.Point(436, 604);
            this.grbApagarUsuario.Name = "grbApagarUsuario";
            this.grbApagarUsuario.Size = new System.Drawing.Size(264, 121);
            this.grbApagarUsuario.TabIndex = 8;
            this.grbApagarUsuario.TabStop = false;
            this.grbApagarUsuario.Text = "Apagar";
            // 
            // lblSelecioneApagar
            // 
            this.lblSelecioneApagar.AutoSize = true;
            this.lblSelecioneApagar.Location = new System.Drawing.Point(34, 28);
            this.lblSelecioneApagar.Name = "lblSelecioneApagar";
            this.lblSelecioneApagar.Size = new System.Drawing.Size(191, 13);
            this.lblSelecioneApagar.TabIndex = 0;
            this.lblSelecioneApagar.Text = "Selecione o usuário que deseja apagar";
            // 
            // btnApagar
            // 
            this.btnApagar.BackColor = System.Drawing.Color.DarkRed;
            this.btnApagar.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.btnApagar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnApagar.ForeColor = System.Drawing.Color.White;
            this.btnApagar.Location = new System.Drawing.Point(10, 62);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(239, 44);
            this.btnApagar.TabIndex = 7;
            this.btnApagar.Text = "Apagar";
            this.btnApagar.UseVisualStyleBackColor = false;
            // 
            // lblCadastrarTitulo
            // 
            this.lblCadastrarTitulo.AutoSize = true;
            this.lblCadastrarTitulo.Font = new System.Drawing.Font("High Tower Text", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadastrarTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(112)))), ((int)(((byte)(90)))));
            this.lblCadastrarTitulo.Location = new System.Drawing.Point(538, 39);
            this.lblCadastrarTitulo.Name = "lblCadastrarTitulo";
            this.lblCadastrarTitulo.Size = new System.Drawing.Size(151, 40);
            this.lblCadastrarTitulo.TabIndex = 10;
            this.lblCadastrarTitulo.Text = "Cadastrar";
            // 
            // lblEditarTitulo
            // 
            this.lblEditarTitulo.AutoSize = true;
            this.lblEditarTitulo.Font = new System.Drawing.Font("High Tower Text", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditarTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(112)))), ((int)(((byte)(90)))));
            this.lblEditarTitulo.Location = new System.Drawing.Point(538, 287);
            this.lblEditarTitulo.Name = "lblEditarTitulo";
            this.lblEditarTitulo.Size = new System.Drawing.Size(103, 40);
            this.lblEditarTitulo.TabIndex = 11;
            this.lblEditarTitulo.Text = "Editar";
            // 
            // lblApagarTitulo
            // 
            this.lblApagarTitulo.AutoSize = true;
            this.lblApagarTitulo.Font = new System.Drawing.Font("High Tower Text", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApagarTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(112)))), ((int)(((byte)(90)))));
            this.lblApagarTitulo.Location = new System.Drawing.Point(538, 556);
            this.lblApagarTitulo.Name = "lblApagarTitulo";
            this.lblApagarTitulo.Size = new System.Drawing.Size(119, 40);
            this.lblApagarTitulo.TabIndex = 14;
            this.lblApagarTitulo.Text = "Apagar";
            // 
            // lblGerenciamento
            // 
            this.lblGerenciamento.AutoSize = true;
            this.lblGerenciamento.Font = new System.Drawing.Font("High Tower Text", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGerenciamento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(112)))), ((int)(((byte)(90)))));
            this.lblGerenciamento.Location = new System.Drawing.Point(139, 39);
            this.lblGerenciamento.Name = "lblGerenciamento";
            this.lblGerenciamento.Size = new System.Drawing.Size(277, 40);
            this.lblGerenciamento.TabIndex = 15;
            this.lblGerenciamento.Text = "Menu de Usuários";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::PadariaPaoQentinho.Properties.Resources.MenuIcon_removebg_preview;
            this.pictureBox4.Location = new System.Drawing.Point(12, 9);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(121, 70);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 16;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::PadariaPaoQentinho.Properties.Resources.ExcluirIcon;
            this.pictureBox3.Location = new System.Drawing.Point(461, 541);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(71, 55);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 13;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::PadariaPaoQentinho.Properties.Resources.EditarIcon;
            this.pictureBox2.Location = new System.Drawing.Point(461, 272);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(71, 55);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PadariaPaoQentinho.Properties.Resources.CadastrarIcon;
            this.pictureBox1.Location = new System.Drawing.Point(461, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(71, 52);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // FormUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(735, 758);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.lblGerenciamento);
            this.Controls.Add(this.lblApagarTitulo);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lblEditarTitulo);
            this.Controls.Add(this.lblCadastrarTitulo);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.grbApagarUsuario);
            this.Controls.Add(this.grbEditarUsuario);
            this.Controls.Add(this.grbCadastro);
            this.Controls.Add(this.dgvUsuarios);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu de Usuários";
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.grbCadastro.ResumeLayout(false);
            this.grbCadastro.PerformLayout();
            this.grbEditarUsuario.ResumeLayout(false);
            this.grbEditarUsuario.PerformLayout();
            this.grbApagarUsuario.ResumeLayout(false);
            this.grbApagarUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.GroupBox grbCadastro;
        private System.Windows.Forms.TextBox txbSenhaCadastro;
        private System.Windows.Forms.TextBox txbEmailCadastro;
        private System.Windows.Forms.TextBox txbNomeCadastro;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Label lblSenhaCadastro;
        private System.Windows.Forms.Label lblEmailCadastro;
        private System.Windows.Forms.Label lblNomeCadastro;
        private System.Windows.Forms.GroupBox grbEditarUsuario;
        private System.Windows.Forms.TextBox txbEditarSenha;
        private System.Windows.Forms.TextBox txbEditarEmail;
        private System.Windows.Forms.TextBox txbEditarNome;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox grbApagarUsuario;
        private System.Windows.Forms.Label lblSelecioneApagar;
        private System.Windows.Forms.Button btnApagar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblCadastrarTitulo;
        private System.Windows.Forms.Label lblEditarTitulo;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label lblApagarTitulo;
        private System.Windows.Forms.Label lblGerenciamento;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}