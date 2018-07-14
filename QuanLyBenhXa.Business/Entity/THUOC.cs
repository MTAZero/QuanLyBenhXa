using System;
using System.Collections.Generic;
using System.Text;
namespace QuanLyBenhXa.BusinessLayer
{
	public class THUOC: BusinessObjectBase
	{

		#region InnerClass
		public enum THUOCFields
		{
			ID,
			TEN,
			HAMLUONG,
			CACHSUDUNG,
			SOLUONG,
			HANSUDUNG,
			GHICHU
		}
		#endregion

		#region Data Members

			int _iD;
			string _tEN;
			string _hAMLUONG;
			string _cACHSUDUNG;
			int? _sOLUONG;
			int? _hANSUDUNG;
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

		public string  TEN
		{
			 get { return _tEN; }
			 set
			 {
					_tEN = value;
			 }
		}

		public string  HAMLUONG
		{
			 get { return _hAMLUONG; }
			 set
			 {
					_hAMLUONG = value;
			 }
		}

		public string  CACHSUDUNG
		{
			 get { return _cACHSUDUNG; }
			 set
			 {
					_cACHSUDUNG = value;
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

		public int?  HANSUDUNG
		{
			 get { return _hANSUDUNG; }
			 set
			 {
					_hANSUDUNG = value;
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
