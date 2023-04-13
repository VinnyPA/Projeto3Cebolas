using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto3Camada
{
    public partial class TelaFornecedor : Form
    {
        public TelaFornecedor()
        {
            InitializeComponent();
        }


        Fornecedor forn;

        private void CarregaTabela()
        {
            forn = new Fornecedor();
            dgvDados.DataSource = forn.Pesquisar();
        }
        private void TelaFornecedor_Load(object sender, EventArgs e)
        {
            CarregaTabela();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            forn = new Fornecedor();
            forn.Id = int.Parse(txtID.Text);
            forn.Cnpj = mtxtCnpj.Text;
            forn.Email = txtEmail.Text;
            forn.Telefone = mtxtTelefone.Text;
            forn.Razao = txtRazao.Text;
            MessageBox.Show(forn.Atualizar() ? "Atualizado com sucesso!" :
                "Não foi possível atualizar!");
            CarregaTabela();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            forn = new Fornecedor();
            forn.Cnpj = mtxtCnpj.Text;
            forn.Email = txtEmail.Text;
            forn.Telefone = mtxtTelefone.Text;
            forn.Razao = txtRazao.Text;
            MessageBox.Show(forn.Gravar() ? "Atualizado com sucesso!" :
                "Não foi possível salvar!");
            CarregaTabela();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            forn = new Fornecedor();
            forn.Id = int.Parse(txtID.Text);
            MessageBox.Show(forn.Excluir() ? "Excluindo com sucesso!" :
                "Não foi possível excluir!");
            CarregaTabela();
        }
    }
}
