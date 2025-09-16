using System;
using System.ComponentModel;
using System.Windows.Forms;
using inventoryliby;

namespace InventoryApp
{

    public partial class Form1 : Form
    {
        private Inventorymanegy _inventoryManager = new Inventorymanegy();

        public Form1()
        {
            InitializeComponent();
            AtualizarDataGridView();
        }


        private void AtualizarDataGridView()
        {
            var lista = _inventoryManager.ObterTodosProdutos();

            BindingList<Produto> bindingListProdutos = new BindingList<Produto>(lista);

            dataGridView1.DataSource = bindingListProdutos;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (_inventoryManager != null)
                {
                    string nome = TxtNome.Text;
                    decimal preco = decimal.Parse(TxtPreco.Text);
                    string descricao = TxtDescricao.Text;
                    _inventoryManager.AdicionarProduto(nome, descricao, preco);
                    MessageBox.Show("Produto adicionado com sucesso!");

                    TxtNome.Text = "";
                    TxtPreco.Text = "";
                    TxtDescricao.Text = "";

                    // Atualiza a exibição dos produtos
                    AtualizarDataGridView();

                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Preço inválido. Por favor, insira um número válido.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro: {ex.Message}");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                try
                {
                    // Pega o ID da linha selecionada
                    int idDoProduto = (int)dataGridView1.SelectedRows[0].Cells["Id"].Value;

                    // Chama o método de remoção na sua DLL
                    _inventoryManager.RemoverProduto(idDoProduto);

                    MessageBox.Show("Produto removido com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // IMPORTANTE: Atualize a tela para refletir a remoção
                    AtualizarDataGridView();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ocorreu um erro ao remover: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Selecione um produto para remover.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void TxtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtPreco_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtDescricao_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = true;
            AtualizarDataGridView();
        }
    }
}
