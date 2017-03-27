using System.Collections.Generic;
using System.Linq;
using LeoHotelManagement.DAL;
using LeoHotelManagement.Model;

namespace LeoHotelManagement.BLL 
{
	public partial class RoomTypeManager
	{
   		     
		/// <summary>
        /// object of database
        /// </summary>
        private RoomTypeService _dao = new RoomTypeService();

        #region InSert +int Insert(RoomType model)
        /// <summary>
        /// InSert into SQL Server
        /// </summary>
        /// <param name="model">the model you are about to insert</param>
        /// <returns>get the id of inserted model</returns>
        public int Insert(RoomType model)
        {
            return _dao.Insert(model);
        }
        #endregion

        #region Delete a record +int Delete(int rtypeid)
        public int Delete(int rtypeid)
        {
            return _dao.Delete(rtypeid);
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
            return _dao.Update(model);
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
            return _dao.QueryList(index, size, wheres, orderField, isDesc);
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
            return _dao.QuerySingle(wheres);
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
            return _dao.QuerySingle(rtypeid);
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