using System;
using System.Collections.Generic;
using System.Linq;
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
            //Printer.Beep(1000, cantidad:1);
            //ImprimirCursosEscuela(engine.Escuela);

           // Dictionary<int, string> diccionario = new Dictionary<int, string>();
//
           // diccionario.Add(10, "nico");
           // diccionario.Add(20, "cami");
//
           // foreach (var KeyValPair in diccionario)
           // {
           //     WriteLine($"Key: {KeyValPair.Key} Valor: {KeyValPair.Value}");
           // }


            var lol = engine.GetDiccionarioDeObjetos();
           
          engine.ImpriDiccionario(lol, true);
        
      
      
      
      // parametros de salida, para optener datos
         
         // var Listadeobj = engine.GetObjetoEscel(
         //  out int conteoEvaluaciones,
         //  out int conteoAsignatura,
         //  out int conteoAlumno,
         //  out int conteoCursos
         // );
                             
           // var ListaILugar = from oj in Listadeobj
           //                   where oj is ILugar
           //                   select (ILugar)oj;

             
          
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


