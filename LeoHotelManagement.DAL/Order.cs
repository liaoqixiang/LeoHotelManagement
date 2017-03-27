using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using LeoHotelManagement.Model;
using LeoHotelManagement.Utility;

namespace LeoHotelManagement.DAL
{
	public partial class OrderService
	{
        #region InSert +int Insert(Order model)
        /// <summary>
        /// InSert into SQL Server
        /// </summary>
        /// <param name="model">the model you are about to insert</param>
        /// <returns>get the id of inserted model</returns>
        public int Insert(Order model)
        {
            #region SQL
            const string sql = @"
INSERT INTO [dbo].[Order] (
	[orderBeginTime]
	,[orderEndTime]
	,[orderbond]
	,[orderAmount]
	,[roomId]
	,[orderStatus]
	,[orderIsDel]
	,[orderRemark]
)
VALUES (
	@orderBeginTime
	,@orderEndTime
	,@orderbond
	,@orderAmount
	,@roomId
	,@orderStatus
	,@orderIsDel
	,@orderRemark
);select @@IDENTITY";
            #endregion
            var res = SqlHelper.ExecuteScalar(sql,
					new SqlParameter("@orderBeginTime", model.orderBeginTime),					
					new SqlParameter("@orderEndTime", model.orderEndTime),					
					new SqlParameter("@orderbond", model.orderbond),					
					new SqlParameter("@orderAmount", model.orderAmount),					
					new SqlParameter("@roomId", model.roomId),					
					new SqlParameter("@orderStatus", model.orderStatus),					
					new SqlParameter("@orderIsDel", model.orderIsDel),					
					new SqlParameter("@orderRemark", model.orderRemark)					
                );
            return res == null ? 0 : Convert.ToInt32(res);
        }
        #endregion

        #region Delete a record +int Delete(int orderid)
        public int Delete(int orderid)
        {
            const string sql = "DELETE FROM [dbo].[Order] WHERE [orderId] = @orderId";
            return SqlHelper.ExecuteNonQuery(sql, new SqlParameter("@orderId", orderid));
        }
        #endregion

        #region Using modified model to update +int Update(Order model)
        /// <summary>
        /// Using modified model to update
        /// </summary>
        /// <param name="model">entity</param>
        /// <returns>return how many rows have effected</returns>
        public int Update(Order model)
        {
            #region SQL
            const string sql = @"
UPDATE [dbo].[Order]
SET 
	[orderBeginTime] = @orderBeginTime
	,[orderEndTime] = @orderEndTime
	,[orderbond] = @orderbond
	,[orderAmount] = @orderAmount
	,[roomId] = @roomId
	,[orderStatus] = @orderStatus
	,[orderIsDel] = @orderIsDel
	,[orderRemark] = @orderRemark
WHERE [orderId] = @orderId";
            #endregion
            return SqlHelper.ExecuteNonQuery(sql,
					new SqlParameter("@orderId", model.orderId),					
					new SqlParameter("@orderBeginTime", model.orderBeginTime),					
					new SqlParameter("@orderEndTime", model.orderEndTime),					
					new SqlParameter("@orderbond", model.orderbond),					
					new SqlParameter("@orderAmount", model.orderAmount),					
					new SqlParameter("@roomId", model.roomId),					
					new SqlParameter("@orderStatus", model.orderStatus),					
					new SqlParameter("@orderIsDel", model.orderIsDel),					
					new SqlParameter("@orderRemark", model.orderRemark)					
                );
        }
        #endregion

