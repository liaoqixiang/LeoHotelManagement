﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using LeoHotelManagement.Model;
using LeoHotelManagement.Utility;

namespace LeoHotelManagement.DAL
{
	public partial class RoomTypeService
	{
        #region InSert +int Insert(RoomType model)
        /// <summary>
        /// InSert into SQL Server
        /// </summary>
        /// <param name="model">the model you are about to insert</param>
        /// <returns>get the id of inserted model</returns>
        public int Insert(RoomType model)
        {
            #region SQL
            const string sql = @"
INSERT INTO [dbo].[RoomType] (
	[rTypeName]
	,[rTypePrice]
	,[rTypeRemark]
	,[rTypeIsDel]
)
VALUES (
	@rTypeName
	,@rTypePrice
	,@rTypeRemark
	,@rTypeIsDel
);select @@IDENTITY";
            #endregion
            var res = SqlHelper.ExecuteScalar(sql,
					new SqlParameter("@rTypeName", model.rTypeName),					
					new SqlParameter("@rTypePrice", model.rTypePrice),					
					new SqlParameter("@rTypeRemark", model.rTypeRemark),					
					new SqlParameter("@rTypeIsDel", model.rTypeIsDel)					
                );
            return res == null ? 0 : Convert.ToInt32(res);
        }
        #endregion

        #region Delete a record +int Delete(int rtypeid)
        public int Delete(int rtypeid)
        {
            const string sql = "DELETE FROM [dbo].[RoomType] WHERE [rTypeId] = @rTypeId";
            return SqlHelper.ExecuteNonQuery(sql, new SqlParameter("@rTypeId", rtypeid));
        }
        #endregion

        #region Using modified model to update +int Update(RoomType model)
        /// <summary>
        /// Using modified model to update
        /// </summary>
        /// <param name="model">entity</param>
        /// <returns>return how many rows have effected</returns>
        public int Update(RoomType model)
        {
            #region SQL
            const string sql = @"
UPDATE [dbo].[RoomType]
SET 
	[rTypeName] = @rTypeName
	,[rTypePrice] = @rTypePrice
	,[rTypeRemark] = @rTypeRemark
	,[rTypeIsDel] = @rTypeIsDel
WHERE [rTypeId] = @rTypeId";
            #endregion
            return SqlHelper.ExecuteNonQuery(sql,
					new SqlParameter("@rTypeId", model.rTypeId),					
					new SqlParameter("@rTypeName", model.rTypeName),					
					new SqlParameter("@rTypePrice", model.rTypePrice),					
					new SqlParameter("@rTypeRemark", model.rTypeRemark),					
					new SqlParameter("@rTypeIsDel", model.rTypeIsDel)					
                );
        }
        #endregion

        #region Pagination +IEnumerable<RoomType> QueryList(int index, int size, object wheres, string orderField, bool isDesc = true)
        /// <summary>
        /// Paginating the list
        /// </summary>
        /// <param name="index">index</param>
        /// <param name="size">Size of the list</param>
        /// <param name="wheres">anonymous class to pass the where conditions</param>
        /// <param name="orderField">using which column name to order</param>
        /// <param name="isDesc">ascending or descending</param>
        /// <returns>a model list</returns>
        public IEnumerable<RoomType> QueryList(int index, int size, object wheres, string orderField, bool isDesc = true)
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
            var sql = SqlHelper.GenerateQuerySql("RoomType", new[] { "rTypeId", "rTypeName", "rTypePrice", "rTypeRemark", "rTypeIsDel" }, index, size, whereBuilder.ToString(), orderField, isDesc);
            using (var reader = SqlHelper.ExecuteReader(sql, parameters.ToArray()))
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        yield return SqlHelper.MapEntity<RoomType>(reader);
                    }
                }
            }
        }
        #endregion

        #region get single entity +RoomType QuerySingle(object wheres)
         /// <summary>
        /// get single entity
        /// </summary>
        /// <param name="wheres">anonymous class(same functionality as above)</param>
        /// <returns>model</returns>
        public RoomType QuerySingle(object wheres)
        {
            var list = QueryList(1, 1, wheres, null);
            return list != null && list.Any() ? list.FirstOrDefault() : null;
        }
        #endregion

        #region Using id to get single entity +RoomType QuerySingle(int rtypeid)
        /// <summary>
        /// Using id to get single entity
        /// </summary>
        /// <param name="id">ID</param>
        /// <returns>Model</returns>
        public RoomType QuerySingle(int rtypeid)
        {
            const string sql = "SELECT TOP 1 [rTypeId], [rTypeName], [rTypePrice], [rTypeRemark], [rTypeIsDel] FROM [dbo].[RoomType] WHERE [rTypeId] = @rTypeId";
            using (var reader = SqlHelper.ExecuteReader(sql, new SqlParameter("@rTypeId", rtypeid)))
            {
                if (reader.HasRows)
                {
                    reader.Read();
                    return SqlHelper.MapEntity<RoomType>(reader);
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
            var sql = SqlHelper.GenerateQuerySql("RoomType", new[] { "COUNT(1)" }, whereBuilder.ToString(), string.Empty);
            var res = SqlHelper.ExecuteScalar(sql, parameters.ToArray());
            return res == null ? 0 : Convert.ToInt32(res);
        }
        #endregion
	}
}