using System;
using System.Collections.Generic;
using System.Text;
namespace QuanLyBenhXa.BusinessLayer
{
	public class BENH: BusinessObjectBase
	{

		#region InnerClass
		public enum BENHFields
		{
			ID,
			TEN,
			MOTA,
			LOAIBENHID,
			GHICHU
		}
		#endregion

		#region Data Members

			int _iD;
			string _tEN;
			string _mOTA;
			int? _lOAIBENHID;
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

		public string  MOTA
		{
			 get { return _mOTA; }
			 set
			 {
					_mOTA = value;
			 }
		}

		public int?  LOAIBENHID
		{
			 get { return _lOAIBENHID; }
			 set
			 {
					_lOAIBENHID = value;
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
