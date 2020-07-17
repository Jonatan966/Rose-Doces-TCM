namespace Projeto_TCM_3
{
    partial class CadastroClientes
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
            this.pnlCentro = new System.Windows.Forms.Panel();
            this.gbDados = new System.Windows.Forms.GroupBox();
            this.txbTelefone = new System.Windows.Forms.MaskedTextBox();
            this.btnBuscarCadastro = new System.Windows.Forms.Button();
            this.txbEndereco = new System.Windows.Forms.TextBox();
            this.txbNome = new System.Windows.Forms.TextBox();
            this.txbCPF = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlInferior = new System.Windows.Forms.Panel();
            this.tlpInferior = new System.Windows.Forms.TableLayoutPanel();
            this.btnAlterarCadastro = new System.Windows.Forms.Button();
            this.btnDeletarCliente = new System.Windows.Forms.Button();
            this.btnFinalizarCadastro = new System.Windows.Forms.Button();
            this.btnCancelarCadastro = new System.Windows.Forms.Button();
            this.tlpControle = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnFechar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.pnlCentro.SuspendLayout();
            this.gbDados.SuspendLayout();
            this.pnlInferior.SuspendLayout();
            this.tlpInferior.SuspendLayout();
            this.tlpControle.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlCentro
            // 
            this.pnlCentro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pnlCentro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCentro.Controls.Add(this.gbDados);
            this.pnlCentro.Controls.Add(this.pnlInferior);
            this.pnlCentro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCentro.Location = new System.Drawing.Point(7, 35);
            this.pnlCentro.Name = "pnlCentro";
            this.pnlCentro.Size = new System.Drawing.Size(487, 231);
            this.pnlCentro.TabIndex = 0;
            // 
            // gbDados
            // 
            this.gbDados.Controls.Add(this.txbTelefone);
            this.gbDados.Controls.Add(this.btnBuscarCadastro);
            this.gbDados.Controls.Add(this.txbEndereco);
            this.gbDados.Controls.Add(this.txbNome);
            this.gbDados.Controls.Add(this.txbCPF);
            this.gbDados.Controls.Add(this.label4);
            this.gbDados.Controls.Add(this.label3);
            this.gbDados.Controls.Add(this.label2);
            this.gbDados.Controls.Add(this.label1);
            this.gbDados.Location = new System.Drawing.Point(7, 5);
            this.gbDados.Name = "gbDados";
            this.gbDados.Size = new System.Drawing.Size(472, 125);
            this.gbDados.TabIndex = 7;
            this.gbDados.TabStop = false;
            this.gbDados.Text = "Dados do Cliente";
            // 
            // txbTelefone
            // 
            this.txbTelefone.Location = new System.Drawing.Point(64, 71);
            this.txbTelefone.Mask = "(00)0000-0000";
            this.txbTelefone.Name = "txbTelefone";
            this.txbTelefone.Size = new System.Drawing.Size(401, 20);
            this.txbTelefone.TabIndex = 3;
            this.txbTelefone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnBuscarCadastro
            // 
            this.btnBuscarCadastro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnBuscarCadastro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarCadastro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnBuscarCadastro.Location = new System.Drawing.Point(404, 16);
            this.btnBuscarCadastro.Name = "btnBuscarCadastro";
            this.btnBuscarCadastro.Size = new System.Drawing.Size(61, 23);
            this.btnBuscarCadastro.TabIndex = 1;
            this.btnBuscarCadastro.Text = "Procurar";
            this.btnBuscarCadastro.UseVisualStyleBackColor = false;
            this.btnBuscarCadastro.Click += new System.EventHandler(this.btnBuscarCadastro_Click);
            // 
            // txbEndereco
            // 
            this.txbEndereco.Location = new System.Drawing.Point(68, 97);
            this.txbEndereco.Name = "txbEndereco";
            this.txbEndereco.Size = new System.Drawing.Size(397, 20);
            this.txbEndereco.TabIndex = 4;
            this.txbEndereco.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txbNome
            // 
            this.txbNome.Location = new System.Drawing.Point(50, 45);
            this.txbNome.Name = "txbNome";
            this.txbNome.Size = new System.Drawing.Size(415, 20);
            this.txbNome.TabIndex = 2;
            this.txbNome.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txbNome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbSemNumero_KeyPress);
            // 
            // txbCPF
            // 
            this.txbCPF.Location = new System.Drawing.Point(42, 19);
            this.txbCPF.Mask = "000000000-00";
            this.txbCPF.Name = "txbCPF";
            this.txbCPF.Size = new System.Drawing.Size(356, 20);
            this.txbCPF.TabIndex = 0;
            this.txbCPF.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Endereço:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Telefone:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "CPF:";
            // 
            // pnlInferior
            // 
            this.pnlInferior.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlInferior.Controls.Add(this.tlpInferior);
            this.pnlInferior.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlInferior.Location = new System.Drawing.Point(0, 148);
            this.pnlInferior.Name = "pnlInferior";
            this.pnlInferior.Size = new System.Drawing.Size(485, 81);
            this.pnlInferior.TabIndex = 6;
            // 
            // tlpInferior
            // 
            this.tlpInferior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.tlpInferior.ColumnCount = 2;
            this.tlpInferior.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpInferior.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpInferior.Controls.Add(this.btnAlterarCadastro, 0, 1);
            this.tlpInferior.Controls.Add(this.btnDeletarCliente, 0, 0);
            this.tlpInferior.Controls.Add(this.btnFinalizarCadastro, 0, 0);
            this.tlpInferior.Controls.Add(this.btnCancelarCadastro, 1, 1);
            this.tlpInferior.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpInferior.Location = new System.Drawing.Point(0, 0);
            this.tlpInferior.Name = "tlpInferior";
            this.tlpInferior.Padding = new System.Windows.Forms.Padding(2);
            this.tlpInferior.RowCount = 2;
            this.tlpInferior.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpInferior.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpInferior.Size = new System.Drawing.Size(481, 77);
            this.tlpInferior.TabIndex = 2;
            // 
            // btnAlterarCadastro
            // 
            this.btnAlterarCadastro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnAlterarCadastro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAlterarCadastro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterarCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterarCadastro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnAlterarCadastro.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnAlterarCadastro.Location = new System.Drawing.Point(5, 41);
            this.btnAlterarCadastro.Name = "btnAlterarCadastro";
            this.btnAlterarCadastro.Size = new System.Drawing.Size(232, 31);
            this.btnAlterarCadastro.TabIndex = 7;
            this.btnAlterarCadastro.Text = "Alterar Cadastro";
            this.btnAlterarCadastro.UseVisualStyleBackColor = false;
            this.btnAlterarCadastro.Click += new System.EventHandler(this.btnAlterarCadastro_Click);
            // 
            // btnDeletarCliente
            // 
            this.btnDeletarCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnDeletarCliente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDeletarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeletarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletarCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDeletarCliente.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnDeletarCliente.Location = new System.Drawing.Point(243, 5);
            this.btnDeletarCliente.Name = "btnDeletarCliente";
            this.btnDeletarCliente.Size = new System.Drawing.Size(233, 30);
            this.btnDeletarCliente.TabIndex = 6;
            this.btnDeletarCliente.Text = "✘Deletar Cliente ✘";
            this.btnDeletarCliente.UseVisualStyleBackColor = false;
            this.btnDeletarCliente.Click += new System.EventHandler(this.btnDeletarCliente_Click);
            // 
            // btnFinalizarCadastro
            // 
            this.btnFinalizarCadastro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnFinalizarCadastro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnFinalizarCadastro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinalizarCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalizarCadastro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnFinalizarCadastro.Location = new System.Drawing.Point(5, 5);
            this.btnFinalizarCadastro.Name = "btnFinalizarCadastro";
            this.btnFinalizarCadastro.Size = new System.Drawing.Size(232, 30);
            this.btnFinalizarCadastro.TabIndex = 5;
            this.btnFinalizarCadastro.Text = "✔ Finalizar Cadastro ✔";
            this.btnFinalizarCadastro.UseVisualStyleBackColor = false;
            this.btnFinalizarCadastro.Click += new System.EventHandler(this.btnFinalizarCadastro_Click);
            // 
            // btnCancelarCadastro
            // 
            this.btnCancelarCadastro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnCancelarCadastro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCancelarCadastro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarCadastro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCancelarCadastro.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnCancelarCadastro.Location = new System.Drawing.Point(243, 41);
            this.btnCancelarCadastro.Name = "btnCancelarCadastro";
            this.btnCancelarCadastro.Size = new System.Drawing.Size(233, 31);
            this.btnCancelarCadastro.TabIndex = 8;
            this.btnCancelarCadastro.Text = "✘ Cancelar Cadastro ✘";
            this.btnCancelarCadastro.UseVisualStyleBackColor = false;
            this.btnCancelarCadastro.Click += new System.EventHandler(this.btnCancelarCadastro_Click);
            // 
            // tlpControle
            // 
            this.tlpControle.ColumnCount = 3;
            this.tlpControle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.403545F));
            this.tlpControle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 92.59646F));
            this.tlpControle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tlpControle.Controls.Add(this.tableLayoutPanel2, 2, 0);
            this.tlpControle.Controls.Add(this.label7, 1, 0);
            this.tlpControle.Location = new System.Drawing.Point(7, 1);
            this.tlpControle.Name = "tlpControle";
            this.tlpControle.RowCount = 1;
            this.tlpControle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpControle.Size = new System.Drawing.Size(487, 34);
            this.tlpControle.TabIndex = 4;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.23529F));
            this.tableLayoutPanel2.Controls.Add(this.btnFechar, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(452, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(32, 28);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // btnFechar
            // 
            this.btnFechar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnFechar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.Font = new System.Drawing.Font("Curlz MT", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnFechar.Location = new System.Drawing.Point(3, 3);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(26, 22);
            this.btnFechar.TabIndex = 2;
            this.btnFechar.TabStop = false;
            this.btnFechar.Text = "✘";
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // label7
            // 
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Font = new System.Drawing.Font("Curlz MT", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(36, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(410, 34);
            this.label7.TabIndex = 3;
            this.label7.Text = "Cadastro de Clientes - Rose Doces";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label7.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Tela_MouseDown);
            this.label7.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Tela_MouseMove);
            this.label7.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Tela_MouseUp);
            // 
            // CadastroClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(215)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(501, 273);
            this.Controls.Add(this.tlpControle);
            this.Controls.Add(this.pnlCentro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CadastroClientes";
            this.Padding = new System.Windows.Forms.Padding(7, 35, 7, 7);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Base";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Tela_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Tela_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Tela_MouseUp);
            this.pnlCentro.ResumeLayout(false);
            this.gbDados.ResumeLayout(false);
            this.gbDados.PerformLayout();
            this.pnlInferior.ResumeLayout(false);
            this.tlpInferior.ResumeLayout(false);
            this.tlpControle.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlCentro;
        private System.Windows.Forms.TableLayoutPanel tlpControle;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox gbDados;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlInferior;
        private System.Windows.Forms.TableLayoutPanel tlpInferior;
        private System.Windows.Forms.Button btnAlterarCadastro;
        private System.Windows.Forms.Button btnDeletarCliente;
        private System.Windows.Forms.Button btnFinalizarCadastro;
        private System.Windows.Forms.Button btnCancelarCadastro;
        private System.Windows.Forms.TextBox txbEndereco;
        private System.Windows.Forms.TextBox txbNome;
        private System.Windows.Forms.MaskedTextBox txbCPF;
        private System.Windows.Forms.Button btnBuscarCadastro;
        private System.Windows.Forms.MaskedTextBox txbTelefone;
    }
}

