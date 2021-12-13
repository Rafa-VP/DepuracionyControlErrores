using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DepuracionyControlErrores
{
    public partial class frmDepuracion_almeida : Form
    {
        public frmDepuracion_almeida()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            MessageBox.Show("iniciando depuracion");
            //sumatoria de los nùmeros comprendidos en un rango dado
            int num1 = int.Parse(this.txtNum1.Text);
            int num2 = int.Parse(this.txtNum2.Text);
            int suma = 0;
            for (int i = num1; i <= num2; i++)
            {
                suma += i;
            }
            this.txtResultado.Text = suma.ToString();
        }
    }
}
