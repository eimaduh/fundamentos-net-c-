using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploFundamentos.Commom.models
{
    public class Calculadora
    {
        public void Somar(int a, int b){
            Console.WriteLine($"{a} + {b} = {a + b}");
        }
        public void Subtrair(int c, int d){
            Console.WriteLine($"{c} - {d} = {c - d}");
        }
        public void Mulltiplicar(int e, int f){
            Console.WriteLine($"{e} * {f} = {e * f}");
        }
        public void Dividir(int g, int h){
            Console.WriteLine($"{g} / {h} = {g / h}");
        }
        public void Potencia(int i, int j){
            //classe que contém vários metódos matemáticos (Math)
            double potencia = Math.Pow(i, j);
            Console.WriteLine($"{i} ^ {j} = {potencia}");
        }
        public void Seno(double angulo){
            double radiano = angulo * Math.PI / 180;
            double seno = Math.Sin(angulo);
            Console.WriteLine($"Seno de {angulo} = {Math.Round(seno, 4)} "); //para errendodar o resultado
        }
        public void Coseno(double angulo){
            double radiano = angulo * Math.PI / 180;
            double conseno = Math.Cos(angulo);
            Console.WriteLine($"Conseno de {angulo} = {conseno}");
        }
        public void Tangente(double angulo){
            double radiano = angulo * Math.PI / 180;
            double tangente = Math.Sin(angulo);
            Console.WriteLine($"Tangente de {angulo} = {tangente}");
        }

    public void RaizQuadrada(double k){
        double raizQuadrada = Math.Sqrt(k);
        Console.WriteLine($"A raiz quadrade de {k} é {raizQuadrada}");
    }
        
    }
}