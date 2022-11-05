using System.Data;
using System.Data.OleDb;
using System.Collections.Generic;
using System.Linq;
using System;
using System.Reflection;

namespace Datos
{
    public class Comando : ConexionBD
    {
        private DataTable _tabla = new DataTable();
        private OleDbDataAdapter DA = new OleDbDataAdapter();
        public Comando(string Sql)
        {
            try
            {
                OleDbConnection Conexion = Conectar();
                DA.Dispose();
                DA = new OleDbDataAdapter(Sql, Conexion);
                _tabla = new DataTable();
                DA.Fill(_tabla);
                Desconectar(Conexion);
            }
            catch
            {
                throw;
            }
        }

        public DataTable Tabla
        {
            get => _tabla;
        }

    }
}
