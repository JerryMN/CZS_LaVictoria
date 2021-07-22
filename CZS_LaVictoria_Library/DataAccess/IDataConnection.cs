using System;
using System.Collections.Generic;
using CZS_LaVictoria_Library.Models;

namespace CZS_LaVictoria_Library.DataAccess
{
    public interface IDataConnection
    {
        #region Licencia

        bool CZS_GetLicencia();

        #endregion

        #region Áreas

        /// <summary>
        /// Crea un área interna de la empresa.
        /// </summary>
        /// <param name="model">Un modelo con las propiedades del área.</param>
        /// <returns>True, si se creó correctamente, falso si no.</returns>
        bool Area_Create(AreaModel model);

        /// <summary>
        /// Obtiene todas las áreas internas de la empresa.
        /// </summary>
        /// <returns>Una lista con los modelos de las áreas.</returns>
        List<AreaModel> Area_GetAll();

        /// <summary>
        /// Obtiene todas las distintas áreas internas de la empresa.
        /// </summary>
        /// <returns>Una lista con los nombres de las áreas.</returns>
        List<string> Area_GetDistinct();

        /// <summary>
        /// Obtiene todas las filas de un área en específico, en caso de que
        /// haya mas de un responsable en dicha área.
        /// </summary>
        /// <param name="area">El nombre del área.</param>
        /// <returns>Una lista con los modelos de las áreas.</returns>
        List<AreaModel> Area_GetByArea(string area);

        /// <summary>
        /// Actualiza un área interna de la empresa.
        /// </summary>
        /// <param name="model">Un modelo con las propiedades del área.</param>
        /// <returns>True, si se actualizó correctamente, falso si no.</returns>
        bool Area_Update(AreaModel model);

        /// <summary>
        /// Elimina un área interna de la empresa.
        /// </summary>
        /// <param name="model">Un modelo con las propiedades del área.</param>
        /// <returns>True, si se eliminó correctamente, falso si no.</returns>
        bool Area_Delete(AreaModel model);

        #endregion

        #region Proveedor

        /// <summary>
        /// Crea un proveedor de la empresa.
        /// </summary>
        /// <param name="model">Un modelo con las propiedades del proveedor.</param>
        /// <returns>True, si se creó correctamente, falso si no.</returns>
        bool Proveedor_Create(ProveedorModel model);

        /// <summary>
        /// Obtiene todos los proveedores de la empresa.
        /// </summary>
        /// <returns>Una lista con los modelos de los proveedores.</returns>
        List<ProveedorModel> Proveedor_GetAll();

        /// <summary>
        /// Obtiene las diferentes condiciones que se tienen con los proveedores.
        /// </summary>
        /// <returns>Una lista con las condiciones.</returns>
        List<string> Proveedor_GetDistinctCondiciones();

        /// <summary>
        /// Actualiza un proveedor de la empresa.
        /// </summary>
        /// <param name="model">Un modelo con las propiedades del proveedor.</param>
        /// <returns>True, si se actualizó correctamente, falso si no.</returns>
        bool Proveedor_Update(ProveedorModel model);

        /// <summary>
        /// Elimina un proveedor de la empresa.
        /// </summary>
        /// <param name="model">Un modelo con las propiedades del proveedor.</param>
        /// <returns>True, si se eliminó correctamente, falso si no.</returns>
        bool Proveedor_Delete(ProveedorModel model);

        #endregion

        #region ProveedorProducto

        /// <summary>
        /// Crea un producto de un proveedor.
        /// </summary>
        /// <param name="model">Un modelo con las propiedades del producto.</param>
        /// <param name="proveedor">Un modelo con las propiedades del proveedor.</param>
        /// <returns>True, si se creó correctamente, falso si no.</returns>
        bool ProveedorProducto_Create(ProveedorProductoModel model, ProveedorModel proveedor);

        /// <summary>
        /// Obtiene todos los productos de todos los proveedores.
        /// </summary>
        /// <returns>Una lista con los modelos de los productos.</returns>
        List<ProveedorProductoModel> ProveedorProducto_GetAll();

        /// <summary>
        /// Obtiene todos los productos de un proveedor y de un área.
        /// </summary>
        /// <param name="idProveedor">El id único del proveedor.</param>
        /// <param name="area">El área interna de la empresa.</param>
        /// <returns>Una lista con los modelos de los productos.</returns>
        List<ProveedorProductoModel> ProveedorProducto_GetByProveedorArea(int idProveedor, string area);

