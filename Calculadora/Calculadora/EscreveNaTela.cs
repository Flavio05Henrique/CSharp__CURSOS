using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora;

internal class EscreveNaTela
{
    private Dictionary<string, int> valoresValidos = new Dictionary<string, int>
            { {"0",0}, {"1",1}, {"2",2}, {"3",3}, {"4",4}, {"5",5}, {"6",6},
                {"7",7}, {"8",8}, {"9",9}};
    private Dictionary<string, int> operadoresValidos = new Dictionary<string, int>
             {{ "+", 10 }, { "-", 11 }, { "*", 12 }, { "/", 13 } };

    private string acumulador = "";
    private bool ultimoDigitoNaoEOperador = false;

    public string Escreve()
    {
        bool enterFoiPressionaod = false;
        int limiteDeCaracteres = 50;

        while(!enterFoiPressionaod && limiteDeCaracteres > 0)
        {
            limiteDeCaracteres--;

            ConsoleKeyInfo input = Console.ReadKey();
            string caracter = input.KeyChar.ToString();
            ConsoleKey tecla = input.Key;

            Console.Clear();

            if(valoresValidos.ContainsKey(caracter))
            {
                acumulador += caracter;
                ultimoDigitoNaoEOperador = true;
            }
            else if (ultimoDigitoNaoEOperador && operadoresValidos.ContainsKey(caracter))
            {
                acumulador += caracter;
                ultimoDigitoNaoEOperador = false;
            }

            if(tecla.Equals(ConsoleKey.Backspace))
            {
                if(acumulador.Length > 0)
                {
                    acumulador = acumulador.Remove(acumulador.Length - 1);
                }
            }

            if (tecla.Equals(ConsoleKey.Enter))
            {
                enterFoiPressionaod = true;
            }

            Console.WriteLine(acumulador);
        }

        return acumulador;
    }
}
