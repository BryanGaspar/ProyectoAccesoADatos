using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace CapaDatos2.clasesMaterias
{
   public static class MateriaDAO
    {
        public static int crear(Materia materia)
        {
            String cadenaConexion = @"server=DESKTOP-9FVCNIV\SQLEXPRESS ; database=Materias; integrated security=true";
            SqlConnection conexion = new SqlConnection(cadenaConexion);

            //operacion sobre bdd
            string sql = "insert into Materias(codMat, nombreMateria, nivel, carrera) values(@codMat, @nombreMateria, @nivel, @carrera)";

            //objeto de clase command
            SqlCommand comando = new SqlCommand(sql, conexion);

            //Parametros
            comando.CommandType = CommandType.Text;
            comando.Parameters.AddWithValue("@codMat", materia.CodMat);
            comando.Parameters.AddWithValue("@nombreMateria", materia.NombreMateria);
            comando.Parameters.AddWithValue("@nivel", materia.Nivel);
            comando.Parameters.AddWithValue("@carrera", materia.Carrera);
           

            //Abiri conexion
            conexion.Open();
            int x = comando.ExecuteNonQuery();
            //cerrar conexion
            conexion.Close();

            return x;
        }
        public static DataTable getAll()
        {
            //1. Definir y configurar la conexión con el motor de BDD

            //Autenticación sql server
            //String cadenaConexion = @" ; database=Estudiantes; user id=sa; pwd=isa";

            //Autenticación con el usuario de windows
            String cadenaConexion = @"server=DESKTOP-9FVCNIV\SQLEXPRESS ; database=Materias; integrated security=true";

            //Objeto tipo conexión para conectarse con el servidor
            SqlConnection conexion = new SqlConnection(cadenaConexion);


            //2. Definir la operación a realizar en el servidor
            //Operación: obtener todos los registros
            // sql(lenguaje estructurado de consultas
            string sql = "select codMat, nombreMateria, nivel, carrera " +
                         "from Materias";

            //definir un adaptador de datos: es un puente que permite pasar datos de la base de datos hacía el datatable
            SqlDataAdapter ad = new SqlDataAdapter(sql, conexion);

            //3. Recuperamos los datos
            DataTable dt = new DataTable();
            ad.Fill(dt); //desde el adaptador paso los datos al datatable

            return dt;

        }
    }
}

