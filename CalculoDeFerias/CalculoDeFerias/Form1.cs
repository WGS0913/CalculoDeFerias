using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculoDeFerias
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void listView1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            // Aqui você pode adicionar funcionários à lista
            // Vou adicionar alguns exemplos para ilustrar como fazer isso

            // Nome dos funcionários
            string[] funcionarios = { "Funcionário 1", "Funcionário 2", "Funcionário 3" };

            // Limpe a lista existente
            listView1.Items.Clear();

            // Adicione os funcionários à lista
            foreach (string funcionario in funcionarios)
            {
                listView1.Items.Add(funcionario);
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
