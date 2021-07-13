using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Transactions;
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
                p.Add("@Area", model.Área);
                p.Add("@Responsable", model.Responsable);
                p.Add("@Correo", model.Correo);

                try
                {
                    connection.Execute("dbo.spAreas_Insert", p, commandType: CommandType.StoredProcedure);
                    return true;
                }
                catch (Exception ex)
                {
                    Debug.Write(ex.ToString());
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
                catch (Exception ex)
                {
                    Debug.Write(ex.ToString());
                    Debug.Assert(false);
                    return null;
                }
            }
        }

        public List<string> Area_GetDistinct()
        {
            using (IDbConnection connection = new SqlConnection(ConnectionString))
            {
                try
                {
                    var output = connection.Query<string>("dbo.spAreas_GetDistinct").ToList();
                    return output;
                }
                catch (Exception ex)
                {
                    Debug.Write(ex.ToString());
                    Debug.Assert(false);
                    return null;
                }
            }
        }

        public List<AreaModel> Area_GetByArea(string area)
        {
            using (IDbConnection connection = new SqlConnection(ConnectionString))
            {
                var p = new DynamicParameters();
                p.Add("@Area", area);

                try
                {
                    var output = connection
                        .Query<AreaModel>("dbo.spAreas_GetByArea", p, commandType: CommandType.StoredProcedure)
                        .ToList();
                    return output;
                }
                catch (Exception ex)
                {
                    Debug.Write(ex.ToString());
                    Debug.Assert(false);
                    return null;
                }
            }
        }

        public bool Area_Update(AreaModel model)
        {
            using (IDbConnection connection = new SqlConnection(ConnectionString))
            {
                var p = new DynamicParameters();
                p.Add("@Area", model.Área);
                p.Add("@Responsable", model.Responsable);
                p.Add("@Correo", model.Correo);
                p.Add("@Id", model.Id);

                try
                {
                    connection.Execute("dbo.spAreas_Update", p, commandType: CommandType.StoredProcedure);
                    return true;
                }
                catch (Exception ex)
                {
                    Debug.Write(ex.ToString());
                    Debug.Assert(false);
                    return false;
                }
            }
        }

        public bool Area_Delete(AreaModel model)
        {
            using (IDbConnection connection = new SqlConnection(ConnectionString))
            {
                var p = new DynamicParameters();
                p.Add("@Id", model.Id);

                try
                {
                    connection.Execute("dbo.spAreas_Delete");
                    return true;
                }
                catch (Exception ex)
                {
                    Debug.Write(ex.ToString());
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

                try
                {
                    connection.Execute("dbo.spSupplier_Insert", p, commandType: CommandType.StoredProcedure);
                    return true;
                }
                catch (Exception ex)
                {
                    Debug.Write(ex.ToString());
                    Debug.Assert(false);
                    return false;
                }
            }
        }

        public List<ProveedorModel> Proveedor_GetAll()
        {
            using (IDbConnection connection = new SqlConnection(ConnectionString))
            {
                try
                {
                    var output = connection.Query<ProveedorModel>("dbo.spSupplier_GetAll").ToList();
                    return output;
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.ToString());
                    Debug.Assert(false);
                    return null;
                }
            }
        }

        public List<string> Proveedor_GetDistinctCondiciones()
        {
            using (IDbConnection connection = new SqlConnection(ConnectionString))
            {
                try
                {
                    var output = connection.Query<string>("dbo.spSupplier_GetDistinctCondiciones").ToList();
                    return output;
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.ToString());
                    Debug.Assert(false);
                    return null;
                }
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
                p.Add("@Id", model.Id);

                try
                {
                    connection.Execute("dbo.spSupplier_Update", p, commandType: CommandType.StoredProcedure);
                    return true;
                }
                catch (Exception ex)
                {
                    Debug.Write(ex.ToString());
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
                p.Add("@Id", model.Id);

                try
                {
                    connection.Execute("dbo.spSupplier_Delete", p, commandType: CommandType.StoredProcedure);
                    return true;
                }
                catch (Exception ex)
                {
                    Debug.Write(ex.ToString());
                    Debug.Assert(false);
                    return false;
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
                p.Add("@Area", model.Área);
                p.Add("@Categoría", model.Categoría);
                p.Add("@IdProveedor", proveedor.Id);
                p.Add("@Proveedor", proveedor.Nombre);

                try
                {
                    connection.Execute("dbo.spSupplierProducts_Insert", p, commandType: CommandType.StoredProcedure);
                    return true;
                }
                catch (Exception ex)
                {
                    Debug.Write(ex.ToString());
                    Debug.Assert(false);
                    return false;
                }
            }
        }

        public List<ProveedorProductoModel> ProveedorProducto_GetAll()
        {
            using (IDbConnection connection = new SqlConnection(ConnectionString))
            {
                try
                {
                    var output = connection.Query<ProveedorProductoModel>("dbo.spSupplierProducts_GetAll").ToList();
                    return output;
                }
                catch (Exception ex)
                {
                    Debug.Write(ex.ToString());
                    Debug.Assert(false);
                    return null;
                }
            }
        }

        public List<ProveedorProductoModel> ProveedorProducto_GetByProveedorArea(int idProveedor, string area)
        {
            using (IDbConnection connection = new SqlConnection(ConnectionString))
            {
                var p = new DynamicParameters();
                p.Add("@IdProveedor", idProveedor);
                p.Add("@Area", area);

                try
                {
                    var output = connection.Query<ProveedorProductoModel>("dbo.spSupplierProducts_GetBySupplierArea", p,
                        commandType: CommandType.StoredProcedure).ToList();
                    return output;
                }
                catch (Exception ex)
                {
                    Debug.Write(ex.ToString());
                    Debug.Assert(false);
                    return null;
                }
            }
        }

        public ProveedorProductoModel ProveedorProducto_Find(string nombreExterno, string proveedor, string area)
        {
            using (IDbConnection connection = new SqlConnection(ConnectionString))
            {
                var p = new DynamicParameters();
                p.Add("@NombreExterno", nombreExterno);
                p.Add("@Proveedor", proveedor);
                p.Add("@Area", area);

                try
                {
                    var output = connection.QuerySingle<ProveedorProductoModel>("dbo.spSupplierProducts_Find", p,
                        commandType: CommandType.StoredProcedure);
                    return output;
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.ToString());
                    Debug.Assert(false);
                    return null;
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
                p.Add("@Id", model.Id);

                try
                {
                    connection.Execute("dbo.spSupplierProducts_Update", p, commandType: CommandType.StoredProcedure);
                    return true;
                }
                catch (Exception ex)
                {
                    Debug.Write(ex.ToString());
                    Debug.Assert(false);
                    return false;
                }
            }
        }

        public bool ProveedorProducto_Delete(ProveedorProductoModel model)
        {
            using (IDbConnection connection = new SqlConnection(ConnectionString))
            {
                var p = new DynamicParameters();
                p.Add("@Id", model.Id);

                try
                {
                    connection.Execute("dbo.spSupplierProducts_Delete", p, commandType: CommandType.StoredProcedure);
                    return true;
                }
                catch (Exception ex)
                {
                    Debug.Write(ex.ToString());
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
                catch (Exception ex)
                {
                    Debug.Write(ex.ToString()); 
                    Debug.Assert(false); 
                    return false;
                }
            }
        }

        public List<ClienteModel> Cliente_GetAll()
        {
            using (IDbConnection connection = new SqlConnection(ConnectionString))
            {
                try
                {
                    var output = connection.Query<ClienteModel>("dbo.spClient_GetAll").ToList();
                    return output;
                }
                catch (Exception ex)
                {
                    Debug.Write(ex.ToString()); 
                    Debug.Assert(false); 
                    return null;
                }

            }
        }

        public List<string> Cliente_GetDistinctCiudades()
        {
            using (IDbConnection connection = new SqlConnection(ConnectionString))
            {
                try
                {
                    var output = connection.Query<string>("spClient_GetDistinctCiudades").ToList();
                    return output;
                }
                catch (Exception ex)
                {
                    Debug.Write(ex.ToString()); 
                    Debug.Assert(false); 
                    return null;
                }
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
                p.Add("@Id", model.Id);

                try
                {
                    connection.Execute("dbo.spClient_Update", p, commandType: CommandType.StoredProcedure);
                    return true;
                }
                catch (Exception ex)
                {
                    Debug.Write(ex.ToString()); 
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
                p.Add("@Id", model.Id);

                try
                {
                    connection.Execute("dbo.spClient_Delete", p, commandType: CommandType.StoredProcedure);
                    return true;
                }
                catch (Exception ex)
                {
                    Debug.Write(ex.ToString()); 
                    Debug.Assert(false); 
                    return false;
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
                p.Add("@Area", model.Área);
                p.Add("@IdCliente", cliente?.Id);
                p.Add("@Cliente", cliente?.Nombre);

                try
                {
                    connection.Execute("dbo.spClientProducts_Insert", p, commandType: CommandType.StoredProcedure);
                    return true;
                }
                catch (Exception ex)
                {
                    Debug.Write(ex.ToString());
                    Debug.Assert(false);
                    return false;
                }
            }
        }

        public List<ClienteProductoModel> ClienteProducto_GetAll()
        {
            using (IDbConnection connection = new SqlConnection(ConnectionString))
            {
                try
                {
                    var output = connection.Query<ClienteProductoModel>("dbo.spClientProducts_GetAll").ToList();
                    return output;
                }
                catch (Exception ex)
                {
                    Debug.Write(ex.ToString());
                    Debug.Assert(false);
                    return null;
                }
            }
        }

        public List<ClienteProductoModel> ClienteProducto_GetByClienteArea(int? idCliente, string area)
        {
            using (IDbConnection connection = new SqlConnection(ConnectionString))
            {
                var p = new DynamicParameters();
                p.Add("@IdClient", idCliente);
                p.Add("@Area", area);

                List<ClienteProductoModel> output;
                try
                {
                    output = connection.Query<ClienteProductoModel>("dbo.spClientProducts_GetByClienteArea", p,
                        commandType: CommandType.StoredProcedure).ToList();
                }
                catch (Exception ex)
                {
                    Debug.Write(ex.ToString()); 
                    Debug.Assert(false); 
                    return null;
                }
                return output;
            }
        }

        public bool ClienteProducto_Update(ClienteProductoModel model)
        {
            using (IDbConnection connection = new SqlConnection(ConnectionString))
            {
                var p = new DynamicParameters();
                p.Add("@ProductoInterno", model.ProductoInterno);
                p.Add("@PrecioUnitario", model.PrecioUnitario);
                p.Add("@Id", model.Id);

                try
                {
                    connection.Execute("dbo.spClientProducts_Update", p, commandType: CommandType.StoredProcedure);
                    return true;
                }
                catch (Exception ex)
                {
                    Debug.Write(ex.ToString());
                    Debug.Assert(false);
                    return false;
                }
            }
        }

        public bool ClienteProducto_Delete(ClienteProductoModel model)
        {
            using (IDbConnection connection = new SqlConnection(ConnectionString))
            {
                var p = new DynamicParameters();
                p.Add("@Id", model.Id);

                try
                {
                    connection.Execute("dbo.spClientProducts_Delete", p, commandType: CommandType.StoredProcedure);
                    return true;
                }
                catch (Exception ex)
                {
                    Debug.Write(ex.ToString());
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
                p.Add("@Area", model.Área);
                p.Add("@Categoría", model.Categoría);
                p.Add("@CantidadDisponible", model.CantidadDisponible);

                try
                {
                    connection.Execute("dbo.spStock_Insert", p, commandType: CommandType.StoredProcedure);
                    return true;
                }
                catch (Exception ex)
                {
                    Debug.Write(ex.ToString());
                    Debug.Assert(false); 
                    return false;
                }
            }
        }

        public List<MaterialModel> Material_GetAll()
        {
            using (IDbConnection connection = new SqlConnection(ConnectionString))
            {
                try
                {
                    var output = connection
                        .Query<MaterialModel>("dbo.spStock_GetAll", commandType: CommandType.StoredProcedure).ToList();
                    return output;
                }
                catch (Exception ex)
                {
                    if (ex.Message == "Sequence contains no elements") return null;
                    Debug.WriteLine(ex.ToString());
                    Debug.Assert(false);
                    return null;
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

                try
                {
                    var output = connection.Query<MaterialModel>("dbo.spStock_GetByAreaCat", p,
                        commandType: CommandType.StoredProcedure).ToList();
                    return output;
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.ToString());
                    Debug.Assert(false);
                    return null;
                }
            }
        }

        public List<MaterialModel> Material_GetByCat(string categoría)
        {
            using (IDbConnection connection = new SqlConnection(ConnectionString))
            {
                var p = new DynamicParameters();
                p.Add("@Categoría", categoría);

                try
                {
                    var output = connection
                        .Query<MaterialModel>("dbo.spStock_GetByCat", p, commandType: CommandType.StoredProcedure)
                        .ToList();
                    return output;
                }
                catch (Exception ex) { Debug.Write(ex.ToString()); Debug.Assert(false); return null; }
            }
        }

        public MaterialModel Material_GetByNombreArea(string nombre, string area)
        {
            using (IDbConnection connection = new SqlConnection(ConnectionString))
            {
                var p = new DynamicParameters();
                p.Add("@Nombre", nombre);
                p.Add("@Area", area);

                try
                {
                    var output =
                        connection.QuerySingle<MaterialModel>("dbo.spStock_GetByNombreArea", p,
                            commandType: CommandType.StoredProcedure);
                    return output;
                }
                catch (Exception ex)
                {
                    if (ex.Message == "Sequence contains no elements") return null;
                    Debug.WriteLine(ex.ToString());
                    Debug.Assert(false);
                    return null;
                }
            }
        }

        public List<string> Material_GetDistinctCategorías()
        {
            using (IDbConnection connection = new SqlConnection(ConnectionString))
            {
                try
                {
                    var output = connection.Query<string>("dbo.spStock_GetDistinctCategorías").ToList();
                    return output;
                }
                catch (Exception ex)
                {
                    if (ex.Message == "Sequence contains no elements") return null;
                    Debug.WriteLine(ex.ToString());
                    Debug.Assert(false);
                    return null;
                }
            }
        }

        public bool Material_Update(MaterialModel model)
        {
            using (IDbConnection connection = new SqlConnection(ConnectionString))
            {
                var p = new DynamicParameters();
                p.Add("@CantidadDisponible", model.CantidadDisponible);
                p.Add("@Id", model.Id);

                try
                {
                    connection.Execute("dbo.spStock_Update", p, commandType: CommandType.StoredProcedure);
                    return true;
                }
                catch (Exception ex)
                {
                    Debug.Write(ex.ToString());
                    Debug.Assert(false);
                    return false;
                }
            }
        }

        public bool Material_Delete(MaterialModel model)
        {
            using (IDbConnection connection = new SqlConnection(ConnectionString))
            {
                var p = new DynamicParameters();
                p.Add("@Id", model.Id);

                try
                {
                    connection.Execute("dbo.spStock_Delete", p, commandType: CommandType.StoredProcedure);
                    return true;
                }
                catch (Exception ex)
                {
                    Debug.Write(ex.ToString());
                    Debug.Assert(false);
                    return false;
                }
            }
        }

        #endregion

        #region Mezclas

        public bool Mezcla_Create(MezclaModel model)
        {
            using (var scope = new TransactionScope())
            using (IDbConnection connection = new SqlConnection(ConnectionString))
            {
                var p = new DynamicParameters();
                p.Add("@Nombre", model.Nombre);
                p.Add("@Cantidad", model.CantidadMezcla);
                p.Add("@Id", 0, direction: ParameterDirection.Output);

                try
                {
                    connection.Execute("dbo.spMix_Insert", p, commandType: CommandType.StoredProcedure);
                    model.Id = p.Get<int>("@Id");

                    var index = 0;
                    foreach (var material in model.Materiales)
                    {
                        p = new DynamicParameters();
                        p.Add("@IdMezcla", model.Id);
                        p.Add("@IdMaterial", material.Id);
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

                    scope.Complete();
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
                try
                {
                    var output = connection
                        .Query<MezclaModel>("dbo.spMix_GetAll", commandType: CommandType.StoredProcedure).ToList();

                    foreach (var mezclaModel in output)
                    {
                        var p = new DynamicParameters();
                        p.Add("@IdMezcla", mezclaModel.Id);

                        var idsMat = connection
                            .Query<int>("dbo.spMixDetails_GetIDs", p, commandType: CommandType.StoredProcedure).ToList();
                        var cants = connection.Query<double>("dbo.spMixDetails_GetCantidades", p,
                            commandType: CommandType.StoredProcedure).ToList();

                        foreach (var cant in cants)
                        {
                            mezclaModel.Cantidades.Add(cant);
                        }

                        foreach (var id in idsMat)
                        {
                            p = new DynamicParameters();
                            p.Add("@Id", id);

                            var mats = connection.QuerySingle<MaterialModel>("dbo.spStock_GetById", p,
                                commandType: CommandType.StoredProcedure);
                            mezclaModel.Materiales.Add(mats);
                        }
                    }

                    return output;
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.ToString());
                    Debug.Assert(false);
                    return null;
                }
            }
        }

        public bool Mezcla_Delete(MezclaModel model)
        {
            using (IDbConnection connection = new SqlConnection(ConnectionString))
            {
                var p = new DynamicParameters();
                p.Add("@Id", model.Id);

                try
                {
                    connection.Execute("dbo.spMix_Delete", p, commandType: CommandType.StoredProcedure);
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

        #endregion

        #region Orden de Compra

        public bool OrdenCompra_Create(OrdenCompraModel model)
        {
            using (var scope = new TransactionScope())
            using (IDbConnection connection = new SqlConnection(ConnectionString))
            {
                var p = new DynamicParameters();
                p.Add("@NumOrden", model.NumOrden);
                p.Add("@TipoOrden", model.TipoOrden);
                p.Add("@Area", model.Area);
                p.Add("@Proveedor", model.Proveedor);
                p.Add("@Condiciones", model.Condiciones);
                p.Add("@FechaOrden", model.FechaOrden);
                p.Add("@Id", 0, direction: ParameterDirection.Output);

                try
                {
                    connection.Execute("dbo.spPurchaseOrder_Insert", p, commandType: CommandType.StoredProcedure);
                    model.Id = p.Get<int>("@Id");

                    foreach (var line in model.Líneas)
                    {
                        p = new DynamicParameters();
                        p.Add("@IdPurchaseOrder", model.Id);
                        p.Add("@NumLinea", line.NumLinea);
                        p.Add("@Producto", line.Producto);
                        p.Add("@CantidadOrden", line.CantidadOrden);
                        p.Add("@CantidadRecibida", line.CantidadRecibida);
                        p.Add("@CantidadPendiente", line.CantidadPendiente);
                        p.Add("@PrecioUnitario", line.PrecioUnitario);
                        p.Add("@Iva", line.Iva);
                        p.Add("@Subtotal", line.Subtotal);
                        p.Add("@FechaEntrega", line.FechaEntrega);
                        p.Add("@Estatus", "Abierta");

                        try
                        {
                            connection.Execute("dbo.spPurchaseOrderDetails_Insert", p,
                                commandType: CommandType.StoredProcedure);
                        }
                        catch (Exception ex)
                        {
                            Debug.Write(ex.ToString());
                            Debug.Assert(false);
                            return false;
                        }
                    }

                    scope.Complete();
                    return true;
                }
                catch (Exception ex)
                {
                    Debug.Write(ex.ToString()); 
                    Debug.Assert(false); 
                    return false;
                }
            }
        }

        public long OrdenCompra_GetLastNumOrden()
        {
            using (IDbConnection connection = new SqlConnection(ConnectionString))
            {
                try
                {
                    var output = connection.ExecuteScalar("dbo.spPurchaseOrder_GetLastNumOrden").ToString();
                    return long.Parse(output);
                }
                catch (NullReferenceException)
                {
                    var year = DateTime.Today.Year.ToString().Substring(2,2);
                    return long.Parse(year + "00000");
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.ToString());
                    Debug.Assert(false);
                    return 0;
                }
            }
        }

        public OrdenCompraModel OrdenCompra_GetByNumOrden(string numOrden)
        {
            using (IDbConnection connection = new SqlConnection(ConnectionString))
            {
                var p = new DynamicParameters();
                p.Add("@NumOrden", numOrden);

                try
                {
                    var output = connection.QuerySingle<OrdenCompraModel>("dbo.spPurchaseOrder_GetByNumOrden", p,
                        commandType: CommandType.StoredProcedure);
                    return output;
                }
                catch (Exception ex)
                {
                    Debug.Write(ex.ToString()); 
                    Debug.Assert(false); 
                    return null;
                }
            }
        }

        public List<OrdenCompraLíneaModel> OrdenCompra_GetLineasByNumOrden(string numOrden)
        {
            using (IDbConnection connection = new SqlConnection(ConnectionString))
            {
                var p = new DynamicParameters();
                p.Add("@NumOrden", long.Parse(numOrden));
                try
                {
                    var output = connection.Query<OrdenCompraLíneaModel>("dbo.spPurchaseOrderDetails_GetByNumOrden", p,
                        commandType: CommandType.StoredProcedure).ToList();
                    return output;
                }
                catch (Exception ex)
                {
                    Debug.Write(ex.ToString()); 
                    Debug.Assert(false); 
                    return null;
                }
            }
        }

        public List<OrdenCompraLíneaModel> OrdenCompra_GetLineasPendientes()
        {
            using (IDbConnection connection = new SqlConnection(ConnectionString))
            {
                try
                {
                    var output = connection.Query<OrdenCompraLíneaModel>("dbo.spPurchaseOrderDetails_GetAllPending",
                        commandType: CommandType.StoredProcedure).ToList();
                    return output;
                }
                catch (Exception ex)
                {
                    Debug.Write(ex.ToString()); 
                    Debug.Assert(false); 
                    return null;
                }
            }
        }

        public List<OrdenCompraLíneaModel> OrdenCompra_GetAllLineas()
        {
            using (IDbConnection connection = new SqlConnection(ConnectionString))
            {
                try
                {
                    var output = connection.Query<OrdenCompraLíneaModel>("dbo.spPurchaseOrderDetails_GetAll",
                        commandType: CommandType.StoredProcedure).ToList();
                    return output;
                }
                catch (Exception ex)
                {
                    Debug.Write(ex.ToString()); 
                    Debug.Assert(false); 
                    return null;
                }
            }
        }

        public bool PurchaseOrderLine_Update(long orderId, OrdenCompraLíneaModel línea, double oldQty, double newQty)
        {
            using (var scope = new TransactionScope())
            using (IDbConnection connection = new SqlConnection(ConnectionString))
            {
                Debug.Assert(línea != null, nameof(línea) + " != null");
                var producto = ProveedorProducto_Find(línea.Producto, línea.Proveedor, línea.Área);
                var material = Material_GetByNombreArea(producto.MaterialInterno, línea.Área);

                var p = new DynamicParameters();
                p.Add("@IdOrden", orderId);
                p.Add("@NumLinea", línea.NumLinea);
                p.Add("@CantidadRecibida", línea.CantidadRecibida);
                p.Add("@CantidadPendiente", línea.CantidadPendiente);
                p.Add("@FechaUltRecepción", línea.FechaUltRecepción);
                p.Add("@FechaCancelación", línea.FechaCancelación);
                p.Add("@Estatus", línea.Estatus);

                try
                {
                    connection.Execute("dbo.spPurchaseOrderDetails_Update", p,
                        commandType: CommandType.StoredProcedure);
                    if (línea.Estatus == "Cancelada")
                    {
                        scope.Complete();
                        return true;
                    }

                    if (material == null)
                    {
                        p = new DynamicParameters();
                        p.Add("@Nombre", producto.MaterialInterno);
                        p.Add("@Area", línea.Área);
                        p.Add("@Categoría", producto.Categoría);
                        p.Add("@CantidadDisponible", línea.CantidadRecibida);

                        try
                        {
                            connection.Execute("dbo.spStock_Insert", p, commandType: CommandType.StoredProcedure);
                        }
                        catch (Exception ex)
                        {
                            Debug.Write(ex.ToString());
                            Debug.Assert(false);
                        }
                    }
                    else
                    {
                        p = new DynamicParameters();
                        p.Add("@CantidadDisponible", material.CantidadDisponible + newQty - oldQty);
                        p.Add("@Id", material.Id);

                        try
                        {
                            connection.Execute("dbo.spStock_Update", p, commandType: CommandType.StoredProcedure);
                        }
                        catch (Exception ex)
                        {
                            Debug.Write(ex.ToString());
                            Debug.Assert(false);
                        }
                    }

                    p = new DynamicParameters();
                    p.Add("@TipoOrden", "C");
                    p.Add("@NumOrden", línea.NumOrden);
                    p.Add("@NumLinea", línea.NumLinea);
                    p.Add("@Producto", línea.Producto);
                    p.Add("@Cantidad", newQty - oldQty);
                    p.Add("@Fecha", línea.FechaUltRecepción);

                    try
                    {
                        connection.Execute("dbo.spDelivery_Insert", p,
                            commandType: CommandType.StoredProcedure);
                    }
                    catch (Exception ex)
                    {
                        Debug.Write(ex.ToString());
                        Debug.Assert(false);
                    }

                    scope.Complete();
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

        #endregion

        #region Orden de Venta

        public bool OrdenVenta_Create(OrdenVentaModel model)
        {
            using (var scope = new TransactionScope())
            using (IDbConnection connection = new SqlConnection(ConnectionString))
            {
                var p = new DynamicParameters();
                p.Add("@NumOrden", model.NumOrden);
                p.Add("@TipoOrden", model.TipoOrden);
                p.Add("@Area", model.Area);
                p.Add("@Cliente", model.Cliente);
                p.Add("@Transporte", model.Transporte);
                p.Add("@PuestoEn", model.PuestoEn);
                p.Add("@Presentación", model.Presentación);
                p.Add("@FechaOrden", model.FechaOrden);
                p.Add("@Id", 0, direction: ParameterDirection.Output);

                try
                {
                    connection.Execute("dbo.spSaleOrder_Insert", p, commandType: CommandType.StoredProcedure);
                    model.Id = p.Get<int>("@Id");

                    foreach (var line in model.Líneas)
                    {
                        p = new DynamicParameters();
                        p.Add("@IdSaleOrder", model.Id);
                        p.Add("@NumLinea", line.NumLinea);
                        p.Add("@Producto", line.Producto);
                        p.Add("@CantidadOrden", line.CantidadOrden);
                        p.Add("@CantidadEntregada", line.CantidadEntregada);
                        p.Add("@CantidadPendiente", line.CantidadPendiente);
                        p.Add("@PrecioUnitario", line.PrecioUnitario);
                        p.Add("@Iva", line.Iva);
                        p.Add("@Subtotal", line.Subtotal);
                        p.Add("@FechaEntrega", line.FechaEntrega);
                        p.Add("@Estatus", "Abierta");

                        try
                        {
                            connection.Execute("dbo.spSaleOrderDetails_Insert", p,
                                commandType: CommandType.StoredProcedure);
                        }
                        catch (Exception ex)
                        {
                            Debug.Write(ex.ToString());
                            Debug.Assert(false);
                            return false;
                        }
                    }

                    scope.Complete();
                    return true;
                }
                catch (Exception ex)
                {
                    Debug.Write(ex.ToString());
                    Debug.Assert(false);
                    return false;
                }
            }
        }

        public long OrdenVenta_GetLastNumOrden()
        {
            using (IDbConnection connection = new SqlConnection(ConnectionString))
            {
                try
                {
                    var output = connection.ExecuteScalar("dbo.spSaleOrder_GetLastNumOrden").ToString();
                    return long.Parse(output);
                }
                catch (NullReferenceException)
                {
                    var year = DateTime.Today.Year.ToString().Substring(2, 3);
                    return long.Parse(year + "00000");
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.ToString());
                    Debug.Assert(false);
                    return 0;
                }
            }
        }

        public OrdenVentaModel OrdenVenta_GetByNumOrden(string numOrden)
        {
            using (IDbConnection connection = new SqlConnection(ConnectionString))
            {
                var p = new DynamicParameters();
                p.Add("@NumOrden", numOrden);

                try
                {
                    var output = connection.QuerySingle<OrdenVentaModel>("dbo.spSaleOrder_GetByNumOrden", p,
                        commandType: CommandType.StoredProcedure);
                    return output;
                }
                catch (Exception ex)
                {
                    Debug.Write(ex.ToString());
                    Debug.Assert(false);
                    return null;
                }
            }
        }

        public List<OrdenVentaLíneaModel> OrdenVenta_GetLineasByNumOrden(string numOrden)
        {
            using (IDbConnection connection = new SqlConnection(ConnectionString))
            {
                var p = new DynamicParameters();
                p.Add("@NumOrden", numOrden);

                try
                {
                    var output = connection.Query<OrdenVentaLíneaModel>("dbo.spSaleOrderDetails_GetByNumOrden", p,
                        commandType: CommandType.StoredProcedure).ToList();
                    return output;
                }
                catch (Exception ex)
                {
                    Debug.Write(ex.ToString());
                    Debug.Assert(false);
                    return null;
                }
            }
        }

        public List<OrdenVentaLíneaModel> OrdenVenta_GetLineasPendientes()
        {
            using (IDbConnection connection = new SqlConnection(ConnectionString))
            {
                try
                {
                    var output = connection.Query<OrdenVentaLíneaModel>("dbo.spSaleOrderDetails_GetAllPending",
                        commandType: CommandType.StoredProcedure).ToList();
                    return output;
                }
                catch (Exception ex)
                {
                    Debug.Write(ex.ToString());
                    Debug.Assert(false);
                    return null;
                }
            }
        }

        public List<OrdenVentaLíneaModel> OrdenVenta_GetAllLineas()
        {
            using (IDbConnection connection = new SqlConnection(ConnectionString))
            {
                try
                {
                    var output = connection.Query<OrdenVentaLíneaModel>("dbo.spSaleOrderDetails_GetAll",
                        commandType: CommandType.StoredProcedure).ToList();
                    return output;
                }
                catch (Exception ex)
                {
                    Debug.Write(ex.ToString());
                    Debug.Assert(false);
                    return null;
                }
            }
        }

        public bool PurchaseOrderLine_Update(long orderId, OrdenVentaLíneaModel model)
        {
            using (IDbConnection connection = new SqlConnection(ConnectionString))
            {
                var p = new DynamicParameters();
                p.Add("@IdOrden", orderId);
                p.Add("@NumLinea", model.NumLinea);
                p.Add("@CantidadEntregada", model.CantidadEntregada);
                p.Add("@CantidadPendiente", model.CantidadPendiente);
                p.Add("@FechaUltEntrega", model.FechaUltEntrega);
                p.Add("@FechaCancelación", model.FechaCancelación);
                p.Add("@Estatus", model.Estatus);

                try
                {
                    connection.Execute("dbo.spSaleOrderDetails_Update", p,
                        commandType: CommandType.StoredProcedure);
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

        #endregion

        #region Historial de Entregas

        public bool Delivery_Create(OrdenCompraLíneaModel model, double quantity)
        {
            using (IDbConnection connection = new SqlConnection(ConnectionString))
            {
                var p = new DynamicParameters();
                p.Add("@TipoOrden", "C");
                p.Add("@NumOrden", model.NumOrden);
                p.Add("@NumLinea", model.NumLinea);
                p.Add("@Producto", model.Producto);
                p.Add("@Cantidad", quantity);
                p.Add("@Fecha", model.FechaUltRecepción);

                try
                {
                    connection.Execute("dbo.spDelivery_Insert", p,
                        commandType: CommandType.StoredProcedure);
                    return true;
                }
                catch (Exception ex)
                {
                    Debug.Write(ex.ToString()); 
                    Debug.Assert(false); 
                    return false;
                }
            }
        }

        public bool Delivery_Create(OrdenVentaLíneaModel model, double quantity)
        {
            using (IDbConnection connection = new SqlConnection(ConnectionString))
            {
                var p = new DynamicParameters();
                p.Add("@TipoOrden", "V");
                p.Add("@NumOrden", model.NumOrden);
                p.Add("@NumLinea", model.NumLinea);
                p.Add("@Producto", model.Producto);
                p.Add("@Cantidad", quantity);
                p.Add("@Fecha", model.FechaUltEntrega);

                try
                {
                    connection.Execute("dbo.spDelivery_Insert", p,
                        commandType: CommandType.StoredProcedure);
                    return true;
                }
                catch (Exception ex)
                {
                    Debug.Write(ex.ToString());
                    Debug.Assert(false);
                    return false;
                }
            }
        }

        public List<HistorialModel> Delivery_GetCompra()
        {
            using (IDbConnection connection = new SqlConnection(ConnectionString))
            {
                try
                {
                    var output = connection.Query<HistorialModel>("dbo.spDelivery_GetCompra",
                        commandType: CommandType.StoredProcedure).ToList();
                    return output;
                }
                catch (Exception ex)
                {
                    Debug.Write(ex.ToString()); 
                    Debug.Assert(false); 
                    return null;
                }
            }
        }

        public List<HistorialModel> Delivery_GetVenta()
        {
            using (IDbConnection connection = new SqlConnection(ConnectionString))
            {
                try
                {
                    var output = connection.Query<HistorialModel>("dbo.spDelivery_GetVenta",
                        commandType: CommandType.StoredProcedure).ToList();
                    return output;
                }
                catch (Exception ex)
                {
                    Debug.Write(ex.ToString());
                    Debug.Assert(false); 
                    return null;
                }
            }
        }

        #endregion

        #region Operadores

        public bool Operator_Create(OperadorModel model)
        {
            using (IDbConnection connection = new SqlConnection(ConnectionString))
            {
                var p = new DynamicParameters();
                p.Add("@Nombre", model.Nombre);
                p.Add("@Area", model.Área);

                try
                {
                    connection.Execute("dbo.spOperators_Insert", p, commandType: CommandType.StoredProcedure);
                    return true;
                }
                catch (Exception ex)
                {
                    Debug.Write(ex.ToString()); 
                    Debug.Assert(false); 
                    return false;
                }
            }
        }

        public List<OperadorModel> Operador_GetAll()
        {
            using (IDbConnection connection = new SqlConnection(ConnectionString))
            {
                try
                {
                    var output = connection.Query<OperadorModel>("dbo.spOperators_GetAll",
                        commandType: CommandType.StoredProcedure).ToList();
                    return output;
                }
                catch (Exception ex)
                {
                    Debug.Write(ex.ToString()); 
                    Debug.Assert(false); 
                    return null;
                }
            }
        }

        public List<OperadorModel> Operador_GetByArea(string area)
        {
            using (IDbConnection connection = new SqlConnection(ConnectionString))
            {
                var p = new DynamicParameters();
                p.Add("@Area", area);

                try
                {
                    var output = connection.Query<OperadorModel>("dbo.spOperators_GetByArea", p, 
                        commandType: CommandType.StoredProcedure).ToList();
                    return output;
                }
                catch (Exception ex)
                {
                    Debug.Write(ex.ToString()); 
                    Debug.Assert(false); 
                    return null;
                }
            }
        }

        public bool Operator_Update(OperadorModel model)
        {
            using (IDbConnection connection = new SqlConnection(ConnectionString))
            {
                var p = new DynamicParameters();
                p.Add("@Nombre", model.Nombre);
                p.Add("@Area", model.Área);
                p.Add("@Id", model.Id);

                try
                {
                    connection.Execute("dbo.spOperators_Update", p, commandType: CommandType.StoredProcedure);
                    return true;
                }
                catch (Exception ex)
                {
                    Debug.Write(ex.ToString());
                    Debug.Assert(false); 
                    return false;
                }
            }
        }

        public bool Operator_Delete(OperadorModel model)
        {
            using (IDbConnection connection = new SqlConnection(ConnectionString))
            {
                var p = new DynamicParameters();
                p.Add("@Id", model.Id);

                try
                {
                    connection.Execute("dbo.spOperators_Delete", p, commandType: CommandType.StoredProcedure);
                    return true;
                }
                catch (Exception ex)
                {
                    Debug.Write(ex.ToString());
                    Debug.Assert(false); 
                    return false;
                }
            }
        }

        #endregion

        #region Producción Plásticos

        public bool PlasticProduction_CreateMolido(ProducciónPlásticosModel model, MaterialModel materialEntrada, MaterialModel materialSalida)
        {
            using (var scope = new TransactionScope())
            using (IDbConnection connection = new SqlConnection(ConnectionString))
            {
                try
                {
                    var p = new DynamicParameters();
                    p.Add("@CantidadDisponible", materialEntrada.CantidadDisponible);
                    p.Add("@Id", materialEntrada.Id);
                    connection.Execute("dbo.spStock_Update", p, commandType: CommandType.StoredProcedure);

                    p = new DynamicParameters();
                    if (materialSalida.Id == 0)
                    {
                        p = new DynamicParameters();
                        p.Add("@Nombre", materialSalida.Nombre);
                        p.Add("@Area", materialSalida.Área);
                        p.Add("@Categoría", materialSalida.Categoría);
                        p.Add("@CantidadDisponible", materialSalida.CantidadDisponible);
                        connection.Execute("dbo.spStock_Insert", p, commandType: CommandType.StoredProcedure);
                    }
                    else
                    {
                        p.Add("@CantidadDisponible", materialSalida.CantidadDisponible);
                        p.Add("@Id", materialSalida.Id);
                        connection.Execute("dbo.spStock_Update", p, commandType: CommandType.StoredProcedure);
                    }

                    p = new DynamicParameters();
                    p.Add("@Fecha", model.Fecha);
                    p.Add("@Proceso", "Molido");
                    p.Add("@Turno", model.Turno);
                    p.Add("@Máquina", model.Máquina);
                    p.Add("@Operador", model.Operador);
                    p.Add("@MaterialEntra", model.MaterialEntra);
                    p.Add("@CantidadEntra", model.CantidadEntra);
                    p.Add("@MaterialSale", model.MaterialSale);
                    p.Add("@CantidadSale", model.CantidadSale);
                    p.Add("@MermaFinal", model.MermaFinal);
                    connection.Execute("dbo.spPlasticProduction_Insert", p, commandType: CommandType.StoredProcedure);
                }
                catch (Exception ex)
                {
                    Debug.Write(ex.ToString());
                    Debug.Assert(false);
                    return false;
                }

                scope.Complete();
                return true;
            }
        }

        public bool PlasticProduction_CreateExtruído(ProducciónPlásticosModel model, MezclaModel mezcla, MaterialModel materialSalida)
        {
            using (var scope = new TransactionScope())
            using (IDbConnection connection = new SqlConnection(ConnectionString))
            {
                try
                {
                    var p = new DynamicParameters();
                    var materialPorMoler = new MaterialModel();
                    foreach (var material in mezcla.Materiales)
                    {
                        p.Add("@CantidadDisponible", material.CantidadDisponible);
                        p.Add("@Id", material.Id);
                        connection.Execute("dbo.spStock_Update", p, commandType: CommandType.StoredProcedure); 
                    }

                    p = new DynamicParameters();
                    if (materialSalida.Id == 0)
                    {
                        p = new DynamicParameters();
                        p.Add("@Nombre", materialSalida.Nombre);
                        p.Add("@Area", materialSalida.Área);
                        p.Add("@Categoría", materialSalida.Categoría);
                        p.Add("@CantidadDisponible", materialSalida.CantidadDisponible);
                        connection.Execute("dbo.spStock_Insert", p, commandType: CommandType.StoredProcedure);
                    }
                    else
                    {
                        p.Add("@CantidadDisponible", materialSalida.CantidadDisponible);
                        p.Add("@Id", materialSalida.Id);
                        connection.Execute("dbo.spStock_Update", p, commandType: CommandType.StoredProcedure);
                    }

                    p = new DynamicParameters();
                    p.Add("@Fecha", model.Fecha);
                    p.Add("@Proceso", "Extruído");
                    p.Add("@Turno", model.Turno);
                    p.Add("@Máquina", model.Máquina);
                    p.Add("@Operador", model.Operador);
                    p.Add("@MaterialEntra", model.MaterialEntra);
                    p.Add("@CantidadEntra", model.CantidadEntra);
                    p.Add("@MaterialSale", model.MaterialSale);
                    p.Add("@CantidadSale", model.CantidadSale);
                    p.Add("@PesoPromedio", model.PesoPromedio);
                    p.Add("@MermaMoler", model.MermaMoler);
                    p.Add("@MermaFinal", model.MermaFinal);
                    connection.Execute("dbo.spPlasticProduction_Insert", p, commandType: CommandType.StoredProcedure);

                    p = new DynamicParameters();
                    p.Add("@Nombre", "Merma Por Moler");
                    p.Add("@Area", "Plásticos");

                    try
                    { 
                        materialPorMoler = connection.QuerySingle<MaterialModel>("dbo.spStock_GetByNombreArea", p,
                            commandType: CommandType.StoredProcedure);
                    }
                    catch (Exception ex)
                    {
                        if (ex.Message != "Sequence contains no elements")
                        {
                            Debug.WriteLine(ex.ToString());
                            Debug.Assert(false);
                        }
                    }
                    finally
                    {
                        if (materialPorMoler == null || materialPorMoler.Id == 0)
                        {
                            p = new DynamicParameters();
                            p.Add("@Nombre", "Merma Por Moler");
                            p.Add("@Area", "Plásticos");
                            p.Add("@Categoría", "Por Moler");
                            p.Add("@CantidadDisponible", model.MermaMoler);
                            connection.Execute("dbo.spStock_Insert", p, commandType: CommandType.StoredProcedure);
                        }
                        else
                        {
                            p = new DynamicParameters();
                            p.Add("@CantidadDisponible", materialPorMoler.CantidadDisponible + model.MermaMoler);
                            p.Add("@Id", materialPorMoler.Id);
                            connection.Execute("dbo.spStock_Update", p, commandType: CommandType.StoredProcedure);
                        }
                    }
                }
                catch (Exception ex)
                {
                    Debug.Write(ex.ToString());
                    Debug.Assert(false);
                    return false;
                }

                scope.Complete();
                return true;
            }
        }

        public bool PlasticProduction_CreateExtruído(ProducciónPlásticosModel model, MaterialModel materialEntrada,
            MaterialModel materialSalida)
        {
            using (var scope = new TransactionScope())
            using (IDbConnection connection = new SqlConnection(ConnectionString))
            {
                try
                {
                    var p = new DynamicParameters();
                    var materialPorMoler = new MaterialModel();
                    p.Add("@CantidadDisponible", materialEntrada.CantidadDisponible);
                    p.Add("@Id", materialEntrada.Id);
                    connection.Execute("dbo.spStock_Update", p, commandType: CommandType.StoredProcedure);

                    p = new DynamicParameters();
                    if (materialSalida.Id == 0)
                    {
                        p = new DynamicParameters();
                        p.Add("@Nombre", materialSalida.Nombre);
                        p.Add("@Area", materialSalida.Área);
                        p.Add("@Categoría", materialSalida.Categoría);
                        p.Add("@CantidadDisponible", materialSalida.CantidadDisponible);
                        connection.Execute("dbo.spStock_Insert", p, commandType: CommandType.StoredProcedure);
                    }
                    else
                    {
                        p.Add("@CantidadDisponible", materialSalida.CantidadDisponible);
                        p.Add("@Id", materialSalida.Id);
                        connection.Execute("dbo.spStock_Update", p, commandType: CommandType.StoredProcedure);
                    }

                    p = new DynamicParameters();
                    p.Add("@Fecha", model.Fecha);
                    p.Add("@Proceso", "Extruído");
                    p.Add("@Turno", model.Turno);
                    p.Add("@Máquina", model.Máquina);
                    p.Add("@Operador", model.Operador);
                    p.Add("@MaterialEntra", model.MaterialEntra);
                    p.Add("@CantidadEntra", model.CantidadEntra);
                    p.Add("@MaterialSale", model.MaterialSale);
                    p.Add("@CantidadSale", model.CantidadSale);
                    p.Add("@PesoPromedio", model.PesoPromedio);
                    p.Add("@MermaMoler", model.MermaMoler);
                    p.Add("@MermaFinal", model.MermaFinal);
                    connection.Execute("dbo.spPlasticProduction_Insert", p, commandType: CommandType.StoredProcedure);

                    p = new DynamicParameters();
                    p.Add("@Nombre", "Merma Por Moler");
                    p.Add("@Area", "Plásticos");

                    try
                    {
                        materialPorMoler = connection.QuerySingle<MaterialModel>("dbo.spStock_GetByNombreArea", p,
                            commandType: CommandType.StoredProcedure);
                    }
                    catch (Exception ex)
                    {
                        if (ex.Message != "Sequence contains no elements")
                        {
                            Debug.WriteLine(ex.ToString());
                            Debug.Assert(false);
                        }
                    }
                    finally
                    {
                        if (materialPorMoler == null || materialPorMoler.Id == 0)
                        {
                            p = new DynamicParameters();
                            p.Add("@Nombre", "Merma Por Moler");
                            p.Add("@Area", "Plásticos");
                            p.Add("@Categoría", "Por Moler");
                            p.Add("@CantidadDisponible", model.MermaMoler);
                            connection.Execute("dbo.spStock_Insert", p, commandType: CommandType.StoredProcedure);
                        }
                        else
                        {
                            p = new DynamicParameters();
                            p.Add("@CantidadDisponible", materialPorMoler.CantidadDisponible + model.MermaMoler);
                            p.Add("@Id", materialPorMoler.Id);
                            connection.Execute("dbo.spStock_Update", p, commandType: CommandType.StoredProcedure);
                        }
                    }
                }
                catch (Exception ex)
                {
                    Debug.Write(ex.ToString());
                    Debug.Assert(false);
                    return false;
                }

                scope.Complete();
                return true;
            }
        }

        public bool PlasticProduction_CreateCortado(ProducciónPlásticosModel model, MaterialModel materialEntrada,
            MaterialModel materialSalida)
        {
            using (var scope = new TransactionScope())
            using (IDbConnection connection = new SqlConnection(ConnectionString))
            {
                try
                {
                    var p = new DynamicParameters();
                    var materialPorMoler = new MaterialModel();
                    p.Add("@CantidadDisponible", materialEntrada.CantidadDisponible);
                    p.Add("@Id", materialEntrada.Id);
                    connection.Execute("dbo.spStock_Update", p, commandType: CommandType.StoredProcedure);

                    p = new DynamicParameters();
                    if (materialSalida.Id == 0)
                    {
                        p = new DynamicParameters();
                        p.Add("@Nombre", materialSalida.Nombre);
                        p.Add("@Area", materialSalida.Área);
                        p.Add("@Categoría", materialSalida.Categoría);
                        p.Add("@CantidadDisponible", materialSalida.CantidadDisponible);
                        connection.Execute("dbo.spStock_Insert", p, commandType: CommandType.StoredProcedure);
                    }
                    else
                    {
                        p.Add("@CantidadDisponible", materialSalida.CantidadDisponible);
                        p.Add("@Id", materialSalida.Id);
                        connection.Execute("dbo.spStock_Update", p, commandType: CommandType.StoredProcedure);
                    }

                    p = new DynamicParameters();
                    p.Add("@Fecha", model.Fecha);
                    p.Add("@Proceso", "Cortado");
                    p.Add("@Turno", model.Turno);
                    p.Add("@Máquina", model.Máquina);
                    p.Add("@Operador", model.Operador);
                    p.Add("@MaterialEntra", model.MaterialEntra);
                    p.Add("@CantidadEntra", model.CantidadEntra);
                    p.Add("@MaterialSale", model.MaterialSale);
                    p.Add("@CantidadSale", model.CantidadSale);
                    p.Add("@MermaMoler", model.MermaMoler);
                    p.Add("@MermaFinal", model.MermaFinal);
                    connection.Execute("dbo.spPlasticProduction_Insert", p, commandType: CommandType.StoredProcedure);

                    p = new DynamicParameters();
                    p.Add("@Nombre", "Merma Por Moler");
                    p.Add("@Area", "Plásticos");

                    try
                    {
                        materialPorMoler = connection.QuerySingle<MaterialModel>("dbo.spStock_GetByNombreArea", p,
                            commandType: CommandType.StoredProcedure);
                    }
                    catch (Exception ex)
                    {
                        if (ex.Message != "Sequence contains no elements")
                        {
                            Debug.WriteLine(ex.ToString());
                            Debug.Assert(false);
                        }
                    }
                    finally
                    {
                        if (materialPorMoler == null || materialPorMoler.Id == 0)
                        {
                            p = new DynamicParameters();
                            p.Add("@Nombre", "Merma Por Moler");
                            p.Add("@Area", "Plásticos");
                            p.Add("@Categoría", "Por Moler");
                            p.Add("@CantidadDisponible", model.MermaMoler);
                            connection.Execute("dbo.spStock_Insert", p, commandType: CommandType.StoredProcedure);
                        }
                        else
                        {
                            p = new DynamicParameters();
                            p.Add("@CantidadDisponible", materialPorMoler.CantidadDisponible + model.MermaMoler);
                            p.Add("@Id", materialPorMoler.Id);
                            connection.Execute("dbo.spStock_Update", p, commandType: CommandType.StoredProcedure);
                        }
                    }
                }
                catch (Exception ex)
                {
                    Debug.Write(ex.ToString());
                    Debug.Assert(false);
                    return false;
                }

                scope.Complete();
                return true;
            }
        }

        public List<ProducciónPlásticosModel> PlasticProduction_GetAll()
        {
            using (IDbConnection connection = new SqlConnection(ConnectionString))
            {
                try
                {
                    var output = connection.Query<ProducciónPlásticosModel>("dbo.spPlasticProduction_GetAll").ToList();
                    return output;
                }
                catch (Exception ex)
                {
                    Debug.Write(ex.ToString());
                    Debug.Assert(false);
                    return null;
                }
            }
        }

        public List<ProducciónPlásticosModel> PlasticProduction_GetByDate(DateTime desde, DateTime hasta)
        {
            using (IDbConnection connection = new SqlConnection(ConnectionString))
            {
                var p = new DynamicParameters();
                p.Add("@Desde", desde);
                p.Add("@Hasta", hasta);

                try
                {
                    var output = connection.Query<ProducciónPlásticosModel>("dbo.spPlasticProduction_GetByDate", p,
                        commandType: CommandType.StoredProcedure).ToList();
                    return output;
                }
                catch (Exception ex)
                {
                    Debug.Write(ex.ToString());
                    Debug.Assert(false);
                    return null;
                }
            }
        }

        public List<ProducciónPlásticosModel> PlasticProduction_GetByProceso(string proceso)
        {
            using (IDbConnection connection = new SqlConnection(ConnectionString))
            {
                var p = new DynamicParameters();
                p.Add("@Proceso", proceso);

                try
                {
                    var output = connection.Query<ProducciónPlásticosModel>("dbo.spPlasticProduction_GetByProceso", p,
                        commandType: CommandType.StoredProcedure).ToList();
                    return output;
                }
                catch (Exception ex)
                {
                    Debug.Write(ex.ToString());
                    Debug.Assert(false);
                    return null;
                }
            }
        }

        #endregion
    }
}