        #region Pagination +IEnumerable<Order> QueryList(int index, int size, object wheres, string orderField, bool isDesc = true)
        /// <summary>
        /// Paginating the list
        /// </summary>
        /// <param name="index">index</param>
        /// <param name="size">Size of the list</param>
        /// <param name="wheres">anonymous class to pass the where conditions</param>
        /// <param name="orderField">using which column name to order</param>
        /// <param name="isDesc">ascending or descending</param>
        /// <returns>a model list</returns>
        public IEnumerable<Order> QueryList(int index, int size, object wheres, string orderField, bool isDesc = true)
        {
            var parameters = new List<SqlParameter>();
            var whereBuilder = new System.Text.StringBuilder();
            if (wheres != null)
            {
                var props = wheres.GetType().GetProperties();
                foreach (var prop in props)
                {
                    if (prop.Name.Equals("__o", StringComparison.InvariantCultureIgnoreCase))//if pass a string like "and" or "or" which is part of your sql query
                    {
                        //pass to sqlhelper to process it
                        whereBuilder.AppendFormat(" {0} ", prop.GetValue(wheres, null).ToString());
                    }
                    else
                    {
                        var val = prop.GetValue(wheres, null).ToString();
						//pass to sqlhelper to process it
                        whereBuilder.AppendFormat(" [{0}] = @{0} ", prop.Name);
                        parameters.Add(new SqlParameter("@" + prop.Name, val));
                    }
                }
            }
            var sql = SqlHelper.GenerateQuerySql("Order", new[] { "orderId", "orderBeginTime", "orderEndTime", "orderbond", "orderAmount", "roomId", "orderStatus", "orderIsDel", "orderRemark" }, index, size, whereBuilder.ToString(), orderField, isDesc);
            using (var reader = SqlHelper.ExecuteReader(sql, parameters.ToArray()))
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        yield return SqlHelper.MapEntity<Order>(reader);
                    }
                }
            }
        }
        #endregion

        #region get single entity +Order QuerySingle(object wheres)
         /// <summary>
        /// get single entity
        /// </summary>
        /// <param name="wheres">anonymous class(same functionality as above)</param>
        /// <returns>model</returns>
        public Order QuerySingle(object wheres)
        {
            var list = QueryList(1, 1, wheres, null);
            return list != null && list.Any() ? list.FirstOrDefault() : null;
        }
        #endregion

        #region Using id to get single entity +Order QuerySingle(int orderid)
        /// <summary>
        /// Using id to get single entity
        /// </summary>
        /// <param name="id">ID</param>
        /// <returns>Model</returns>
        public Order QuerySingle(int orderid)
        {
            const string sql = "SELECT TOP 1 [orderId], [orderBeginTime], [orderEndTime], [orderbond], [orderAmount], [roomId], [orderStatus], [orderIsDel], [orderRemark] FROM [dbo].[Order] WHERE [orderId] = @orderId";
            using (var reader = SqlHelper.ExecuteReader(sql, new SqlParameter("@orderId", orderid)))
            {
                if (reader.HasRows)
                {
                    reader.Read();
                    return SqlHelper.MapEntity<Order>(reader);
                }
                else
                {
                    return null;
                }
            }
        }
        #endregion

        #region Number of Results +int QueryCount(object wheres)
         /// <summary>
        /// Number of Results
        /// </summary>
        /// <param name="wheres">anonymous class</param>
        /// <returns>model</returns>
        public int QueryCount(object wheres)
        {
            var parameters = new List<SqlParameter>();
            var whereBuilder = new System.Text.StringBuilder();
            if (wheres != null)
            {
				//Using Reflection
                var props = wheres.GetType().GetProperties();
                foreach (var prop in props)
                {
                    if (prop.Name.Equals("__o", StringComparison.InvariantCultureIgnoreCase))
                    {
                        //pass to sqlhelper to process it
                        whereBuilder.AppendFormat(" {0} ", prop.GetValue(wheres, null).ToString());
                    }
                    else
                    {
                        var val = prop.GetValue(wheres, null).ToString();
						//pass to sqlhelper to process it
                        whereBuilder.AppendFormat(" [{0}] = @{0} ", prop.Name);
                        parameters.Add(new SqlParameter("@" + prop.Name, val));
                    }
                }
            }
            var sql = SqlHelper.GenerateQuerySql("Order", new[] { "COUNT(1)" }, whereBuilder.ToString(), string.Empty);
            var res = SqlHelper.ExecuteScalar(sql, parameters.ToArray());
            return res == null ? 0 : Convert.ToInt32(res);
        }
        #endregion
	}
}