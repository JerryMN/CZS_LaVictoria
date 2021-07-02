using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using CZS_LaVictoria_Library.Models;
using Dapper;

namespace CZS_LaVictoria_Library.DataAccess
{
    public class SqlConnector : IDataConnection
    {
        const string ConnectionString = "Server=czsystems.database.windows.net;Database=escobaslavictoria;User Id=czsystems_escobaslavictoria;Password=Prye2uikg4;";

        #region Area
        public bool Area_Create(AreaModel model)
        {
            using (IDbConnection connection = new SqlConnection(ConnectionString))
            {
                var p = new DynamicParameters();
                p.Add("@Area", model.Area);
                p.Add("@Responsable", model.Responsable);

                try
                {
                    connection.Execute("dbo.spAreas_Insert", p, commandType: CommandType.StoredProcedure);
                    return true;
                }
                catch (Exception)
                {
                    Debug.Assert(false);
                    return false;
                }
            }
        }

        public bool Area_Update(AreaModel model)
        {
            using (IDbConnection connection = new SqlConnection(ConnectionString))
            {
                var p = new DynamicParameters();
                p.Add("@Area", model.Area);
                p.Add("@Responsable", model.Responsable);
                p.Add("@idArea", model.IdArea);

                try
                {
                    connection.Execute("dbo.spAreas_Update", p, commandType: CommandType.StoredProcedure);
                    return true;
                }
                catch (Exception)
                {
                    Debug.Assert(false);
                    return false;
                }
            }
        }

        public List<AreaModel> Area_GetAll()
        {
            using (IDbConnection connection = new SqlConnection(ConnectionString))
            {
                try
                {
                    var output = connection.Query<AreaModel>("dbo.spAreas_GetAll").ToList();
                    return output;
                }
                catch (Exception)
                {
                    Debug.Assert(false);
                    return null;
                }
            }
        }

        public AreaModel Area_GetByArea(AreaModel model)
        {
            using (IDbConnection connection = new SqlConnection(ConnectionString))
            {
                var p = new DynamicParameters();
                p.Add("@Area", model.Area);

                try
                {
                    var output = connection.ExecuteScalar<AreaModel>("dbo.spAreas_GetByArea");
                    return output;
                }
                catch (Exception)
                {
                    Debug.Assert(false);
                    return null;
                }
            }
        }

        public bool Area_Delete(AreaModel model)
        {
            using (IDbConnection connection = new SqlConnection(ConnectionString))
            {
                var p = new DynamicParameters();
                p.Add("@IdArea", model.IdArea);

                try
                {
                    connection.Execute("dbo.spAreas_Delete");
                    return true;
                }
                catch (Exception)
                {
                    Debug.Assert(false);
                    return false;
                }
            }
        }

        #endregion

        #region Proveedor

