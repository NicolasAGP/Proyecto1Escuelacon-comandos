using System;
using System.Collections.Generic;
using CoreEscuela.Entidades;
using CoreEscuele;
using static System.Console;

namespace Etapa1
{
    class Program
    {
        static void Main(string[] args)
        {

            var engine = new EscuelaEngine();
            engine.Inicializar();
              /*   escuela.Cursos.AddRange(prueb);
                 ImprimirCursosEscuela(escuela);

                 escuela.Cursos.RemoveAll(delegate(Curso cur)
                 {
                     return cur.Nombre == "301";      }
                 );

                escuela.Cursos.RemoveAll((Curso cur) => cur.Jornada == TiposJornada.mañana);

                */ 
                 WriteLine("============");
                 ImprimirCursosEscuela(engine.Escuela);
            
                 
         
        }

       

        private static void ImprimirCursosEscuela(Escuela escuela)
        {
            WriteLine("====================");
            WriteLine("Cursos de la escuela");
            WriteLine("====================");
              
            if(escuela?.Cursos != null){
                
            foreach(var curso in escuela.Cursos)
            {
            WriteLine($"Nombre {curso.Nombre}, Id {curso.UniqueId}"); 
            }
            }
        }

       
        
    }
}


