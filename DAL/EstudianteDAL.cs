using Jueves.BLL;
using Jueves.DAL;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Jueves.DAL
{

    public abstract class absEstudianteDAL
    {
        ConexionDAL conexion;

        public absEstudianteDAL()
        {
            conexion = new ConexionDAL();
        }

        // metodo abstracto para las operaciones CRUD y poder usar el polimorfismo en las clases hijas
        public abstract bool operacion(EstudianteBLL estudiante);


        public class MostrarResultadoDAL : absEstudianteDAL
        {
            // metodo para obtener los estudiantes desde la base de datos
            public DataSet ObtenerEstudiantes()
            {
                SqlCommand command = new SqlCommand("SELECT * FROM RegEstudiantes");
                return conexion.EjecutarSentencia(command);
            }

            public override bool operacion(EstudianteBLL estudiante) => throw new NotImplementedException();
        }




    }


    // Clase para el boton agregar
    public class AgregarCL : absEstudianteDAL
    {
        ConexionDAL conexion;

        public AgregarCL(ConexionDAL conexionDAL) => conexion = conexionDAL;

        public override bool operacion(EstudianteBLL estudiante)
        {
            SqlCommand sqlCommand = new SqlCommand("INSERT INTO RegEstudiantes (Matricula, Nombre, Apellido, Materia, [Practica 1], [Practica 2], [Practica Final], [Examen 1], [Examen 2], [Examen Final], [Nota Final], Estado) VALUES " +
                                                   "(@matricula, @nombre, @apellido, @materia, @practica1, @practica2, @practicaFinal, @examen1, @examen2, @examenFinal, @NotaFinal, @Estado)");

            sqlCommand.Parameters.AddWithValue("@matricula", estudiante.matricula);
            sqlCommand.Parameters.AddWithValue("@nombre", estudiante.nombre);
            sqlCommand.Parameters.AddWithValue("@apellido", estudiante.apellido);
            sqlCommand.Parameters.AddWithValue("@materia", estudiante.materia);
            sqlCommand.Parameters.AddWithValue("@practica1", estudiante.practica1);
            sqlCommand.Parameters.AddWithValue("@practica2", estudiante.practica2);
            sqlCommand.Parameters.AddWithValue("@practicaFinal", estudiante.practicaFinal);
            sqlCommand.Parameters.AddWithValue("@examen1", estudiante.examen1);
            sqlCommand.Parameters.AddWithValue("@examen2", estudiante.examen2);
            sqlCommand.Parameters.AddWithValue("@examenFinal", estudiante.examenFinal);
            sqlCommand.Parameters.AddWithValue("@NotaFinal", estudiante.NotaFinal);
            sqlCommand.Parameters.AddWithValue("@Estado", estudiante.Estado);

            return conexion.EjecutarComandoSinRetornoDatos(sqlCommand);


        }
    }


    // Clase para el boton consultar
    public class ConsultarCL : absEstudianteDAL
    {
        ConexionDAL conexion;

        public ConsultarCL(ConexionDAL conexionDAL) => conexion = conexionDAL;

        public override bool operacion(EstudianteBLL estudiante)
        {

            ConsultarEstudiante(estudiante);
            return true;
        }
        public DataSet ConsultarEstudiante(EstudianteBLL estudiante)
        {
            SqlCommand sqlCommand = new SqlCommand("SELECT * from RegEstudiantes WHERE matricula = @matricula");
            sqlCommand.Parameters.AddWithValue("@matricula", estudiante.matricula);
            return conexion.EjecutarSentencia(sqlCommand);


        }
    }


    //clase para el boton eliminar
    public class EliminarCL : absEstudianteDAL
    {
        ConexionDAL conexion;
        public EliminarCL(ConexionDAL conexionDAL) => conexion = conexionDAL;
        public override bool operacion(EstudianteBLL estudiante)
        {
            SqlCommand sqlCommand = new SqlCommand("DELETE FROM RegEstudiantes WHERE matricula = @matricula");
            sqlCommand.Parameters.AddWithValue("@matricula", estudiante.matricula);
            return conexion.EjecutarComandoSinRetornoDatos(sqlCommand);
        }




    }

    // clase para el boton modificar
    public class ModificarCL : absEstudianteDAL
    {
        ConexionDAL conexion;
        public ModificarCL(ConexionDAL conexionDAL) => conexion = conexionDAL;
        public override bool operacion(EstudianteBLL estudiante)
        {
            // El comando SQL para actualizar los datos del estudiante en la base de datos
            SqlCommand sqlCommand = new SqlCommand("UPDATE RegEstudiantes SET Nombre = @nombre, Apellido = @apellido, Materia = @materia, [Practica 1] = @practica1, [Practica 2] = @practica2, [Practica Final] = @practicaFinal, [Examen 1] = @examen1, [Examen 2] = @examen2, [Examen Final] = @examenFinal, [Nota Final] = @NotaFinal, Estado = @Estado WHERE Matricula = @matricula");
            sqlCommand.Parameters.AddWithValue("@matricula", estudiante.matricula);
            sqlCommand.Parameters.AddWithValue("@nombre", estudiante.nombre);
            sqlCommand.Parameters.AddWithValue("@apellido", estudiante.apellido);
            sqlCommand.Parameters.AddWithValue("@materia", estudiante.materia);
            sqlCommand.Parameters.AddWithValue("@practica1", estudiante.practica1);
            sqlCommand.Parameters.AddWithValue("@practica2", estudiante.practica2);
            sqlCommand.Parameters.AddWithValue("@practicaFinal", estudiante.practicaFinal);
            sqlCommand.Parameters.AddWithValue("@examen1", estudiante.examen1);
            sqlCommand.Parameters.AddWithValue("@examen2", estudiante.examen2);
            sqlCommand.Parameters.AddWithValue("@examenFinal", estudiante.examenFinal);
            sqlCommand.Parameters.AddWithValue("@NotaFinal", estudiante.NotaFinal);
            sqlCommand.Parameters.AddWithValue("@Estado", estudiante.Estado);
            return conexion.EjecutarComandoSinRetornoDatos(sqlCommand);
        }
    }
}