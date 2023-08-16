using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Swicth_Case
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            DialogResult mensagem = MessageBox.Show("Deseja finalizar a aplicação?", "Encerrar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2); if (mensagem == DialogResult.Yes) { this.Close(); }
        }

        private void BtnNome_Click(object sender, EventArgs e)
        {

        }

        private void BtnNome_Click_1(object sender, EventArgs e)
        {
            switch(cboDiaDaSemana.Text)
            {
                case "1":
                    lblDiaDaSemana.Text = "Domingo";
                    break;
                case "2":
                    lblDiaDaSemana.Text = "Segunda-Feira";
                    break;
                case "3":
                    lblDiaDaSemana.Text = "Terça-Feira";
                    break;
                case "4":
                    lblDiaDaSemana.Text = "Quarta-Feira";
                    break;
                case "5":
                    lblDiaDaSemana.Text = "Quinta-Feira";
                    break;
                case "6":
                    lblDiaDaSemana.Text = "Sexta-Feira";
                    break;
                case "7":
                    lblDiaDaSemana.Text = "Sábado";
                    break;
            }
        }
    }
}