        /// <summary>
        /// Obtiene un producto con cierto nombre, de cierto proveedor y de cierta área.
        /// </summary>
        /// <param name="nombreExterno">El nombre externo del producto.</param>
        /// <param name="proveedor">El nombre del proveedor.</param>
        /// <param name="area">El área interna de la empresa.</param>
        /// <returns>Un modelo de un producto.</returns>
        ProveedorProductoModel ProveedorProducto_Find(string nombreExterno, string proveedor, string area);

        /// <summary>
        /// Actualiza el nombre externo, nombre interno y precio de un producto de un proveedor.
        /// </summary>
        /// <param name="model">Un modelo con las propiedades del producto.</param>
        /// <returns>True, si se actualizó correctamente, falso si no.</returns>
        bool ProveedorProducto_Update(ProveedorProductoModel model);

        /// <summary>
        /// Elimina un producto de un proveedor.
        /// </summary>
        /// <param name="model">Un modelo con las propiedades del producto.</param>
        /// <returns>True, si se eliminó correctamente, falso si no.</returns>
        bool ProveedorProducto_Delete(ProveedorProductoModel model);

        #endregion

        #region Cliente

        /// <summary>
        /// Crea un cliente de la empresa.
        /// </summary>
        /// <param name="model">Un modelo con las propiedades del cliente.</param>
        /// <returns>True, si se creó correctamente, falso si no.</returns>
        bool Cliente_Create(ClienteModel model);

        /// <summary>
        /// Obtiene todos los clientes de la empresa.
        /// </summary>
        /// <returns>Una lista con los modelos de los clientes.</returns>
        List<ClienteModel> Cliente_GetAll();

        /// <summary>
        /// Obtiene las diferentes ciudades que se tienen con los clientes.
        /// </summary>
        /// <returns>Una lista con las ciudades.</returns>
        List<string> Cliente_GetDistinctCiudades();

        /// <summary>
        /// Actualiza un cliente de la empresa.
        /// </summary>
        /// <param name="model">Un modelo con las propiedades del cliente.</param>
        /// <returns>True, si se actualizó correctamente, falso si no.</returns>
        bool Cliente_Update(ClienteModel model);

        /// <summary>
        /// Elimina un cliente de la empresa.
        /// </summary>
        /// <param name="model">Un modelo con las propiedades del cliente.</param>
        /// <returns>True, si se eliminó correctamente, falso si no.</returns>
        bool Cliente_Delete(ClienteModel model);

        #endregion

        #region ClienteProducto

        /// <summary>
        /// Crea un producto a comercializar.
        /// </summary>
        /// <param name="model">Un modelo con las propiedades del producto.</param>
        /// <param name="cliente">Un modelo con las propiedades del cliente. Puede pasarse null.</param>
        /// <returns>True, si se creó correctamente, falso si no.</returns>
        bool ClienteProducto_Create(ClienteProductoModel model, ClienteModel cliente);

        /// <summary>
        /// Obtiene todos los productos con o sin cliente.
        /// </summary>
        /// <returns>Una lista con los modelos de los productos.</returns>
        List<ClienteProductoModel> ClienteProducto_GetAll();

        /// <summary>
        /// Obtiene todos los productos de un cliente(?) y de un área.
        /// </summary>
        /// <param name="idCliente">El id único del cliente. Puede ser null.</param>
        /// <param name="area">El área interna de la empresa.</param>
        /// <returns>Una lista con los modelos de los productos.</returns>
        List<ClienteProductoModel> ClienteProducto_GetByClienteArea(int? idCliente, string area);

        /// <summary>
        /// Obtiene un producto con cierto nombre, y de cierta área.
        /// </summary>
        /// <param name="nombreInterno">El nombre externo del producto.</param>
        /// <param name="area">El área interna de la empresa.</param>
        /// <returns>Un modelo de un producto.</returns>
        ClienteProductoModel ClienteProducto_Find(string nombreInterno, string area);

        /// <summary>
        /// Actualiza un producto a comercializar.
        /// </summary>
        /// <param name="model">Un modelo con las propiedades del producto.</param>
        /// <returns>True, si se actualizó correctamente, falso si no.</returns>
        bool ClienteProducto_Update(ClienteProductoModel model);

