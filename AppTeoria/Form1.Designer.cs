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
            this.btnForIncremento = new System.Windows.Forms.Button();
            this.btnForDecremento = new System.Windows.Forms.Button();
            this.btnWhile = new System.Windows.Forms.Button();
            this.btnDoWhile = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.lstLoop = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSoNumero = new System.Windows.Forms.Button();
            this.txtValor1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtValor2 = new System.Windows.Forms.TextBox();
            this.label78 = new System.Windows.Forms.Label();
            this.txtResultadoMF = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnMetodo = new System.Windows.Forms.Button();
            this.btnFuncao = new System.Windows.Forms.Button();
            this.btnFuncaoAlt = new System.Windows.Forms.Button();
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
            // btnForIncremento
            // 
            this.btnForIncremento.Location = new System.Drawing.Point(12, 140);
            this.btnForIncremento.Name = "btnForIncremento";
            this.btnForIncremento.Size = new System.Drawing.Size(109, 23);
            this.btnForIncremento.TabIndex = 4;
            this.btnForIncremento.Text = "FOR 0 TO 10";
            this.btnForIncremento.UseVisualStyleBackColor = true;
            this.btnForIncremento.Click += new System.EventHandler(this.btnForIncremento_Click);
            // 
            // btnForDecremento
            // 
            this.btnForDecremento.Location = new System.Drawing.Point(12, 169);
            this.btnForDecremento.Name = "btnForDecremento";
            this.btnForDecremento.Size = new System.Drawing.Size(109, 23);
            this.btnForDecremento.TabIndex = 5;
            this.btnForDecremento.Text = "FOR 10 TO 0";
            this.btnForDecremento.UseVisualStyleBackColor = true;
            this.btnForDecremento.Click += new System.EventHandler(this.btnForDecremento_Click);
            // 
            // btnWhile
            // 
            this.btnWhile.Location = new System.Drawing.Point(12, 198);
            this.btnWhile.Name = "btnWhile";
            this.btnWhile.Size = new System.Drawing.Size(109, 23);
            this.btnWhile.TabIndex = 6;
            this.btnWhile.Text = "WHILE";
            this.btnWhile.UseVisualStyleBackColor = true;
            this.btnWhile.Click += new System.EventHandler(this.btnWhile_Click);
            // 
            // btnDoWhile
            // 
            this.btnDoWhile.Location = new System.Drawing.Point(12, 227);
            this.btnDoWhile.Name = "btnDoWhile";
            this.btnDoWhile.Size = new System.Drawing.Size(109, 23);
            this.btnDoWhile.TabIndex = 7;
            this.btnDoWhile.Text = "DO WHILE";
            this.btnDoWhile.UseVisualStyleBackColor = true;
            this.btnDoWhile.Click += new System.EventHandler(this.btnDoWhile_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(12, 256);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(109, 23);
            this.btnLimpar.TabIndex = 8;
            this.btnLimpar.Text = "LIMPAR";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // lstLoop
            // 
            this.lstLoop.FormattingEnabled = true;
            this.lstLoop.Location = new System.Drawing.Point(127, 140);
            this.lstLoop.Name = "lstLoop";
            this.lstLoop.Size = new System.Drawing.Size(120, 147);
            this.lstLoop.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(289, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Valor:";
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(292, 29);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(100, 20);
            this.txtValor.TabIndex = 11;
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(292, 122);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(100, 20);
            this.txtResultado.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(289, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Resultado";
            // 
            // btnSoNumero
            // 
            this.btnSoNumero.Location = new System.Drawing.Point(292, 68);
            this.btnSoNumero.Name = "btnSoNumero";
            this.btnSoNumero.Size = new System.Drawing.Size(100, 23);
            this.btnSoNumero.TabIndex = 14;
            this.btnSoNumero.Text = "SÓ NÚMERO";
            this.btnSoNumero.UseVisualStyleBackColor = true;
            this.btnSoNumero.Click += new System.EventHandler(this.btnSoNumero_Click);
            // 
            // txtValor1
            // 
            this.txtValor1.Location = new System.Drawing.Point(292, 181);
            this.txtValor1.Name = "txtValor1";
            this.txtValor1.Size = new System.Drawing.Size(100, 20);
            this.txtValor1.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(289, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Valor 1:";
            // 
            // txtValor2
            // 
            this.txtValor2.Location = new System.Drawing.Point(292, 222);
            this.txtValor2.Name = "txtValor2";
            this.txtValor2.Size = new System.Drawing.Size(100, 20);
            this.txtValor2.TabIndex = 18;
            // 
            // label78
            // 
            this.label78.AutoSize = true;
            this.label78.Location = new System.Drawing.Point(289, 206);
            this.label78.Name = "label78";
            this.label78.Size = new System.Drawing.Size(43, 13);
            this.label78.TabIndex = 17;
            this.label78.Text = "Valor 2:";
            // 
            // txtResultadoMF
            // 
            this.txtResultadoMF.Location = new System.Drawing.Point(292, 263);
            this.txtResultadoMF.Name = "txtResultadoMF";
            this.txtResultadoMF.Size = new System.Drawing.Size(100, 20);
            this.txtResultadoMF.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(289, 247);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Resultado:";
            // 
            // btnMetodo
            // 
            this.btnMetodo.Location = new System.Drawing.Point(398, 179);
            this.btnMetodo.Name = "btnMetodo";
            this.btnMetodo.Size = new System.Drawing.Size(100, 23);
            this.btnMetodo.TabIndex = 21;
            this.btnMetodo.Text = "MÉTODO";
            this.btnMetodo.UseVisualStyleBackColor = true;
            this.btnMetodo.Click += new System.EventHandler(this.btnMetodo_Click);
            // 
            // btnFuncao
            // 
            this.btnFuncao.Location = new System.Drawing.Point(398, 219);
            this.btnFuncao.Name = "btnFuncao";
            this.btnFuncao.Size = new System.Drawing.Size(100, 23);
            this.btnFuncao.TabIndex = 22;
            this.btnFuncao.Text = "FUNÇÃO";
            this.btnFuncao.UseVisualStyleBackColor = true;
            this.btnFuncao.Click += new System.EventHandler(this.btnFuncao_Click);
            // 
            // btnFuncaoAlt
            // 
            this.btnFuncaoAlt.Location = new System.Drawing.Point(398, 261);
            this.btnFuncaoAlt.Name = "btnFuncaoAlt";
            this.btnFuncaoAlt.Size = new System.Drawing.Size(100, 23);
            this.btnFuncaoAlt.TabIndex = 23;
            this.btnFuncaoAlt.Text = "FUNÇÃO ALT";
            this.btnFuncaoAlt.UseVisualStyleBackColor = true;
            this.btnFuncaoAlt.Click += new System.EventHandler(this.btnFuncaoAlt_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 305);
            this.Controls.Add(this.btnFuncaoAlt);
            this.Controls.Add(this.btnFuncao);
            this.Controls.Add(this.btnMetodo);
            this.Controls.Add(this.txtResultadoMF);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtValor2);
            this.Controls.Add(this.label78);
            this.Controls.Add(this.txtValor1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSoNumero);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstLoop);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnDoWhile);
            this.Controls.Add(this.btnWhile);
            this.Controls.Add(this.btnForDecremento);
            this.Controls.Add(this.btnForIncremento);
            this.Controls.Add(this.btnExemplo);
            this.Controls.Add(this.btnSwitch);
            this.Controls.Add(this.btnIF);
            this.Controls.Add(this.cbbOpcoes);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbbOpcoes;
        private System.Windows.Forms.Button btnIF;
        private System.Windows.Forms.Button btnSwitch;
        private System.Windows.Forms.Button btnExemplo;
        private System.Windows.Forms.Button btnForIncremento;
        private System.Windows.Forms.Button btnForDecremento;
        private System.Windows.Forms.Button btnWhile;
        private System.Windows.Forms.Button btnDoWhile;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.ListBox lstLoop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSoNumero;
        private System.Windows.Forms.TextBox txtValor1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtValor2;
        private System.Windows.Forms.Label label78;
        private System.Windows.Forms.TextBox txtResultadoMF;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnMetodo;
        private System.Windows.Forms.Button btnFuncao;
        private System.Windows.Forms.Button btnFuncaoAlt;
    }
}

