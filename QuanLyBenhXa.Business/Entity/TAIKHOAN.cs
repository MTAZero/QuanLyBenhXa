using System;
using System.Collections.Generic;
using System.Text;
namespace QuanLyBenhXa.BusinessLayer
{
	public class TAIKHOAN: BusinessObjectBase
	{

		#region InnerClass
		public enum TAIKHOANFields
		{
			ID,
			TENDANGNHAP,
			PASSWORDMD5
		}
		#endregion

		#region Data Members

			int _iD;
			string _tENDANGNHAP;
			string _pASSWORDMD5;

		#endregion

		#region Properties

		public int  ID
		{
			 get { return _iD; }
			 set
			 {
					_iD = value;
			 }
		}

		public string  TENDANGNHAP
		{
			 get { return _tENDANGNHAP; }
			 set
			 {
					_tENDANGNHAP = value;
			 }
		}

		public string  PASSWORDMD5
		{
			 get { return _pASSWORDMD5; }
			 set
			 {
					_pASSWORDMD5 = value;
			 }
		}


		#endregion


	}
}
