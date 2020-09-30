namespace desafio_publica
{
    partial class inserirdados
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
            this.btninserir = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.txtplacar = new System.Windows.Forms.TextBox();
            this.txtmintemp = new System.Windows.Forms.TextBox();
            this.txtmaxtemp = new System.Windows.Forms.TextBox();
            this.txtrecmin = new System.Windows.Forms.TextBox();
            this.txtrecmax = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btninserir
            // 
            this.btninserir.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btninserir.Location = new System.Drawing.Point(418, 43);
            this.btninserir.Name = "btninserir";
            this.btninserir.Size = new System.Drawing.Size(93, 33);
            this.btninserir.TabIndex = 1;
            this.btninserir.Text = "Inserir";
            this.btninserir.UseVisualStyleBackColor = false;
            this.btninserir.Click += new System.EventHandler(this.btninserir_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btncancelar.Location = new System.Drawing.Point(416, 102);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(95, 35);
            this.btncancelar.TabIndex = 2;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseVisualStyleBackColor = false;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // txtplacar
            // 
            this.txtplacar.Location = new System.Drawing.Point(289, 24);
            this.txtplacar.Name = "txtplacar";
            this.txtplacar.Size = new System.Drawing.Size(100, 20);
            this.txtplacar.TabIndex = 4;
            // 
            // txtmintemp
            // 
            this.txtmintemp.Location = new System.Drawing.Point(289, 50);
            this.txtmintemp.Name = "txtmintemp";
            this.txtmintemp.Size = new System.Drawing.Size(100, 20);
            this.txtmintemp.TabIndex = 5;
            // 
            // txtmaxtemp
            // 
            this.txtmaxtemp.Location = new System.Drawing.Point(289, 76);
            this.txtmaxtemp.Name = "txtmaxtemp";
            this.txtmaxtemp.Size = new System.Drawing.Size(100, 20);
            this.txtmaxtemp.TabIndex = 6;
            // 
            // txtrecmin
            // 
            this.txtrecmin.Location = new System.Drawing.Point(289, 102);
            this.txtrecmin.Name = "txtrecmin";
            this.txtrecmin.Size = new System.Drawing.Size(100, 20);
            this.txtrecmin.TabIndex = 7;
            // 
            // txtrecmax
            // 
            this.txtrecmax.Location = new System.Drawing.Point(289, 128);
            this.txtrecmax.Name = "txtrecmax";
            this.txtrecmax.Size = new System.Drawing.Size(100, 20);
            this.txtrecmax.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(246, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Placar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(190, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Minimo temporada";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(187, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Maximo temporada";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(154, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "quebra de recorde minimo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(164, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Quebra recorde maximo";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 177);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(750, 270);
            this.dataGridView1.TabIndex = 15;
            // 
            // inserirdados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(774, 459);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtrecmax);
            this.Controls.Add(this.txtrecmin);
            this.Controls.Add(this.txtmaxtemp);
            this.Controls.Add(this.txtmintemp);
            this.Controls.Add(this.txtplacar);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btninserir);
            this.Name = "inserirdados";
            this.Text = "Inserir Dados";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btninserir;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.TextBox txtplacar;
        private System.Windows.Forms.TextBox txtmintemp;
        private System.Windows.Forms.TextBox txtmaxtemp;
        private System.Windows.Forms.TextBox txtrecmin;
        private System.Windows.Forms.TextBox txtrecmax;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

