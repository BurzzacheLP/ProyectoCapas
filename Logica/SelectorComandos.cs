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
        private DataTable _resultado;
        public void Consulta(string Consulta, string Arg1 = "", string Arg2 = "", string Arg3 = "", string Arg4 = "")
        {
            Selector Ejecutar = new Selector();
            if (Consulta == "Registrar")
            {
                Ejecutar.Registrar(Arg1, Arg2, Arg3, Arg4);
            }
            else if (Consulta == "VerificarUsuario")
            {
                Ejecutar.VerificarUsuario(Arg1);
            }
            else if (Consulta == "Login")
            {
                Ejecutar.Login(Arg1, Arg2);
            }
            else if (Consulta == "RecibirInfo")
            {
                Ejecutar.RecibirInfo(Arg1);
            }
            else if (Consulta == "ConseguirTodo")
            {
                Ejecutar.ConseguirTodo();
            }
            else if (Consulta == "LeerFaltas")
            {
                Ejecutar.LeerFaltas(Arg1, Arg2);
            }
            else if (Consulta == "SumarFaltas")
            {
                Ejecutar.SumarFaltas(Arg1, Arg2);
            }
            else if (Consulta == "RestarFaltas")
            {
                Ejecutar.RestarFaltas(Arg1, Arg2);
            }
            else if (Consulta == "AgregarAlumno")
            {
                Ejecutar.AgregarAlumno(Arg1, Arg2);
            }
            else if (Consulta == "SacarAlumno")
            {
                Ejecutar.SacarAlumno(Arg1, Arg2);
            }
            _resultado = Ejecutar.Resultado;
        }

        public DataTable Resultado
        {
            get { return _resultado; }
        }

    }
}