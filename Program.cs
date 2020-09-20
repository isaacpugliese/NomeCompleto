using System;

namespace nomecompleto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite seu Nome: ");
            string NmUsuario = Console.ReadLine();
            Console.Write("Digite seu Sobrenome: ");
            string NmSobrenome = Console.ReadLine();
            Console.Write("Nome Completo: ");
            Console.WriteLine(NmUsuario +" "+ NmSobrenome);
            Console.Write("Nome Catálogo: ");
            Console.WriteLine(NmSobrenome +", "+ NmUsuario);
        }
    }
}
