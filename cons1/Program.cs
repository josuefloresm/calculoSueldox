using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sueldo
{
    class Program
    {
        public static void Main(string[] args)
        {

            
            int horaTS = 0;
            double valorH = 0, horaFS = 0;
            int mes;
            int ano;
            double rut;
            string nombres;
            string apellidos;
           // int prevision;
            double anticipos, descuentos, bonos;
            Double sueldo, ingresos;

            Console.WriteLine("Horas trabajadas en dias de semana: ");
            horaTS = int.Parse(Console.ReadLine());

            Console.WriteLine("Horas trabajadas en fin de semana: ");
            horaFS = int.Parse(Console.ReadLine());

            Console.WriteLine("Valor por hora: ");
            valorH = int.Parse(Console.ReadLine());

            Console.WriteLine("Mes: (solo nros)");
            mes = int.Parse(Console.ReadLine());

            Console.WriteLine("Año: ");
            ano = int.Parse(Console.ReadLine());

            Console.WriteLine("RUT: (sin guión)"); //validar largo
            rut = int.Parse(Console.ReadLine());

            Console.WriteLine("Nombres: ");
            nombres = Console.ReadLine();

            Console.WriteLine("Apellidos: ");
            apellidos = Console.ReadLine();
       
            Console.WriteLine("Prevision social: 1.- Fonasa, 2.- ISAPRE");
            string str = Console.ReadLine();
            int prevision = 0;
            
            
            switch(str)
            {
                case "1":
                case "Fonasa":
                    prevision = 10000; //ingresos * 0.07;
                    break;
                case "2":
                case "ISAPRE":
                    prevision = 35000;
                    break;


            }


            //prevision = int.Parse(Console.ReadLine());

            Console.WriteLine("Anticipos otorgados: ");
            anticipos = int.Parse(Console.ReadLine());

            Console.WriteLine("Descuentos: ");
            descuentos = int.Parse(Console.ReadLine());

            Console.WriteLine("Bonos: ");
            bonos = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("LIQUIDACION DE SUELDO");
            Console.WriteLine();
            Console.WriteLine("Nombres: " + nombres);
            Console.WriteLine("Apellidos: " + apellidos);
            Console.WriteLine("RUT: " + rut);
            Console.WriteLine("Previsión Social: $" + prevision);
            Console.WriteLine("Horas trabajas en semana: " + horaTS + " horas");
            Console.WriteLine("Horas trabajas en fin de semana: " + horaFS + " horas");
            Console.WriteLine("Valor por hora: $ " + valorH);
            Console.WriteLine("Bonos: $ " + bonos);
            Console.WriteLine("Descuentos: $ " + descuentos);
            Console.WriteLine("Anticipos otorgados: $ " + anticipos);
            Console.WriteLine();
                                ingresos = (horaTS * valorH) + (horaFS * (valorH * 1.5));
                                sueldo =  ingresos + bonos - descuentos - anticipos - prevision;
            Console.WriteLine("Sueldo + $ " + sueldo);
            Console.WriteLine();
            Console.WriteLine("Pulse cualquier tecla para salir");
            Console.ReadKey();

        }
    }
}