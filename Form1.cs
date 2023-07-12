using MosaicoSolutions.ViaCep;
using MosaicoSolutions.ViaCep.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Consulta_CEP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            try { 

            var viaCepService = ViaCepService.Default();

            if (txtCep.Text.Length==8)
            {
                var Endereco = viaCepService.ObterEndereco(txtCep.Text);

                lblCEP.Text = "CEP: ";
                lblCEP.Text += Endereco.Cep;
                lblCEP.Visible= true;

                lblLogradouro.Text = "Logradouro: ";
                lblLogradouro.Text += Endereco.Logradouro;
                lblLogradouro.Visible= true;

                lblComplemento.Text = "Complemento: ";
                lblComplemento.Text += Endereco.Complemento;
                if (Endereco.Complemento!="")
                {
                    lblComplemento.Visible= true;
                }

                lblBairro.Text= "Bairro: ";
                lblBairro.Text += Endereco.Bairro;
                lblBairro.Visible= true;

                lblCidade.Text= "Cidade: ";
                lblCidade.Text += Endereco.Localidade;
                lblCidade.Visible= true;

                lblUF.Text="UF: ";
                lblUF.Text += Endereco.UF;
                lblUF.Visible= true;
            }
            else
            {
                MessageBox.Show("Favor digitar o cep corretamente (somente dígitos)!!!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtCep.Clear();
                txtCep.Focus();
            }

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"Erro",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }


        }
    }
}
