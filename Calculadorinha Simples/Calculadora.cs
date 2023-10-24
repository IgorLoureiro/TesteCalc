using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadorinha_Simples
{
    public class Calculadora
    {
        private List<string> listahistorico;
        private string data;

        public Calculadora(string data)
        {
            listahistorico = new List<string>();
            this.data = data;
        }


        public int somar(int val1, int val2)
        {

            listahistorico.Add($"{val1 + val2} -- data: {data}");
            return val1 + val2;

        }

        public int subtrair(int val1, int val2)
        {
            listahistorico.Add($"{val1 - val2}");
            return val1 - val2;
        }

        public int multiplicar(int val1, int val2)
        {
            listahistorico.Add($"{val1 * val2}");
            return val1 * val2;
        }

        public int dividir(int val1, int val2)
        {
            listahistorico.Add($"{val1 / val2}");
            return val1/val2;
        }

        public List<string> historico()
        {
            listahistorico.RemoveRange(3, listahistorico.Count - 3);
            return listahistorico;
        }

    }
}
