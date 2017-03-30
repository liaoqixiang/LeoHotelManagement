using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using LeoHotelManagement.Model;
using LeoHotelManagement.Utility;

namespace LeoHotelManagement.DAL
{
	public partial class RoomService
	{
        #region InSert +int Insert(Room model)
        /// <summary>
        /// InSert into SQL Server
        /// </summary>
        /// <param name="model">the model you are about to insert</param>
        /// <returns>get the id of inserted model</returns>
        public int Insert(Room model)
        {
            #region SQL
            const string sql = @"
INSERT INTO [dbo].[Room] (
	[roomId]
	,[rTypeId]
	,[roomStatus]
	,[roomFloor]
	,[roomRemark]
	,[roomIsDel]
)
VALUES (
	@roomId
	,@rTypeId
	,@roomStatus
	,@roomFloor
	,@roomRemark
	,@roomIsDel
);select @@IDENTITY";
            #endregion
            var res = SqlHelper.ExecuteScalar(sql,
					new SqlParameter("@roomId", model.roomId),					
					new SqlParameter("@rTypeId", model.rTypeId),					
					new SqlParameter("@roomStatus", model.roomStatus),					
					new SqlParameter("@roomFloor", model.roomFloor),					
					new SqlParameter("@roomRemark", model.roomRemark),					
					new SqlParameter("@roomIsDel", model.roomIsDel)					
                );
            if (res == DBNull.Value)
            {
                return 0;
            }
            return res == null ? 0 : Convert.ToInt32(res);
        }
        #endregion

        #region Delete a record +int Delete(int roomid)
        public int Delete(int roomid)
        {
            const string sql = "DELETE FROM [dbo].[Room] WHERE [roomId] = @roomId";
            return SqlHelper.ExecuteNonQuery(sql, new SqlParameter("@roomId", roomid));
        }
        #endregion

        #region Using modified model to update +int Update(Room model)
        /// <summary>
        /// Using modified model to update
        /// </summary>
        /// <param name="model">entity</param>
        /// <returns>return how many rows have effected</returns>
        public int Update(Room model)
        {
            #region SQL
            const string sql = @"
UPDATE [dbo].[Room]
SET 
	[roomId] = @roomId
	,[rTypeId] = @rTypeId
	,[roomStatus] = @roomStatus
	,[roomFloor] = @roomFloor
	,[roomRemark] = @roomRemark
	,[roomIsDel] = @roomIsDel
WHERE [roomId] = @roomId";
            #endregion
            return SqlHelper.ExecuteNonQuery(sql,
					new SqlParameter("@roomId", model.roomId),					
					new SqlParameter("@rTypeId", model.rTypeId),					
					new SqlParameter("@roomStatus", model.roomStatus),					
					new SqlParameter("@roomFloor", model.roomFloor),					
					new SqlParameter("@roomRemark", model.roomRemark),					
					new SqlParameter("@roomIsDel", model.roomIsDel)					
                );
        }
        #endregion

        #region Pagination +IEnumerable<Room> QueryList(int index, int size, object wheres, string orderField, bool isDesc = true)
        /// <summary>
        /// Paginating the list
        /// </summary>
        /// <param name="index">index</param>
        /// <param name="size">Size of the list</param>
        /// <param name="wheres">anonymous class to pass the where conditions</param>
        /// <param name="orderField">using which column name to order</param>
        /// <param name="isDesc">ascending or descending</param>
        /// <returns>a model list</returns>
        public IEnumerable<Room> QueryList(int index, int size, object wheres, string orderField, bool isDesc = true)
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
            var sql = SqlHelper.GenerateQuerySql("Room", new[] { "roomId", "rTypeId", "roomStatus", "roomFloor", "roomRemark", "roomIsDel" }, index, size, whereBuilder.ToString(), orderField, isDesc);
            using (var reader = SqlHelper.ExecuteReader(sql, parameters.ToArray()))
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        yield return SqlHelper.MapEntity<Room>(reader);
                    }
                }
            }
        }
        #endregion

        #region get single entity +Room QuerySingle(object wheres)
         /// <summary>
        /// get single entity
        /// </summary>
        /// <param name="wheres">anonymous class(same functionality as above)</param>
        /// <returns>model</returns>
        public Room QuerySingle(object wheres)
        {
            var list = QueryList(1, 1, wheres, null);
            return list != null && list.Any() ? list.FirstOrDefault() : null;
        }
        #endregion

        #region Using id to get single entity +Room QuerySingle(int roomid)
        /// <summary>
        /// Using id to get single entity
        /// </summary>
        /// <param name="id">ID</param>
        /// <returns>Model</returns>
        public Room QuerySingle(int roomid)
        {
            const string sql = "SELECT TOP 1 [roomId], [rTypeId], [roomStatus], [roomFloor], [roomRemark], [roomIsDel] FROM [dbo].[Room] WHERE [roomId] = @roomId";
            using (var reader = SqlHelper.ExecuteReader(sql, new SqlParameter("@roomId", roomid)))
            {
                if (reader.HasRows)
                {
                    reader.Read();
                    return SqlHelper.MapEntity<Room>(reader);
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
            var sql = SqlHelper.GenerateQuerySql("Room", new[] { "COUNT(1)" }, whereBuilder.ToString(), string.Empty);
            var res = SqlHelper.ExecuteScalar(sql, parameters.ToArray());
            return res == null ? 0 : Convert.ToInt32(res);
        }
        #endregion
	}
}