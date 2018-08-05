using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDatos;
using System.Data;

namespace CapaNegocio
{
    public class fSistema_Academico_Jornadas
    {
        public static string Guardar_DatosBasicos
            (//Datos Basicos
            string auto, string jornada, string año, string estado, string descripcion)
        {
            Conexion_Sistema_Jornadas Obj = new Conexion_Sistema_Jornadas();
            //Datos Basicos
            Obj.Auto = auto;
            Obj.Jornada = jornada;
            Obj.Año = año;
            Obj.Estado = estado;
            Obj.Descripcion = descripcion;

            return Obj.Guardar_DatosBasicos(Obj);
        }

        public static DataTable Mostrar()
        {
            return new Conexion_Sistema_Jornadas().Mostrar();
        }

    }
}
