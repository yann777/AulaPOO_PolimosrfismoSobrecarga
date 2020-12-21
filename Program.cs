using System;
using POO_PolimosrfismoSobrecarga.classes;

namespace POO_PolimosrfismoSobrecarga
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Funcionario fun = new Funcionario(); 
            fun.Mostrar();
            fun.Mostrar("Paulo");
            fun.Mostrar(2);

            Console.Beep(900, 5000);
        }
    }
}
