namespace Swicth_Case
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.cboDiaDaSemana = new System.Windows.Forms.ComboBox();
            this.lblDiaDaSemana = new System.Windows.Forms.Label();
            this.btnNome = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cboDiaDaSemana
            // 
            this.cboDiaDaSemana.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDiaDaSemana.FormattingEnabled = true;
            this.cboDiaDaSemana.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7"});
            this.cboDiaDaSemana.Location = new System.Drawing.Point(159, 102);
            this.cboDiaDaSemana.Name = "cboDiaDaSemana";
            this.cboDiaDaSemana.Size = new System.Drawing.Size(121, 32);
            this.cboDiaDaSemana.TabIndex = 0;
            // 
            // lblDiaDaSemana
            // 
            this.lblDiaDaSemana.AutoSize = true;
            this.lblDiaDaSemana.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiaDaSemana.Location = new System.Drawing.Point(296, 178);
            this.lblDiaDaSemana.Name = "lblDiaDaSemana";
            this.lblDiaDaSemana.Size = new System.Drawing.Size(0, 24);
            this.lblDiaDaSemana.TabIndex = 1;
            // 
            // btnNome
            // 
            this.btnNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNome.Location = new System.Drawing.Point(159, 247);
            this.btnNome.Name = "btnNome";
            this.btnNome.Size = new System.Drawing.Size(136, 41);
            this.btnNome.TabIndex = 2;
            this.btnNome.Text = "Nome >>";
            this.btnNome.UseVisualStyleBackColor = true;
            this.btnNome.Click += new System.EventHandler(this.BtnNome_Click_1);
            // 
            // btnFechar
            // 
            this.btnFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.Location = new System.Drawing.Point(159, 310);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(136, 41);
            this.btnFechar.TabIndex = 3;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.BtnFechar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(156, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(386, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Selecione o Número do Dia da Semana:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnNome);
            this.Controls.Add(this.lblDiaDaSemana);
            this.Controls.Add(this.cboDiaDaSemana);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboDiaDaSemana;
        private System.Windows.Forms.Label lblDiaDaSemana;
        private System.Windows.Forms.Button btnNome;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Label label2;
    }
}

