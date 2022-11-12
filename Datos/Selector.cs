using System.Data;

namespace Datos
{
    public class Selector
    {
        private string Sql = "";
        private DataTable _resultado;

        private void Ejecutar(string Sql)
        {
            Comando Cmd = new Comando(Sql);
            _resultado = Cmd.Tabla;
        }
        public void Registrar(string Usuario, string Contrasena, string Nombre, string Apellido)
        {
            Sql = "INSERT INTO Login (Usuario, Contrasena, Nombre, Apellido) VALUES ('" + Usuario + "', '" + Contrasena + "', '" + Nombre + "', '" + Apellido + "')";
            Ejecutar(Sql);
        }
        public void VerificarUsuario(string Usuario)
        {
            Sql = "SELECT Usuario FROM Login WHERE Usuario = '" + Usuario + "'";
            Ejecutar(Sql);
        }
        public void Login(string Usuario, string Contrasena)
        {
            Sql = "SELECT Usuario FROM Login WHERE Usuario = '" + Usuario + "' AND Contrasena = '" + Contrasena + "'";
            Ejecutar(Sql);
        }
        public void RecibirInfo(string Usuario)
        {
            Sql = "SELECT Usuario, Nombre, Apellido FROM Login WHERE Usuario = '" + Usuario + "'";
            Ejecutar(Sql);
        }
        public void LeerFaltas(string Nombre, string Apellido)
        {
            Sql = "SELECT Faltas FROM Alumnos WHERE Nombre = '" + Nombre + "' AND Apellido = '" + Apellido + "'";
            Ejecutar(Sql);
        }
        public void ConseguirTodo()
        {
            Sql = "SELECT Nombre, Apellido, Faltas FROM Alumnos";
            Ejecutar(Sql);
        }
        public void SumarFaltas(string Nombre, string Apellido)
        {
            Sql = "UPDATE Alumnos SET Faltas = Faltas+1 WHERE Nombre = '" + Nombre + "' AND Apellido = '" + Apellido + "'";
            Ejecutar(Sql);
        }
        public void RestarFaltas(string Nombre, string Apellido)
        {
            Sql = "UPDATE Alumnos SET Faltas = Faltas-1 WHERE Nombre = '" + Nombre + "' AND Apellido = '" + Apellido + "'";
            Ejecutar(Sql);
        }
        public void AgregarAlumno(string Nombre, string Apellido)
        {
            Sql = "INSERT INTO Alumnos (Nombre, Apellido, Faltas) VALUES ('" + Nombre + "', '" + Apellido + "', 0)";
            Ejecutar(Sql);
        }
        public void SacarAlumno(string Nombre, string Apellido)
        {
            Sql = "DELETE FROM Alumnos WHERE Nombre = '" + Nombre + "' AND Apellido = '" + Apellido + "'";
            Ejecutar(Sql);
        }
        public DataTable Resultado
        {
            get { return _resultado; }
        }


    }
}
