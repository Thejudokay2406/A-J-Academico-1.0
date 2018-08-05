using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDatos;
using System.Data;

namespace CapaNegocio
{
    public class fAcademico_Alumno
    {
        public static string Guardar_DatosBasicos
            (//Datos Basicos
            int idfamilia, string autocodigoid, int idorden, string carnet, string noorden, string nombres,
            string documentos, string identificacion, string familia, DateTime fechadenacimiento, string genero, string ciudad, string municipio,
            string nacionalidad, string becado, string direccion, string barrio, string estracto, string comuna, string telefono, string movil, string email, string auto)
        {
            Conexion_Academico_Alumno Obj = new Conexion_Academico_Alumno();
            //Datos Basicos
            Obj.IdFamilia = idfamilia;
            Obj.Auto_CodigoID = autocodigoid;
            Obj.IdOrden = idorden;
            Obj.Auto = auto;
            Obj.Carnet = carnet;
            Obj.No_Orden = noorden;
            Obj.Nombres = nombres;
            Obj.Documentos = documentos;
            Obj.Identificacion = identificacion;
            Obj.Familia = familia;
            Obj.FechaDeNacimiento = fechadenacimiento;
            Obj.Genero = genero;
            Obj.Ciudad = ciudad;
            Obj.Municipio = municipio;
            Obj.Nacionalidad = nacionalidad;
            Obj.Becado = becado;
            Obj.Direccion = direccion;
            Obj.Barrio = barrio;
            Obj.Estracto = estracto;
            Obj.Comuna = comuna;
            Obj.Telefono = telefono;
            Obj.Movil = movil;
            Obj.Email = email;

            return Obj.Guardar_DatosBasicos(Obj);
        }

        public static string Guardar_DatosDelPadre
            (//Dato del Padre
            string auto, string padre, string identificacionpadre, string noidentificacionpadre, string hogarpadre, string direccionpadre, string barriopadre,
            string telefonopadre, string movilpadre, string profesionpadre, string empresapadre,
            string direccionempresapadre, string telefonoempresapadre, string estadocivilpadre, string emailpadre, string retiropadre, string informacionpadre)
        {
            Conexion_Academico_Padre Obj = new Conexion_Academico_Padre();
            //Datos del padre
            Obj.Auto = auto;
            Obj.Padre = padre;
            Obj.Documento = identificacionpadre;
            Obj.Identificacion = noidentificacionpadre;
            Obj.Hogar = hogarpadre;
            Obj.Direccion = direccionpadre;
            Obj.Barrio = barriopadre;
            Obj.Telefono = telefonopadre;
            Obj.Movil = movilpadre;
            Obj.Profesion = profesionpadre;
            Obj.Empresa = empresapadre;
            Obj.DireccionEmpresa = direccionempresapadre;
            Obj.TelefonoEmpresa = telefonoempresapadre;
            Obj.EstadoCivil = estadocivilpadre;
            Obj.Email = emailpadre;
            Obj.Retiro = retiropadre;
            Obj.Informacion = informacionpadre;

            return Obj.Guardar_Padre(Obj);
        }

        public static string Guardar_DatosDeLaMadre
            (//Datos de la Madre
            string auto, string madre, string identificacionmadre, string noidentificacionmadre, string hogarmadre, string direccionmadre, string barriomadre,
            string telefonomadre, string movilmadre, string profesionmadre, string empresamadre, string direccionempresamadre, string telefonoempresamadre,
            string estadocivilmadre, string emailmadre, string retiromadre, string informacionmadre)
        {
            Conexion_Academico_Madre Obj = new Conexion_Academico_Madre();
            //Datos de la Madre
            Obj.Auto = auto;
            Obj.Madre = madre;
            Obj.Identificacion_Madre = identificacionmadre;
            Obj.No_Identificacion_Madre = noidentificacionmadre;
            Obj.Hogar_Madre = hogarmadre;
            Obj.Direccion_Madre = direccionmadre;
            Obj.Barrio_Madre = barriomadre;
            Obj.Telefono_Madre = telefonomadre;
            Obj.Movil_Madre = movilmadre;
            Obj.Profesion_Madre = profesionmadre;
            Obj.Empresa_Madre = empresamadre;
            Obj.DireccionEmpresa_Madre = direccionempresamadre;
            Obj.TelefonoEmpresa_Madre = telefonoempresamadre;
            Obj.EstadoCivil_Madre = estadocivilmadre;
            Obj.Email_Madre = emailmadre;
            Obj.Retiro_Madre = retiromadre;
            Obj.Informacion_Madre = informacionmadre;

            return Obj.Guardar_Madre(Obj);
        }

        public static string Guardar_DatosDelAcudiente
            (//Datos del acudiente
            string auto, string acudiente, string identificacionacudiente, string noidentificacionacudiente, string parentescoacudiente,
            string direccionacudiente, string telefonoacudiente, string movilacudiente, string emailacudiente, string observacionacudiente)
        {
            Conexion_Academico_Acudiente Obj = new Conexion_Academico_Acudiente();
            //Datos del Acudiente
            Obj.Auto = auto;
            Obj.Acudiente = acudiente;
            Obj.Documento = identificacionacudiente;
            Obj.Identificacion = noidentificacionacudiente;
            Obj.Parentesco = parentescoacudiente;
            Obj.Direccion = direccionacudiente;
            Obj.Telefono = telefonoacudiente;
            Obj.Movil = movilacudiente;
            Obj.Email = emailacudiente;
            Obj.Observacion = observacionacudiente;

            return Obj.Guardar_Acudiente(Obj);
        }

