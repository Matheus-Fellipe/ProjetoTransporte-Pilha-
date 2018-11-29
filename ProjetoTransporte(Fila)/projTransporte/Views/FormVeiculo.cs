﻿using ProjetoTransporte.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoTransporte.Views
{
    partial class FormVeiculo : Form
    {
        public TerminalController terminal;

        public FormVeiculo()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string placa = txtPlaca.Text;
            string motorista = txtMotorista.Text;
            int lotacao = Int32.Parse(txtLotacao.Text);
            // Cadastrando veículos no terminal
            this.terminal.cadastrarVeiculo(placa, motorista, lotacao);
            // Fechando janela e liberando recursos
            this.Dispose();
        }
    }
}
