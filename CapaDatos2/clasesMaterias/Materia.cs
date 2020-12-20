using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace CapaDatos2
{
    public class Materia
    {

        //getter y setter (getter: devolver el valor --hacer un return

        //setter (cambiar el valor del atributos)

        public String CodMat { get; set; }

        public String NombreMateria { get; set; }

        public int Nivel { get; set; }

        public String Carrera { get; set; }

     
        public static Boolean codigoMateria(String codigo)
        {
            String expresion;
            expresion = @"[0-9]{1,9}(\.[0-9]{0,2})?$";
            if (Regex.IsMatch(codigo, expresion))
            {
                if (Regex.Replace(codigo, expresion, String.Empty).Length == 0)
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
        public static Boolean validarNombre(String soloLetras)
        {
            String expresion;
            expresion = @"[a-zA-ZñÑ\s]";
            if (Regex.IsMatch(soloLetras, expresion))
            {
                if (Regex.Replace(soloLetras, expresion, String.Empty).Length == 0)
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
