using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace instraga
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Criar_Conta criar = new Criar_Conta();
            criar.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Iniciar_Sessão inicar = new Iniciar_Sessão();
            inicar.ShowDialog();
        }
    }
}
