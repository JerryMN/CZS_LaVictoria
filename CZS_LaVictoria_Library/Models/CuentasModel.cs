using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using CZS_LaVictoria_Library.DataAccess;
using Dapper;

namespace CZS_LaVictoria_Library.Models
{
    public class CuentasModel
    {
        static List<CuentasModel> _currentData;
        static DateTime _monthEnd;

        public DateTime Month { get; set; }
        public decimal Income { get; set; }
        public decimal Outcome { get; set; }

        public static List<CuentasModel> GetData()
        {
            return _currentData = _currentData ?? CreateData();
        }

        static List<CuentasModel> CreateData()
        {
            var result = new List<CuentasModel>();
            for (var i = 1; i <= 12; i++)
            {
                _monthEnd = new DateTime(2021, i, DateTime.DaysInMonth(2021, i));
                result.Add(CreateItem(2021, i));
            }
            return result;
        }

        static CuentasModel CreateItem(int year, int month)
        {
            var startDate = $"'2021-{month}-1'";
            var endDate = $"'2021-{month}-{_monthEnd.Day}'";
            using (IDbConnection connection = new SqlConnection(SqlConnector.connectionString))
            {
                var income = connection.ExecuteScalar(
                    $"SELECT SUM(Pago) From dbo.AR_Payments where FechaPago >= {startDate} and FechaPago <= {endDate}");
                var outcome = connection.ExecuteScalar(
                    $"SELECT SUM(Pago) From dbo.AP_Payments where FechaPago >= {startDate} and FechaPago <= {endDate}");

                var model = new CuentasModel {Month = new DateTime(year, month, DateTime.DaysInMonth(year, month))};
                if (income == null)
                {
                    model.Income = 0;
                }
                else
                {
                    model.Income = (decimal)income;
                }

                if (outcome == null)
                {
                    model.Outcome = 0;
                }
                else
                {
                    model.Outcome = (decimal)outcome;
                }

                return model;
            }
        }
    }
}
