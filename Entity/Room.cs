using System; 
namespace LeoHotelManagement.Model
{
	public class Room
	{
   		     
      	/// <summary>
		/// room number
        /// </summary>
        public int roomId { get; set; }
		/// <summary>
		/// type of room,
        /// </summary>
        public int rTypeId { get; set; }
		/// <summary>
		/// state of room, 0 empty, 1 is cleaning, 2 is occupied
        /// </summary>
        public int roomStatus { get; set; }
		/// <summary>
		/// floor
        /// </summary>
        public int roomFloor { get; set; }
		/// <summary>
		/// room description
        /// </summary>
        public string roomRemark { get; set; }
		/// <summary>
		/// 0 means not deleted, 1 means deleted
        /// </summary>
        public bool roomIsDel { get; set; }
		   
	}
}

