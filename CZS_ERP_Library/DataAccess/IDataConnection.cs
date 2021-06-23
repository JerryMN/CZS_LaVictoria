using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CZS_ERP_Library.Models;

namespace CZS_ERP_Library.DataAccess
{
    public interface IDataConnection
    {
        #region Proveedor

        bool ProveedorCreate(ProveedorModel model);

        bool ProveedorUpdate(ProveedorModel model);

        List<ProveedorModel> ProveedorGetAll();

        bool ProveedorDelete(ProveedorModel model);

        #endregion
    }
}
