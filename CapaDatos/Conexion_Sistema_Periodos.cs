﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class Conexion_Sistema_Periodos
    {
        private int _Idperiodo;
        private string _Periodo;
        private string _Año;
        private string _Estado;
        private string _Descripcion;

        private string _Auto;
        private string _Filtro;

        public int Idperiodo
        {
            get
            {
                return _Idperiodo;
            }

            set
            {
                _Idperiodo = value;
            }
        }

        public string Periodo
        {
            get
            {
                return _Periodo;
            }

            set
            {
                _Periodo = value;
            }
        }

        public string Año
        {
            get
            {
                return _Año;
            }

            set
            {
                _Año = value;
            }
        }

        public string Estado
        {
            get
            {
                return _Estado;
            }

            set
            {
                _Estado = value;
            }
        }

        public string Descripcion
        {
            get
            {
                return _Descripcion;
            }

            set
            {
                _Descripcion = value;
            }
        }

        public string Auto
        {
            get
            {
                return _Auto;
            }

            set
            {
                _Auto = value;
            }
        }

        public string Filtro
        {
            get
            {
                return _Filtro;
            }

            set
            {
                _Filtro = value;
            }
        }

        public Conexion_Sistema_Periodos()
        {

        }

        //Constructor con todos los parametros
        public Conexion_Sistema_Periodos(string auto, int idperiodo, string periodo, string estado, string año, string descripcion)
        {
            //Datos Basicos
            this.Idperiodo = idperiodo;
            this.Auto = auto;
            this.Periodo = periodo;
            this.Año = año;
            this.Estado = estado;
            this.Descripcion = descripcion;
        }

        //Metodo Insertar

        public string Guardar_DatosBasicos(Conexion_Sistema_Periodos Periodo)
        {
            string rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                //Jalo la conexion de la base de datos 
                SqlCon.ConnectionString = Conexion_BaseDeDatos.Cn;
                SqlCon.Open();

                //Establecer la conexion para mandar a la base de datos
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "Sistema.AJ_Periodos";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //Comienzo a mandar a la base de datos
                SqlParameter ParIdcurso = new SqlParameter();
                ParIdcurso.ParameterName = "@Idperiodo";
                ParIdcurso.SqlDbType = SqlDbType.Int;
                ParIdcurso.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParIdcurso);

                SqlParameter ParPeriodo = new SqlParameter();
                ParPeriodo.ParameterName = "@Periodo";
                ParPeriodo.SqlDbType = SqlDbType.VarChar;
                ParPeriodo.Size = 10;
                ParPeriodo.Value = Periodo.Periodo;
                SqlCmd.Parameters.Add(ParPeriodo);

                SqlParameter ParAuto = new SqlParameter();
                ParAuto.ParameterName = "@Auto";
                ParAuto.SqlDbType = SqlDbType.VarChar;
                ParAuto.Size = 1;
                ParAuto.Value = Periodo.Auto;
                SqlCmd.Parameters.Add(ParAuto);

                SqlParameter ParAño = new SqlParameter();
                ParAño.ParameterName = "@Año";
                ParAño.SqlDbType = SqlDbType.VarChar;
                ParAño.Size = 10;
                ParAño.Value = Periodo.Año;
                SqlCmd.Parameters.Add(ParAño);

                SqlParameter ParEstado = new SqlParameter();
                ParEstado.ParameterName = "@Estado";
                ParEstado.SqlDbType = SqlDbType.VarChar;
                ParEstado.Size = 1;
                ParEstado.Value = Periodo.Estado;
                SqlCmd.Parameters.Add(ParEstado);

                SqlParameter ParDescripcion = new SqlParameter();
                ParDescripcion.ParameterName = "@Descripcion";
                ParDescripcion.SqlDbType = SqlDbType.VarChar;
                ParDescripcion.Size = 200;
                ParDescripcion.Value = Periodo.Descripcion;
                SqlCmd.Parameters.Add(ParDescripcion);

                //ejecutamos el envio de datos

                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "Error al Registrar";
            }
            catch (Exception ex)
            {

                rpta = ex.Message;
            }

            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return rpta;
        }

        public DataTable Mostrar()
        {
            DataTable DtResultado = new DataTable("Sistema.Sistema_Periodos");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion_BaseDeDatos.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "Sistema.Mostrar_Periodo";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);

            }
#pragma warning disable CS0168 // La variable está declarada pero nunca se usa
            catch (Exception ex)
#pragma warning restore CS0168 // La variable está declarada pero nunca se usa
            {

                DtResultado = null;
            }
            return DtResultado;
        }
    }
}

