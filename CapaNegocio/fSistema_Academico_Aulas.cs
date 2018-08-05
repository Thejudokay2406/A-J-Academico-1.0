using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDatos;

namespace CapaNegocio
{
    public class fSistema_Academico_Aulas
    {
        public static string Guardar_DatosBasicos
            (//Datos Basicos
            string auto, string Aula, string capacidad, string curso, string año, string estado, string descripcion)
        {
            Conexion_Sistema_Aula Obj = new Conexion_Sistema_Aula();
            //Datos Basicos
            Obj.Aula = Aula;
            Obj.Capacidad = capacidad;
            Obj.Curso = curso;
            Obj.Año = año;
            Obj.Estado = estado;
            Obj.Descrípcion = descripcion;
            Obj.Auto = auto;

            return Obj.Guardar_DatosBasicos(Obj);
        }
    }
}
