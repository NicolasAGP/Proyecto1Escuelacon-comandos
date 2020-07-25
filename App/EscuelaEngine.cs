using System.Collections.Generic;
using CoreEscuela.Entidades;

namespace CoreEscuele
{
     public class EscuelaEngine
     {
        public EscuelaEngine(Escuela escuela) 
        {
            this.Escuela = escuela;
               
        }
                public Escuela Escuela{get;set;}

         public EscuelaEngine()
             {
              
             }

           public void Inicializar()
{

  Escuela = new Escuela("Camila y nico", 2020, TiposEscuela.Preescolar,
                pais: "Chile", ciudad: "Santiago");

 Escuela.Cursos = new List<Curso>(){
                new Curso(){ Nombre = "101", Jornada = TiposJornada.mañana },
                new Curso(){ Nombre = "201", Jornada = TiposJornada.mañana }, 
                new Curso(){ Nombre = "401", Jornada = TiposJornada.tarde },
                new Curso(){ Nombre = "501", Jornada = TiposJornada.tarde },                 
                new Curso{ Nombre = "301", Jornada = TiposJornada.mañana   }               
            };
               

}

     }
}