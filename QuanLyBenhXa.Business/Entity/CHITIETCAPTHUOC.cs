using System;
using System.Collections.Generic;
using System.Text;
namespace QuanLyBenhXa.BusinessLayer
{
	public class CHITIETCAPTHUOC: BusinessObjectBase
	{

		#region InnerClass
		public enum CHITIETCAPTHUOCFields
		{
			ID,
			CAPTHUOCID,
			THUOCID,
			SOLUONG,
			GHICHU
		}
		#endregion

		#region Data Members

			int _iD;
			int? _cAPTHUOCID;
			int? _tHUOCID;
			int? _sOLUONG;
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

		public int?  CAPTHUOCID
		{
			 get { return _cAPTHUOCID; }
			 set
			 {
					_cAPTHUOCID = value;
			 }
		}

		public int?  THUOCID
		{
			 get { return _tHUOCID; }
			 set
			 {
					_tHUOCID = value;
			 }
		}

		public int?  SOLUONG
		{
			 get { return _sOLUONG; }
			 set
			 {
					_sOLUONG = value;
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
