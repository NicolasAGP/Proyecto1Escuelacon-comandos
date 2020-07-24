using System;
using System.Collections.Generic;
using CoreEscule.Entidades;
using static System.Console;

namespace Etapa1
{
    class Program
    {
        static void Main(string[] args)
        {
            var escuela = new Escuela("Camila y nico", 2020, TiposEscuela.Preescolar,
                pais: "Chile", ciudad: "Santiago"
            );
            
            escuela.Cursos = new List<Curso>(){
                new Curso(){ Nombre = "101", Jornada = TiposJornada.mañana },
                new Curso(){ Nombre = "201", Jornada = TiposJornada.mañana },              
                new Curso{ Nombre = "301", Jornada = TiposJornada.mañana   }               
            };
          
                 escuela.Cursos.Add(new Curso(){ Nombre="102", Jornada = TiposJornada.tarde});   
                 escuela.Cursos.Add(new Curso(){ Nombre="202", Jornada = TiposJornada.tarde});   

              var prueb = new List<Curso>(){
                new Curso(){ Nombre = "401", Jornada = TiposJornada.mañana },
                new Curso(){ Nombre = "501", Jornada = TiposJornada.mañana },              
                new Curso{ Nombre = "601", Jornada = TiposJornada.mañana   }               
            };
               
              /*   escuela.Cursos.AddRange(prueb);
                 ImprimirCursosEscuela(escuela);

                 escuela.Cursos.RemoveAll(delegate(Curso cur)
                 {
                     return cur.Nombre == "301";      }
                 );

                escuela.Cursos.RemoveAll((Curso cur) => cur.Jornada == TiposJornada.mañana);

                */ 
                 WriteLine("============");
                 ImprimirCursosEscuela(escuela);
                 
         
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


