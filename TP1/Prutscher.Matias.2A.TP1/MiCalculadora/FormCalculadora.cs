using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace MiCalculadora
{
    public partial class FormCalculadora : Form
    {
        #region METODOS
        public FormCalculadora()
        {
            InitializeComponent();
        }

        /// <summary>
        /// El evento Load del formulario deberá llamar al método Limpiar.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MiCalculadora_Load(object sender, EventArgs e)
        {
            this.Limpiar();
        }
        /// <summary>
        /// Se llama al metodo operar y muestra el resultado del mismo tanto en el 
        /// label como en el list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOperar_Click(object sender, EventArgs e)
        {
            string numero1 = this.txtNumero1.Text;
            string numero2 = this.txtNumero2.Text;
            string operador = this.cmbOperador.Text;
            double resultado;
            double aux;

            if (double.TryParse(numero1, out aux) && double.TryParse(numero2, out aux))
            {
                if (operador == "")
                {
                    operador = "+";
                }
                resultado = Operar(numero1, numero2, operador);
                if (resultado == double.MinValue)
                {
                    MessageBox.Show("Error, no se puede dividir por 0!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    this.lblResultado.Text = resultado.ToString();
                    this.lstOperaciones.Items.Add((numero1 + operador + numero2 + " = " + resultado));
                }
            }
            else
            {
                MessageBox.Show("Error, no se puede ingresar letras!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// Hace la llamada al metodo limpiar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.Limpiar();
        }

        /// <summary>
        /// El botón btnCerrar deberá cerrar el formulario.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// El evento click del botón btnConvertirABinario convertirá el resultado, de existir, a
        ///binario.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConvertirABinario_Click(object sender, EventArgs e)
        {
            Operando aux = new Operando();
            string resultado;
            resultado = aux.DecimalBinario(lblResultado.Text);
            lblResultado.Text = resultado;
        }

        /// <summary>
        /// El evento click del botón btnConvertirADecimal convertirá el resultado, de existir y
        ///ser binario, a decimal.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConvertirADecimal_Click(object sender, EventArgs e)
        {
            Operando aux = new Operando();
            string resultado;
            resultado = aux.BinarioDecimal(lblResultado.Text);
            lblResultado.Text = resultado;
        }

        /// <summary>
        /// El método Limpiar será llamado por el evento click del botón btnLimpiar y borrará
        ///los datos de los TextBox, ComboBox y Label de la pantalla.
        /// </summary>
        private void Limpiar()
        {
            this.txtNumero1.Clear();
            this.txtNumero2.Clear();
            this.cmbOperador.SelectedIndex = 0;
            this.lblResultado.Text = "0";
        }

        /// <summary>
        /// El método Operar será estático recibirá los dos números y el operador para luego
        ///llamar al método Operar de Calculadora y retornar el resultado al método de
        ///evento del botón btnOperar que reflejará el resultado en el Label txtResultado.
        /// </summary>
        /// <param name="numero1"></param>
        /// <param name="numero2"></param>
        /// <param name="operador"></param>
        /// <returns></returns>
        private static double Operar(string numero1, string numero2, string operador)
        {
            double resultado;
            Operando num1 = new Operando(numero1);
            Operando num2 = new Operando(numero2);
            char op = char.Parse(operador);

            resultado = Calculadora.Operar(num1, num2, op);
            return resultado;
        }
        /// <summary>
        /// Implementar el manejador de evento necesario para que al intentar cerrar el
        ///formulario por cualquier método pregunte "¿Está seguro de querer salir?". Si
        ///contesta SI se cerrará, si contesta NO debe continuar en ejecución.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormCalculadora_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Seguro de querer salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        #endregion


    }
}
