using System;
using System.Collections.Generic;
using System.Text;
namespace QuanLyBenhXa.BusinessLayer
{
	public class CHITIETMUONVATTU: BusinessObjectBase
	{

		#region InnerClass
		public enum CHITIETMUONVATTUFields
		{
			ID,
			MUONVATTUID,
			VATTUID,
			SOLUONG,
			GHICHU
		}
		#endregion

		#region Data Members

			int _iD;
			int? _mUONVATTUID;
			int? _vATTUID;
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

		public int?  MUONVATTUID
		{
			 get { return _mUONVATTUID; }
			 set
			 {
					_mUONVATTUID = value;
			 }
		}

		public int?  VATTUID
		{
			 get { return _vATTUID; }
			 set
			 {
					_vATTUID = value;
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
