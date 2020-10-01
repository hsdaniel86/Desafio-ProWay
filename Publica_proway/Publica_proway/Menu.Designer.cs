namespace Publica_proway
{
    partial class Menu
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
            this.btnfechar = new System.Windows.Forms.Button();
            this.btnconsultar = new System.Windows.Forms.Button();
            this.btncalculardados = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btninserirdados
            // 
            this.btninserirdados.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btninserirdados.Location = new System.Drawing.Point(12, 12);
            this.btninserirdados.Name = "btninserirdados";
            this.btninserirdados.Size = new System.Drawing.Size(146, 44);
            this.btninserirdados.TabIndex = 11;
            this.btninserirdados.Text = "Inserir dados";
            this.btninserirdados.UseVisualStyleBackColor = false;
            this.btninserirdados.Click += new System.EventHandler(this.btninserirdados_Click_1);
            // 
            // btnfechar
            // 
            this.btnfechar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnfechar.Location = new System.Drawing.Point(12, 223);
            this.btnfechar.Name = "btnfechar";
            this.btnfechar.Size = new System.Drawing.Size(146, 44);
            this.btnfechar.TabIndex = 7;
            this.btnfechar.Text = "Fechar";
            this.btnfechar.UseVisualStyleBackColor = false;
            this.btnfechar.Click += new System.EventHandler(this.btnfechar_Click);
            // 
            // btnconsultar
            // 
            this.btnconsultar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnconsultar.Location = new System.Drawing.Point(12, 154);
            this.btnconsultar.Name = "btnconsultar";
            this.btnconsultar.Size = new System.Drawing.Size(146, 44);
            this.btnconsultar.TabIndex = 9;
            this.btnconsultar.Text = "Consultar";
            this.btnconsultar.UseVisualStyleBackColor = false;
            this.btnconsultar.Click += new System.EventHandler(this.btnconsultar_Click);
            // 
            // btncalculardados
            // 
            this.btncalculardados.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btncalculardados.Location = new System.Drawing.Point(12, 83);
            this.btncalculardados.Name = "btncalculardados";
            this.btncalculardados.Size = new System.Drawing.Size(146, 44);
            this.btncalculardados.TabIndex = 10;
            this.btncalculardados.Text = "Calcular";
            this.btncalculardados.UseVisualStyleBackColor = false;
            this.btncalculardados.Click += new System.EventHandler(this.btncalculardados_Click_1);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(169, 276);
            this.Controls.Add(this.btninserirdados);
            this.Controls.Add(this.btncalculardados);
            this.Controls.Add(this.btnconsultar);
            this.Controls.Add(this.btnfechar);
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btninserirdados;
        private System.Windows.Forms.Button btnfechar;
        private System.Windows.Forms.Button btnconsultar;
        private System.Windows.Forms.Button btncalculardados;
    }
}