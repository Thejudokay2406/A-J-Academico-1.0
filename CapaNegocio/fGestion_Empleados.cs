using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDatos;
using System.Data;

namespace CapaNegocio
{
    public class fGestion_Empleados
    {
        //Método Insertar que llama al método Insertar de la clase DIngreso
        //de la CapaDatos
        public static string Guardar_DatosBasicos(string auto,int idrol, string codigoid,string estado, string empleado, string profesion, string identificacion, string documento, string expedicion, DateTime fechaexpedicion, string email, string telefono,
            string direccion, DateTime Fechadeingreso, DateTime fechadesalida, DataTable dtDetalles_Experiencia, DataTable dtDetalles_Formacion,
            DataTable dtDetalles_Referencia)
        {
            Conexion_Gestion_Empleados Obj = new Conexion_Gestion_Empleados();
            Obj.Idrol = idrol;
            Obj.CodigoID = codigoid;
            Obj.Empleado = empleado;
            Obj.Profesion = profesion;
            Obj.Identificacion = identificacion;
            Obj.Documento = documento;
            Obj.Expedicion = expedicion;
            Obj.FechaExpedicion = fechaexpedicion;
            Obj.Email = email;
            Obj.Telefono = telefono;
            Obj.Estado = estado;
            Obj.Direccion = direccion;
            Obj.FechaDeIngreso = Fechadeingreso;
            Obj.Fechadesalida = fechadesalida;
            Obj.Auto = auto;

            List<Conexion_Gestion_Experiencias> detalles_Experiencia = new List<Conexion_Gestion_Experiencias>();
            foreach (DataRow row in dtDetalles_Experiencia.Rows)
            {
                Conexion_Gestion_Experiencias detalle_experiencia = new Conexion_Gestion_Experiencias();
                detalle_experiencia.CodigoID = Convert.ToString(row["CodigoID"].ToString());
                detalle_experiencia.Empresa = Convert.ToString(row["Empresa"].ToString());
                detalle_experiencia.Cargo = Convert.ToString(row["Cargo"].ToString());
                detalle_experiencia.Tiempo = Convert.ToString(row["Tiempo"].ToString());

                detalles_Experiencia.Add(detalle_experiencia);
            }

            List<Conexion_Gestion_Formacion> detalles_Formacion = new List<Conexion_Gestion_Formacion>();
            foreach (DataRow row in dtDetalles_Formacion.Rows)
            {
                Conexion_Gestion_Formacion detalle_formacion = new Conexion_Gestion_Formacion();
                detalle_formacion.CodigoID = Convert.ToString(row["CodigoID"].ToString());
                detalle_formacion.Entidad = Convert.ToString(row["Entidad"].ToString());
                detalle_formacion.Carrera = Convert.ToString(row["Carrera"].ToString());
                detalle_formacion.Año = Convert.ToString(row["Año"].ToString());

                detalles_Formacion.Add(detalle_formacion);
            }

            List<Conexion_Gestion_Referencia> detalles_Referencia = new List<Conexion_Gestion_Referencia>();
            foreach (DataRow row in dtDetalles_Referencia.Rows)
            {
                Conexion_Gestion_Referencia detalle_referencia = new Conexion_Gestion_Referencia();
                detalle_referencia.CodigoID = Convert.ToString(row["CodigoID"].ToString());
                detalle_referencia.Referencia = Convert.ToString(row["Referencia"].ToString());
                detalle_referencia.Profesion = Convert.ToString(row["Profesion"].ToString());
                detalle_referencia.Telefono = Convert.ToString(row["Telefono"].ToString());

                detalles_Referencia.Add(detalle_referencia);
            }


            return Obj.Guardar_DatosBasicos(Obj, detalles_Experiencia, detalles_Formacion, detalles_Referencia);
        }

        
    }
}
