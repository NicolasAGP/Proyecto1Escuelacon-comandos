using System;
using CoreEscule.Entidades;

namespace Etapa1
{
    class Program
    {
        static void Main(string[] args)
        {
            var escuela = new Escuela("Camila y nico", 2020, TiposEscuela.Preescolar,
                pais: "Chile", ciudad: "Santiago"
            );

            var arregloCursos = new Curso[3];

            arregloCursos[0] = new Curso()
            {
                Nombre = "101"
            };

            var curso2 = new Curso()
            {

                Nombre = "301"

            };
            arregloCursos[1] = curso2;

            arregloCursos[2] = new Curso
            {

                Nombre = "301"

            };


            Console.WriteLine(escuela);
            System.Console.WriteLine("=======================");
            ImprimirCursosWhile(arregloCursos);
            System.Console.WriteLine("=======================");
            ImprimirCursosDoWhile(arregloCursos);
            System.Console.WriteLine("=======================");
            ImprimirCursosFor(arregloCursos);
            System.Console.WriteLine("=======================");
            ImprimirCursosForEach(arregloCursos);
        }

        private static void ImprimirCursosWhile(Curso[] arregloCursos)
        {
            int ol =0;
            while (ol < arregloCursos.Length)
            {
                Console.WriteLine($"Nombre {arregloCursos[ol].Nombre}, Id {arregloCursos[ol].UniqueId}");
                ol++;
            }

        }


         private static void ImprimirCursosDoWhile(Curso[] arregloCursos)
        {
            int ol =0;
            do 
            {
                Console.WriteLine($"Nombre {arregloCursos[ol].Nombre}, Id {arregloCursos[ol].UniqueId}");
                ol++;
            }while(ol < arregloCursos.Length);

        }

          private static void ImprimirCursosFor(Curso[] arregloCursos)
        {
            
            for (int i = 0; i < arregloCursos.Length; i++)
            {
               Console.WriteLine($"Nombre {arregloCursos[i].Nombre}, Id {arregloCursos[i].UniqueId}"); 
            }
        }


           private static void ImprimirCursosForEach(Curso[] arregloCursos)
        {
            foreach (var cur in arregloCursos)
            {
                Console.WriteLine($"Nombre {cur.Nombre}, Id {cur.UniqueId}"); 
            }

        }
        
    }

}

