using System;
using System.Collections.Generic;
using System.Text;
namespace QuanLyBenhXa.BusinessLayer
{
	public class NHAPTHUOC: BusinessObjectBase
	{

		#region InnerClass
		public enum NHAPTHUOCFields
		{
			ID,
			NGAY,
			BACSIID,
			TONGTIEN,
			GHICHU
		}
		#endregion

		#region Data Members

			int _iD;
			DateTime? _nGAY;
			int? _bACSIID;
			int? _tONGTIEN;
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

		public int?  TONGTIEN
		{
			 get { return _tONGTIEN; }
			 set
			 {
					_tONGTIEN = value;
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
