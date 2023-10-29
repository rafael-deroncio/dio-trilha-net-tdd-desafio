using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wex.trilha.console
{
    public class Calculadora
    {
        private List<string> _historico = new List<string>();

        public Calculadora()
        {
            
        }

        private void AddHistorico(string historico)
        {
            this._historico.Add(historico);
        }

        public List<string> Historico()
        {
            return this._historico;
        }

        public void Run()
        {
            while (true)
            {
                Console.WriteLine("Calculadora Simples");
                Console.WriteLine("Escolha uma operação:");
                Console.WriteLine("1. Adição");
                Console.WriteLine("2. Subtração");
                Console.WriteLine("3. Multiplicação");
                Console.WriteLine("4. Divisão");
                Console.WriteLine("5. Sair");

                Console.Write("Opção: ");
                int opcao = int.Parse(Console.ReadLine());

                if (opcao == 5)
                {
                    break;
                }

                double resultado = 0;

                switch (opcao)
                {
                    case 1:
                        resultado = Adicao(
                            ObterNumero("Digite o primeiro número: "), 
                            ObterNumero("Digite o segundo número: "));
                        break;
                    case 2:
                        resultado = Subtracao(
                            ObterNumero("Digite o primeiro número: "),
                            ObterNumero("Digite o segundo número: "));
                        break;
                    case 3:
                        resultado = Multiplicacao(
                            ObterNumero("Digite o primeiro número: "),
                            ObterNumero("Digite o segundo número: "));
                        break;
                    case 4:
                        resultado = Divisao(
                            ObterNumero("Digite o primeiro número: "),
                            ObterNumero("Digite o segundo número: "));
                        break;
                    default:
                        Console.WriteLine("Opção inválida.");
                        continue;
                }

                Console.WriteLine("Resultado: " + resultado);
            }
        }
        
        public double Adicao(double a, double b)
        {
            AddHistorico(nameof(Adicao));
            return a + b;
        }

        public double Subtracao(double a, double b)
        {
            AddHistorico(nameof(Subtracao));
            return a - b;
        }

        public double Multiplicacao(double a, double b)
        {
            AddHistorico(nameof(Multiplicacao));
            return a * b;
        }

        public double Divisao(double a, double b)
        {
            if (b == 0)
            {
                Console.WriteLine("Erro: Divisão por zero.");
                return double.NaN;
            }

            AddHistorico(nameof(Divisao));
            return a / b;
        }

        public double ObterNumero(string textoConsole)
        {
            Console.Write(textoConsole);
            string input1 = Console.ReadLine();
            double numero;

            if (!double.TryParse(input1, out numero))
            {
                Console.WriteLine("Valor inválido. Certifique-se de digitar um número válido.");
            }

            return numero;
        }
    }
}
