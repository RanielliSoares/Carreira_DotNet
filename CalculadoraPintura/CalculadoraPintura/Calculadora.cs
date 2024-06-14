using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraPintura
{
    class Calculadora
    {
        public double areaParedes;
        public double areaTeto;

        //criação do metodo calcularAreaParede 
        public double CalcularAreaParedes(double largura, double profundidade, double altura)
        {
           areaParedes = 2 * (largura + profundidade) * altura;
            return areaParedes;
        }
        public double CalcularAreaTeto(double largura, double profundidade)
        {
            areaTeto = largura * profundidade;
            return areaTeto;
        }
        public double CalcularLitros()
        {
            return (areaParedes + areaTeto) / 10;
        }
    }
}
