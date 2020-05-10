using System;

namespace calculos
{
    public class Calculadora
    {
        public int Soma(int operador1, int operador2) => operador1 + operador2;
        public int Subtracao(int operador1, int operador2) => operador1 - operador2;
        public int Multiplicao(int operador1, int operador2) => operador1 * operador2;
        public int Divisao(int dividento, int divisor)=> dividento / divisor;
        
    }
}