        public static string Guardar_DatosMedicos
            (//Datos Medicos
            string auto, int codigoid, string gruposanguineo, string eps, string alimentos, string animales, string insectos,
            string medicamentos, string plantas, string otros, string indicaciones)
        {
            Conexion_Academico_Salud Obj = new Conexion_Academico_Salud();
            //Datos Medicos
            Obj.Auto = auto;
            Obj.CodigoID = codigoid;
            Obj.GrupoSanguineo = gruposanguineo;
            Obj.Eps = eps;
            Obj.Alimentos = alimentos;
            Obj.Animales = animales;
            Obj.Insectos = insectos;
            Obj.Medicamentos = medicamentos;
            Obj.Plantas = plantas;
            Obj.Otros = otros;
            Obj.Indicaciones = indicaciones;

            return Obj.Guardar_Salud(Obj);
        }

        public static string Guardar_OtrosDatos
            (//Otros Datos
            string auto, string institutoanterior, string nombreinstituto, string ultimocurso, string ultimajornada,
            string documento1, string documento2, string documento3, string documento4, string documento5, string documento6, string documento7, string documento8, string documento9,
            string documento10, string documento11, string documento12, string documento13, string documento14, string documento15, string documento16, string documento17, string documento18, string documento19, string documento20)
        {
            Conexion_Academico_Otros Obj = new Conexion_Academico_Otros();
            //Otros Datos
            Obj.Auto = auto;
            Obj.InstitutoAnterior = institutoanterior;
            Obj.NombreInstituto = nombreinstituto;
            Obj.UltimoCurso = ultimocurso;
            Obj.UltimaJornada = ultimajornada;
            Obj.Documento1 = documento1;
            Obj.Documento2 = documento2;
            Obj.Documento3 = documento3;
            Obj.Documento4 = documento4;
            Obj.Documento5 = documento5;
            Obj.Documento6 = documento6;
            Obj.Documento7 = documento7;
            Obj.Documento8 = documento8;
            Obj.Documento9 = documento9;
            Obj.Documento10 = documento10;
            Obj.Documento11 = documento11;
            Obj.Documento12 = documento12;
            Obj.Documento13 = documento13;
            Obj.Documento14 = documento14;
            Obj.Documento15 = documento15;
            Obj.Documento16 = documento16;
            Obj.Documento17 = documento17;
            Obj.Documento18 = documento18;
            Obj.Documento19 = documento19;
            Obj.Documento20 = documento20;

            return Obj.Guardar_Otros(Obj);
        }

        public static string Guardar_InformacionAcademica(string auto, string cursoacademico, string jornadaacademico, string periodoacademico, string Estadoacademico, DateTime fechadeingresoacademico, DateTime fechaderegistroacademico, byte[] Foto, int codigoid, string observacion)
        {
            Conexion_Academico_InformacionAcademica Obj = new Conexion_Academico_InformacionAcademica();
            //Informacion Academica
            Obj.Auto = auto;
            Obj.Curso_Academico = cursoacademico;
            Obj.Jornada_Academico = jornadaacademico;
            Obj.Periodo_Academico = periodoacademico;
            Obj.Estado_Academico = Estadoacademico;
            Obj.FechaDeIngreso_Academico = fechadeingresoacademico;
            Obj.FechaDeRegistro_Academico = fechaderegistroacademico;
            Obj.Foto = Foto;
            Obj.CodigoID = codigoid;
            Obj.Observacion_Academica = observacion;

            return Obj.Guardar_InformacionAcademica(Obj);
        }

        //public static string FiltroDeBusqueda
        //    (//Filtros de Busquda
        //    string auto, string filtro1, string filtro2, string filtro3, string filtro4, string filtro5)
        //{
        //    Conexion_Academico_Alumno Obj = new Conexion_Academico_Alumno();
        //    //Filtros de Busquda
        //    Obj.Auto = auto;
        //    Obj.Filtro11 = filtro1;
        //    Obj.Filtro21 = filtro2;
        //    Obj.Filtro31 = filtro3;
        //    Obj.Filtro41 = filtro4;
        //    Obj.Filtro51 = filtro5;

        //    return Obj.FiltroDeBusqueda(Obj);
        //}

        public static DataTable Examinar_PorCarnet(string filtro)
        {
            Conexion_Academico_Alumno Obj = new Conexion_Academico_Alumno();
            Obj.Filtro = filtro;
            return Obj.Examinar_AlumnoPorCarnet(Obj);
        }

        public static DataTable Examinar_PorIdentificacion(string filtro)
        {
            Conexion_Academico_Alumno Obj = new Conexion_Academico_Alumno();
            Obj.Filtro = filtro;
            return Obj.Examinar_AlumnoPorIdentificacion(Obj);
        }

        public static DataTable Examinar_PorNombre(string filtro)
        {
            Conexion_Academico_Alumno Obj = new Conexion_Academico_Alumno();
            Obj.Filtro = filtro;
            return Obj.Examinar_Alumno(Obj);
        }

        public static DataTable AutoCompletar_CodigoID()
        {
            return new Conexion_Academico_Alumno().AutoCompletar_CodigoID();
        }

    }
}
