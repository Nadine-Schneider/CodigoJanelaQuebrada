using System;

namespace Trabalho_do_GB
{
    class Program
    {
static void Main(string[] args)
{
int a;
string b;
 double n1 = 0;
double n2 = 0;
    do{
Console.WriteLine("[ 1 ] Informar dados"); 
Console.WriteLine("[ 2 ] Calcular média"); 
Console.WriteLine("[ 3 ] Verificar aprovação"); 
Console.WriteLine("[ 0 ] Sair"); 
Console.WriteLine("-------------------------------------"); 
Console.Write("Digite uma opção: "); 
a = Int32.Parse(Console.ReadLine()); 
if (a == 1){
   Console.WriteLine("Nome: ");
   b = Console.ReadLine();
   Console.WriteLine("Nota 1: ");
   n1 = double.Parse(Console.ReadLine());
Console.WriteLine("Nota 2: ");
    n2 = float.Parse(Console.ReadLine());
} if (a ==2)
{
  double ga = n1 * 0.33;
  double gb = n2 * 0.67;
  double c = ga + gb;
  Console.Write("Nota: " + c); 

} if (a == 3){
  double ga = n1 * 0.33;
  double gb = n2 * 0.67;
  double c = ga + gb;
  if (c >= 6 )
  Console.Write("Aprovado"); 
 if (c< 6)
   Console.Write("Nãp aprovado"); 

} if (a ==0){
return;
}
}
            while (a != 0 || a > 3);
        }
    }
}