        /// <summary>
        /// Elimina un producto a comercializar.
        /// </summary>
        /// <param name="model">Un modelo con las propiedades del producto.</param>
        /// <returns>True, si se eliminó correctamente, falso si no.</returns>
        bool ClienteProducto_Delete(ClienteProductoModel model);

        #endregion

        #region Materiales

        /// <summary>
        /// Crea un material o producto en el inventario.
        /// </summary>
        /// <param name="model">Un modelo con las propiedades del material o producto.</param>
        /// <returns>True, si se creó correctamente, falso si no.</returns>
        bool Material_Create(MaterialModel model);

        /// <summary>
        /// Obtiene todos los materiales o productos en el inventario.
        /// </summary>
        /// <returns>Una lista con los modelos de los materiales o productos.</returns>
        List<MaterialModel> Material_GetAll();

        /// <summary>
        /// Obtiene todos los materiales o productos en el inventario que se encuentran
        /// en una área y categoría especificadas.
        /// </summary>
        /// <param name="area">El área de los materiales o productos.</param>
        /// <param name="categoría">La categoría de los materiales o productos.</param>
        /// <returns>Una lista con los modelos de los materiales o productos.</returns>
        List<MaterialModel> Material_GetByAreaCat(string area, string categoría);

        /// <summary>
        /// Obtiene todos los materiales o productos en el inventario que se encuentran
        /// en una área especificada.
        /// </summary>
        /// <param name="area">El área de los materiales o productos.</param>
        /// <returns>Una lista con los modelos de los materiales o productos.</returns>
        List<MaterialModel> Material_GetByArea(string area);

        /// <summary>
        /// Obtiene todos los materiales o productos en el inventario que se encuentran
        /// en una categoría especificada.
        /// </summary>
        /// <param name="categoría">La categoría de los materiales o productos.</param>
        /// <returns>Una lista con los modelos de los materiales o productos.</returns>
        List<MaterialModel> Material_GetByCat(string categoría);

        /// <summary>
        /// Obtiene el material o producto en el inventario con cierto nombre y en un
        /// área especificada.
        /// </summary>
        /// <param name="nombre">El nombre del material o producto.</param>
        /// <param name="area">El área de; material o producto.</param>
        /// <returns></returns>
        MaterialModel Material_GetByNombreArea(string nombre, string area);

        /// <summary>
        /// Obtiene las distintas categorías de los materiales o productos en el inventario.
        /// </summary>
        /// <returns>Una lista con las categorías.</returns>
        List<string> Material_GetDistinctCategorías();

        /// <summary>
        /// Actualiza un material o producto en el inventario.
        /// </summary>
        /// <param name="model">Un modelo con las propiedades del material o producto.</param>
        /// <returns>True, si se actualizó correctamente, falso si no.</returns>
        bool Material_Update(MaterialModel model);

        /// <summary>
        /// Elimina un material o producto en el inventario.
        /// </summary>
        /// <param name="model">Un modelo con las propiedades del material o producto.</param>
        /// <returns>True, si se eliminó correctamente, falso si no.</returns>
        bool Material_Delete(MaterialModel model);

        #endregion

        #region Mezclas

        /// <summary>
        /// Crea una mezcla de materiales.
        /// </summary>
        /// <param name="model">Un modelo con las propiedades de la mezcla.</param>
        /// <returns>True, si se creó correctamente, falso si no.</returns>
        bool Mezcla_Create(MezclaModel model);

        /// <summary>
        /// Obtiene todas las mezclas registradas.
        /// </summary>
        /// <returns>Una lista con los modelos de las mezclas.</returns>
        List<MezclaModel> Mezcla_GetAll();

        /// <summary>
        /// Elimina una mezcla de materiales.
        /// </summary>
        /// <param name="model">Un modelo con las propiedades de la mezcla.</param>
        /// <returns>True, si se eliminó correctamente, falso si no.</returns>
        bool Mezcla_Delete(MezclaModel model);

        #endregion

        #region Kits

        /// <summary>
        /// Crea una kit de trapeadores.
        /// </summary>
        /// <param name="model">Un modelo con las propiedades del kit.</param>
        /// <returns>True, si se creó correctamente, falso si no.</returns>
        bool Kit_Create(KitModel model);

