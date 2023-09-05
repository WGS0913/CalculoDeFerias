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

        private void label1_Click(object sender, EventArgs e)
        {
            Label myLabel = new Label();
            Image myImage = Image.FromFile("circulo.png");
            myLabel.Size = new Size(myImage.Width, myImage.Height);
            myLabel.Image = myImage;

        }
    }
}
