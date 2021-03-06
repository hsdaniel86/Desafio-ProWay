﻿using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Publica_proway
{
    public partial class Calcular : Form
    {
        // metodo que inicializa codigo fonte
        public Calcular()
        {
            InitializeComponent();
        }

        // button que ao click calcula dados coluna Placar
        private void btncalcplacar_Click(object sender, EventArgs e)
        {
            try
            {
                // classe que abre conexão com banco de dados
                funçãosql.cn.Open();
                // comando sql que retorna calculo da coluna placar  na tabela painel
                SqlCommand command = new SqlCommand("select sum (Placar) from Painel", funçãosql.cn);
                // comando que exibe resultado da consulta no textbox
                txttotal.Text = command.ExecuteScalar().ToString();
            }
            catch (Exception ex)
            {
                // caso o codigo não execute retorna o motivo da falha 
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                // campo que encerra conexão com banco de dados
                funçãosql.cn.Close();
            }
        }

        // button que ao click calcula dados coluna minimo da temporada
        private void btncalcmin_Click(object sender, EventArgs e)
        {
            try
            {
                // classe que abre conexão com banco de dados
                funçãosql.cn.Open();
                // comando sql que retorna calculo da somente as vezes que foi alterado coluna minimo temporada na tabela painel
                SqlCommand command = new SqlCommand("select sum (distinct Minimo_temporada) from Painel", funçãosql.cn);
                // comando que exibe resultado da consulta no textbox
                txttotal.Text = command.ExecuteScalar().ToString();
            }
            catch (Exception ex)
            {
                // caso o codigo não execute retorna o motivo da falha 
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                // campo que encerra conexão com banco de dados
                funçãosql.cn.Close();
            }    
        }

        // button que ao click calcula dados coluna maximo temporada
        private void btncalcmax_Click(object sender, EventArgs e)
        {
            try
            {
                // classe que abre conexão com banco de dados
                funçãosql.cn.Open();
                // comando sql que retorna calculo da somente as vezes que foi alterado coluna maximo temporada na tabela painel
                SqlCommand command = new SqlCommand("select sum (distinct Maximo_temporada) from Painel", funçãosql.cn);
                // comando que exibe resultado da consulta no textbox
                txttotal.Text = command.ExecuteScalar().ToString();
            }
            catch (Exception ex)
            {
                // caso o codigo não execute retorna o motivo da falha 
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                // campo que encerra conexão com banco de dados
                funçãosql.cn.Close();
            }
        }

        // button que ao click busca total de vezes que foi quebrado o recorde minimo 
        private void btnrecmin_Click(object sender, EventArgs e)
        {
            try
            {
                // classe que abre conexão com banco de dados
                funçãosql.cn.Open();
                // comando sql que retorna quantidade de vezes que foi quebrado o recorde na coluna recorde minimo da temporada na tabela painel
                SqlCommand command = new SqlCommand("select max (Recorde_minimo_temporada) from Painel", funçãosql.cn);
                // comando que exibe resultado da consulta no textbox
                txttotal.Text = command.ExecuteScalar().ToString();
            }
            catch (Exception ex)
            {
                // caso o codigo não execute retorna o motivo da falha 
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                // campo que encerra conexão com banco de dados
                funçãosql.cn.Close();
            }            
        }

        // button que ao click busca total de vezes que foi quebrado o recorde maximo
        private void btnrecmax_Click(object sender, EventArgs e)
        {
            try
            {
                // classe que abre conexão com banco de dados
                funçãosql.cn.Open();
                // comando sql que retorna quantidade de vezes que foi quebrado o recorde na coluna recorde maximo temporada jogo na tabela painel
                SqlCommand command = new SqlCommand("select max (Recorde_maximo_temporada) from Painel", funçãosql.cn);
                // comando que exibe resultado da consulta no textbox
                txttotal.Text = command.ExecuteScalar().ToString();
            }
            catch (Exception ex)
            {
                // caso o codigo não execute retorna o motivo da falha 
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                // campo que encerra conexão com banco de dados
                funçãosql.cn.Close();
            }
        }

        // button que ao click encerra a interface
        private void btncancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
