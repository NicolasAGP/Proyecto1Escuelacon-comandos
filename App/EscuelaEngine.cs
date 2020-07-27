using System;
using System.Collections.Generic;
using System.Linq;
using CoreEscuela.Entidades;

namespace CoreEscuela.Entidades
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

            CargarCursos();
            CargarAsignaturas();
            Cargarevaluaciones();
        }

        private void Cargarevaluaciones()
        {
         
        }

        private void CargarAsignaturas()
        {
        

            foreach (var curso in Escuela.Cursos)
            {
             // var lol = new Asignatura();
             // string n;
             // n = lol.Nombre; 
          
              
              var ListaAsignaturas = new List<Asignatura>(){
                    new Asignatura{Nombre="Matematica"},
                    new Asignatura{Nombre="Lenguaje"},
                    new Asignatura{Nombre="Castellano"},
                    new Asignatura{Nombre="Ciencias Naturales"},

              };
              curso.Asignaturas = ListaAsignaturas;             

            }
        }

        private List<Alumno> GenerarAlumnosAlAzar( int cantidad)
        {

          String[] nombre1 = {"Nicolas","Camila","Eusebio","Juan"};
          String[] Apellido1 = {"Gonzalez","Escalona","Pradas","Santiago"};
          String[] nombre2 = {"Ferddy","Anabell","Ricky","Morty"};
          
          var ListAlumno = from n1 in nombre1
                            from n2 in nombre2
                            from a1 in Apellido1
                            select new Alumno{Nombre=$"{n1} {n2} {a1}"};
            
          
            return ListAlumno.OrderBy((al)=> al.UniqueId ).Take(cantidad).ToList();
        }

        private void CargarCursos()
        {
            Escuela.Cursos = new List<Curso>(){
                new Curso(){ Nombre = "101", Jornada = TiposJornada.mañana },
                new Curso(){ Nombre = "201", Jornada = TiposJornada.mañana },
                new Curso(){ Nombre = "401", Jornada = TiposJornada.tarde },
                new Curso(){ Nombre = "501", Jornada = TiposJornada.tarde },
                new Curso{ Nombre = "301", Jornada = TiposJornada.mañana   }
            };
 
          Random rnd = new Random();
            
            foreach(var c in Escuela.Cursos)
            {
              int cantidadRandom = rnd.Next(5, 20);
              c.Alumonos = GenerarAlumnosAlAzar(cantidadRandom);

            }
        }
    }
}