        /// <summary>
        /// Obtiene todos los kits registrados.
        /// </summary>
        /// <returns>Una lista con los modelos de los kits.</returns>
        List<KitModel> Kit_GetAll();

        /// <summary>
        /// Elimina un kit de trapeadores.
        /// </summary>
        /// <param name="model">Un modelo con las propiedades del kit.</param>
        /// <returns>True, si se eliminó correctamente, falso si no.</returns>
        bool Kit_Delete(KitModel model);

        #endregion

        #region Orden de Compra

        /// <summary>
        /// Crea una nueva orden de compra.
        /// </summary>
        /// <param name="model">Un modelo con las propiedades de la orden.</param>
        /// <returns>True, si se creó correctamente, falso si no.</returns>
        bool OrdenCompra_Create(OrdenCompraModel model);

        /// <summary>
        /// Obtiene el último número de orden de compra en la base de datos.
        /// </summary>
        /// <returns>El último número de orden.</returns>
        long OrdenCompra_GetLastNumOrden();

        /// <summary>
        /// Obtiene una orden de compra.
        /// </summary>
        /// <param name="numOrden">El número de orden.</param>
        /// <returns>Un modelo con las propiedades de la orden.</returns>
        OrdenCompraModel OrdenCompra_GetByNumOrden(string numOrden);

        /// <summary>
        /// Obtiene todas las líneas de una orden de compra.
        /// </summary>
        /// <param name="numOrden">El número de orden.</param>
        /// <returns>Una lista con los modelos de las líneas.</returns>
        List<OrdenCompraLíneaModel> OrdenCompra_GetLineasByNumOrden(string numOrden);

        /// <summary>
        /// Obtiene las líneas pendientes de una orden de compra.
        /// </summary>
        /// <returns>Una lista con los modelos de las líneas.</returns>
        List<OrdenCompraLíneaModel> OrdenCompra_GetLineasPendientes();

        /// <summary>
        /// Obtiene todas las líneas de todas las órdenes de compra.
        /// </summary>
        /// <returns>Una lista con los modelos de las líneas.</returns>
        List<OrdenCompraLíneaModel> OrdenCompra_GetAllLineas();

        /// <summary>
        /// Actualiza una línea de una orden de compra.
        /// </summary>
        /// <param name="orderId">El Id de la orden.</param>
        /// <param name="línea">El modelo de la línea a actualizar.</param>
        /// <param name="oldQty">La cantidad que se había entregado.</param>
        /// <param name="newQty">La cantidad entregada contando esta entrega.</param>
        /// <returns>True, si se actualizó correctamente, falso si no.</returns>
        bool OrdenCompra_UpdateLinea(long orderId, OrdenCompraLíneaModel línea, double oldQty, double newQty);

        #endregion

        #region Orden de Venta

        /// <summary>
        /// Crea una nueva orden de venta.
        /// </summary>
        /// <param name="model">Un modelo con las propiedades de la orden.</param>
        /// <returns>True, si se creó correctamente, falso si no.</returns>
        bool OrdenVenta_Create(OrdenVentaModel model);

        /// <summary>
        /// Obtiene el último número de orden de venta en la base de datos.
        /// </summary>
        /// <returns>El último número de orden.</returns>
        long OrdenVenta_GetLastNumOrden();

        /// <summary>
        /// Obtiene una orden de venta.
        /// </summary>
        /// <param name="numOrden">El número de orden.</param>
        /// <returns>Un modelo con las propiedades de la orden.</returns>
        OrdenVentaModel OrdenVenta_GetByNumOrden(string numOrden);

        /// <summary>
        /// Obtiene todas las líneas de una orden de venta.
        /// </summary>
        /// <param name="numOrden">El número de orden.</param>
        /// <returns>Una lista con los modelos de las líneas.</returns>
        List<OrdenVentaLíneaModel> OrdenVenta_GetLineasByNumOrden(string numOrden);

        /// <summary>
        /// Obtiene las líneas pendientes de una orden de venta.
        /// </summary>
        /// <returns>Una lista con los modelos de las líneas.</returns>
        List<OrdenVentaLíneaModel> OrdenVenta_GetLineasPendientes();

