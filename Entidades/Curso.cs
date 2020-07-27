using System;
using System.Collections.Generic;

namespace CoreEscuela.Entidades
{
    public class Curso
    {
        
        public string UniqueId {get; private set;}

        public string Nombre {get; set;}

        public TiposJornada Jornada {get; set;}

        public List<Asignatura> Asignaturas {get;set;}

        public List<Alumno> Alumonos {get;set;}
        public Asignatura Asignatura {get; set;}

        public float Nota {get; set;}

        

        public Curso()=> UniqueId = Guid.NewGuid().ToString();
            
        }

    //prueba

    }
