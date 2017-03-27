using System.Collections.Generic;
using System.Linq;
using LeoHotelManagement.DAL;
using LeoHotelManagement.Model;

namespace LeoHotelManagement.BLL 
{
	public partial class RoomManager
	{
   		     
		/// <summary>
        /// object of database
        /// </summary>
        private RoomService _dao = new RoomService();

        #region InSert +int Insert(Room model)
        /// <summary>
        /// InSert into SQL Server
        /// </summary>
        /// <param name="model">the model you are about to insert</param>
        /// <returns>get the id of inserted model</returns>
        public int Insert(Room model)
        {
            return _dao.Insert(model);
        }
        #endregion

        #region Delete a record +int Delete(int roomid)
        public int Delete(int roomid)
        {
            return _dao.Delete(roomid);
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
            return _dao.Update(model);
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
            return _dao.QueryList(index, size, wheres, orderField, isDesc);
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
            return _dao.QuerySingle(wheres);
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
            return _dao.QuerySingle(roomid);
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
            return _dao.QueryCount(wheres);
        }
        #endregion
	}
}