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
    public partial class Factorial : Form
    {
        public Factorial()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int num = int.Parse(this.txtNum.Text);
            
            //usando POO
            //llamada 1
            Funciones ob1 = new Funciones();
            this.txtResultado.Text = ob1.factorial(num).ToString();

            //llamada 2
            int resultado2 = (new Funciones()).factorial(6);
            MessageBox.Show("El factorial es: "+resultado2.ToString());
        }

        private void btnError_Click(object sender, EventArgs e)
        {
            
            try
            {
                int num = int.Parse(this.txtNum.Text);
                int res = (new Funciones().division_para_cero(num));
                this.txtResultado.Text = res.ToString();
            }catch(DivideByZeroException e1)
            {
                MessageBox.Show(e1.Message.ToString(), "Error",MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }catch(ArithmeticException e1)
            {
                MessageBox.Show(e1.Message.ToString());
            }catch(Exception e1)
            {
                MessageBox.Show(e1.Message.ToString());
            }
            finally
            {//se ejecuta existan o no errores
                this.label2.Text = "Debes corregir la funcion que tiene el error";
            }

        }

        private void Factorial_Load(object sender, EventArgs e)
        {

        }

        private void btnPropiaExcep_Click(object sender, EventArgs e)
        {
            try
            {
                Funciones ob1 = new Funciones();
                int suma = ob1.divide(100, 0);
                MessageBox.Show(suma.ToString());
            }catch (Exception e1)
            {
                MessageBox.Show(e1.Message.ToString());
            }

        }
    }
}
