using System;

namespace Trabalho_do_GB
{
    class Program
    {
        public static int opcao;
        public static int numeroMatricula = 0;
        public static double nota1 = 0;
        public static double nota2 = 0;
        public static double media = 0;
        public const double constanteGA = 0.33;
        public const double constanteGB = 0.67;
        static void Main(string[] args)
        {
            do
            {
                imprimirMenu();
                opcao = Int32.Parse(Console.ReadLine());
                switch(opcao){
                    case 1:
                        inserirDadosAluno();
                        break;
                    case 2:
                        calcularMedia(nota1, nota2);
                        break;
                    case 3:
                    if (numeroMatricula != 0){
                        verificarAprovacao(media);
                    } else {
                        Console.WriteLine("É necessário informar os dados do aluno antes (utilize a opção 1 para isso)");
                    }

                        break;
                    default:
                        fecharPrograma();
                        break;
                }   
            }
            while (opcao != 0 || opcao > 3);            
        }

        public static void imprimirMenu(){
            Console.WriteLine("[ 1 ] Informar dados do aluno");
            Console.WriteLine("[ 2 ] Calcular média");
            Console.WriteLine("[ 3 ] Verificar aprovação");
            Console.WriteLine("[ 0 ] Sair");
            Console.WriteLine("-------------------------------------");
            Console.Write("Digite uma opção: ");
        }
        public static void inserirDadosAluno(){
            Console.WriteLine("Insira o número de mtrícula do aluno: ");
            numeroMatricula = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Informe a nota 1 do aluno: ");
            nota1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe a nota 2 do aluno: ");
            nota2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Dados cadastrados com sucesso!");
        }

        public static void calcularMedia(double nota1, double nota2){
            media = (nota1 * constanteGA) + (nota2 * constanteGB);
            Console.WriteLine("A média do aluno é: " + media);
        }

        public static void verificarAprovacao (double media){
            if (media >= 6){
                Console.WriteLine("O aluno de matricula " + numeroMatricula + " foi aprovado!");
            } else {
                Console.WriteLine("O aluno de matricula " + numeroMatricula + " não foi aprovado!");
            }
        }
        public static void fecharPrograma(){
            Console.WriteLine("O programa esá encerrando..."); 
        }
    }
}
