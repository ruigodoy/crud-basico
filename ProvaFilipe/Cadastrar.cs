using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProvaFilipe
{
    public partial class Cadastrar : Form
    {
        public string nome;
        public string periodo;
        public string telefone;
        public string cidade;
        public string cpf;
        public string sexo;
        public string materiaInteresse;
        public Boolean buttonClick;
        public Cadastrar()
        {
            InitializeComponent();
            txtNome.Text = "";
            txtTelefone.Text = "";
            txtCidade.Text = "";
            txtCPF.Text = "";
            materiaInteresse = "";
            sexo = "";
            cmbPeriodo.Text = "";
            buttonClick = false;
        }
        private void btnCadastra_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == "" || txtTelefone.Text == "" || txtCidade.Text == "" || txtCPF.Text == "" || cmbPeriodo.Text == "")
            {
                MessageBox.Show("Preencha todos os campos obrigatorios.", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            }
            else
            {
                nome = txtNome.Text;
                telefone = txtTelefone.Text;
                cidade = txtCidade.Text;
                cpf = txtCPF.Text;
                periodo = cmbPeriodo.Text;

                if (radioButton1.Checked)
                {
                    sexo = "Masculino";
                }
               
                if (radioButton2.Checked)
                {
                    sexo = "Feminino";
                }
              
                if (radioButton3.Checked)
                {
                    sexo = "Outro";
                }

                string[] checkBoxs = new string[6];
                if (checkBox1.Checked)
                {
                    checkBoxs[0] = "Matematica";
                }
                else
                {
                    checkBoxs[0] = null;
                }
                
                if (checkBox2.Checked)
                {
                    checkBoxs[1] = "Medicina Veterinaria";
                }
                else
                {
                    checkBoxs[1] = null;
                }
               
                if (checkBox3.Checked)
                {
                    checkBoxs[2] = "Medicina";
                }
                else
                {
                    checkBoxs[2] = null;
                }
               
                if (checkBox4.Checked)
                {
                    checkBoxs[3] = "Odontologia";
                }
                else
                {
                    checkBoxs[3] = null;
                }
               
                if (checkBox5.Checked)
                {
                    checkBoxs[4] = "Sistema de Informação";
                }
                else
                {
                    checkBoxs[4] = null;
                }

                if (checkBox6.Checked)
                {
                    checkBoxs[5] = "Engenharia da Computação";
                }
                else
                {
                    checkBoxs[5] = null;
                }

                for (int i = 0; i < 6; i++)
                {
                    if (checkBoxs[i] != null)
                    {
                        materiaInteresse += checkBoxs[i] + "; ";
                    }

                }
                buttonClick = true;
                this.Close();
            }
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            buttonClick = false;
            this.Close();
        }
    }
}
