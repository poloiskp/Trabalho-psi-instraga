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
    public partial class Iniciar_Sessão : Form
    {
        public Iniciar_Sessão()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
                if (textBox1.Text == cenas.user.utilizador && textBox2.Text == cenas.user.password)
                {
                    Conta conta = new Conta();
                    conta.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Nome de utilizador ou palavra-passe incorretos");
                }
            }
        }
    }

