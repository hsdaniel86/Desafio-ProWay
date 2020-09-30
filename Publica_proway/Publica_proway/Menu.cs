﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Publica_proway
{
    public partial class Menu : Form
    {
        // metodo que inicializa codigo fonte
        public Menu()
        {
            InitializeComponent();
        }

        // button que ao click abre a interface para inserir dados
        private void btninserirdados_Click(object sender, EventArgs e)
        {
            Inserir insere = new Inserir();
            insere.ShowDialog();
        }

        // button que ao click abre a interface para calcular
        private void btncalculardados_Click(object sender, EventArgs e)
        {
            Calcular calculo = new Calcular();
            calculo.ShowDialog();
        }

        // button que ao click abre a interface para consulta de dados
        private void btntabela_Click(object sender, EventArgs e)
        {
            Consultar_dados consulta = new Consultar_dados();
            consulta.ShowDialog();
        }

        // button que ao click encerra a interface
        private void btnfechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
