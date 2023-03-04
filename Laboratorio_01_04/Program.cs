using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_01_04
{
    class Program
    {
        static void Main(string[] args)
        {

            //Func<double, double> reducirDecimales = (num) => return (Math.Truncate(num * 100) / 100);


            // Ejercicio 1

            Console.WriteLine("Ejercicio 1: Operaciones Aritmeticas");
            Console.WriteLine("");

            Console.Write("Ingrese un numero: ");
            int n1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingrese otro numero: ");
            int n2 = Convert.ToInt32(Console.ReadLine());        
            Console.WriteLine("");

            try
            {
                Console.ReadLine();
            }
            catch (Exception)
            {
                Console.Clear();
                Console.WriteLine("Ingrese un valor correcto");
            }
            int suma = n1 + n2;
            int resta = n1 - n2;
            int multiplicacion = n1 * n2;
            double div1 = n1;
            double division = div1 / n2;
            int divOperacion = n1 / n2;
            int resto = n1 % n2;

            Console.WriteLine(n1 + "+" + n2 + "=" + suma);
            Console.WriteLine(n1 + "-" + n2 + "=" + resta);
            Console.WriteLine(n1 + "*" + n2 + "=" + multiplicacion);
            Console.WriteLine(n1 + "/" + n2 + "=" + division);
            Console.WriteLine(n1 + "/" + n2 + "=" + divOperacion);
            Console.WriteLine(n1 + "%" + n2 + "=" + resto);

            Console.WriteLine("");
            Console.WriteLine("Presione ENTER para ver segundo ejercicio");
            Console.ReadKey();
            Console.Clear();

            // Ejercicio 2
            Console.WriteLine("Ejercicio 2: Operaciones Booleanas");
            Console.WriteLine("");

            bool mayorQue = n1 > n2;
            bool menorQue = n1 < n2;
            bool igualQue = n1 == n2;
            string valorBooleano = "";
            string valorBooleano2 = "";
            string valorBooleano3 = "";

            // condicion 1
            if (mayorQue)
            {
                valorBooleano = "Verdadero";
            } else
            {
                valorBooleano = "Falso";
            }
            // condicion 2
            if (menorQue)
            {
                valorBooleano2 = "Verdadero";
            }
            else
            {
                valorBooleano2 = "Falso";
            }

            // condicion 3

            if (igualQue)
            {
                valorBooleano3 = "Verdadero";
            }
            else
            {
                valorBooleano3 = "Falso";
            }

            Console.WriteLine("es " + n1 + " mayor que " + n2 + " ? R// " + valorBooleano);
            Console.WriteLine("es " + n1 + " menor que " + n2 + " ? R// " + valorBooleano2);
            Console.WriteLine("es " + n1 + " igual que " + n2 + " ? R// " + valorBooleano3);

            Console.WriteLine("");
            Console.WriteLine("Presione ENTER para ver tercer ejercicio");
            Console.ReadKey();
            Console.Clear();

            // Ejercicio 3

            Console.WriteLine("Ejercicio 3: Jerarquia de operaciones");
            Console.WriteLine("");

            int a;
            int b;
            int c;

            Console.Write("Ingrese el primer numero a operar: ");
            a = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el segundo numero a operar: ");
            b = int.Parse(Console.ReadLine());        

            Console.Write("Ingrese el tercer numero a operar: ");
            c = int.Parse(Console.ReadLine());
            Console.Clear();

            double aDouble = a;
            double bDouble = b;
            double cDouble = c;

            int primeraOperacion = (a * b) + c;
            int segundaOperacion = (b + c) * a;
            double terceraOperacion = aDouble / (bDouble * cDouble);
            double cuartaOperacion = ((3 * aDouble) + (2 * bDouble)) / Math.Pow(cDouble, 2);

            Console.WriteLine("Resultado");
            Console.WriteLine("");

            Console.WriteLine("a * b + c = " + primeraOperacion);
            Console.WriteLine("a * (b + c) = " + segundaOperacion);
            Console.WriteLine("a / b * c = " + terceraOperacion);
            Console.WriteLine("3*a + 2*b / C^2 = " + cuartaOperacion);

            Console.WriteLine("");
            Console.WriteLine("Presione ENTER para ver " + a + "," + b + "," + c + " de la forma a^2 + bx + c");
            Console.ReadKey();
            Console.Clear();

            // Ejercicio 3 pero con formula de bhaskara

            Console.WriteLine("El resultado de la formula de bhaskara es");
            Console.WriteLine("");

            double determinante = Math.Sqrt(Math.Pow(b, 2) - (4 * a * c));

            if (determinante >= 0 && a != 0)
            {
                double x1 = (-bDouble + determinante) / (2 * a);
                //truncate para reducir decimales
                double x1TwoDecimals = (Math.Truncate(x1 * 100) / 100);

                double x2 = (-bDouble - determinante) / (2 * a);
                double x2TwoDecimals = (Math.Truncate(x2 * 100) / 100);

                Console.WriteLine("X1 = " + x1TwoDecimals);
                Console.WriteLine("X2 = " + x2TwoDecimals);
            }
            else if (determinante < 0 || double.IsNaN(determinante))
            {
               
                Console.WriteLine("ERROR: 202 MATH ERROR. Las raices negativas no pertenecen a los numeros reales");
            }
            else if (a == 0)
            {
                Console.WriteLine("ERROR: 305 MATH ERROR. El valor de 'a' no puede ser 0 para la formula");
            
            }

            Console.ReadLine();

        }
    }
}
