using System;
using System.Collections.Generic;
using System.Text;
namespace QuanLyBenhXa.BusinessLayer
{
	public class VATTU: BusinessObjectBase
	{

		#region InnerClass
		public enum VATTUFields
		{
			ID,
			TEN,
			SOLUONG,
			KYHIEU,
			GHICHU
		}
		#endregion

		#region Data Members

			int _iD;
			string _tEN;
			int? _sOLUONG;
			string _kYHIEU;
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

		public int?  SOLUONG
		{
			 get { return _sOLUONG; }
			 set
			 {
					_sOLUONG = value;
			 }
		}

		public string  KYHIEU
		{
			 get { return _kYHIEU; }
			 set
			 {
					_kYHIEU = value;
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
