using System;
using System.Runtime.InteropServices;

namespace Tarea2Eje1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int opcion = 0;

            do
            {
                Console.WriteLine("1- ejercicio 1");
                Console.WriteLine("2- ejercicio 2");
                Console.WriteLine("3- ejercicio 3");
                Console.WriteLine("4- Salir");
                opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        Ejercicio1();
                        Console.Clear();
                        break;
                    case 2:
                        Ejercicio2();
                        Console.Clear();
                        break;
                    case 3:
                        Ejercicio3();
                        Console.Clear();
                        break;

                    default:
                        Console.WriteLine("Opcion incorrecta");
                        break;
                }
            } while (opcion != 4);
        }
      
        public static void Ejercicio1() //Ejercicio 1
        {
            float precio = 0;
            int cantidad = 0;
            float total = 0;

            Console.WriteLine("Ejercicio 1");
            Console.Write("Cual es el precio de las camisas? ");
            precio = float.Parse(Console.ReadLine());
            Console.Write("Cual es la cantidad de camisas? ");
            cantidad = int.Parse(Console.ReadLine());

            if (cantidad == 1)
            {
                total = precio;
                Console.WriteLine($"El precio de la camisa es: {total}");

            }
            else if (cantidad >= 2 && cantidad <= 5)
            {
                total = (cantidad *precio) * 0.15f;
                total = (cantidad * precio) - total;
                Console.WriteLine($"El precio de la camisa es: {total} con descuento del 15%");
            }
            else if (cantidad >= 6)
            {
                total = (cantidad * precio) * 0.20f;
                total = (cantidad * precio) - total;
                Console.WriteLine($"El precio de la camisa es: {total} con descuento del 20%");
            }

            Console.ReadLine();
        }
        public static void Ejercicio2() //Ejercicio 2
        {
            String carnet = "";
            String nombre = "";
            float quiz1, quiz2, quiz3 = 0f;
            float tarea1, tarea2, tarea3 = 0f;
            float examen1, examen2, examen3 = 0f;
            float examenT, quizT, tareaT, promedio= 0f;
            String condicion = "";

            Console.WriteLine ("Digite su carnet:");
            carnet = Console.ReadLine ();
            Console.WriteLine("Digite su nombre:");
            nombre = Console.ReadLine();
            Console.WriteLine("Digite la nota del quiz 1:");
            quiz1 = float.Parse (Console.ReadLine());
            Console.WriteLine("Digite la nota del quiz 2:");
            quiz2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite la nota del quiz 3:");
            quiz3 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite la nota de la tarea 1:");
            tarea1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite la nota de la tarea 2:");
            tarea2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite la nota de la tarea 3:");
            tarea3 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite la nota del Examen 1:");
            examen1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite la nota del Examen 2:");
            examen2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite la nota del Examen 3:");
            examen3 = float.Parse(Console.ReadLine());

            quizT = ((((quiz1 + quiz2 + quiz3)/3) *25) /100);
            tareaT = ((((tarea1 + tarea2 + tarea3) / 3) * 30) / 100);
            examenT = ((((examen1 + examen2 + examen3) / 3) * 45) / 100);
            promedio = quizT + tareaT + examenT;

            if (promedio >= 70)
            {
                condicion = "Aprobado";
            } else if (promedio >= 50 && promedio <= 70)
            {
                condicion = "Aplazado";
            } else if (promedio < 50)
            {
                condicion = "Reprobado";
            }

            Console.WriteLine($"El carnet es: {carnet}");
            Console.WriteLine($"El nombre es: {nombre}");
            Console.WriteLine($"La nota de los quices es: {quizT}");
            Console.WriteLine($"La nota de las tareas es: {tareaT}");
            Console.WriteLine($"La nota de los examenes es: {examenT}");
            Console.WriteLine($"La nota total es de: {promedio}");
            Console.WriteLine($"La condicion es: {condicion}");

            Console.ReadLine(); 
        }
        public static void Ejercicio3() //Ejercicio 3
        {
            int cantidad = 0;
            int total = 0;

            Console.WriteLine("Digite la cantidad de productos");
            cantidad = int.Parse( Console.ReadLine() );
            if ( cantidad <= 10 )
            {
                total = cantidad * 20;
                Console.WriteLine($"El precio es de $20 por producto el total es: {total}");

            }else if ( cantidad > 10)
            {
                total = cantidad * 15;
                Console.WriteLine($"El precio es de $15 por producto el total es: {total}");
            }
            Console.ReadLine() ;

        }

        
       
    }
}
