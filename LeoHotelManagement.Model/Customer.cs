using System; 
namespace LeoHotelManagement.Model
{
	public class Customer
	{
   		     
      	/// <summary>
		/// customer ID
        /// </summary>
        public int CustomerId { get; set; }
		/// <summary>
		/// cName
        /// </summary>
        public string cName { get; set; }
		/// <summary>
		/// cGender
        /// </summary>
        public bool cGender { get; set; }
		/// <summary>
		/// 证件类型：0--身份证，1--学生证，3--军官证，4--其他
        /// </summary>
        public int cIdType { get; set; }
		/// <summary>
		/// 证件号
        /// </summary>
        public string cIdNo { get; set; }
		/// <summary>
		/// 联系方式
        /// </summary>
        public string cPhone { get; set; }
		/// <summary>
		/// 客户备注
        /// </summary>
        public string cRemark { get; set; }
		   
	}
}

