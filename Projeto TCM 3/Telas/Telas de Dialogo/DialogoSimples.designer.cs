namespace Projeto_TCM_3
{
    partial class DialogoSimples
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DialogoSimples));
            this.pnlCentro = new System.Windows.Forms.Panel();
            this.lblMsg = new System.Windows.Forms.Label();
            this.pnlInferior = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tlpInferior = new System.Windows.Forms.TableLayoutPanel();
            this.btnFinalizarCadastro = new System.Windows.Forms.Button();
            this.tlpControle = new System.Windows.Forms.TableLayoutPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.pnlCentro.SuspendLayout();
            this.pnlInferior.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tlpInferior.SuspendLayout();
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
            this.pnlCentro.Size = new System.Drawing.Size(425, 157);
            this.pnlCentro.TabIndex = 0;
            // 
            // lblMsg
            // 
            this.lblMsg.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMsg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMsg.Font = new System.Drawing.Font("Curlz MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMsg.Location = new System.Drawing.Point(0, 0);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(423, 111);
            this.lblMsg.TabIndex = 1;
            this.lblMsg.Text = "Mensagem";
            this.lblMsg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlInferior
            // 
            this.pnlInferior.Controls.Add(this.panel1);
            this.pnlInferior.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlInferior.Location = new System.Drawing.Point(0, 111);
            this.pnlInferior.Name = "pnlInferior";
            this.pnlInferior.Size = new System.Drawing.Size(423, 44);
            this.pnlInferior.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.tlpInferior);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(423, 45);
            this.panel1.TabIndex = 6;
            // 
            // tlpInferior
            // 
            this.tlpInferior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.tlpInferior.ColumnCount = 1;
            this.tlpInferior.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpInferior.Controls.Add(this.btnFinalizarCadastro, 0, 0);
            this.tlpInferior.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpInferior.Location = new System.Drawing.Point(0, 0);
            this.tlpInferior.Name = "tlpInferior";
            this.tlpInferior.Padding = new System.Windows.Forms.Padding(2);
            this.tlpInferior.RowCount = 1;
            this.tlpInferior.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpInferior.Size = new System.Drawing.Size(419, 41);
            this.tlpInferior.TabIndex = 2;
            // 
            // btnFinalizarCadastro
            // 
            this.btnFinalizarCadastro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnFinalizarCadastro.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnFinalizarCadastro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnFinalizarCadastro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinalizarCadastro.Font = new System.Drawing.Font("Curlz MT", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalizarCadastro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnFinalizarCadastro.Location = new System.Drawing.Point(5, 5);
            this.btnFinalizarCadastro.Name = "btnFinalizarCadastro";
            this.btnFinalizarCadastro.Size = new System.Drawing.Size(409, 31);
            this.btnFinalizarCadastro.TabIndex = 1;
            this.btnFinalizarCadastro.Text = "Ok";
            this.btnFinalizarCadastro.UseVisualStyleBackColor = false;
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
            // DialogoSimples
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(439, 199);
            this.Controls.Add(this.tlpControle);
            this.Controls.Add(this.pnlCentro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DialogoSimples";
            this.Padding = new System.Windows.Forms.Padding(7, 35, 7, 7);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dialogos";
            this.Load += new System.EventHandler(this.Dialogos_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Tela_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Tela_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Tela_MouseUp);
            this.pnlCentro.ResumeLayout(false);
            this.pnlInferior.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tlpInferior.ResumeLayout(false);
            this.tlpControle.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlCentro;
        private System.Windows.Forms.Panel pnlInferior;
        private System.Windows.Forms.TableLayoutPanel tlpControle;
        private System.Windows.Forms.Label lblMsg;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tlpInferior;
        private System.Windows.Forms.Button btnFinalizarCadastro;
    }
}