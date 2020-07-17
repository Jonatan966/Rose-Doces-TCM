namespace Projeto_TCM_3
{
    partial class Splash
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Splash));
            this.tlpCentro = new System.Windows.Forms.TableLayoutPanel();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.lbBoasVindas = new System.Windows.Forms.Label();
            this.pbProgresso = new System.Windows.Forms.ProgressBar();
            this.tlpDireita = new System.Windows.Forms.TableLayoutPanel();
            this.tlpCentro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.tlpDireita.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpCentro
            // 
            this.tlpCentro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tlpCentro.ColumnCount = 2;
            this.tlpCentro.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpCentro.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpCentro.Controls.Add(this.pbLogo, 0, 0);
            this.tlpCentro.Controls.Add(this.tlpDireita, 1, 0);
            this.tlpCentro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpCentro.Location = new System.Drawing.Point(7, 7);
            this.tlpCentro.Name = "tlpCentro";
            this.tlpCentro.RowCount = 1;
            this.tlpCentro.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpCentro.Size = new System.Drawing.Size(535, 278);
            this.tlpCentro.TabIndex = 0;
            // 
            // pbLogo
            // 
            this.pbLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pbLogo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbLogo.Image = global::Projeto_TCM_3.Properties.Resources.logoPrincipal;
            this.pbLogo.Location = new System.Drawing.Point(3, 3);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(261, 272);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogo.TabIndex = 0;
            this.pbLogo.TabStop = false;
            // 
            // lbBoasVindas
            // 
            this.lbBoasVindas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lbBoasVindas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbBoasVindas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbBoasVindas.Font = new System.Drawing.Font("Curlz MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBoasVindas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lbBoasVindas.Location = new System.Drawing.Point(4, 1);
            this.lbBoasVindas.Name = "lbBoasVindas";
            this.lbBoasVindas.Size = new System.Drawing.Size(254, 229);
            this.lbBoasVindas.TabIndex = 1;
            this.lbBoasVindas.Text = "Aguarde. . .\r\nCarregando Componentes\r\n\r\n\r\n";
            this.lbBoasVindas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbProgresso
            // 
            this.pbProgresso.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbProgresso.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pbProgresso.Location = new System.Drawing.Point(4, 234);
            this.pbProgresso.MarqueeAnimationSpeed = 50;
            this.pbProgresso.Name = "pbProgresso";
            this.pbProgresso.Size = new System.Drawing.Size(254, 34);
            this.pbProgresso.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.pbProgresso.TabIndex = 0;
            // 
            // tlpDireita
            // 
            this.tlpDireita.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tlpDireita.ColumnCount = 1;
            this.tlpDireita.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpDireita.Controls.Add(this.pbProgresso, 0, 1);
            this.tlpDireita.Controls.Add(this.lbBoasVindas, 0, 0);
            this.tlpDireita.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tlpDireita.Location = new System.Drawing.Point(270, 3);
            this.tlpDireita.Name = "tlpDireita";
            this.tlpDireita.RowCount = 2;
            this.tlpDireita.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 229F));
            this.tlpDireita.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tlpDireita.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpDireita.Size = new System.Drawing.Size(262, 272);
            this.tlpDireita.TabIndex = 1;
            // 
            // Splash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(549, 292);
            this.Controls.Add(this.tlpCentro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Splash";
            this.Padding = new System.Windows.Forms.Padding(7);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Splash";
            this.tlpCentro.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.tlpDireita.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpCentro;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.TableLayoutPanel tlpDireita;
        private System.Windows.Forms.ProgressBar pbProgresso;
        private System.Windows.Forms.Label lbBoasVindas;
    }
}