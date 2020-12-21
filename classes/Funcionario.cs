using System;

namespace POO_PolimosrfismoSobrecarga.classes
{
    public class Funcionario
    {
        public string[] lista = {"Paulo", "Tsuka", "Pricila", "Fernando"};

        public void Mostrar(){
            foreach (var item in lista){
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(item);
                Console.ResetColor();
            }
        }

        public void Mostrar(int indice){
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(lista[indice]);
            Console.ResetColor();
        }

        public void Mostrar(string busca){
            foreach (var item in lista)
           
            if(item == busca){
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Resultado da busca : " + item);
            }
            Console.ResetColor();
        }
    }
}