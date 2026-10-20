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
    public partial class Criar_Conta : Form
    {
        public Criar_Conta()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cenas.user.utilizador = textBox1.Text;
            cenas.user.password = textBox2.Text;
            cenas.user.nome = textBox3.Text;
            cenas.user.data = dateTimePicker1.Value;
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            dateTimePicker1.Value = DateTime.Today;
            this.Close();
            Application.DoEvents();
        }
    }
}
