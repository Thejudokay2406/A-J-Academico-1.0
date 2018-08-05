using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDatos;

namespace CapaNegocio
{
    public class fSistema_Academico_Año
    {
        public static string Guardar_DatosBasicos
            (//Datos Basicos
            string auto, string año, string estado, string descripcion)
        {
            Conexion_Sistema_Año Obj = new Conexion_Sistema_Año();
            //Datos Basicos
            Obj.Auto = auto;
            Obj.Año = año;
            Obj.Estado = estado;
            Obj.Descripcion = descripcion;

            return Obj.Guardar_DatosBasicos(Obj);
        }
    }
}
