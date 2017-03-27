using System.Collections.Generic;
using System.Linq;
using LeoHotelManagement.DAL;
using LeoHotelManagement.Model;

namespace LeoHotelManagement.BLL 
{
	public partial class CustomerManager
	{
   		     
		/// <summary>
        /// object of database
        /// </summary>
        private CustomerService _dao = new CustomerService();

        #region InSert +int Insert(Customer model)
        /// <summary>
        /// InSert into SQL Server
        /// </summary>
        /// <param name="model">the model you are about to insert</param>
        /// <returns>get the id of inserted model</returns>
        public int Insert(Customer model)
        {
            return _dao.Insert(model);
        }
        #endregion

        #region Delete a record +int Delete(int customerid)
        public int Delete(int customerid)
        {
            return _dao.Delete(customerid);
        }
        #endregion

        #region Using modified model to update +int Update(Customer model)
        /// <summary>
        /// Using modified model to update
        /// </summary>
        /// <param name="model">entity</param>
        /// <returns>return how many rows have effected</returns>
        public int Update(Customer model)
        {
            return _dao.Update(model);
        }
        #endregion

        #region Pagination +IEnumerable<Customer> QueryList(int index, int size, object wheres, string orderField, bool isDesc = true)
        /// <summary>
        /// Paginating the list
        /// </summary>
        /// <param name="index">index</param>
        /// <param name="size">Size of the list</param>
        /// <param name="wheres">anonymous class to pass the where conditions</param>
        /// <param name="orderField">using which column name to order</param>
        /// <param name="isDesc">ascending or descending</param>
        /// <returns>a model list</returns>
        public IEnumerable<Customer> QueryList(int index, int size, object wheres, string orderField, bool isDesc = true)
        {
            return _dao.QueryList(index, size, wheres, orderField, isDesc);
        }
        #endregion

        #region get single entity +Customer QuerySingle(object wheres)
        /// <summary>
        /// get single entity
        /// </summary>
        /// <param name="wheres">anonymous class(same functionality as above)</param>
        /// <returns>model</returns>
        public Customer QuerySingle(object wheres)
        {
            return _dao.QuerySingle(wheres);
        }
        #endregion
        
        #region Using id to get single entity +Customer QuerySingle(int customerid)
         /// <summary>
        /// Using id to get single entity
        /// </summary>
        /// <param name="id">ID</param>
        /// <returns>Model</returns>
        public Customer QuerySingle(int customerid)
        {
            return _dao.QuerySingle(customerid);
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