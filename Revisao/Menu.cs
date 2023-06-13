using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Revisao
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void bt_divisao_Click(object sender, EventArgs e)
        {
            Divisao d = new Divisao();
            d.ShowDialog();//abrir o from divisao
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sexo = "";
            if (radioButton1.Checked)
            {
                sexo = radioButton1.Text;
            }
            else if(radioButton2.Checked)
            {
                sexo = radioButton2.Text;
            }

            MessageBox.Show(sexo);
        }
    }
}
