using System;
using System.Collections.Generic;
using System.Text;
namespace QuanLyBenhXa.BusinessLayer
{
	public class CHUCVU: BusinessObjectBase
	{

		#region InnerClass
		public enum CHUCVUFields
		{
			ID,
			TEN,
			KIHIEU,
			GHICHU
		}
		#endregion

		#region Data Members

			int _iD;
			string _tEN;
			string _kIHIEU;
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

		public string  KIHIEU
		{
			 get { return _kIHIEU; }
			 set
			 {
					_kIHIEU = value;
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
