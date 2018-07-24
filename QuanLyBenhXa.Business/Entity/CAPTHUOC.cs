using System;
using System.Collections.Generic;
using System.Text;
namespace QuanLyBenhXa.BusinessLayer
{
	public class CAPTHUOC: BusinessObjectBase
	{

		#region InnerClass
		public enum CAPTHUOCFields
		{
			ID,
			NGAY,
			BACSIID,
			KHAMTHUONGXUYENID,
			GHICHU
		}
		#endregion

		#region Data Members

			int _iD;
			DateTime? _nGAY;
			int? _bACSIID;
			int? _kHAMTHUONGXUYENID;
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

		public int?  BACSIID
		{
			 get { return _bACSIID; }
			 set
			 {
					_bACSIID = value;
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
