using System;
using System.Collections.Generic;
using System.Linq;
using CoreEscuela.Entidades;
using CoreEscuela.Util;

namespace CoreEscuela.Entidades
{
    public sealed class EscuelaEngine
    {
        public EscuelaEngine(Escuela escuela)
        {
            this.Escuela = escuela;

        }
        public Escuela Escuela { get; set; }


        public EscuelaEngine()
        {


        }
        public void Inicializar()
        {

            Escuela = new Escuela("Camila y nico", 2020, TiposEscuela.Preescolar,
                            pais: "Chile", ciudad: "Santiago");

            CargarCursos();
            CargarAsignaturas();
            CargarEvaluaciones();

        }

        public void ImpriDiccionario(Dictionary<LlaveDiccionario, IEnumerable<ObjetoEscuelaBase>> dic,
                            bool imprEval = false)
        {
            foreach (var obj in dic)
            {
                Printer.WriteTitele(obj.Key.ToString());

                foreach (var Kvp in obj.Value)
                {
                    switch (obj.Key)
                    {
                        case LlaveDiccionario.Evaluación:
                        if (imprEval)
                            Console.WriteLine(Kvp);
                        break;
                        case LlaveDiccionario.Escuela:
                        Console.WriteLine("Escuela: " + Kvp);
                        break;
                        case LlaveDiccionario.Alumno:
                        Console.WriteLine("Alumno :" + Kvp.Nombre);
                        break;
                        case LlaveDiccionario.Cursos:
                        var ctmp = Kvp as Curso;
                        if (ctmp != null)
                        {
                            int counnt = ctmp.Alumonos.Count;
                             Console.WriteLine("Curso :" + Kvp.Nombre + "Cantidad de alumno" + counnt );
                        }

                        break;
                        default:
                        Console.WriteLine(Kvp);
                        break;
                    }
                   


                }
            }

        }
        public Dictionary<LlaveDiccionario, IEnumerable<ObjetoEscuelaBase>> GetDiccionarioDeObjetos()
        {

            var diccionario = new Dictionary<LlaveDiccionario, IEnumerable<ObjetoEscuelaBase>>();
            diccionario.Add(LlaveDiccionario.Escuela, new[] { Escuela });
            diccionario.Add(LlaveDiccionario.Cursos, Escuela.Cursos.Cast<ObjetoEscuelaBase>());
            var listatmp = new List<Evaluación>();
            var listatmpas = new List<Asignatura>();
            var listatmpal = new List<Alumno>();

            foreach (var cur in Escuela.Cursos)
            {

                listatmpas.AddRange(cur.Asignaturas);
                listatmpal.AddRange(cur.Alumonos);

                foreach (var al in cur.Alumonos)
                {

                    listatmp.AddRange(al.Evaluaciones);
                }

            }
            diccionario.Add(LlaveDiccionario.Evaluación, listatmp.Cast<ObjetoEscuelaBase>());
            diccionario.Add(LlaveDiccionario.Asignatura, listatmpas.Cast<ObjetoEscuelaBase>());
            diccionario.Add(LlaveDiccionario.Alumno, listatmpal.Cast<ObjetoEscuelaBase>());
            return diccionario;

        }



        public IReadOnlyList<ObjetoEscuelaBase> GetObjetoEscel(
            bool traeEvaluaciones = true,
            bool traeAlumnos = true,
            bool traeAsignaturas = true,
            bool traeCursos = true

            )
        {
            return GetObjetoEscel(out int dummy, out dummy, out dummy, out dummy);

        }



        public IReadOnlyList<ObjetoEscuelaBase> GetObjetoEscel(
            out int conteoEvaluaciones,
            bool traeEvaluaciones = true,
            bool traeAlumnos = true,
            bool traeAsignaturas = true,
            bool traeCursos = true

            )
        {
            return GetObjetoEscel(out conteoEvaluaciones, out int dummy, out dummy, out dummy);

        }

        public IReadOnlyList<ObjetoEscuelaBase> GetObjetoEscel(
           out int conteoEvaluaciones, out int conteoCursos,
           bool traeEvaluaciones = true,
           bool traeAlumnos = true,
           bool traeAsignaturas = true,
           bool traeCursos = true

           )
        {
            return GetObjetoEscel(out conteoEvaluaciones, out conteoCursos, out int dummy, out dummy);

        }

