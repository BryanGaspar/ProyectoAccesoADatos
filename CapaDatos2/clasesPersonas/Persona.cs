using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
namespace CapaDatos
{
    public class Persona

    {

        //getter y setter (getter: devolver el valor --hacer un return

        //setter (cambiar el valor del atributos)

        public String Cedula { get; set; }

        public String Apellidos { get; set; }

        public String Nombres { get; set; }

        public String Sexo { get; set; }

        public DateTime FechaNacimiento { get; set; }

        public String Correo { get; set; }
        
        public int Estatura { get; set; }

        public Decimal Peso { get; set; }

        //validaciones

        public static Boolean email_bien_escrito(String email)
        {
            String expresion;
            expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(email, expresion))
            {
                if (Regex.Replace(email, expresion, String.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        public static Boolean cedula_bien_escrito(String cedula)
        {
            String expresion;
            expresion = @"[0-9]{1,9}(\.[0-9]{0,2})?$";
            if (Regex.IsMatch(cedula, expresion))
            {
                if (Regex.Replace(cedula, expresion, String.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        public static Boolean nombre_apellidos_bien_escrito(String letras)
        {
            String expresion;
            expresion = @"[a-zA-ZñÑ\s]";
            if (Regex.IsMatch(letras, expresion))
            {
                if (Regex.Replace(letras, expresion, String.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        public static Boolean ValidaPeso(String peso)
        {
            String expresion;
            expresion = @"^[0-9]+([.|,][0-9]+)?$";
            if (Regex.IsMatch(peso, expresion))
            {
                if (Regex.Replace(peso, expresion, String.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }






    }
}
