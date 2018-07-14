using System;
using System.Collections.Generic;
using System.Text;
namespace QuanLyBenhXa.BusinessLayer
{
	public class MUONVATTU: BusinessObjectBase
	{

		#region InnerClass
		public enum MUONVATTUFields
		{
			ID,
			NGAYMUON,
			NGAYTRA,
			GHICHU,
			BACSIMUONID,
			BACSITRAID,
			BENHNHANID,
			KHAMTHUONGXUYENID,
			TRANGTHAI
		}
		#endregion

		#region Data Members

			int _iD;
			DateTime? _nGAYMUON;
			DateTime? _nGAYTRA;
			string _gHICHU;
			int? _bACSIMUONID;
			int? _bACSITRAID;
			int? _bENHNHANID;
			int? _kHAMTHUONGXUYENID;
			int? _tRANGTHAI;

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

		public DateTime?  NGAYMUON
		{
			 get { return _nGAYMUON; }
			 set
			 {
					_nGAYMUON = value;
			 }
		}

		public DateTime?  NGAYTRA
		{
			 get { return _nGAYTRA; }
			 set
			 {
					_nGAYTRA = value;
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

		public int?  BACSIMUONID
		{
			 get { return _bACSIMUONID; }
			 set
			 {
					_bACSIMUONID = value;
			 }
		}

		public int?  BACSITRAID
		{
			 get { return _bACSITRAID; }
			 set
			 {
					_bACSITRAID = value;
			 }
		}

		public int?  BENHNHANID
		{
			 get { return _bENHNHANID; }
			 set
			 {
					_bENHNHANID = value;
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

		public int?  TRANGTHAI
		{
			 get { return _tRANGTHAI; }
			 set
			 {
					_tRANGTHAI = value;
			 }
		}


		#endregion


	}
}