        /// <summary>
        /// Obtiene todas las líneas de todas las órdenes de compra.
        /// </summary>
        /// <returns>Una lista con los modelos de las líneas.</returns>
        List<OrdenVentaLíneaModel> OrdenVenta_GetAllLineas();

        /// <summary>
        /// Actualiza una línea de una orden de venta.
        /// </summary>
        /// <param name="orderId">El Id de la orden.</param>
        /// <param name="línea">El modelo de la línea a actualizar.</param>
        /// <param name="oldQty">La cantidad que se había entregado.</param>
        /// <param name="newQty">La cantidad entregada contando esta entrega.</param>
        /// <returns>True, si se actualizó correctamente, falso si no.</returns>
        bool OrdenVenta_UpdateLinea(long orderId, OrdenVentaLíneaModel línea, double oldQty, double newQty);

        #endregion

        #region Historial de Entregas

        /// <summary>
        /// Registra la recepción de una línea de una orden de compra.
        /// </summary>
        /// <param name="model">Un modelo de línea de orden de compra del cual
        /// se hace la recepción.</param>
        /// <param name="quantity">La cantidad recibida.</param>
        /// <returns>True, si se creó correctamente, falso si no.</returns>
        bool Delivery_Create(OrdenCompraLíneaModel model, double quantity);

        /// <summary>
        /// Registra la entrega de una línea de una orden de venta.
        /// </summary>
        /// <param name="model">Un modelo de línea de orden de venta del cual
        /// se hace la entrega.</param>
        /// <param name="quantity">La cantidad entregada.</param>
        /// <returns>True, si se creó correctamente, falso si no.</returns>
        bool Delivery_Create(OrdenVentaLíneaModel model, double quantity);

        /// <summary>
        /// Obtiene todos los registros de recepciones de órdenes de compra.
        /// </summary>
        /// <returns>Una lista con los modelos de las recepciones.</returns>
        List<HistorialModel> Delivery_GetCompra();

        /// <summary>
        /// Obtiene todos los registros de recepciones de órdenes de venta.
        /// </summary>
        /// <returns>Una lista con los modelos de las recepciones.</returns>
        List<HistorialModel> Delivery_GetVenta();

        #endregion

        #region Operadores

        /// <summary>
        /// Crea un operador.
        /// </summary>
        /// <param name="model">Un modelo con las propiedades del operador.</param>
        /// <returns>True, si se creó correctamente, falso si no.</returns>
        bool Operator_Create(OperadorModel model);

        /// <summary>
        /// Obtiene todos los operadores.
        /// </summary>
        /// <returns>Una lista con los modelos de los operadores.</returns>
        List<OperadorModel> Operador_GetAll();

        /// <summary>
        /// Obtiene todos los operadores en un área en específico.
        /// </summary>
        /// <param name="area">El área a buscar.</param>
        /// <returns>Una lista con los modelos de los operadores.</returns>
        List<OperadorModel> Operador_GetByArea(string area);

        /// <summary>
        /// Actualiza un operador.
        /// </summary>
        /// <param name="model">Un modelo con las propiedades del operador.</param>
        /// <returns>True, si se actualizó correctamente, falso si no.</returns>
        bool Operator_Update(OperadorModel model);

        /// <summary>
        /// Elimina un operador.
        /// </summary>
        /// <param name="model">Un modelo con las propiedades del operador.</param>
        /// <returns>True, si se eliminó correctamente, falso si no.</returns>
        bool Operator_Delete(OperadorModel model);

        #endregion

        #region Producción Plásticos

        /// <summary>
        /// Crea un registro de una producción de molido.
        /// </summary>
        /// <param name="model">Un modelo con las propiedades de la producción.</param>
        /// <param name="materialEntrada">Un modelo con las propiedades del material de entrada al proceso.</param>
        /// <param name="materialSalida">Un modelo con las propiedades del material de salida del proceso.</param>
        /// <returns>True, si se creó correctamente, falso si no.</returns>
        bool PlasticProduction_CreateMolido(ProducciónPlásticosModel model, MaterialModel materialEntrada, MaterialModel materialSalida);

