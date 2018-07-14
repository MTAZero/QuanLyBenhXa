using System;
using System.Collections.Generic;
using System.Text;
namespace QuanLyBenhXa.BusinessLayer
{
	public class GIAYGIOITHIEU: BusinessObjectBase
	{

		#region InnerClass
		public enum GIAYGIOITHIEUFields
		{
			ID,
			NGAY,
			KHAMTHUONGXUYENID,
			YKIENDENGHI,
			GHICHU
		}
		#endregion

		#region Data Members

			int _iD;
			DateTime? _nGAY;
			int? _kHAMTHUONGXUYENID;
			string _yKIENDENGHI;
			string _gHICHU;

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

		public DateTime?  NGAY
		{
			 get { return _nGAY; }
			 set
			 {
					_nGAY = value;
			 }
		}

		public int?  KHAMTHUONGXUYENID
		{
			 get { return _kHAMTHUONGXUYENID; }
			 set
			 {
					_kHAMTHUONGXUYENID = value;
			 }
		}

		public string  YKIENDENGHI
		{
			 get { return _yKIENDENGHI; }
			 set
			 {
					_yKIENDENGHI = value;
			 }
		}

		public string  GHICHU
		{
			 get { return _gHICHU; }
			 set
			 {
					_gHICHU = value;
			 }
		}


		#endregion


	}
}
