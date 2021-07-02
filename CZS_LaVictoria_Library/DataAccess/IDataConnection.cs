﻿using System;
using System.Collections.Generic;
using CZS_ERP_Library.Models;

namespace CZS_ERP_Library.DataAccess
{
    public interface IDataConnection
    {
        #region Area

        bool Area_Create(AreaModel model);

        bool Area_Update(AreaModel model);

        List<AreaModel> Area_GetAll();

        AreaModel Area_GetByArea(AreaModel model);

        bool Area_Delete(AreaModel model);

        #endregion

        #region Proveedor

        bool Proveedor_Create(ProveedorModel model);

        bool Proveedor_Update(ProveedorModel model);

        List<ProveedorModel> Proveedor_GetAll();

        bool Proveedor_Delete(ProveedorModel model);

        List<ProveedorCondicionesModel> ProveedorCondiciones_GetDistinct();

        #endregion

        #region ProveedorProducto

        bool ProveedorProducto_Create(ProveedorProductoModel model, ProveedorModel proveedor);

        bool ProveedorProducto_Update(ProveedorProductoModel model);

        List<ProveedorProductoModel> ProveedorProducto_GetAll();

        List<ProveedorProductoModel> ProveedorProducto_GetByProveedorArea(int idProveedor, string area);

        bool ProveedorProducto_Delete(ProveedorProductoModel model);

        #endregion

        #region Cliente

        bool Cliente_Create(ClienteModel model);

        bool Cliente_Update(ClienteModel model);

        List<ClienteModel> Cliente_GetAll();

        bool Cliente_Delete(ClienteModel model);

        List<ClienteCiudadModel> ClienteCiudad_GetDistinct();

        #endregion

        #region ClienteProducto

        bool ClienteProducto_Create(ClienteProductoModel model, ClienteModel cliente);

        bool ClienteProducto_Create(ClienteProductoModel model);

        bool ClienteProducto_Update(ClienteProductoModel model);

        List<ClienteProductoModel> ClienteProducto_GetAll();

        List<ClienteProductoModel> ClienteProducto_GetByClienteArea(int idCliente, string area);

        bool ClienteProducto_Delete(ClienteProductoModel model);

        #endregion

        #region Materiales

        bool Material_Create(MaterialModel model);

        List<MaterialModel> Material_GetByAreaCat(string area, string categoría);

        List<MaterialModel> Material_GetByCat(string categoría);

        bool Material_Update(MaterialModel model);

        #endregion

        #region Mezclas

        bool Mezcla_Create(MezclaModel model);

        List<MezclaModel> Mezcla_GetAll();

        #endregion
    }
}
