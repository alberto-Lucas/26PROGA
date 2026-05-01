namespace AppCadastro
{
    partial class frmMovimentacao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMovimentacao));
            this.pnlModoTela = new System.Windows.Forms.Panel();
            this.lblModoTela = new System.Windows.Forms.Label();
            this.pnlModoTela.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlModoTela
            // 
            this.pnlModoTela.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.pnlModoTela.Controls.Add(this.lblModoTela);
            this.pnlModoTela.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlModoTela.Location = new System.Drawing.Point(0, 0);
            this.pnlModoTela.Name = "pnlModoTela";
            this.pnlModoTela.Size = new System.Drawing.Size(575, 42);
            this.pnlModoTela.TabIndex = 0;
            // 
            // lblModoTela
            // 
            this.lblModoTela.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblModoTela.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModoTela.ForeColor = System.Drawing.Color.White;
            this.lblModoTela.Location = new System.Drawing.Point(12, 9);
            this.lblModoTela.Name = "lblModoTela";
            this.lblModoTela.Size = new System.Drawing.Size(551, 23);
            this.lblModoTela.TabIndex = 0;
            this.lblModoTela.Text = "MODO";
            this.lblModoTela.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmMovimentacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 283);
            this.Controls.Add(this.pnlModoTela);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMovimentacao";
            this.Text = "frmMovimentacao";
            this.pnlModoTela.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlModoTela;
        private System.Windows.Forms.Label lblModoTela;
    }
}