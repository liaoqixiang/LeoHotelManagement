using System; 
namespace LeoHotelManagement.Model
{
	public class Order
	{
   		     
      	/// <summary>
		/// order number
        /// </summary>
        public int orderId { get; set; }
		/// <summary>
		/// check in time
        /// </summary>
        public DateTime orderBeginTime { get; set; }
		/// <summary>
		/// checkout time
        /// </summary>
        public DateTime orderEndTime { get; set; }
		/// <summary>
		/// bond
        /// </summary>
        public decimal orderbond { get; set; }
		/// <summary>
		/// amount
        /// </summary>
        public decimal orderAmount { get; set; }
		/// <summary>
		/// which room this order belongs to 
        /// </summary>
        public int roomId { get; set; }
		/// <summary>
		/// 0 means order not finished, 1 means order finished
        /// </summary>
        public int orderStatus { get; set; }
		/// <summary>
		/// 0 means not deleted, 1 means deleted
        /// </summary>
        public bool orderIsDel { get; set; }
		/// <summary>
		/// remark
        /// </summary>
        public string orderRemark { get; set; }
		   
	}
}

