using System;

namespace CoreEscuela.Entidades
{
    public class Evaluaciones
    {
     public string UniqueId {get; private set;}

        public string Nombre {get; set;}  

        public Alumno Alumno {get; set;}

        public Evaluaciones()=> UniqueId = Guid.NewGuid().ToString();

    }
}