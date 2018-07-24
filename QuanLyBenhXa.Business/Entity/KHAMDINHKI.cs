using System;
using System.Collections.Generic;
using System.Text;
namespace QuanLyBenhXa.BusinessLayer
{
	public class KHAMDINHKI: BusinessObjectBase
	{

		#region InnerClass
		public enum KHAMDINHKIFields
		{
			ID,
			BENHNHANID,
			PHANLOAISUCKHOEID,
			BACSIID,
			KHAMTHELUCID,
			KHAMCANLAMSANGID,
			KHAMCHUYENKHOAID,
			KETLUAN,
			THOIGIANKHAM,
			LOAIHINHKHAM,
			BENHHIEMNGHEO,
			GHICHU
		}
		#endregion

		#region Data Members

			int _iD;
			int? _bENHNHANID;
			int? _pHANLOAISUCKHOEID;
			int? _bACSIID;
			int? _kHAMTHELUCID;
			int? _kHAMCANLAMSANGID;
			int? _kHAMCHUYENKHOAID;
			string _kETLUAN;
			DateTime? _tHOIGIANKHAM;
			int? _lOAIHINHKHAM;
			int? _bENHHIEMNGHEO;
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

		public int?  BENHNHANID
		{
			 get { return _bENHNHANID; }
			 set
			 {
					_bENHNHANID = value;
			 }
		}

		public int?  PHANLOAISUCKHOEID
		{
			 get { return _pHANLOAISUCKHOEID; }
			 set
			 {
					_pHANLOAISUCKHOEID = value;
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

		public int?  KHAMTHELUCID
		{
			 get { return _kHAMTHELUCID; }
			 set
			 {
					_kHAMTHELUCID = value;
			 }
		}

		public int?  KHAMCANLAMSANGID
		{
			 get { return _kHAMCANLAMSANGID; }
			 set
			 {
					_kHAMCANLAMSANGID = value;
			 }
		}

		public int?  KHAMCHUYENKHOAID
		{
			 get { return _kHAMCHUYENKHOAID; }
			 set
			 {
					_kHAMCHUYENKHOAID = value;
			 }
		}

		public string  KETLUAN
		{
			 get { return _kETLUAN; }
			 set
			 {
					_kETLUAN = value;
			 }
		}

		public DateTime?  THOIGIANKHAM
		{
			 get { return _tHOIGIANKHAM; }
			 set
			 {
					_tHOIGIANKHAM = value;
			 }
		}

		public int?  LOAIHINHKHAM
		{
			 get { return _lOAIHINHKHAM; }
			 set
			 {
					_lOAIHINHKHAM = value;
			 }
		}

		public int?  BENHHIEMNGHEO
		{
			 get { return _bENHHIEMNGHEO; }
			 set
			 {
					_bENHHIEMNGHEO = value;
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
