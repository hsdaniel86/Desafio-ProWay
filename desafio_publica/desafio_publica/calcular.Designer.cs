﻿namespace desafio_publica
{
    partial class calcular
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
            this.btncalcplacar = new System.Windows.Forms.Button();
            this.btncalcmin = new System.Windows.Forms.Button();
            this.btncalcmax = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txttotal = new System.Windows.Forms.TextBox();
            this.btnrecmax = new System.Windows.Forms.Button();
            this.btnrecmin = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btncalcplacar
            // 
            this.btncalcplacar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btncalcplacar.Location = new System.Drawing.Point(12, 12);
            this.btncalcplacar.Name = "btncalcplacar";
            this.btncalcplacar.Size = new System.Drawing.Size(146, 44);
            this.btncalcplacar.TabIndex = 0;
            this.btncalcplacar.Text = "Calculo Placar";
            this.btncalcplacar.UseVisualStyleBackColor = false;
            this.btncalcplacar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btncalcmin
            // 
            this.btncalcmin.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btncalcmin.Location = new System.Drawing.Point(12, 62);
            this.btncalcmin.Name = "btncalcmin";
            this.btncalcmin.Size = new System.Drawing.Size(146, 44);
            this.btncalcmin.TabIndex = 1;
            this.btncalcmin.Text = "Calacular Minimo";
            this.btncalcmin.UseVisualStyleBackColor = false;
            this.btncalcmin.Click += new System.EventHandler(this.btncalcmin_Click);
            // 
            // btncalcmax
            // 
            this.btncalcmax.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btncalcmax.Location = new System.Drawing.Point(12, 112);
            this.btncalcmax.Name = "btncalcmax";
            this.btncalcmax.Size = new System.Drawing.Size(146, 44);
            this.btncalcmax.TabIndex = 2;
            this.btncalcmax.Text = "Calcular Maximo";
            this.btncalcmax.UseVisualStyleBackColor = false;
            this.btncalcmax.Click += new System.EventHandler(this.btncalcmax_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 265);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Total";
            // 
            // txttotal
            // 
            this.txttotal.Location = new System.Drawing.Point(51, 262);
            this.txttotal.Name = "txttotal";
            this.txttotal.Size = new System.Drawing.Size(107, 20);
            this.txttotal.TabIndex = 5;
            // 
            // btnrecmax
            // 
            this.btnrecmax.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnrecmax.Location = new System.Drawing.Point(12, 212);
            this.btnrecmax.Name = "btnrecmax";
            this.btnrecmax.Size = new System.Drawing.Size(146, 44);
            this.btnrecmax.TabIndex = 6;
            this.btnrecmax.Text = "Recorde Maximo";
            this.btnrecmax.UseVisualStyleBackColor = false;
            this.btnrecmax.Click += new System.EventHandler(this.btnrecmax_Click);
            // 
            // btnrecmin
            // 
            this.btnrecmin.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnrecmin.Location = new System.Drawing.Point(12, 162);
            this.btnrecmin.Name = "btnrecmin";
            this.btnrecmin.Size = new System.Drawing.Size(146, 44);
            this.btnrecmin.TabIndex = 7;
            this.btnrecmin.Text = "Recorde Minimo";
            this.btnrecmin.UseVisualStyleBackColor = false;
            this.btnrecmin.Click += new System.EventHandler(this.btnrecmin_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btncancelar.Location = new System.Drawing.Point(10, 288);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(146, 44);
            this.btncancelar.TabIndex = 8;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseVisualStyleBackColor = false;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // calcular
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(168, 341);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnrecmin);
            this.Controls.Add(this.btnrecmax);
            this.Controls.Add(this.txttotal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btncalcmax);
            this.Controls.Add(this.btncalcmin);
            this.Controls.Add(this.btncalcplacar);
            this.Name = "calcular";
            this.Text = "calcular";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btncalcplacar;
        private System.Windows.Forms.Button btncalcmin;
        private System.Windows.Forms.Button btncalcmax;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txttotal;
        private System.Windows.Forms.Button btnrecmax;
        private System.Windows.Forms.Button btnrecmin;
        private System.Windows.Forms.Button btncancelar;
    }
}