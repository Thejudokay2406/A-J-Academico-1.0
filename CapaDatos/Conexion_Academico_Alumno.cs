using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class Conexion_Academico_Alumno
    {
        //Llaves primarias       
        private int _CodigoID;
        private int _IdFamilia;
        private int _IdOrden;
        private string _Auto;
        

        //Datos Basicos
        private string _Nombres;
        private string _Documentos;
        private string _Identificacion;
        private string _Carnet;
        private string _No_Orden;
        private string _Familia;
        private DateTime _FechaDeNacimiento;
        private string _Genero;
        private string _Ciudad;
        private string _Municipio;
        private string _Nacionalidad;
        private string _Becado;
        private string _Direccion;
        private string _Barrio;
        private string _Comuna;
        private string _Estracto;
        private string _Telefono;
        private string _Movil;
        private string _Email;

        //Filtros de Busquda
        private string _Filtro;
        private string _Estado;
        private string _Auto_CodigoID;

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

        public int IdFamilia
        {
            get
            {
                return _IdFamilia;
            }

            set
            {
                _IdFamilia = value;
            }
        }

        public int IdOrden
        {
            get
            {
                return _IdOrden;
            }

            set
            {
                _IdOrden = value;
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

        public string Nombres
        {
            get
            {
                return _Nombres;
            }

            set
            {
                _Nombres = value;
            }
        }

        public string Documentos
        {
            get
            {
                return _Documentos;
            }

            set
            {
                _Documentos = value;
            }
        }

        public string Identificacion
        {
            get
            {
                return _Identificacion;
            }

            set
            {
                _Identificacion = value;
            }
        }

        public string Carnet
        {
            get
            {
                return _Carnet;
            }

            set
            {
                _Carnet = value;
            }
        }

        public string No_Orden
        {
            get
            {
                return _No_Orden;
            }

            set
            {
                _No_Orden = value;
            }
        }

        public string Familia
        {
            get
            {
                return _Familia;
            }

            set
            {
                _Familia = value;
            }
        }

        public DateTime FechaDeNacimiento
        {
            get
            {
                return _FechaDeNacimiento;
            }

            set
            {
                _FechaDeNacimiento = value;
            }
        }

        public string Genero
        {
            get
            {
                return _Genero;
            }

            set
            {
                _Genero = value;
            }
        }

        public string Ciudad
        {
            get
            {
                return _Ciudad;
            }

            set
            {
                _Ciudad = value;
            }
        }

        public string Municipio
        {
            get
            {
                return _Municipio;
            }

            set
            {
                _Municipio = value;
            }
        }

        public string Nacionalidad
        {
            get
            {
                return _Nacionalidad;
            }

            set
            {
                _Nacionalidad = value;
            }
        }

        public string Becado
        {
            get
            {
                return _Becado;
            }

            set
            {
                _Becado = value;
            }
        }

        public string Direccion
        {
            get
            {
                return _Direccion;
            }

            set
            {
                _Direccion = value;
            }
        }

        public string Barrio
        {
            get
            {
                return _Barrio;
            }

            set
            {
                _Barrio = value;
            }
        }

        public string Comuna
        {
            get
            {
                return _Comuna;
            }

            set
            {
                _Comuna = value;
            }
        }

        public string Estracto
        {
            get
            {
                return _Estracto;
            }

            set
            {
                _Estracto = value;
            }
        }

        public string Telefono
        {
            get
            {
                return _Telefono;
            }

            set
            {
                _Telefono = value;
            }
        }

        public string Movil
        {
            get
            {
                return _Movil;
            }

            set
            {
                _Movil = value;
            }
        }

        public string Email
        {
            get
            {
                return _Email;
            }

            set
            {
                _Email = value;
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

        public string Auto_CodigoID
        {
            get
            {
                return _Auto_CodigoID;
            }

            set
            {
                _Auto_CodigoID = value;
            }
        }




        //Constructor Vacio
        public Conexion_Academico_Alumno()
        {

        }
        //Constructor con todos los parametros
        public Conexion_Academico_Alumno(
            //Datos Basicos
            int codigoid, int idfamilia, int idorden, string auto,string carnet, string noorden, string nombres,
            string documento, string identificacion, string familia, DateTime fechadenacimiento, string genero, string ciudad, string municipio,
            string nacionalidad, string becado, string direccion, string barrio, string estracto, string comuna, string telefono, string movil, string email,

            //Dato del Padre
            int iddatosdelpadre, string padre, string identificacionpadre, string noidentificacionpadre, string hogarpadre, string direccionpadre, string barriopadre,
            string telefonopadre, string movilpadre, string profesionpadre, string empresapadre,
            string direccionempresapadre, string telefonoempresapadre, string estadocivilpadre, string emailpadre, string retiropadre, string informacionpadre,

            //Datos de la Madre
            int iddatosdelamadre, string madre, string identificacionmadre, string noidentificacionmadre, string hogarmadre, string direccionmadre, string barriomadre,
            string telefonomadre, string movilmadre, string profesionmadre, string empresamadre, string direccionempresamadre, string telefonoempresamadre,
            string estadocivilmadre, string emailmadre, string retiromadre, string informacionmadre,

            //Datos del acudiente

            int iddatosdelacudiente, string acudiente, string identificacionacudiente, string noidentificacionacudiente, string parentescoacudiente,
            string direccionacudiente, string telefonoacudiente, string movilacudiente, string emailacudiente, string observacionacudiente,

            //Datos Medicos
            int iddatosmedicos, string gruposanguineo, string eps, string alimentos, string animales, string insectos,
            string medicamentos, string plantas, string otros, string indicaciones,

            //Otros Datos
            int idotros, string institutoanterior, string nombreinstituto, string ultimocurso, string ultimajornada,
            string documento1, string documento2, string documento3, string documento4, string documento5, string documento6, string documento7, string documento8, string documento9,
            string documento10, string documento11, string documento12, string documento13, string documento14, string documento15, string documento16, string documento17, string documento18, string documento19, string documento20,

            //Informacion Academica
            int idinformacion, string cursoacademico, string jornadaacademico, string periodoacademico, string Estadoacademico,
            DateTime fechadeingresoacademico, DateTime fechaderegistroacademico, byte[] Foto,

            //Filtros de Busquda
            string filtro, string auto_codigoid

            )
        {
            //Datos Basicos
            this.CodigoID = codigoid;
            this.Auto_CodigoID = auto_codigoid;
            this.IdFamilia = idfamilia;
            this.IdOrden = idorden;
            this.Auto = auto;
            this.Carnet = carnet;
            this.No_Orden = noorden;
            this.Nombres = nombres;
            this.Documentos = documento;
            this.Identificacion = identificacion;
            this.Familia = familia;
            this.FechaDeNacimiento = fechadenacimiento;
            this.Genero = genero;
            this.Ciudad = ciudad;
            this.Municipio = municipio;
            this.Nacionalidad = nacionalidad;
            this.Becado = becado;
            this.Direccion = direccion;
            this.Barrio = barrio;
            this.Estracto = estracto;
            this.Comuna = comuna;
            this.Telefono = telefono;
            this.Movil = movil;
            this.Email = email;

            //Filtros de Busquda
            this.Filtro = filtro;
        }

        //Metodo Insertar

        public string Guardar_DatosBasicos (Conexion_Academico_Alumno Alumno)
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
                SqlCmd.CommandText = "Academico.AJ_DatosBasicos";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //Comienzo a mandar a la base de datos
                SqlParameter ParIdalumno = new SqlParameter();
                ParIdalumno.ParameterName = "@idalumno";
                ParIdalumno.SqlDbType = SqlDbType.Int;
                ParIdalumno.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParIdalumno);

                SqlParameter ParIdfamilia = new SqlParameter();
                ParIdfamilia.ParameterName = "@Idfamilia";
                ParIdfamilia.SqlDbType = SqlDbType.Int;
                ParIdfamilia.Value = Alumno.IdFamilia;
                SqlCmd.Parameters.Add(ParIdfamilia);

                SqlParameter ParIdOrden = new SqlParameter();
                ParIdOrden.ParameterName = "@Idorden";
                ParIdOrden.SqlDbType = SqlDbType.Int;
                ParIdOrden.Value = Alumno.IdOrden;
                SqlCmd.Parameters.Add(ParIdOrden);

                SqlParameter ParCodigoID = new SqlParameter();
                ParCodigoID.ParameterName = "@CodigoID";
                ParCodigoID.SqlDbType = SqlDbType.VarChar;
                ParCodigoID.Size = 20;
                ParCodigoID.Value = Alumno.Auto_CodigoID;
                SqlCmd.Parameters.Add(ParCodigoID);

                SqlParameter ParAuto = new SqlParameter();
                ParAuto.ParameterName = "@Auto";
                ParAuto.SqlDbType = SqlDbType.VarChar;
                ParAuto.Size = 1;
                ParAuto.Value = Alumno.Auto;
                SqlCmd.Parameters.Add(ParAuto);

                SqlParameter ParNombres = new SqlParameter();
                ParNombres.ParameterName = "@Alumno";
                ParNombres.SqlDbType = SqlDbType.VarChar;
                ParNombres.Size = 50;
                ParNombres.Value = Alumno.Nombres;
                SqlCmd.Parameters.Add(ParNombres);

                SqlParameter ParIdentificacion = new SqlParameter();
                ParIdentificacion.ParameterName = "@Documento";
                ParIdentificacion.SqlDbType = SqlDbType.VarChar;
                ParIdentificacion.Size = 5;
                ParIdentificacion.Value = Alumno.Documentos;
                SqlCmd.Parameters.Add(ParIdentificacion);

                SqlParameter ParNo_Identificacion = new SqlParameter();
                ParNo_Identificacion.ParameterName = "@Identificacion";
                ParNo_Identificacion.SqlDbType = SqlDbType.VarChar;
                ParNo_Identificacion.Size = 20;
                ParNo_Identificacion.Value = Alumno.Identificacion;
                SqlCmd.Parameters.Add(ParNo_Identificacion);

                SqlParameter ParCarnet = new SqlParameter();
                ParCarnet.ParameterName = "@Carnet";
                ParCarnet.SqlDbType = SqlDbType.VarChar;
                ParCarnet.Size = 20;
                ParCarnet.Value = Alumno.Carnet;
                SqlCmd.Parameters.Add(ParCarnet);

                SqlParameter ParOrden = new SqlParameter();
                ParOrden.ParameterName = "@Orden";
                ParOrden.SqlDbType = SqlDbType.VarChar;
                ParOrden.Size = 20;
                ParOrden.Value = Alumno.No_Orden;
                SqlCmd.Parameters.Add(ParOrden);

                SqlParameter ParFamilia = new SqlParameter();
                ParFamilia.ParameterName = "@Familia";
                ParFamilia.SqlDbType = SqlDbType.VarChar;
                ParFamilia.Size = 30;
                ParFamilia.Value = Alumno.Familia;
                SqlCmd.Parameters.Add(ParFamilia);

                SqlParameter ParNacimiento = new SqlParameter();
                ParNacimiento.ParameterName = "@Nacimiento";
                ParNacimiento.SqlDbType = SqlDbType.Date;
                ParNacimiento.Value = Alumno.FechaDeNacimiento;
                SqlCmd.Parameters.Add(ParNacimiento);

                SqlParameter ParGenero = new SqlParameter();
                ParGenero.ParameterName = "@Genero";
                ParGenero.SqlDbType = SqlDbType.VarChar;
                ParGenero.Size = 20;
                ParGenero.Value = Alumno.Genero;
                SqlCmd.Parameters.Add(ParGenero);

                SqlParameter ParCiudad = new SqlParameter();
                ParCiudad.ParameterName = "@Ciudad";
                ParCiudad.SqlDbType = SqlDbType.VarChar;
                ParCiudad.Size = 20;
                ParCiudad.Value = Alumno.Ciudad;
                SqlCmd.Parameters.Add(ParCiudad);

                SqlParameter ParMunicipio = new SqlParameter();
                ParMunicipio.ParameterName = "@Municipio";
                ParMunicipio.SqlDbType = SqlDbType.VarChar;
                ParMunicipio.Size = 20;
                ParMunicipio.Value = Alumno.Municipio;
                SqlCmd.Parameters.Add(ParMunicipio);

                SqlParameter ParNacionalidad = new SqlParameter();
                ParNacionalidad.ParameterName = "@Nacionalidad";
                ParNacionalidad.SqlDbType = SqlDbType.VarChar;
                ParNacionalidad.Size = 20;
                ParNacionalidad.Value = Alumno.Nacionalidad;
                SqlCmd.Parameters.Add(ParNacionalidad);

                SqlParameter ParBecado = new SqlParameter();
                ParBecado.ParameterName = "@Becario";
                ParBecado.SqlDbType = SqlDbType.VarChar;
                ParBecado.Size = 20;
                ParBecado.Value = Alumno.Becado;
                SqlCmd.Parameters.Add(ParBecado);

                SqlParameter ParDireccion = new SqlParameter();
                ParDireccion.ParameterName = "@Direccion";
                ParDireccion.SqlDbType = SqlDbType.VarChar;
                ParDireccion.Size = 50;
                ParDireccion.Value = Alumno.Direccion;
                SqlCmd.Parameters.Add(ParDireccion);

                SqlParameter ParBarrio = new SqlParameter();
                ParBarrio.ParameterName = "@Barrio";
                ParBarrio.SqlDbType = SqlDbType.VarChar;
                ParBarrio.Size = 50;
                ParBarrio.Value = Alumno.Barrio;
                SqlCmd.Parameters.Add(ParBarrio);

                SqlParameter ParComuna = new SqlParameter();
                ParComuna.ParameterName = "@Comuna";
                ParComuna.SqlDbType = SqlDbType.VarChar;
                ParComuna.Size = 10;
                ParComuna.Value = Alumno.Comuna;
                SqlCmd.Parameters.Add(ParComuna);

                SqlParameter ParEstracto = new SqlParameter();
                ParEstracto.ParameterName = "@Estracto";
                ParEstracto.SqlDbType = SqlDbType.VarChar;
                ParEstracto.Size = 10;
                ParEstracto.Value = Alumno.Estracto;
                SqlCmd.Parameters.Add(ParEstracto);

                SqlParameter ParTelefono = new SqlParameter();
                ParTelefono.ParameterName = "@Telefono";
                ParTelefono.SqlDbType = SqlDbType.VarChar;
                ParTelefono.Size = 20;
                ParTelefono.Value = Alumno.Telefono;
                SqlCmd.Parameters.Add(ParTelefono);

                SqlParameter ParMovil = new SqlParameter();
                ParMovil.ParameterName = "@Movil";
                ParMovil.SqlDbType = SqlDbType.VarChar;
                ParMovil.Size = 30;
                ParMovil.Value = Alumno.Movil;
                SqlCmd.Parameters.Add(ParMovil);

                SqlParameter ParEmail = new SqlParameter();
                ParEmail.ParameterName = "@Email";
                ParEmail.SqlDbType = SqlDbType.VarChar;
                ParEmail.Size = 50;
                ParEmail.Value = Alumno.Email;
                SqlCmd.Parameters.Add(ParEmail);

                //Ejecutamos nuestro comando 

                // ejecutamos el envio de datos

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

        public DataTable Examinar_Alumno(Conexion_Academico_Alumno Alumno)
        {
            DataTable DtResultado = new DataTable("Academico.DatosBasicos");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion_BaseDeDatos.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "Academico.CB_PorAlumno";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParTextoBuscar = new SqlParameter();
                ParTextoBuscar.ParameterName = "@Filtro";
                ParTextoBuscar.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar.Size = 50;
                ParTextoBuscar.Value = Alumno.Filtro;
                SqlCmd.Parameters.Add(ParTextoBuscar);

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

        public DataTable Examinar_AlumnoPorCarnet(Conexion_Academico_Alumno Alumno)
        {
            DataTable DtResultado = new DataTable("Academico.DatosBasicos");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion_BaseDeDatos.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "Academico.CB_PorCarnet";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParTextoBuscar = new SqlParameter();
                ParTextoBuscar.ParameterName = "@Filtro";
                ParTextoBuscar.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar.Size = 50;
                ParTextoBuscar.Value = Alumno.Filtro;
                SqlCmd.Parameters.Add(ParTextoBuscar);

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

        
        public DataTable Examinar_AlumnoPorIdentificacion(Conexion_Academico_Alumno Alumno)
        {
            DataTable DtResultado = new DataTable("Academico.DatosBasicos");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion_BaseDeDatos.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "Academico.CB_PorIdentificacion";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParTextoBuscar = new SqlParameter();
                ParTextoBuscar.ParameterName = "@Filtro";
                ParTextoBuscar.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar.Size = 50;
                ParTextoBuscar.Value = Alumno.Filtro;
                SqlCmd.Parameters.Add(ParTextoBuscar);

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
