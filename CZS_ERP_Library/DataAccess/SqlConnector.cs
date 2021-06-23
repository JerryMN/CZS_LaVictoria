using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using CZS_ERP_Library.Models;
using Dapper;

namespace CZS_ERP_Library.DataAccess
{
    public class SqlConnector : IDataConnection
    {
        const string ConnectionString = "Server=czsystems.database.windows.net;Database=escobaslavictoria;User Id=czsystems_escobaslavictoria;Password=n392JusjX6;";

        public bool ProveedorCreate(ProveedorModel model)
        {
            using (IDbConnection connection = new SqlConnection(ConnectionString))
            {
                var p = new DynamicParameters();
                p.Add("@Nombre", model.Nombre);
                p.Add("@Teléfono", model.Telefono);
                p.Add("@Correo", model.Correo);
                p.Add("@Dirección", model.Direccion);
                p.Add("@Responsable", model.Responsable);
                p.Add("@id", 0, DbType.Int32, ParameterDirection.Output);

                try
                {
                    connection.Execute("dbo.spProvider_Insert", p, commandType: CommandType.StoredProcedure);
                    return true;
                }
                catch (Exception)
                {
                    Debug.Assert(false);
                    return false;
                }
            }
        }

        public List<ProveedorModel> ProveedorGetAll()
        {
            using (IDbConnection connection = new SqlConnection(ConnectionString))
            {
                List<ProveedorModel> output;
                try
                {
                    output = connection.Query<ProveedorModel>("dbo.spProvider_GetAll").ToList();
                }
                catch (Exception)
                {
                    return null;
                }

                return output;
            }
        }

        public bool ProveedorUpdate(ProveedorModel model)
        {
            using (IDbConnection connection = new SqlConnection(ConnectionString))
            {
                var p = new DynamicParameters();
                p.Add("@Nombre", model.Nombre);
                p.Add("@Teléfono", model.Telefono);
                p.Add("@Correo", model.Correo);
                p.Add("@Dirección", model.Direccion);
                p.Add("@Responsable", model.Responsable);
                p.Add("@id", model.IdProvider);

                try
                {
                    connection.Execute("dbo.spProvider_Update", p, commandType: CommandType.StoredProcedure);
                    return true;
                }
                catch (Exception)
                {
                    Debug.Assert(false);
                    return false;
                }
            }
        }

        public bool ProveedorDelete(ProveedorModel model)
        {
            using (IDbConnection connection = new SqlConnection(ConnectionString))
            {
                var p = new DynamicParameters();
                p.Add("@id", model.IdProvider);

                try
                {
                    connection.Execute("dbo.spProvider_Delete", p, commandType: CommandType.StoredProcedure);
                    return true;
                }
                catch (Exception)
                {
                    Debug.Assert(false);
                    return false;
                }
            }
        }
    }
}
