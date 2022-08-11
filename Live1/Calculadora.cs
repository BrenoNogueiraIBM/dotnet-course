using System;
using System.Collections.Generic;

namespace Live1 
{
    class Calculadora
    {

            public int Valor1 { get; set; }
            public int Valor2 { get; set; }
            public int Resultado { get; set; }
            public static int Qte { get; set; }

            public Calculadora(){
                Qte++;
            }

            public int Soma(int x, int y){
                Valor1 = x;
                Valor2 = y;

                Resultado = Valor1 + Valor2;
                return Resultado;
            }
        
    }
}