        public IReadOnlyList<ObjetoEscuelaBase> GetObjetoEscel(
            out int conteoEvaluaciones, out int conteoCursos,
             out int conteoAsignatura,
            bool traeEvaluaciones = true,
            bool traeAlumnos = true,
            bool traeAsignaturas = true,
            bool traeCursos = true

            )
        {
            return GetObjetoEscel(out conteoEvaluaciones, out conteoCursos, out conteoAsignatura, out int dummy);

        }




        public IReadOnlyList<ObjetoEscuelaBase> GetObjetoEscel(
            out int conteoEvaluaciones,
            out int conteoCursos,
            out int conteoAsignatura,
            out int conteoAlumno,
            bool traeEvaluaciones = true,
            bool traeAlumnos = true,
            bool traeAsignaturas = true,
            bool traeCursos = true

            )
        {

            conteoEvaluaciones = conteoAsignatura = conteoAlumno = 0;

            var ListObj = new List<ObjetoEscuelaBase>();
            ListObj.Add(Escuela);

            if (traeCursos)
                ListObj.AddRange(Escuela.Cursos);

            conteoCursos = Escuela.Cursos.Count;
            //integramos un polimorfismo para asiganrle valores a cada objeto
            foreach (var curso in Escuela.Cursos)
            {

                conteoAsignatura += curso.Asignaturas.Count;
                conteoAlumno += curso.Alumonos.Count;


                if (traeAsignaturas)
                    ListObj.AddRange(curso.Asignaturas);

                if (traeAlumnos)
                    ListObj.AddRange(curso.Alumonos);

                if (traeEvaluaciones)
                {
                    foreach (var alumno in curso.Alumonos)
                    {

                        ListObj.AddRange(alumno.Evaluaciones);
                        conteoEvaluaciones += alumno.Evaluaciones.Count;

                    }
                }

            }
            return ListObj.AsReadOnly();
        }



        public List<ObjetoEscuelaBase> GetObjetoEscel()
        {

            var ListObj = new List<ObjetoEscuelaBase>();
            ListObj.Add(Escuela);
            ListObj.AddRange(Escuela.Cursos);


            //integramos un polimorfismo para asiganrle valores a cada objeto

            foreach (var curso in Escuela.Cursos)
            {

                ListObj.AddRange(curso.Asignaturas);
                ListObj.AddRange(curso.Alumonos);
                foreach (var alumno in curso.Alumonos)
                {
                    ListObj.AddRange(alumno.Evaluaciones);

                }
            }

            return ListObj;
        }


        #region carga de clases
        private void CargarEvaluaciones()
        {
            foreach (var curso in Escuela.Cursos)
            {
                foreach (var asignatura in curso.Asignaturas)
                {
                    foreach (var alumno in curso.Alumonos)
                    {
                        var rnd = new Random(System.Environment.TickCount);


                        for (int i = 0; i < 5; i++)
                        {
                            var ev = new Evaluación
                            {
                                Asignatura = asignatura,
                                Nombre = $"{asignatura.Nombre} Ev#{i + 1}",
                                Nota = (float)Math.Round(5 * rnd.NextDouble(), 2),
                                Alumno = alumno
                            };
                            alumno.Evaluaciones.Add(ev);
                        }

                    }


                }
            }

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

        private List<Alumno> GenerarAlumnosAlAzar(int cantidad)
        {

            String[] nombre1 = { "Nicolas", "Camila", "Eusebio", "Juan" };
            String[] Apellido1 = { "Gonzalez", "Escalona", "Pradas", "Santiago" };
            String[] nombre2 = { "Ferddy", "Anabell", "Ricky", "Morty" };

            var ListAlumno = from n1 in nombre1
                             from n2 in nombre2
                             from a1 in Apellido1
                             select new Alumno { Nombre = $"{n1} {n2} {a1}" };


            return ListAlumno.OrderBy((al) => al.UniqueId).Take(cantidad).ToList();
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

            foreach (var c in Escuela.Cursos)
            {
                int cantidadRandom = rnd.Next(5, 20);
                c.Alumonos = GenerarAlumnosAlAzar(cantidadRandom);

            }
        }
    }
    #endregion
}