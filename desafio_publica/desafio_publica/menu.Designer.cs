namespace desafio_publica
{
    partial class menu
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
            this.btninserirdados = new System.Windows.Forms.Button();
            this.btncalculardados = new System.Windows.Forms.Button();
            this.btntabela = new System.Windows.Forms.Button();
            this.btnfechar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btninserirdados
            // 
            this.btninserirdados.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btninserirdados.Location = new System.Drawing.Point(12, 12);
            this.btninserirdados.Name = "btninserirdados";
            this.btninserirdados.Size = new System.Drawing.Size(146, 44);
            this.btninserirdados.TabIndex = 0;
            this.btninserirdados.Text = "inserir dados";
            this.btninserirdados.UseVisualStyleBackColor = false;
            this.btninserirdados.Click += new System.EventHandler(this.btninserirdados_Click);
            // 
            // btncalculardados
            // 
            this.btncalculardados.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btncalculardados.Location = new System.Drawing.Point(12, 77);
            this.btncalculardados.Name = "btncalculardados";
            this.btncalculardados.Size = new System.Drawing.Size(146, 44);
            this.btncalculardados.TabIndex = 1;
            this.btncalculardados.Text = "calcular";
            this.btncalculardados.UseVisualStyleBackColor = false;
            this.btncalculardados.Click += new System.EventHandler(this.btncalculardados_Click);
            // 
            // btntabela
            // 
            this.btntabela.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btntabela.Location = new System.Drawing.Point(12, 148);
            this.btntabela.Name = "btntabela";
            this.btntabela.Size = new System.Drawing.Size(146, 44);
            this.btntabela.TabIndex = 2;
            this.btntabela.Text = "tabela";
            this.btntabela.UseVisualStyleBackColor = false;
            this.btntabela.Click += new System.EventHandler(this.btntabela_Click);
            // 
            // btnfechar
            // 
            this.btnfechar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnfechar.Location = new System.Drawing.Point(12, 220);
            this.btnfechar.Name = "btnfechar";
            this.btnfechar.Size = new System.Drawing.Size(146, 44);
            this.btnfechar.TabIndex = 3;
            this.btnfechar.Text = "Fechar";
            this.btnfechar.UseVisualStyleBackColor = false;
            this.btnfechar.Click += new System.EventHandler(this.btnfechar_Click);
            // 
            // menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(168, 276);
            this.Controls.Add(this.btnfechar);
            this.Controls.Add(this.btntabela);
            this.Controls.Add(this.btncalculardados);
            this.Controls.Add(this.btninserirdados);
            this.Name = "menu";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btninserirdados;
        private System.Windows.Forms.Button btncalculardados;
        private System.Windows.Forms.Button btntabela;
        private System.Windows.Forms.Button btnfechar;
    }
}