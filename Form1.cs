using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraCientificaPOO104
{
    public partial class frmCalculadora : Form
    {
        // Instancia global de nuestra clase de operaciones (POO)
        //para llamar a nuestra clase donde estan los metodos a usar
        Calculadora calc = new Calculadora();
        public frmCalculadora()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        // --- MÉTODOS AUXILIARES DE VALIDACIÓN ---

        // Valida que la caja no esté vacía y contenga un número válido
        private bool ValidarNumero(TextBox caja, out double numero)
        {
            if (string.IsNullOrWhiteSpace(caja.Text)) //verifica si el campo está vacío
            {
                MessageBox.Show("No se permiten campos vacíos.");
                caja.Focus();
                numero = 0;
                return false;
            }

            if (!double.TryParse(caja.Text, out numero)) //verifica que sean números
            {
                MessageBox.Show("Ingrese un valor numérico válido.", "Error de Formato");
                caja.Clear();
                caja.Focus();
                return false;
            }

            return true;
        }

        // --- BOTONES DE OPERACIONES BÁSICAS ---

        private void btnSuma_Click(object sender, EventArgs e)
        {
            double n1, n2;
            //llamamos al metodo para validar los campos
            if (ValidarNumero(txtNum1, out n1) && ValidarNumero(txtNum2, out n2))
            {
                double resultado = calc.Sumar(n1, n2);//reslizar la operacion con el metodo
                txtResultado.Text = resultado.ToString();
            }

        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            double n1, n2;
            if (ValidarNumero(txtNum1, out n1) && ValidarNumero(txtNum2, out n2))
            {
                double resultado = calc.Restar(n1, n2);
                txtResultado.Text = resultado.ToString();
            }
        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            double n1, n2;
            if (ValidarNumero(txtNum1, out n1) && ValidarNumero(txtNum2, out n2))
            {
                double resultado = calc.Multiplicar(n1, n2);
                txtResultado.Text = resultado.ToString();
            }
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            double n1, n2;
            if (ValidarNumero(txtNum1, out n1) && ValidarNumero(txtNum2, out n2))
            {
                if (n2 == 0) //validacion especial de division entre cero
                {
                    MessageBox.Show("No se permite la división entre cero.", "Error Matemático");
                    txtNum2.Clear();
                    txtNum2.Focus();
                    return;
                }

                double resultado = calc.Dividir(n1, n2);
                txtResultado.Text = resultado.ToString();
            }
        }
        // --- BOTONES DE OPERACIONES CIENTÍFICAS ---
        private void btnPotencia_Click(object sender, EventArgs e)
        {
            double n1, n2;
            if (ValidarNumero(txtNum1, out n1) && ValidarNumero(txtNum2, out n2))
            {
                double resultado = calc.Potencia(n1, n2);
                txtResultado.Text = resultado.ToString();
            }

        }

        private void btnRaizCuadrada_Click(object sender, EventArgs e)
        {
            double n1;
            if (ValidarNumero(txtNum1, out n1))
            {
                if (n1 < 0) //validacion de raices negativas
                {
                    MessageBox.Show("No se puede calcular la raíz cuadrada de un número negativo.", "Error Matemático");
                    return;
                }
                double resultado = calc.RaizCuadrada(n1);
                txtResultado.Text = resultado.ToString();
            }
        }

        private void btnRaizCubica_Click(object sender, EventArgs e)
        {
            double n1;
            if (ValidarNumero(txtNum1, out n1))
            {
                double resultado = calc.RaizCubica(n1);
                txtResultado.Text = resultado.ToString();
            }
        }

        private void btnAbsoluto_Click(object sender, EventArgs e)
        {
            double n1;
            if (ValidarNumero(txtNum1, out n1))
            {
                double resultado = calc.ValorAbsoluto(n1);
                txtResultado.Text = resultado.ToString();
            }
        }

        private void btnLn_Click(object sender, EventArgs e)
        {
            double n1;
            if (ValidarNumero(txtNum1, out n1))
            {
                if (n1 <= 0) //validacion logaritmo invalido
                {
                    MessageBox.Show("El logaritmo solo está definido para números mayores a cero.", "Error Matemático");
                    return;
                }
                double resultado = calc.LogaritmoNatural(n1);
                txtResultado.Text = resultado.ToString();
            }
        }

        private void btnLog10_Click(object sender, EventArgs e)
        {
            double n1;
            if (ValidarNumero(txtNum1, out n1))
            {
                if (n1 <= 0) //validacion logaritmo invalido
                {
                    MessageBox.Show("El logaritmo solo está definido para números mayores a cero.");
                    return;
                }
                double resultado = calc.LogaritmoBase10(n1);
                txtResultado.Text = resultado.ToString();
            }
        }

        private void btnSeno_Click(object sender, EventArgs e)
        {
            double n1;
            if (ValidarNumero(txtNum1, out n1))
            {
                double resultado = calc.Seno(n1);
                txtResultado.Text = resultado.ToString();
            }
        }

        private void btnCoseno_Click(object sender, EventArgs e)
        {
            double n1;
            if (ValidarNumero(txtNum1, out n1))
            {
                double resultado = calc.Coseno(n1);
                txtResultado.Text = resultado.ToString();
            }
        }

        private void btnTangente_Click(object sender, EventArgs e)
        {
            double n1;
            if (ValidarNumero(txtNum1, out n1))
            {
                double resultado = calc.Tangente(n1);
                txtResultado.Text = resultado.ToString();
            }
        }

        private void btnExp_Click(object sender, EventArgs e)
        {
            double n1;
            if (ValidarNumero(txtNum1, out n1))
            {
                double resultado = calc.Exponencial(n1);
                txtResultado.Text = resultado.ToString();
            }
        }

        private void btnFactorial_Click(object sender, EventArgs e)
        {
            double n1;
            if (ValidarNumero(txtNum1, out n1))
            {
                if (n1 < 0) //validacion factorial de negativos
                {
                    MessageBox.Show("No existe el factorial de un número negativo.");
                    return;
                }
                double resultado = calc.Factorial(n1);
                txtResultado.Text = resultado.ToString();
            }
        }

        private void btnModulo_Click(object sender, EventArgs e)
        {
            double n1, n2;
            if (ValidarNumero(txtNum1, out n1) && ValidarNumero(txtNum2, out n2))
            {
                double resultado = calc.Modulo(n1, n2);
                txtResultado.Text = resultado.ToString();
            }
        }
        // --- BOTONES GENERALES ---
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNum1.Clear(); //limpia los campos de texto
            txtNum2.Clear();
            txtResultado.Clear();
            txtNum1.Focus(); //posiciona el cursor en la primera caja
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit(); //termina la aplicacion
        }

        //Botones abiertos pero sin procesos
        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }

        private void lblResultado_Click(object sender, EventArgs e)
        {

        }

        private void gbpCientificas_Enter(object sender, EventArgs e)
        {

        }

        private void lblMulti_Click(object sender, EventArgs e)
        {

        }
    }
}

