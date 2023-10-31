using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio
{
    public class Calculadora
    {
        private List<string> listaHistorico;

        public Calculadora()
        {
            listaHistorico=new List<string>();
        }

        public int somar(int num1, int num2)
        {
            int result =num1 + num2;
            listaHistorico.Insert(0,"Res: "+result);

            return result;
        }
        public int subtrair(int num1, int num2)
        {
            int result =num1 - num2;
            listaHistorico.Insert(0, "Res: " + result);
            return result;
        }
        public int multiplicar(int num1, int num2)
        {
            int result =num1 * num2;
            listaHistorico.Insert(0, "Res: " + result);
            return result;
        }
        public int dividir(int num1, int num2)
        {
            int result=num1 / num2;
            listaHistorico.Insert(0, "Res: " + result);
            return result;
        }

        public List<string> historico()
        {
            List<string> result;
            listaHistorico.RemoveRange(2,listaHistorico.Count-3);

            return listaHistorico;
        }
    }
}
