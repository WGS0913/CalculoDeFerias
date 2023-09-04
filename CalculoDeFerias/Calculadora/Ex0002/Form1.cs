using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Ex0002
{
    public partial class Form1 : Form
    {
        private List<string> listaItens = new List<string>();

        public Form1()
        {
            InitializeComponent();

            // Adicionando alguns funcionários à lista
            listaItens.Add("Funcionário 1");
            listaItens.Add("Funcionário 2");
            listaItens.Add("Funcionário 3");

            // Atualizando o ListBox com os funcionários
            foreach (string funcionario in listaItens)
            {
                listBox1.Items.Add(funcionario);
            }
        }

        // Adicionar um item à lista
        private void button4_Click(object sender, EventArgs e)
        {
            string novoItem = textBox3.Text;
            listaItens.Add(novoItem);
            listBox1.Items.Add(novoItem);
        }

        // Consultar um item da lista
        private void button3_Click(object sender, EventArgs e)
        {
            int indiceSelecionado = listBox1.SelectedIndex;
            if (indiceSelecionado >= 0)
            {
                string itemSelecionado = listaItens[indiceSelecionado];
                textBox3.Text = itemSelecionado;
            }
        }

        // Alterar um item da lista
        private void button5_Click(object sender, EventArgs e)
        {
            int indiceSelecionado = listBox1.SelectedIndex;
            if (indiceSelecionado >= 0)
            {
                string novoValor = textBox3.Text;
                listaItens[indiceSelecionado] = novoValor;
                listBox1.Items[indiceSelecionado] = novoValor;
            }
        }

        // Limpar todos os campos
        private void button2_Click(object sender, EventArgs e)
        {
            foreach (Control controle in this.Controls)
            {
                if (controle is TextBox)
                {
                    ((TextBox)controle).Text = "";
                }
            }
            label7.Text = "...";
        }

        // Calcular algo (exemplo)
        private void button1_Click(object sender, EventArgs e)
        {
            int mesesTrabalhados;
            float valorPorMes, valorTotal;

            if (int.TryParse(textBox1.Text, out mesesTrabalhados) && float.TryParse(textBox3.Text, out valorPorMes))
            {
                valorTotal = mesesTrabalhados * valorPorMes;
                label7.Text = valorTotal.ToString("F2"); // Atualiza a Label7 com o valor total formatado com duas casas decimais
            }
            else
            {
                label7.Text = "Valores inválidos";
            }
        }
    }
}
