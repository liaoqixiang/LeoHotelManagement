using System; 
namespace LeoHotelManagement.Model
{
	public class Admin
	{
   		     
      	/// <summary>
		/// admin account
        /// </summary>
        public string uId { get; set; }
		/// <summary>
		/// admin password
        /// </summary>
        public string uPwd { get; set; }
		/// <summary>
		/// admin name
        /// </summary>
        public string uName { get; set; }
		/// <summary>
		/// 0 means not deleted,1 means deleted
        /// </summary>
        public bool uIsDel { get; set; }
		/// <summary>
		/// remark
        /// </summary>
        public string uRemark { get; set; }
		   
	}
}

