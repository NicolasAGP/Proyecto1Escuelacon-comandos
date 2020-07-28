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

           var Listadeobj = engine.GetObjetoEscel();
            
          
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


