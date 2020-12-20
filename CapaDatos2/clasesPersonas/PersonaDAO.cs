using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Data.SqlClient;

namespace CapaDatos
{
    public static class PersonaDAO
    {
        public static int crear(Persona persona)
        {
            String cadenaConexion = @"server=DESKTOP-9FVCNIV\SQLEXPRESS ; database=Estudiantes; integrated security=true";
            SqlConnection conexion = new SqlConnection(cadenaConexion);

            //operacion sobre bdd
            string sql = "insert into Personas(cedula, apellidos, nombres, sexo, fechaNacimiento," +
            "correo, estatura, peso) values(@cedula, @apellidos, @nombres, @sexo, @fechaNacimiento, "+
            "@correo, @estatura, @peso)";
            
            //objeto de clase command
            SqlCommand comando = new SqlCommand(sql, conexion);

            //Parametros
            comando.CommandType = CommandType.Text;
            comando.Parameters.AddWithValue("@cedula", persona.Cedula);
            comando.Parameters.AddWithValue("@apellidos", persona.Apellidos);
            comando.Parameters.AddWithValue("@nombres", persona.Nombres);
            comando.Parameters.AddWithValue("@sexo", persona.Sexo);
            comando.Parameters.AddWithValue("@fechaNacimiento", persona.FechaNacimiento);
            comando.Parameters.AddWithValue("@correo", persona.Correo);
            comando.Parameters.AddWithValue("@estatura", persona.Estatura);
            comando.Parameters.AddWithValue("@peso", persona.Peso);

            //Abiri conexion
            conexion.Open();
            int x = comando.ExecuteNonQuery();
            //cerrar conexion
            conexion.Close();

            return x;
        }   
        public static  DataTable getAll()
        {
            //1. Definir y configurar la conexión con el motor de BDD

            //Autenticación sql server
            //String cadenaConexion = @" ; database=Estudiantes; user id=sa; pwd=isa";

            //Autenticación con el usuario de windows
            String cadenaConexion = @"server=DESKTOP-9FVCNIV\SQLEXPRESS ; database=Estudiantes; integrated security=true";

            //Objeto tipo conexión para conectarse con el servidor
            SqlConnection conexion = new SqlConnection(cadenaConexion);


            //2. Definir la operación a realizar en el servidor
            //Operación: obtener todos los registros
            // sql(lenguaje estructurado de consultas
            string sql = "select cedula, apellidos, nombres, sexo, fechaNacimiento, correo, estatura, peso " +
                         "from Personas";

            //definir un adaptador de datos: es un puente que permite pasar datos de la base de datos hacía el datatable
            SqlDataAdapter ad = new SqlDataAdapter(sql, conexion);

            //3. Recuperamos los datos
            DataTable dt = new DataTable();
            ad.Fill(dt); //desde el adaptador paso los datos al datatable

            return dt;

        }
    }
}
