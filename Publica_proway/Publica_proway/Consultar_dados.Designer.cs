namespace Publica_proway
{
    partial class Consultar_dados
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
            this.btncancela = new System.Windows.Forms.Button();
            this.btntotal = new System.Windows.Forms.Button();
            this.txtconsulta = new System.Windows.Forms.TextBox();
            this.btnmenor = new System.Windows.Forms.Button();
            this.btnmaior = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // btncancela
            // 
            this.btncancela.Location = new System.Drawing.Point(453, 127);
            this.btncancela.Name = "btncancela";
            this.btncancela.Size = new System.Drawing.Size(95, 35);
            this.btncancela.TabIndex = 13;
            this.btncancela.Text = "Cancelar";
            this.btncancela.UseVisualStyleBackColor = true;
            this.btncancela.Click += new System.EventHandler(this.btncancela_Click);
            // 
            // btntotal
            // 
            this.btntotal.Location = new System.Drawing.Point(215, 127);
            this.btntotal.Name = "btntotal";
            this.btntotal.Size = new System.Drawing.Size(95, 35);
            this.btntotal.TabIndex = 12;
            this.btntotal.Text = "Total de jogos";
            this.btntotal.UseVisualStyleBackColor = true;
            this.btntotal.Click += new System.EventHandler(this.btntotal_Click);
            // 
            // txtconsulta
            // 
            this.txtconsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtconsulta.Location = new System.Drawing.Point(316, 127);
            this.txtconsulta.Multiline = true;
            this.txtconsulta.Name = "txtconsulta";
            this.txtconsulta.Size = new System.Drawing.Size(131, 35);
            this.txtconsulta.TabIndex = 11;
            // 
            // btnmenor
            // 
            this.btnmenor.Location = new System.Drawing.Point(114, 127);
            this.btnmenor.Name = "btnmenor";
            this.btnmenor.Size = new System.Drawing.Size(95, 35);
            this.btnmenor.TabIndex = 10;
            this.btnmenor.Text = "Placar minimo";
            this.btnmenor.UseVisualStyleBackColor = true;
            this.btnmenor.Click += new System.EventHandler(this.btnmenor_Click);
            // 
            // btnmaior
            // 
            this.btnmaior.Location = new System.Drawing.Point(13, 127);
            this.btnmaior.Name = "btnmaior";
            this.btnmaior.Size = new System.Drawing.Size(95, 35);
            this.btnmaior.TabIndex = 9;
            this.btnmaior.Text = "Placar maximo";
            this.btnmaior.UseVisualStyleBackColor = true;
            this.btnmaior.Click += new System.EventHandler(this.btnmaior_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(12, 168);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(750, 270);
            this.dataGridView2.TabIndex = 8;
            // 
            // Consultar_dados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(774, 450);
            this.Controls.Add(this.btncancela);
            this.Controls.Add(this.btntotal);
            this.Controls.Add(this.txtconsulta);
            this.Controls.Add(this.btnmenor);
            this.Controls.Add(this.btnmaior);
            this.Controls.Add(this.dataGridView2);
            this.Name = "Consultar_dados";
            this.Text = "Consultar_dados";
            this.Load += new System.EventHandler(this.Consultar_dados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btncancela;
        private System.Windows.Forms.Button btntotal;
        private System.Windows.Forms.TextBox txtconsulta;
        private System.Windows.Forms.Button btnmenor;
        private System.Windows.Forms.Button btnmaior;
        private System.Windows.Forms.DataGridView dataGridView2;
    }
}