        /// <summary>
        /// Crea un registro de una producción de extruído.
        /// </summary>
        /// <param name="model">Un modelo con las propiedades de la producción.</param>
        /// <param name="mezcla">Un modelo con las propiedades de la mezcla de entrada al proceso.</param>
        /// <param name="materialSalida">Un modelo con las propiedades del material de salida del proceso.</param>
        /// <returns>True, si se creó correctamente, falso si no.</returns>
        bool PlasticProduction_CreateExtruído(ProducciónPlásticosModel model, MezclaModel mezcla, MaterialModel materialSalida);

        /// <summary>
        /// Crea un registro de una producción de extruído.
        /// </summary>
        /// <param name="model">Un modelo con las propiedades de la producción.</param>
        /// <param name="materialEntrada">Un modelo con las propiedades del material de entrada al proceso.</param>
        /// <param name="materialSalida">Un modelo con las propiedades del material de salida del proceso.</param>
        /// <returns>True, si se creó correctamente, falso si no.</returns>
        bool PlasticProduction_CreateExtruído(ProducciónPlásticosModel model, MaterialModel materialEntrada, MaterialModel materialSalida);

        /// <summary>
        /// Crea un registro de una producción de cortado.
        /// </summary>
        /// <param name="model">Un modelo con las propiedades de la producción.</param>
        /// <param name="materialEntrada">Un modelo con las propiedades del material de entrada al proceso.</param>
        /// <param name="materialSalida">Un modelo con las propiedades del material de salida del proceso.</param>
        /// <returns>True, si se creó correctamente, falso si no.</returns>
        bool PlasticProduction_CreateCortado(ProducciónPlásticosModel model, MaterialModel materialEntrada, MaterialModel materialSalida);

        /// <summary>
        /// Crea un registro de una producción de inyección.
        /// </summary>
        /// <param name="model">Un modelo con las propiedades de la producción.</param>
        /// <param name="mezcla">Un modelo con las propiedades de la mezcla de entrada al proceso.</param>
        /// <param name="materialSalida">Un modelo con las propiedades del material de salida del proceso.</param>
        /// <returns>True, si se creó correctamente, falso si no.</returns>
        bool PlasticProduction_CreateInyección(ProducciónPlásticosModel model, MezclaModel mezcla, MaterialModel materialSalida);

        /// <summary>
        /// Crea un registro de una producción de inyección.
        /// </summary>
        /// <param name="model">Un modelo con las propiedades de la producción.</param>
        /// <param name="materialEntrada">Un modelo con las propiedades del material de entrada al proceso.</param>
        /// <param name="materialSalida">Un modelo con las propiedades del material de salida del proceso.</param>
        /// <returns>True, si se creó correctamente, falso si no.</returns>
        bool PlasticProduction_CreateInyección(ProducciónPlásticosModel model, MaterialModel materialEntrada, MaterialModel materialSalida);

        /// <summary>
        /// Crea un registro de una producción de insertado.
        /// </summary>
        /// <param name="model">Un modelo con las propiedades de la producción.</param>
        /// <param name="baseEntrada">Un modelo con las propiedades de la base de entrada al proceso.</param>
        /// <param name="fibraEntrada">Un modelo con las propiedades de la fibra de entrada al proceso.</param>
        /// <param name="alambreEntrada">Un modelo con las propiedades del alambre de entrada al proceso.</param>
        /// <param name="materialSalida">Un modelo con las propiedades del material de salida del proceso.</param>
        /// <returns>True, si se creó correctamente, falso si no.</returns>
        bool PlasticProduction_CreateInsertado(ProducciónPlásticosModel model, MaterialModel baseEntrada, MaterialModel fibraEntrada, MaterialModel alambreEntrada, MaterialModel materialSalida);

        /// <summary>
        /// Obtiene todos los registros de producciones de plásticos.
        /// </summary>
        /// <returns>Una lista con los modelos de las producciones.</returns>
        List<ProducciónPlásticosModel> PlasticProduction_GetAll();

        /// <summary>
        /// Obtiene todos los registros de producciones de plásticos entre ciertas fechas.
        /// </summary>
        /// <param name="desde">La fecha de inicio.</param>
        /// <param name="hasta">La fecha de final.</param>
        /// <returns>Una lista con los modelos de las producciones.</returns>
        List<ProducciónPlásticosModel> PlasticProduction_GetByDate(DateTime desde, DateTime hasta);

