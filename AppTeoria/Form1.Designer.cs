namespace AppTeoria
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
            this.cbbOpcoes = new System.Windows.Forms.ComboBox();
            this.btnIF = new System.Windows.Forms.Button();
            this.btnSwitch = new System.Windows.Forms.Button();
            this.btnExemplo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbbOpcoes
            // 
            this.cbbOpcoes.FormattingEnabled = true;
            this.cbbOpcoes.Items.AddRange(new object[] {
            "APARTAMENTO",
            "SUITE",
            "MASTER",
            "DIAMANTE",
            "EXECUTIVA"});
            this.cbbOpcoes.Location = new System.Drawing.Point(12, 12);
            this.cbbOpcoes.Name = "cbbOpcoes";
            this.cbbOpcoes.Size = new System.Drawing.Size(231, 21);
            this.cbbOpcoes.TabIndex = 0;
            // 
            // btnIF
            // 
            this.btnIF.Location = new System.Drawing.Point(12, 39);
            this.btnIF.Name = "btnIF";
            this.btnIF.Size = new System.Drawing.Size(75, 23);
            this.btnIF.TabIndex = 1;
            this.btnIF.Text = "IF";
            this.btnIF.UseVisualStyleBackColor = true;
            this.btnIF.Click += new System.EventHandler(this.btnIF_Click);
            // 
            // btnSwitch
            // 
            this.btnSwitch.Location = new System.Drawing.Point(12, 68);
            this.btnSwitch.Name = "btnSwitch";
            this.btnSwitch.Size = new System.Drawing.Size(75, 23);
            this.btnSwitch.TabIndex = 2;
            this.btnSwitch.Text = "SWITCH";
            this.btnSwitch.UseVisualStyleBackColor = true;
            this.btnSwitch.Click += new System.EventHandler(this.btnSwitch_Click);
            // 
            // btnExemplo
            // 
            this.btnExemplo.Location = new System.Drawing.Point(93, 68);
            this.btnExemplo.Name = "btnExemplo";
            this.btnExemplo.Size = new System.Drawing.Size(75, 23);
            this.btnExemplo.TabIndex = 3;
            this.btnExemplo.Text = "Exemplo";
            this.btnExemplo.UseVisualStyleBackColor = true;
            this.btnExemplo.Click += new System.EventHandler(this.btnExemplo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(255, 110);
            this.Controls.Add(this.btnExemplo);
            this.Controls.Add(this.btnSwitch);
            this.Controls.Add(this.btnIF);
            this.Controls.Add(this.cbbOpcoes);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbbOpcoes;
        private System.Windows.Forms.Button btnIF;
        private System.Windows.Forms.Button btnSwitch;
        private System.Windows.Forms.Button btnExemplo;
    }
}

