using System; 
namespace LeoHotelManagement.Model
{
	public class Admin
	{
   		     
      	/// <summary>
		/// 管理员账号
        /// </summary>
        public string uId { get; set; }
		/// <summary>
		/// 管理员密码
        /// </summary>
        public string uPwd { get; set; }
		/// <summary>
		/// 管理员昵称
        /// </summary>
        public string uName { get; set; }
		/// <summary>
		/// 是否删除 0代表未删除，1代表删除
        /// </summary>
        public bool uIsDel { get; set; }
		/// <summary>
		/// 账号备注
        /// </summary>
        public string uRemark { get; set; }
		   
	}
}