        /// <summary>
        /// Obtiene todos los registros de producciones de plásticos de cierto proceso.
        /// </summary>
        /// <param name="proceso">El proceso de producción (molido, insertado, etc.).</param>
        /// <returns>Una lista con los modelos de las producciones.</returns>
        List<ProducciónPlásticosModel> PlasticProduction_GetByProceso(string proceso);

        /// <summary>
        /// Obtiene todas las máquinas usadas anteriormente en procesos de plásticos.
        /// </summary>
        /// <returns>Una lista con los nombres de las máquinas.</returns>
        List<string> PlasticProduction_GetMáquinas();

        #endregion

        #region Producción Algodón

        /// <summary>
        /// Crea un registro de una producción de escalera.
        /// </summary>
        /// <param name="model">Un modelo con las propiedades de la producción.</param>
        /// <param name="materialEntrada">Un modelo con las propiedades del material de entrada al proceso.</param>
        /// <returns>True, si se creó correctamente, falso si no.</returns>
        bool WoolProduction_CreateEscalera(ProducciónAlgodónModel model, MaterialModel materialEntrada);

        /// <summary>
        /// Crea un registro de una producción de cardas.
        /// </summary>
        /// <param name="model">Un modelo con las propiedades de la producción.</param>
        /// <returns>True, si se creó correctamente, falso si no.</returns>
        bool WoolProduction_CreateCardas(ProducciónAlgodónModel model);

        /// <summary>
        /// Crea un registro de una producción de estirado.
        /// </summary>
        /// <param name="model">Un modelo con las propiedades de la producción.</param>
        /// <returns>True, si se creó correctamente, falso si no.</returns>
        bool WoolProduction_CreateEstirado(ProducciónAlgodónModel model);

        /// <summary>
        /// Crea un registro de una producción de open end.
        /// </summary>
        /// <param name="model">Un modelo con las propiedades de la producción.</param>
        /// <param name="materialSalida">Un modelo con las propiedades del material de salida del proceso.</param>
        /// <returns>True, si se creó correctamente, falso si no.</returns>
        bool WoolProduction_CreateOpenEnd(ProducciónAlgodónModel model, MaterialModel materialSalida);

        /// <summary>
        /// Crea un registro de una producción de torcedura.
        /// </summary>
        /// <param name="model">Un modelo con las propiedades de la producción.</param>
        /// <returns>True, si se creó correctamente, falso si no.</returns>
        bool WoolProduction_CreateTorcedura(ProducciónAlgodónModel model);

        /// <summary>
        /// Crea un registro de una producción de enrollado.
        /// </summary>
        /// <param name="model">Un modelo con las propiedades de la producción.</param>
        /// <param name="materialSalida">Un modelo con las propiedades del material de salida del proceso.</param>
        /// <returns>True, si se creó correctamente, falso si no.</returns>
        bool WoolProduction_CreateEnrollado(ProducciónAlgodónModel model, MaterialModel materialSalida);

        /// <summary>
        /// Obtiene todos los registros de producciones de algodón.
        /// </summary>
        /// <returns>Una lista con los modelos de las producciones.</returns>
        List<ProducciónAlgodónModel> WoolProduction_GetAll();

        /// <summary>
        /// Obtiene todos los registros de producciones de algodón entre ciertas fechas.
        /// </summary>
        /// <param name="desde">La fecha de inicio.</param>
        /// <param name="hasta">La fecha de final.</param>
        /// <returns>Una lista con los modelos de las producciones.</returns>
        List<ProducciónAlgodónModel> WoolProduction_GetByDate(DateTime desde, DateTime hasta);

        /// <summary>
        /// Obtiene todos los registros de producciones de algodón de cierto proceso.
        /// </summary>
        /// <param name="proceso">El proceso de producción (escalera, cardas, etc.).</param>
        /// <returns>Una lista con los modelos de las producciones.</returns>
        List<ProducciónAlgodónModel> WoolProduction_GetByProceso(string proceso);

        /// <summary>
        /// Obtiene todas las máquinas usadas anteriormente en procesos de algodón.
        /// </summary>
        /// <returns>Una lista con los nombres de las máquinas.</returns>
        List<string> WoolProduction_GetMáquinas();

        #endregion

        #region Producción Trapeadores