        public bool Proveedor_Create(ProveedorModel model)
        {
            using (IDbConnection connection = new SqlConnection(ConnectionString))
            {
                var p = new DynamicParameters();
                p.Add("@Nombre", model.Nombre);
                p.Add("@Teléfono", model.Teléfono);
                p.Add("@Correo", model.Correo);
                p.Add("@Dirección", model.Dirección);
                p.Add("@Responsable", model.Responsable);
                p.Add("@Condiciones", model.Condiciones);
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

        public List<ProveedorModel> Proveedor_GetAll()
        {
            using (IDbConnection connection = new SqlConnection(ConnectionString))
            {
                List<ProveedorModel> output;
                try
                {
                    output = connection.Query<ProveedorModel>("dbo.spProvider_GetAll").ToList();
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.ToString());
                    Debug.Assert(false);
                    return null;
                }

                return output;
            }
        }

        public bool Proveedor_Update(ProveedorModel model)
        {
            using (IDbConnection connection = new SqlConnection(ConnectionString))
            {
                var p = new DynamicParameters();
                p.Add("@Nombre", model.Nombre);
                p.Add("@Teléfono", model.Teléfono);
                p.Add("@Correo", model.Correo);
                p.Add("@Dirección", model.Dirección);
                p.Add("@Responsable", model.Responsable);
                p.Add("@Condiciones", model.Condiciones);
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

        public bool Proveedor_Delete(ProveedorModel model)
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

        public List<ProveedorCondicionesModel> ProveedorCondiciones_GetDistinct()
        {
            using (IDbConnection connection = new SqlConnection(ConnectionString))
            {
                try
                {
                    var output = connection.Query<ProveedorCondicionesModel>("dbo.spProvider_Condiciones_GetDistinct").ToList();
                    return output;
                }
                catch (Exception)
                {
                    Debug.Assert(false);
                    return null;
                }
            }
        }

        #endregion

        #region ProveedorProducto

        public bool ProveedorProducto_Create(ProveedorProductoModel model, ProveedorModel proveedor)
        {
            using (IDbConnection connection = new SqlConnection(ConnectionString))
            {
                var p = new DynamicParameters();
                p.Add("@MaterialExterno", model.MaterialExterno);
                p.Add("@MaterialInterno", model.MaterialInterno);
                p.Add("@PrecioUnitario", model.PrecioUnitario);
                p.Add("@Area", model.Area);
                p.Add("@IdProveedor", proveedor.IdProvider);
                p.Add("@Proveedor", proveedor.Nombre);

                try
                {
                    connection.Execute("dbo.spProviderProduct_Insert", p, commandType: CommandType.StoredProcedure);
                    return true;
                }
                catch (Exception)
                {
                    Debug.Assert(false);
                    return false;
                }
            }
        }

        public bool ProveedorProducto_Update(ProveedorProductoModel model)
        {
            using (IDbConnection connection = new SqlConnection(ConnectionString))
            {
                var p = new DynamicParameters();
                p.Add("@MaterialExterno", model.MaterialExterno);
                p.Add("@MaterialInterno", model.MaterialInterno);
                p.Add("@PrecioUnitario", model.PrecioUnitario);
                p.Add("@Area", model.Area);
                p.Add("@IdProducto", model.IdProviderProduct);

                try
                {
                    connection.Execute("dbo.spProviderProduct_Update", p, commandType: CommandType.StoredProcedure);
                    return true;
                }
                catch (Exception)
                {
                    Debug.Assert(false);
                    return false;
                }
            }
        }

        public List<ProveedorProductoModel> ProveedorProducto_GetAll()
        {
            using (IDbConnection connection = new SqlConnection(ConnectionString))
            {
                List<ProveedorProductoModel> output;
                try
                {
                    output = connection.Query<ProveedorProductoModel>("dbo.spProviderProduct_GetAll").ToList();
                }
                catch (Exception)
                {
                    Debug.Assert(false);
                    return null;
                }
                return output;
            }
        }

        public List<ProveedorProductoModel> ProveedorProducto_GetByProveedorArea(int idProveedor, string area)
        {
            using (IDbConnection connection = new SqlConnection(ConnectionString))
            {
                var p = new DynamicParameters();
                p.Add("@IdProvider", idProveedor);
                p.Add("@Area", area);

                List<ProveedorProductoModel> output;
                try
                {
                    output = connection.Query<ProveedorProductoModel>("dbo.spProviderProduct_GetByProviderArea", p, commandType: CommandType.StoredProcedure).ToList();
                }
                catch (Exception)
                {
                    Debug.Assert(false);
                    return null;
                }
                return output;
            }
        }

        public bool ProveedorProducto_Delete(ProveedorProductoModel model)
        {
            using (IDbConnection connection = new SqlConnection(ConnectionString))
            {
                var p = new DynamicParameters();
                p.Add("@id", model.IdProviderProduct);

                try
                {
                    connection.Execute("dbo.spProviderProduct_Delete", p, commandType: CommandType.StoredProcedure);
                    return true;
                }
                catch (Exception)
                {
                    Debug.Assert(false);
                    return false;
                }
            }
        }

        #endregion

        #region Cliente

        public bool Cliente_Create(ClienteModel model)
        {
            using (IDbConnection connection = new SqlConnection(ConnectionString))
            {
                var p = new DynamicParameters();
                p.Add("@Nombre", model.Nombre);
                p.Add("@Atención", model.Atención);
                p.Add("@Correo", model.Correo);
                p.Add("@Teléfono", model.Teléfono);
                p.Add("@TeléfonoDos", model.TeléfonoDos);
                p.Add("@Dirección", model.Dirección);
                p.Add("@Ciudad", model.Ciudad);

                try
                {
                    connection.Execute("dbo.spClient_Insert", p, commandType: CommandType.StoredProcedure);
                    return true;
                }
                catch (Exception)
                {
                    Debug.Assert(false);
                    return false;
                }
            }
        }

        public List<ClienteModel> Cliente_GetAll()
        {
            using (IDbConnection connection = new SqlConnection(ConnectionString))
            {
                List<ClienteModel> output;
                try
                {
                    output = connection.Query<ClienteModel>("dbo.spClient_GetAll").ToList();
                }
                catch (Exception)
                {
                    Debug.Assert(false);
                    return null;
                }

                return output;
            }
        }

        public bool Cliente_Update(ClienteModel model)
        {
            using (IDbConnection connection = new SqlConnection(ConnectionString))
            {
                var p = new DynamicParameters();
                p.Add("@Nombre", model.Nombre);
                p.Add("@Atención", model.Atención);
                p.Add("@Correo", model.Correo);
                p.Add("@Teléfono", model.Teléfono);
                p.Add("@TeléfonoDos", model.TeléfonoDos);
                p.Add("@Dirección", model.Dirección);
                p.Add("@Ciudad", model.Ciudad);
                p.Add("@id", model.IdClient);

                try
                {
                    connection.Execute("dbo.spClient_Update", p, commandType: CommandType.StoredProcedure);
                    return true;
                }
                catch (Exception)
                {
                    Debug.Assert(false);
                    return false;
                }
            }
        }

        public bool Cliente_Delete(ClienteModel model)
        {
            using (IDbConnection connection = new SqlConnection(ConnectionString))
            {
                var p = new DynamicParameters();
                p.Add("@id", model.IdClient);

                try
                {
                    connection.Execute("dbo.spClient_Delete", p, commandType: CommandType.StoredProcedure);
                    return true;
                }
                catch (Exception)
                {
                    Debug.Assert(false);
                    return false;
                }
            }
        }

        public List<ClienteCiudadModel> ClienteCiudad_GetDistinct()
        {
            using (IDbConnection connection = new SqlConnection(ConnectionString))
            {
                try
                {
                    var output = connection.Query<ClienteCiudadModel>("spClient_Ciudad_GetDistinct").ToList();
                    return output;
                }
                catch (Exception)
                {
                    Debug.Assert(false);
                    return null;
                }
            }
        }

        #endregion

        #region ClienteProducto

        public bool ClienteProducto_Create(ClienteProductoModel model, ClienteModel cliente)
        {
            using (IDbConnection connection = new SqlConnection(ConnectionString))
            {
                var p = new DynamicParameters();
                p.Add("@ProductoInterno", model.ProductoInterno);
                p.Add("@PrecioUnitario", model.PrecioUnitario);
                p.Add("@Area", model.Area);
                p.Add("@IdCliente", cliente.IdClient);
                p.Add("@Cliente", cliente.Nombre);

                try
                {
                    connection.Execute("dbo.spClientProduct_Insert", p, commandType: CommandType.StoredProcedure);
                    return true;
                }
                catch (Exception)
                {
                    Debug.Assert(false);
                    return false;
                }
            }
        }

        public bool ClienteProducto_Create(ClienteProductoModel model)
        {
            using (IDbConnection connection = new SqlConnection(ConnectionString))
            {
                var p = new DynamicParameters();
                p.Add("@ProductoInterno", model.ProductoInterno);
                p.Add("@PrecioUnitario", model.PrecioUnitario);
                p.Add("@Area", model.Area);

                try
                {
                    connection.Execute("dbo.spClientProduct_Insert", p, commandType: CommandType.StoredProcedure);
                    return true;
                }
                catch (Exception)
                {
                    Debug.Assert(false);
                    return false;
                }
            }
        }

        public bool ClienteProducto_Update(ClienteProductoModel model)
        {
            using (IDbConnection connection = new SqlConnection(ConnectionString))
            {
                var p = new DynamicParameters();
                p.Add("@ProductoInterno", model.ProductoInterno);
                p.Add("@PrecioUnitario", model.PrecioUnitario);
                p.Add("@Area", model.Area);
                p.Add("@IdProducto", model.IdProduct);

                try
                {
                    connection.Execute("dbo.spClientProduct_Update", p, commandType: CommandType.StoredProcedure);
                    return true;
                }
                catch (Exception)
                {
                    Debug.Assert(false);
                    return false;
                }
            }
        }

        public List<ClienteProductoModel> ClienteProducto_GetAll()
        {
            using (IDbConnection connection = new SqlConnection(ConnectionString))
            {
                List<ClienteProductoModel> output;
                try
                {
                    output = connection.Query<ClienteProductoModel>("dbo.spClientProduct_GetAll").ToList();
                }
                catch (Exception)
                {
                    Debug.Assert(false);
                    return null;
                }
                return output;
            }
        }

        public List<ClienteProductoModel> ClienteProducto_GetByClienteArea(int idCliente, string area)
        {
            using (IDbConnection connection = new SqlConnection(ConnectionString))
            {
                var p = new DynamicParameters();
                p.Add("@IdClient", idCliente);
                p.Add("@Area", area);

                List<ClienteProductoModel> output;
                try
                {
                    output = connection.Query<ClienteProductoModel>("dbo.spClientProduct_GetByProviderArea", p, commandType: CommandType.StoredProcedure).ToList();
                }
                catch (Exception)
                {
                    Debug.Assert(false);
                    return null;
                }
                return output;
            }
        }

        public bool ClienteProducto_Delete(ClienteProductoModel model)
        {
            using (IDbConnection connection = new SqlConnection(ConnectionString))
            {
                var p = new DynamicParameters();
                p.Add("@IdProducto", model.IdProduct);

                try
                {
                    connection.Execute("dbo.spClientProduct_Delete", p, commandType: CommandType.StoredProcedure);
                    return true;
                }
                catch (Exception)
                {
                    Debug.Assert(false);
                    return false;
                }
            }
        }

        #endregion

        #region Materiales

        public bool Material_Create(MaterialModel model)
        {
            using (IDbConnection connection = new SqlConnection(ConnectionString))
            {
                var p = new DynamicParameters();
                p.Add("@Nombre", model.Nombre);
                p.Add("@Area", model.Area);
                p.Add("@Categoría", model.Categoría);
                p.Add("@CantidadDisponible", model.CantidadDisponible);
                p.Add("@peso", model.Peso);

                try
                {
                    connection.Execute("dbo.spStock_Insert", p, commandType: CommandType.StoredProcedure);
                    return true;
                }
                catch (Exception)
                {
                    Debug.Assert(false);
                    return false;
                }
            }
        }

        public List<MaterialModel> Material_GetByAreaCat(string area, string categoría)
        {
            using (IDbConnection connection = new SqlConnection(ConnectionString))
            {
                var p = new DynamicParameters();
                p.Add("@Area", area);
                p.Add("@Categoría", categoría);

                List<MaterialModel> output;
                try
                {
                    output = connection.Query<MaterialModel>("dbo.spStock_GetByAreaCat", p, commandType: CommandType.StoredProcedure).ToList();
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.ToString());
                    Debug.Assert(false);
                    return null;
                }
                return output;
            }
        }

        public List<MaterialModel> Material_GetByCat(string categoría)
        {
            using (IDbConnection connection = new SqlConnection(ConnectionString))
            {
                var p = new DynamicParameters();
                p.Add("@Categoría", categoría);

                List<MaterialModel> output;
                try
                {
                    output = connection.Query<MaterialModel>("dbo.spStock_GetByCat", p, commandType: CommandType.StoredProcedure).ToList();
                }
                catch (Exception)
                {
                    Debug.Assert(false);
                    return null;
                }
                return output;
            }
        }

        public bool Material_Update(MaterialModel model)
        {
            using (IDbConnection connection = new SqlConnection(ConnectionString))
            {
                var p = new DynamicParameters();
                p.Add("@idMaterial", model.IdMaterial);
                p.Add("@CantidadDisponible", model.CantidadDisponible);
                p.Add("@peso", model.Peso);

                try
                {
                    connection.Execute("dbo.spStock_Update", p, commandType: CommandType.StoredProcedure);
                    return true;
                }
                catch (Exception)
                {
                    Debug.Assert(false);
                    return false;
                }
            }
        }

        #endregion

        #region Mezclas

        public bool Mezcla_Create(MezclaModel model)
        {
            using (IDbConnection connection = new SqlConnection(ConnectionString))
            {
                var p = new DynamicParameters();
                p.Add("@Nombre", model.Nombre);
                p.Add("@Cantidad", model.CantidadMezcla);
                p.Add("@IdMezcla", 0, direction: ParameterDirection.Output);

                try
                {
                    connection.Execute("dbo.spMix_Insert", p, commandType: CommandType.StoredProcedure);
                    model.IdMezcla = p.Get<int>("@IdMezcla");

                    var index = 0;
                    foreach (var material in model.Materiales)
                    {
                        p = new DynamicParameters();
                        p.Add("@IdMezcla", model.IdMezcla);
                        p.Add("@IdMaterial", material.IdMaterial);
                        p.Add("@Cantidad", model.Cantidades[index]);
                        try
                        {
                            connection.Execute("dbo.spMixDetails_Insert", p, commandType: CommandType.StoredProcedure);
                            index += 1;
                        }
                        catch (Exception ex)
                        {
                            Debug.WriteLine(ex.ToString());
                            Debug.Assert(false);
                            return false;
                        }
                    }

                    return true;
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.ToString());
                    Debug.Assert(false);
                    return false;
                }
            }
        }

        public List<MezclaModel> Mezcla_GetAll()
        {
            using (IDbConnection connection = new SqlConnection(ConnectionString))
            {
                List<MezclaModel> output;

                try
                {
                    output = connection.Query<MezclaModel>("dbo.spMix_GetAll", commandType: CommandType.StoredProcedure).ToList();

                    foreach (var mezclaModel in output)
                    {
                        var p = new DynamicParameters();
                        p.Add("@idMezcla", mezclaModel.IdMezcla);
                        var idsMat = connection.Query<int>($"SELECT idMaterial FROM MixDetails WHERE idMezcla = {mezclaModel.IdMezcla}").ToList();
                        var cants = connection.Query<double>($"SELECT cantidad FROM MixDetails WHERE idMezcla = {mezclaModel.IdMezcla}").ToList();

                        foreach (var cant in cants)
                        {
                            mezclaModel.Cantidades.Add(cant);
                        }

                        foreach (var id in idsMat)
                        {
                            p = new DynamicParameters();
                            p.Add("@IdMaterial", id);
                            var mats = connection.Query<MaterialModel>("dbo.spStock_GetById", p, commandType: CommandType.StoredProcedure).ToList();
                            mezclaModel.Materiales.Add(mats[0]);
                        }
                    }
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.ToString());
                    Debug.Assert(false);
                    return null;
                }
                return output;
            }
        }

        #endregion
    }
}
