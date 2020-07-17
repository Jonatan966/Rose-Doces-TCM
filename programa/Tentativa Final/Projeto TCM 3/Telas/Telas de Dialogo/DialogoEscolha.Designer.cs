namespace Projeto_TCM_3
{
    partial class DialogoEscolha
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DialogoEscolha));
            this.pnlCentro = new System.Windows.Forms.Panel();
            this.lblMsg = new System.Windows.Forms.Label();
            this.pnlInferior = new System.Windows.Forms.Panel();
            this.tlpBotoes = new System.Windows.Forms.TableLayoutPanel();
            this.btnNao = new System.Windows.Forms.Button();
            this.btnSim = new System.Windows.Forms.Button();
            this.tlpControle = new System.Windows.Forms.TableLayoutPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.pnlCentro.SuspendLayout();
            this.pnlInferior.SuspendLayout();
            this.tlpBotoes.SuspendLayout();
            this.tlpControle.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlCentro
            // 
            this.pnlCentro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pnlCentro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCentro.Controls.Add(this.lblMsg);
            this.pnlCentro.Controls.Add(this.pnlInferior);
            this.pnlCentro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCentro.Location = new System.Drawing.Point(7, 35);
            this.pnlCentro.Name = "pnlCentro";
            this.pnlCentro.Size = new System.Drawing.Size(425, 158);
            this.pnlCentro.TabIndex = 0;
            // 
            // lblMsg
            // 
            this.lblMsg.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMsg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMsg.Font = new System.Drawing.Font("Curlz MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMsg.Location = new System.Drawing.Point(0, 0);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(423, 117);
            this.lblMsg.TabIndex = 1;
            this.lblMsg.Text = "Mensagem";
            this.lblMsg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlInferior
            // 
            this.pnlInferior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pnlInferior.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlInferior.Controls.Add(this.tlpBotoes);
            this.pnlInferior.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlInferior.Location = new System.Drawing.Point(0, 117);
            this.pnlInferior.Name = "pnlInferior";
            this.pnlInferior.Size = new System.Drawing.Size(423, 39);
            this.pnlInferior.TabIndex = 0;
            // 
            // tlpBotoes
            // 
            this.tlpBotoes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.tlpBotoes.ColumnCount = 2;
            this.tlpBotoes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpBotoes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpBotoes.Controls.Add(this.btnNao, 1, 0);
            this.tlpBotoes.Controls.Add(this.btnSim, 0, 0);
            this.tlpBotoes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpBotoes.Location = new System.Drawing.Point(0, 0);
            this.tlpBotoes.Name = "tlpBotoes";
            this.tlpBotoes.RowCount = 1;
            this.tlpBotoes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpBotoes.Size = new System.Drawing.Size(419, 35);
            this.tlpBotoes.TabIndex = 0;
            // 
            // btnNao
            // 
            this.btnNao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnNao.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnNao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNao.Font = new System.Drawing.Font("Curlz MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnNao.Location = new System.Drawing.Point(212, 3);
            this.btnNao.Name = "btnNao";
            this.btnNao.Size = new System.Drawing.Size(204, 29);
            this.btnNao.TabIndex = 3;
            this.btnNao.TabStop = false;
            this.btnNao.Text = "Não";
            this.btnNao.UseVisualStyleBackColor = false;
            this.btnNao.Click += new System.EventHandler(this.btnNao_Click);
            // 
            // btnSim
            // 
            this.btnSim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnSim.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSim.Font = new System.Drawing.Font("Curlz MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSim.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSim.Location = new System.Drawing.Point(3, 3);
            this.btnSim.Name = "btnSim";
            this.btnSim.Size = new System.Drawing.Size(203, 29);
            this.btnSim.TabIndex = 2;
            this.btnSim.TabStop = false;
            this.btnSim.Text = "Sim";
            this.btnSim.UseVisualStyleBackColor = false;
            this.btnSim.Click += new System.EventHandler(this.btnSim_Click);
            // 
            // tlpControle
            // 
            this.tlpControle.ColumnCount = 3;
            this.tlpControle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.117647F));
            this.tlpControle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 97.88235F));
            this.tlpControle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tlpControle.Controls.Add(this.label7, 1, 0);
            this.tlpControle.Location = new System.Drawing.Point(7, 1);
            this.tlpControle.Name = "tlpControle";
            this.tlpControle.RowCount = 1;
            this.tlpControle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpControle.Size = new System.Drawing.Size(425, 34);
            this.tlpControle.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Font = new System.Drawing.Font("Curlz MT", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(11, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(402, 34);
            this.label7.TabIndex = 3;
            this.label7.Text = "! Atenção !";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label7.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Tela_MouseDown);
            this.label7.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Tela_MouseMove);
            this.label7.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Tela_MouseUp);
            // 
            // DialogoEscolha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(439, 200);
            this.Controls.Add(this.tlpControle);
            this.Controls.Add(this.pnlCentro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DialogoEscolha";
            this.Padding = new System.Windows.Forms.Padding(7, 35, 7, 7);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DialogoEscolha";
            this.Load += new System.EventHandler(this.Dialogos_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Tela_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Tela_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Tela_MouseUp);
            this.pnlCentro.ResumeLayout(false);
            this.pnlInferior.ResumeLayout(false);
            this.tlpBotoes.ResumeLayout(false);
            this.tlpControle.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlCentro;
        private System.Windows.Forms.Panel pnlInferior;
        private System.Windows.Forms.Button btnSim;
        private System.Windows.Forms.TableLayoutPanel tlpControle;
        private System.Windows.Forms.Label lblMsg;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnNao;
        private System.Windows.Forms.TableLayoutPanel tlpBotoes;
    }
}