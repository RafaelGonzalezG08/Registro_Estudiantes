using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Reflection.Metadata.Ecma335;
using System.Configuration;
using System.Security.Cryptography.X509Certificates;
using Microsoft.Data.SqlClient;

namespace Jueves.DAL
{

    // empezamos con la clase de conexion a la base de datos, esta clase se encargara de abrir y cerrar la conexion,
    // ademas de ejecutar los comandos SQL
    public class ConexionDAL
    {
        public SqlConnection conexion = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=dbJueves;
                                          Integrated Security=True;TrustServerCertificate=True;Encrypt=False;");
        public bool Conectar()
        {
            try
            {
                conexion.Open();
                return true;
            }
            catch
            {
                return false;
            }


        }


        // metodo para ejecutar comandos SQL sin retorno de datos, como INSERT, UPDATE, DELETE
        public bool EjecutarComandoSinRetornoDatos(SqlCommand sqlCommand)
        {
            try
            {
                sqlCommand.Connection = this.conexion;
                this.Conectar();
                sqlCommand.ExecuteNonQuery();
                conexion.Close();
                return true;

            }
            // mostramos mensaje si ocurre un error
            catch
            {
                Console.WriteLine("Error al ejecutar el comando al SQL: " + sqlCommand.CommandText);
                return false;
            }
        }


        // metodo para ejecutar comandos SQL con retorno de datos, como SELECT
        public DataSet EjecutarSentencia(SqlCommand sqlcomando)
        {
            DataSet DS = new DataSet();
            SqlDataAdapter Adaptador = new SqlDataAdapter();

            try
            {
                sqlcomando.Connection = this.conexion;
                Adaptador.SelectCommand = sqlcomando;
                this.Conectar();
                Adaptador.Fill(DS);
                conexion.Close();
                return DS;
            }
            catch
            {
                return DS;
            }
        }
    }
}
