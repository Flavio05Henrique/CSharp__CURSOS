using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora;

internal class Calculadora
{
    private Dictionary<string, int> operadoresValidos = new Dictionary<string, int>
             {{ "+", 10 }, { "-", 11 }, { "*", 12 }, { "/", 13 } };

    private List<string> ListaDeValoresDaConta = new();

    public string Calcular(string operacao)
    {
        ListaDeValoresDaConta = SeparaOperacao(operacao);
        List<string> operadores = new() { "/", "*", "+", "-"};
        var contador = 10;

        while (ListaDeValoresDaConta.Count >= 3 && contador != 0)
        {
            contador--;
            if (operadores.Count != 0 && ListaDeValoresDaConta.Count != 0)
            {
                if (ListaDeValoresDaConta.Contains(operadores[0]))
                {
                    Calcula(operadores[0]);
                }
                else
                {
                    operadores.RemoveAt(0);
                }
            }

        }

        string resultado = ListaDeValoresDaConta[0];

        return resultado;
    }

    private List<string> SeparaOperacao(string operacao)
    {
        List<string> operacoes = new();
        string acc = "";
        for(int i =0 ; i <= operacao.Length -1; i++)
        {
            var verificaSeEOperador = operadoresValidos.ContainsKey(operacao[i].ToString());
            if (verificaSeEOperador)
            {
                operacoes.Add(acc);
                operacoes.Add(operacao[i].ToString());
                acc = "";
            } else
            {
                acc += operacao[i];
            }
            if(i == operacao.Length - 1)
            {
                operacoes.Add(acc);
            }
        }
        return operacoes;
    }

    private void RemoveItensJaVistos(List<string> lista, int index)
    {
        if (ListaDeValoresDaConta.Count > 3)
        {
            lista.RemoveRange(index - 1, 3);
        }
    }

    private List<string> ReorganizaLista(List<string> listaAntiga, string valorAAdicionar, int indexDoOperador)
    {
        List<string> novaLista = new();
        bool jaFoiAdicionado = false;

        for(int i = 0; i < listaAntiga.Count; i++)
        {
            if(i == indexDoOperador -1)
            {
                novaLista.Add(valorAAdicionar);
                jaFoiAdicionado = true;
            }
            novaLista.Add(listaAntiga[i]);
        }
        if(jaFoiAdicionado == false)
        {
            novaLista.Add(valorAAdicionar);
        }

        return novaLista;
    }

    private void Calcula(string operador)
    {
        var valores = ListaDeValoresDaConta;

        try
        {
            int getIndex = valores.IndexOf(operador);
            float val1 = float.Parse(valores[getIndex - 1]);
            float val2 = float.Parse(valores[getIndex + 1]);
            string resultado = "0";

            switch (operador)
            {
                case "/":
                    resultado = (val1 / val2) + "";
                    break;
                case "*":
                    resultado = (val1 * val2) + "";
                    break;
                case "+":
                    resultado = (val1 + val2) + "";
                    break;
                case "-":
                    resultado = (val1 - val2) + "";
                    break;
            }

            RemoveItensJaVistos(valores, getIndex);
            ListaDeValoresDaConta = ReorganizaLista(valores, resultado, getIndex);
        }
        catch ( Exception e)
        {
            Console.WriteLine(e);
            return;
        }
    }
}
