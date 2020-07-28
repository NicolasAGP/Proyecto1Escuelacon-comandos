using System;
using System.Collections.Generic;
using CoreEscuela.Entidades;
using CoreEscuela.Util;
using static System.Console;

namespace Etapa1
{
    class Program
    {
        static void Main(string[] args)
        {

            var engine = new EscuelaEngine();
            engine.Inicializar();
            Printer.WriteTitele("Curso de la escuela");
            Printer.Beep(10000, cantidad:1);
            ImprimirCursosEscuela(engine.Escuela);

           Printer.DrawLine(20);
           Printer.DrawLine(20);
           Printer.DrawLine(20);
            Printer.WriteTitele("Prueba de polimorfismo");
            var alumnoTest = new Alumno{Nombre = "Clarie UnderWood"};

            Printer.WriteTitele("Alumno");
            WriteLine($"Alumno: {alumnoTest.Nombre}");
            WriteLine($"Alumno: {alumnoTest.UniqueId}");
            WriteLine($"Alumno: {alumnoTest.GetType()}");

            Printer.WriteTitele("Objeto escuela");
            ObjetoEscuelaBase ob = alumnoTest;
            WriteLine($"Alumno: {alumnoTest.Nombre}");
            WriteLine($"Alumno: {alumnoTest.UniqueId}");
            WriteLine($"Alumno: {alumnoTest.GetType()}");
            
            var objDum = new ObjetoEscuelaBase(){Nombre="Camila Preciosa"};
            Printer.WriteTitele("Objeto escuela base");
            WriteLine($"Alumno: {objDum.Nombre}");
            WriteLine($"Alumno: {objDum.UniqueId}");
            WriteLine($"Alumno: {objDum.GetType()}");

            var evaluación = new Evaluación(){Nombre="Evaluacion demath", Nota=5.5f };
               Printer.WriteTitele("Evaluación");
            WriteLine($"Alumno: {evaluación.Nombre}");
            WriteLine($"Alumno: {evaluación.UniqueId}");
            WriteLine($"Alumno: {evaluación.Nota}");
            WriteLine($"Alumno: {alumnoTest.GetType()}");

            //ob = evaluación;
          
            
            if(ob is Alumno)
            {
                Alumno alumnoRecuperado = (Alumno)ob;
                WriteLine(alumnoRecuperado.Nombre + "holaaa");
            }
         Alumno alumnoRecuperado2 = (Alumno)ob;
        }

    
        private static void ImprimirCursosEscuela(Escuela escuela)
        {            
            if(escuela?.Cursos != null){
                
            foreach(var curso in escuela.Cursos)
            {
            WriteLine($"Nombre {curso.Nombre}, Id {curso.UniqueId}"); 
            }
            }
        }

       
        
    }
}


