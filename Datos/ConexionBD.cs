using System.Data.OleDb;

namespace Datos
{
    public class ConexionBD
    {
        private string Codigo = "Provider=Microsoft.ACE.OLEDB.16.0;Data Source=|DataDirectory|Login.accdb";

        public OleDbConnection Conectar()
        {
            OleDbConnection Conexion = new OleDbConnection(Codigo);
            return Conexion;
        }
        public void Desconectar(OleDbConnection _Conexion)
        {
            _Conexion.Close();
        }
    }
}
