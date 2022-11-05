using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using System.Data;

namespace Logica
{
    public class SelectorComandos
    {
        private string Registrar(string Usuario, string Contrasena, string Nombre, string Apellido)
        {
            Sql = "INSERT INTO Login" +
                "VALUES ('" + Usuario + "', '" + Contrasena + "', '" + Nombre + "', '" + Apellido + "', 0)";
            return Sql;
        }
        private string VerificarUsuario(string Usuario, string Contrasena)
        {
            Sql = "SELECT Usuario FROM Login WHERE Usuario = '" + Usuario + "' AND Contrasena = '" + Contrasena + "'";
            return Sql;
        }
        private string RecibirInfo(string Usuario)
        {
            Sql = "SELECT Usuario, Nombre, Apellido FROM Login WHERE Usuario = '" + Usuario + "'";
            return Sql;
        }
        private string LeerFaltas(string Nombre, string Apellido)
        {
            Sql = "SELECT Faltas FROM Alumnos WHERE Nombre = '" + Nombre + "' AND Apellido = '" + Apellido + "'";
            return Sql;
        }
        private string ConseguirTodo()
        {
            Sql = "SELECT Nombre, Apellido, Faltas FROM Alumnos";
            return Sql;
        }
        private string SumarFaltas(string Nombre, string Apellido)
        {
            Sql = "UPDATE Alumnos SET Faltas = Faltas+1 WHERE Nombre = '" + Nombre + "' AND Apellido = '" + Apellido + "'";
            return Sql;
        }
        private string RestarFaltas(string Nombre, string Apellido)
        {
            Sql = "UPDATE Alumnos SET Faltas = Faltas-1 WHERE Nombre = '" + Nombre + "' AND Apellido = '" + Apellido + "'";
            return Sql;
        }

        private string Sql = "";
        private DataTable _resultado;
        public void Consulta(string Consulta, string Arg1 = "", string Arg2 = "", string Arg3 = "", string Arg4 = "")
        {
            if (Consulta == "Registrar")
            {
                Sql = Registrar(Arg1, Arg2, Arg3, Arg4);
            }
            else if (Consulta == "Login")
            {
                Sql = VerificarUsuario(Arg1, Arg2);

            }
            else if (Consulta == "RecibirInfo")
            {
                Sql = RecibirInfo(Arg1);
            }
            else if (Consulta == "ConseguirTodo")
            {
                Sql = ConseguirTodo();
            }
            else if (Consulta == "LeerFaltas")
            {
                Sql = LeerFaltas(Arg1, Arg2);
            }
            else if (Consulta == "SumarFaltas")
            {
                Sql = SumarFaltas(Arg1, Arg2);
            }
            else if (Consulta == "RestarFaltas")
            {
                Sql = RestarFaltas(Arg1, Arg2);
            }
            Comando ObjCmd = new Comando(Sql);
            _resultado = ObjCmd.Tabla;
        }

        public DataTable Resultado
        {
            get => _resultado;
        }

    }
}
