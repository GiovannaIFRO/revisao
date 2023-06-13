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
    public partial class Divisao : Form
    {
        public Divisao()
        {
            InitializeComponent();
            lb_resultado.Text = "";
        }

        private void bt_calcular_Click(object sender, EventArgs e)
        {
            try
            {
                int a = Convert.ToInt32(tx_valor1.Text);
                int b = Convert.ToInt32(tx_valor2.Text);

                int c = a / b;
            }catch (Exception ex)
            {
                MessageBox.Show("Não pode ser dividido por 0");
            }
            finally
            {
                MessageBox.Show("Vai executar de quarquer forma");
            }
            
            //MessageBox.Show(c.ToString());
        }
    }
}
