using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace ProvaFilipe
{
    public partial class Principal : Form
    {
        public int matricula = 1000;
        int selectedRowIndex;
        public Principal()
        {
            InitializeComponent();
            Grid.Columns.Add("NumMatricula", "Matricula");
            Grid.Columns.Add("NomeCompleto", "Nome Completo");
            Grid.Columns.Add("Telefone", "Telefone");
            Grid.Columns.Add("Cidade", "Cidade");
            Grid.Columns.Add("CPF", "CPF");
            Grid.Columns.Add("Sexo", "Sexo");
            Grid.Columns.Add("Periodo", "Periodo");
            Grid.Columns.Add("MateriasInteresse", "Materias De Interesse");
            Grid.Columns["NumMatricula"].ReadOnly = true;
            Grid.Columns["NomeCompleto"].ReadOnly = true;
            Grid.Columns["Telefone"].ReadOnly = true;
            Grid.Columns["Cidade"].ReadOnly = true;
            Grid.Columns["CPF"].ReadOnly = true;
            Grid.Columns["Sexo"].ReadOnly = true;
            Grid.Columns["NomeCompleto"].ReadOnly = true;
            Grid.Columns["Periodo"].ReadOnly = true;
            Grid.Columns["MateriasInteresse"].ReadOnly = true;
            Grid.Columns[7].Width = 240;
        }
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Cadastrar FrmCadastro = new Cadastrar();
            FrmCadastro.ShowDialog();

            string nome = FrmCadastro.nome;
            string periodo = FrmCadastro.periodo;
            string telefone = FrmCadastro.telefone;
            string cidade = FrmCadastro.cidade;
            string cpf = FrmCadastro.cpf;
            string sexo = FrmCadastro.sexo;
            string materiaInteresse = FrmCadastro.materiaInteresse;
            Boolean ButtonClick = FrmCadastro.buttonClick;

            if (materiaInteresse == "")
            {
                materiaInteresse = "Não informado";
            }
        
            if (sexo == "")
            {
                sexo = "Não informado";
            }
            
            object[] parametros = {matricula, nome, telefone, cidade, cpf, sexo, periodo, materiaInteresse };

            if(ButtonClick == true)
            {
                Grid.Rows.Add(parametros);
                matricula++;
            }
    }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            try
            {
                row = Grid.Rows[selectedRowIndex];
            }
            catch (ArgumentOutOfRangeException)
            {
                //Não fazer nada.  
            }
            try
            {
                if (row.Cells[0].Selected)
                {
                    MessageBox.Show("Valor de Matricula não pode ser Editado!");
                }
                else if (row.Cells[1].Selected)
                {
                    if (row.Cells[1].Value != null)
                    {
                        string nomeEditar = Interaction.InputBox("Novo Nome: ", "Edição", row.Cells[1].Value.ToString(), -1, -1);
                        row.Cells[1].Value = nomeEditar;
                    }
                    else
                    {
                        MessageBox.Show("Você não pode alterar onde está vazio.");
                    }

                }
                else if (row.Cells[2].Selected)
                {
                    if (row.Cells[2].Value != null)
                    {
                        string telefoneEditar = Interaction.InputBox("Novo Telefone: ", "Edição", row.Cells[2].Value.ToString(), -1, -1);
                        row.Cells[2].Value = telefoneEditar;
                    }
                    else
                    {
                        MessageBox.Show("Você não pode alterar onde está vazio.");
                    }

                }
                else if (row.Cells[3].Selected)
                {
                    if (row.Cells[3].Value != null)
                    {
                        string cidadeEditar = Interaction.InputBox("Nova Cidade: ", "Edição", row.Cells[3].Value.ToString(), -1, -1);
                        row.Cells[3].Value = cidadeEditar;
                    }
                    else
                    {
                        MessageBox.Show("Você não pode alterar onde está vazio.");
                    }

                }
                else if (row.Cells[4].Selected)
                {
                    if (row.Cells[4].Value != null)
                    {
                        string cpfEditar = Interaction.InputBox("Novo CPF: ", "Edição", row.Cells[4].Value.ToString(), -1, -1);
                        row.Cells[4].Value = cpfEditar;
                    }
                    else
                    {
                        MessageBox.Show("Você não pode alterar onde está vazio.");
                    }

                }
                else if (row.Cells[5].Selected)
                {
                    if (row.Cells[5].Value != null)
                    {
                        string sexoEditar = Interaction.InputBox("Novo Sexo: ", "Edição", row.Cells[5].Value.ToString(), -1, -1);
                        row.Cells[5].Value = sexoEditar;
                    }
                    else
                    {
                        MessageBox.Show("Você não pode alterar onde está vazio.");
                    }

                }
                else if (row.Cells[6].Selected)
                {
                    if (row.Cells[6].Value != null)
                    {
                        string periodoEditar = Interaction.InputBox("Novo Periodo: ", "Edição", row.Cells[6].Value.ToString(), -1, -1);
                        row.Cells[6].Value = periodoEditar;
                    }
                    else
                    {
                        MessageBox.Show("Você não pode alterar onde está vazio.");
                    }

                }
                else if (row.Cells[7].Selected)
                {
                    if (row.Cells[7].Value != null)
                    {
                        string materiasInteresseEditar = Interaction.InputBox("Novas Materias de Interesse: ", "Edição", row.Cells[7].Value.ToString(), -1, -1);
                        row.Cells[7].Value = materiasInteresseEditar;
                    }
                    else
                    {
                        MessageBox.Show("Você não pode alterar onde está vazio.");
                    }
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                //Não fazer nada.
            }
        }
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                Grid.Rows.RemoveAt(selectedRowIndex);
            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("Não tem nada para Excluir.");
            }
        }

        private void Grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRowIndex = e.RowIndex;
        }

        private void Grid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            
            try
            {
                row = Grid.Rows[selectedRowIndex];
            }
            catch(ArgumentOutOfRangeException)
            {
                //Não fazer nada.  
            }
            try
            { 
                if (row.Cells[0].Selected)
                {
                    MessageBox.Show("Valor de Matricula não pode ser Editado!");
                }
                else if (row.Cells[1].Selected)
                {
                    if (row.Cells[1].Value != null)
                    {
                        string nomeEditar = Interaction.InputBox("Novo Nome: ", "Edição", row.Cells[1].Value.ToString(), -1, -1);
                        row.Cells[1].Value = nomeEditar;
                    }
                    else
                    {
                        MessageBox.Show("Você não pode alterar onde está vazio.");
                    }

                }
                else if (row.Cells[2].Selected)
                {
                    if (row.Cells[2].Value != null)
                    {
                        string telefoneEditar = Interaction.InputBox("Novo Telefone: ", "Edição", row.Cells[2].Value.ToString(), -1, -1);
                        row.Cells[2].Value = telefoneEditar;
                    }
                    else
                    {
                        MessageBox.Show("Você não pode alterar onde está vazio.");
                    }

                }
                else if (row.Cells[3].Selected)
                {
                    if (row.Cells[3].Value != null)
                    {
                        string cidadeEditar = Interaction.InputBox("Nova Cidade: ", "Edição", row.Cells[3].Value.ToString(), -1, -1);
                        row.Cells[3].Value = cidadeEditar;
                    }
                    else
                    {
                        MessageBox.Show("Você não pode alterar onde está vazio.");
                    }

                }
                else if (row.Cells[4].Selected)
                {
                    if (row.Cells[4].Value != null)
                    {
                        string cpfEditar = Interaction.InputBox("Novo CPF: ", "Edição", row.Cells[4].Value.ToString(), -1, -1);
                        row.Cells[4].Value = cpfEditar;
                    }
                    else
                    {
                        MessageBox.Show("Você não pode alterar onde está vazio.");
                    }

                }
                else if (row.Cells[5].Selected)
                {
                    if (row.Cells[5].Value != null)
                    {
                        string sexoEditar = Interaction.InputBox("Novo Sexo: ", "Edição", row.Cells[5].Value.ToString(), -1, -1);
                        row.Cells[5].Value = sexoEditar;
                    }
                    else
                    {
                        MessageBox.Show("Você não pode alterar onde está vazio.");
                    }

                }
                else if (row.Cells[6].Selected)
                {
                    if (row.Cells[6].Value != null)
                    {
                        string periodoEditar = Interaction.InputBox("Novo Periodo: ", "Edição", row.Cells[6].Value.ToString(), -1, -1);
                        row.Cells[6].Value = periodoEditar;
                    }
                    else
                    {
                        MessageBox.Show("Você não pode alterar onde está vazio.");
                    }

                }
                else if (row.Cells[7].Selected)
                {
                    if (row.Cells[7].Value != null)
                    {
                        string materiasInteresseEditar = Interaction.InputBox("Novas Materias de Interesse: ", "Edição", row.Cells[7].Value.ToString(), -1, -1);
                        row.Cells[7].Value = materiasInteresseEditar;
                    }
                    else
                    {
                        MessageBox.Show("Você não pode alterar onde está vazio.");
                    }
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                //Não fazer nada.
            }
        }

    }
}
