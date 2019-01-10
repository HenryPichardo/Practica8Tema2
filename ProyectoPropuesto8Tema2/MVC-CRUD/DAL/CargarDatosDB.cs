using MVC_CRUD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_CRUD.DAL
{
    public class CargarDatosDB : System.Data.Entity.DropCreateDatabaseIfModelChanges<EstudianteContext>
    {
        protected override void Seed(EstudianteContext context)
        {
            var Cursos = new List<Curso>
            {
                new Curso{CursoID=1,Descripcion="Programacion",},
                new Curso{CursoID=2,Descripcion="Base de Datos",},
                new Curso{CursoID=3,Descripcion="Redes",}
            };
            Cursos.ForEach(s => context.Cursos.Add(s));
            context.SaveChanges();

            var Estudiantes = new List<Estudiante>
            {
                new Estudiante{Nombres="Juan Carlos",Apellidos="Reyes Jimenez",Fecha_Inscripcion=DateTime.Parse("2001-09-01")},
                new Estudiante{Nombres="Belkys",Apellidos="Sandoval Polanco",Fecha_Inscripcion=DateTime.Parse("2002-10-25")},
                new Estudiante{Nombres="Jean Carlos",Apellidos="Reyes Sandoval",Fecha_Inscripcion=DateTime.Parse("2003-01-16")},
                new Estudiante{Nombres="Josue",Apellidos="Reyes Sandoval",Fecha_Inscripcion=DateTime.Parse("2003-09-15")}
            };
            Estudiantes.ForEach(s => context.Estudiantes.Add(s));
            context.SaveChanges();

            var Inscripciones = new List<Inscripcion>
            {
                new Inscripcion{EstudianteID=1,CursoID=1,Semestre=1},
                new Inscripcion{EstudianteID=2,CursoID=1,Semestre=2},
                new Inscripcion{EstudianteID=3,CursoID=2,Semestre=1},
                new Inscripcion{EstudianteID=4,CursoID=2,Semestre=1}
            };
            Inscripciones.ForEach(s => context.Inscripciones.Add(s));
            context.SaveChanges();

        }
    }
}
