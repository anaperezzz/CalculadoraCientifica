using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Clase independendiente para las operaciones
namespace CalculadoraCientificaPOO104
{
    public class Calculadora
    {
        // --- OPERACIONES BÁSICAS ---
        public double Sumar(double n1, double n2)
        {
            return n1 + n2;
        }

        public double Restar(double n1, double n2)
        {
            return n1 - n2;
        }

        public double Multiplicar(double n1, double n2)
        {
            return n1 * n2;
        }

        public double Dividir(double n1, double n2)
        {
            return n1 / n2;
        }

        // --- OPERACIONES CIENTÍFICAS ---
        public double Potencia(double baseNum, double exponente)
        {
            return Math.Pow(baseNum, exponente);
        }

        public double RaizCuadrada(double numero)
        {
            return Math.Sqrt(numero);
        }

        public double RaizCubica(double numero)
        {
            return Math.Pow(numero, 1.0 / 3.0);
        }

        public double ValorAbsoluto(double numero)
        {
            return Math.Abs(numero);
        }

        public double LogaritmoNatural(double numero)
        {
            return Math.Log(numero);
        }

        public double LogaritmoBase10(double numero)
        {
            return Math.Log10(numero);
        }

        public double Seno(double angulo)
        {
            double radianes = angulo * (Math.PI / 180.0); //convertir a radianes
            return Math.Sin(radianes);
        }

        public double Coseno(double angulo)
        {
            double radianes = angulo * (Math.PI / 180.0); //convertir a radianes
            return Math.Cos(radianes);
        }

        public double Tangente(double angulo)
        {
            double radianes = angulo * (Math.PI / 180.0); //convertir a radianes
            return Math.Tan(radianes);
        }

        public double Exponencial(double numero)
        {
            return Math.Exp(numero);
        }

        public double Factorial(double numero)
        {
            double fact = 1;
            for (int i = 1; i <= (int)numero; i++)
            {
                fact = fact * i;
            }
            return fact;
        }

        public double Modulo(double n1, double n2)
        {
            return n1 % n2;
        }
    }

}

