using System;
using System.Collections.Generic;
using System.Text;
namespace QuanLyBenhXa.BusinessLayer
{
	public class CHITIETNHAP: BusinessObjectBase
	{

		#region InnerClass
		public enum CHITIETNHAPFields
		{
			ID,
			NHAPTHUOCID,
			THUOCID,
			SOLUONG,
			DONGIA,
			THANHTIEN,
			GHICHU
		}
		#endregion

		#region Data Members

			int _iD;
			int? _nHAPTHUOCID;
			int? _tHUOCID;
			int? _sOLUONG;
			int? _dONGIA;
			int? _tHANHTIEN;
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

		public int?  NHAPTHUOCID
		{
			 get { return _nHAPTHUOCID; }
			 set
			 {
					_nHAPTHUOCID = value;
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

		public int?  DONGIA
		{
			 get { return _dONGIA; }
			 set
			 {
					_dONGIA = value;
			 }
		}

		public int?  THANHTIEN
		{
			 get { return _tHANHTIEN; }
			 set
			 {
					_tHANHTIEN = value;
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
