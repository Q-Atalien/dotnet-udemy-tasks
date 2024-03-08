//using Curso;
//using System;
//using System.Globalization;

//namespace curso
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {

//            Triangulo x, y;

//            x = new Triangulo();
//            y = new Triangulo();

//            Console.WriteLine("Entre com as medidas do triângulo X:");
//            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
//            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
//            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
//            Console.WriteLine("Entre com as medidas do triângulo Y:");
//            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
//            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
//            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
//            AreaMaior(x, y);

//            Console.WriteLine("Numero soma 1:");
//            int a = int.Parse(Console.ReadLine());
//            Console.WriteLine("Numero soma 2:");
//            int b = int.Parse(Console.ReadLine());
//            Console.WriteLine("Soma: " + Soma(a, b));

//            Console.WriteLine("digite o raio");
//            double raio = double.Parse(Console.ReadLine());
//            Console.WriteLine("Area :" + Area(raio));

//            Console.WriteLine("Digite tres numeros, e separe eles com espaço");
//            string[] tresNumeros = Console.ReadLine().Split();

//            Console.WriteLine($"numero maior: " + NumeroMaior(tresNumeros));

//        }

//        static int Soma(int a, int b)
//        {
//            return a + b;
//        }

//        static double Area(double raio)
//        {
//            double pi = 3.14159;
//            double raioAoQuadrado = raio * raio;
//            return pi * raioAoQuadrado;
//        }

//        static int NumeroMaior(string[] tresNumeros)
//        {
//            int[] vetNumeros = new int[tresNumeros.Length];

//            Console.WriteLine("Seus numeros digitados " + string.Join(", ", tresNumeros));

//            for (int i = 0; i < tresNumeros.Length; i++)
//            {
//                vetNumeros[i] = int.Parse(tresNumeros[i]);
//            }


//            int numeroMaior = 0;

//            for (int i = 0; i < vetNumeros.Length; i++)
//            {

//                if (vetNumeros[i] > numeroMaior)
//                {
//                    numeroMaior = vetNumeros[i];
//                }
//            }

//            return numeroMaior;

//        }

//        static void AreaMaior(Triangulo x, Triangulo y){

//            double xs = x.AreaMaior();
//            double yps = y.AreaMaior();

//            Console.WriteLine("Área de X = " + x.AreaMaior());
//            Console.WriteLine("Área de Y = " + y.AreaMaior());
//            if (xs > yps)
//            {
//                Console.WriteLine("Maior área: X");
//            }
//            else
//            {
//                Console.WriteLine("Maior área: Y");
//            }
//        }
//    }
//}