        /// <summary>
        /// Crea un registro de una producción de trapeadores.
        /// </summary>
        /// <param name="model">Un modelo con las propiedades de la producción.</param>
        /// <param name="alambre">Un modelo con las propiedades del alambre de entrada al proceso.</param>
        /// <param name="kit">Un modelo con las propiedades del kit de salida del proceso.</param>
        /// <returns>True, si se creó correctamente, falso si no.</returns>
        bool MopProduction_Create(ProducciónTrapeadoresModel model, MaterialModel alambre, KitModel kit);

        /// <summary>
        /// Obtiene todos los registros de producciones de trapeadores.
        /// </summary>
        /// <returns>Una lista con los modelos de las producciones.</returns>
        List<ProducciónTrapeadoresModel> MopProduction_GetAll();

        /// <summary>
        /// Obtiene todos los registros de producciones de trapeadores entre ciertas fechas.
        /// </summary>
        /// <param name="desde">La fecha de inicio.</param>
        /// <param name="hasta">La fecha de final.</param>
        /// <returns>Una lista con los modelos de las producciones.</returns>
        List<ProducciónTrapeadoresModel> MopProduction_GetByDate(DateTime desde, DateTime hasta);

        #endregion

        #region Por Pagar

        /// <summary>
        /// Registra un pago de una cuenta por pagar.
        /// </summary>
        /// <param name="línea">El modelo de la línea que se va a pagar.</param>
        /// <returns>True, si se creó correctamente, falso si no.</returns>
        bool Payable_Create(PorPagarModel línea);

        /// <summary>
        /// Registra un pago de una cuenta por pagar.
        /// </summary>
        /// <param name="línea">El modelo de la línea que se va a pagar.</param>
        /// <param name="registro">El modelo del registro del pago.</param>
        /// <returns>True, si se creó correctamente, falso si no.</returns>
        bool Payable_Create(PorPagarModel línea, PorPagarPagosModel registro);

        /// <summary>
        /// Obtiene todos los registros de cuentas por pagar.
        /// </summary>
        /// <returns>Una lista con los modelos de las cuentas.</returns>
        List<PorPagarModel> Payable_GetAll();

        /// <summary>
        /// Obtiene todos los registros de pagos hechos.
        /// </summary>
        /// <returns>Una lista con los modelos de los pagos.</returns>
        List<PorPagarPagosModel> Payable_GetPagos();

        /// <summary>
        /// Obtiene todos los registros de pagos hechos entre ciertas fechas.
        /// </summary>
        /// <param name="desde">La fecha desde donde buscar.</param>
        /// <param name="hasta">La fecha hasta donde buscar.</param>
        /// <returns>Una lista con los modelos de los pagos.</returns>
        List<PorPagarPagosModel> Payable_GetPagosByDate(DateTime desde, DateTime hasta);

        #endregion

        #region Por Cobrar

        /// <summary>
        /// Registra un pago de una cuenta por cobrar.
        /// </summary>
        /// <param name="línea">El modelo de la línea que se va a cobrar.</param>
        /// <returns>True, si se creó correctamente, falso si no.</returns>
        bool Receivable_Create(PorCobrarModel línea);

        /// <summary>
        /// Registra un pago de una cuenta por cobrar.
        /// </summary>
        /// <param name="línea">El modelo de la línea que se va a cobrar.</param>
        /// <param name="registro">El modelo del registro del pago.</param>
        /// <returns>True, si se creó correctamente, falso si no.</returns>
        bool Receivable_Create(PorCobrarModel línea, PorCobrarPagosModel registro);

        /// <summary>
        /// Obtiene todos los registros de cuentas por cobrar.
        /// </summary>
        /// <returns>Una lista con los modelos de las cuentas.</returns>
        List<PorCobrarModel> Receivable_GetAll();

        /// <summary>
        /// Obtiene todos los registros de pagos recibidos.
        /// </summary>
        /// <returns>Una lista con los modelos de los pagos.</returns>
        List<PorCobrarPagosModel> Receivable_GetPagos();

        /// <summary>
        /// Obtiene todos los registros de pagos recibidos1 entre ciertas fechas.
        /// </summary>
        /// <param name="desde">La fecha desde donde buscar.</param>
        /// <param name="hasta">La fecha hasta donde buscar.</param>
        /// <returns>Una lista con los modelos de los pagos.</returns>
        List<PorCobrarPagosModel> Receivable_GetPagosByDate(DateTime desde, DateTime hasta);

        #endregion
    }
}
