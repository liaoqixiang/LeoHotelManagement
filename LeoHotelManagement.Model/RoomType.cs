using System; 
namespace LeoHotelManagement.Model
{
	public class RoomType
	{
   		     
      	/// <summary>
		/// roomtypeid
        /// </summary>
        public int rTypeId { get; set; }
		/// <summary>
		/// room_name
        /// </summary>
        public string rTypeName { get; set; }
		/// <summary>
		/// room_price
        /// </summary>
        public decimal rTypePrice { get; set; }
		/// <summary>
		/// remark
        /// </summary>
        public string rTypeRemark { get; set; }
		/// <summary>
		/// 0 means not deleted 1 means deleted
        /// </summary>
        public bool rTypeIsDel { get; set; }
		   
	}
}

