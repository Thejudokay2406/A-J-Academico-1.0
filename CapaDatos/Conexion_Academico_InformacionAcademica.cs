using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class Conexion_Academico_InformacionAcademica
    {
        //Llaves primarias
        private int _Idinformacionacademica;
        private int _CodigoID;

        //Campos Auxiliares
        private string _Auto;
        private string _Filtro;

        //Informacion Academica
        private string _Curso_Academico;
        private string _Jornada_Academico;
        private string _Periodo_Academico;
        private string _Estado_Academico;
        private DateTime _FechaDeRegistro_Academico;

        private string _UltimoCurso;
        private string _UltimaJornada;
        private string _Instituto;

        private byte[] _Foto;

        public int Idinformacionacademica
        {
            get
            {
                return _Idinformacionacademica;
            }

            set
            {
                _Idinformacionacademica = value;
            }
        }

        public int CodigoID
        {
            get
            {
                return _CodigoID;
            }

            set
            {
                _CodigoID = value;
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

        public string Curso_Academico
        {
            get
            {
                return _Curso_Academico;
            }

            set
            {
                _Curso_Academico = value;
            }
        }

        public string Jornada_Academico
        {
            get
            {
                return _Jornada_Academico;
            }

            set
            {
                _Jornada_Academico = value;
            }
        }

        public string Periodo_Academico
        {
            get
            {
                return _Periodo_Academico;
            }

            set
            {
                _Periodo_Academico = value;
            }
        }

        public string Estado_Academico
        {
            get
            {
                return _Estado_Academico;
            }

            set
            {
                _Estado_Academico = value;
            }
        }

        public DateTime FechaDeRegistro_Academico
        {
            get
            {
                return _FechaDeRegistro_Academico;
            }

            set
            {
                _FechaDeRegistro_Academico = value;
            }
        }

        public string UltimoCurso
        {
            get
            {
                return _UltimoCurso;
            }

            set
            {
                _UltimoCurso = value;
            }
        }

        public string UltimaJornada
        {
            get
            {
                return _UltimaJornada;
            }

            set
            {
                _UltimaJornada = value;
            }
        }

        public string Instituto
        {
            get
            {
                return _Instituto;
            }

            set
            {
                _Instituto = value;
            }
        }

        public byte[] Foto
        {
            get
            {
                return _Foto;
            }

            set
            {
                _Foto = value;
            }
        }



        //Constructor Vacio
        public Conexion_Academico_InformacionAcademica()
        {

        }
        //Constructor con todos los parametros
        public Conexion_Academico_InformacionAcademica(
            
            //Informacion Academica
            int idinformacion, string cursoacademico, string jornadaacademico, string periodoacademico, string Estadoacademico, string ultimocurso, string ultimajornada,
            DateTime fechaderegistroacademico, byte[] Foto, int codigoid,

            //Filtros de Busquda
            string filtro

            )
        {

            //Informacion Academica
            this.CodigoID = codigoid;
            this.Curso_Academico = cursoacademico;
            this.Jornada_Academico = jornadaacademico;
            this.Periodo_Academico = periodoacademico;
            this.Estado_Academico = Estadoacademico;
            this.FechaDeRegistro_Academico = fechaderegistroacademico;
            this.UltimoCurso = ultimocurso;
            this.UltimaJornada = ultimajornada;
            this.Foto = Foto;

            //Filtros de Busquda
            this.Filtro = filtro;
        }

        public string Guardar_InformacionAcademica(Conexion_Academico_InformacionAcademica Alumno)
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
                SqlCmd.CommandText = "Academico.AJ_InformacionAcademica";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //Comienzo a mandar a la base de datos
                SqlParameter ParIdalumno = new SqlParameter();
                ParIdalumno.ParameterName = "@Idinformacion";
                ParIdalumno.SqlDbType = SqlDbType.Int;
                ParIdalumno.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParIdalumno);

                SqlParameter ParCodigoID = new SqlParameter();
                ParCodigoID.ParameterName = "@CodigoID";
                ParCodigoID.SqlDbType = SqlDbType.Int;
                ParCodigoID.Value = Alumno.CodigoID;
                SqlCmd.Parameters.Add(ParCodigoID);

                SqlParameter ParAuto = new SqlParameter();
                ParAuto.ParameterName = "@Auto";
                ParAuto.SqlDbType = SqlDbType.VarChar;
                ParAuto.Size = 1;
                ParAuto.Value = Alumno.Auto;
                SqlCmd.Parameters.Add(ParAuto);

                SqlParameter ParCurso = new SqlParameter();
                ParCurso.ParameterName = "@Curso";
                ParCurso.SqlDbType = SqlDbType.VarChar;
                ParCurso.Size = 20;
                ParCurso.Value = Alumno.Curso_Academico;
                SqlCmd.Parameters.Add(ParCurso);

                SqlParameter ParJornada = new SqlParameter();
                ParJornada.ParameterName = "@Jornada";
                ParJornada.SqlDbType = SqlDbType.VarChar;
                ParJornada.Size = 20;
                ParJornada.Value = Alumno.Jornada_Academico;
                SqlCmd.Parameters.Add(ParJornada);

                SqlParameter ParPeriodo = new SqlParameter();
                ParPeriodo.ParameterName = "@Periodo";
                ParPeriodo.SqlDbType = SqlDbType.VarChar;
                ParPeriodo.Size = 20;
                ParPeriodo.Value = Alumno.Periodo_Academico;
                SqlCmd.Parameters.Add(ParPeriodo);

                SqlParameter ParEstado = new SqlParameter();
                ParEstado.ParameterName = "@Estado";
                ParEstado.SqlDbType = SqlDbType.VarChar;
                ParEstado.Size = 20;
                ParEstado.Value = Alumno.Estado_Academico;
                SqlCmd.Parameters.Add(ParEstado);

                //SqlParameter ParFechaDeIngreso_Academico = new SqlParameter();
                //ParFechaDeIngreso_Academico.ParameterName = "@Ingreso";
                //ParFechaDeIngreso_Academico.SqlDbType = SqlDbType.Date;
                //ParFechaDeIngreso_Academico.Value = Alumno.FechaDeIngreso_Academico;
                //SqlCmd.Parameters.Add(ParFechaDeIngreso_Academico);

                SqlParameter ParFechaDeRegistro_Academico = new SqlParameter();
                ParFechaDeRegistro_Academico.ParameterName = "@Registro";
                ParFechaDeRegistro_Academico.SqlDbType = SqlDbType.Date;
                ParFechaDeRegistro_Academico.Value = Alumno.FechaDeRegistro_Academico;
                SqlCmd.Parameters.Add(ParFechaDeRegistro_Academico);

                //SqlParameter ParObservacion = new SqlParameter();
                //ParObservacion.ParameterName = "@Observacion";
                //ParObservacion.SqlDbType = SqlDbType.VarChar;
                //ParObservacion.Size = 200;
                //ParObservacion.Value = Alumno.Observacion_Academica;
                //SqlCmd.Parameters.Add(ParObservacion);

                SqlParameter ParFoto = new SqlParameter();
                ParFoto.ParameterName = "@Foto";
                ParFoto.SqlDbType = SqlDbType.Image;
                ParFoto.Value = Alumno.Foto;
                SqlCmd.Parameters.Add(ParFoto);


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

    }
}
