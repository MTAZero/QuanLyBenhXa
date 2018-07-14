using System;
using System.Collections.Generic;
using System.Text;
namespace QuanLyBenhXa.BusinessLayer
{
	public class LOAIBENH: BusinessObjectBase
	{

		#region InnerClass
		public enum LOAIBENHFields
		{
			ID,
			TEN,
			NHOMBENHID,
			GHICHU
		}
		#endregion

		#region Data Members

			int _iD;
			string _tEN;
			int? _nHOMBENHID;
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

		public int?  NHOMBENHID
		{
			 get { return _nHOMBENHID; }
			 set
			 {
					_nHOMBENHID = value;
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
