using System;
using System.Collections.Generic;
using System.Text;
namespace QuanLyBenhXa.BusinessLayer
{
	public class KHAMTHUONGXUYEN: BusinessObjectBase
	{

		#region InnerClass
		public enum KHAMTHUONGXUYENFields
		{
			ID,
			BENHNHANID,
			BACSIID,
			THOIGIAN,
			BENHID,
			CHANDOANSOBO,
			CACHGIAIQUYET,
			THOIGIANCHUYEN,
			BENHVIENID,
			THOIGIANVAO,
			THOIGIANRA,
			PHUONGPHAPDIEUTRI,
			KETQUADIEUTRI,
			CHIPHIKHAM,
			GHICHU,
			TRIEUCHUNG
		}
		#endregion

		#region Data Members

			int _iD;
			int? _bENHNHANID;
			int? _bACSIID;
			DateTime? _tHOIGIAN;
			int? _bENHID;
			string _cHANDOANSOBO;
			int? _cACHGIAIQUYET;
			DateTime? _tHOIGIANCHUYEN;
			int? _bENHVIENID;
			DateTime? _tHOIGIANVAO;
			DateTime? _tHOIGIANRA;
			string _pHUONGPHAPDIEUTRI;
			string _kETQUADIEUTRI;
			int? _cHIPHIKHAM;
			string _gHICHU;
			string _tRIEUCHUNG;

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

		public int?  BACSIID
		{
			 get { return _bACSIID; }
			 set
			 {
					_bACSIID = value;
			 }
		}

		public DateTime?  THOIGIAN
		{
			 get { return _tHOIGIAN; }
			 set
			 {
					_tHOIGIAN = value;
			 }
		}

		public int?  BENHID
		{
			 get { return _bENHID; }
			 set
			 {
					_bENHID = value;
			 }
		}

		public string  CHANDOANSOBO
		{
			 get { return _cHANDOANSOBO; }
			 set
			 {
					_cHANDOANSOBO = value;
			 }
		}

		public int?  CACHGIAIQUYET
		{
			 get { return _cACHGIAIQUYET; }
			 set
			 {
					_cACHGIAIQUYET = value;
			 }
		}

		public DateTime?  THOIGIANCHUYEN
		{
			 get { return _tHOIGIANCHUYEN; }
			 set
			 {
					_tHOIGIANCHUYEN = value;
			 }
		}

		public int?  BENHVIENID
		{
			 get { return _bENHVIENID; }
			 set
			 {
					_bENHVIENID = value;
			 }
		}

		public DateTime?  THOIGIANVAO
		{
			 get { return _tHOIGIANVAO; }
			 set
			 {
					_tHOIGIANVAO = value;
			 }
		}

		public DateTime?  THOIGIANRA
		{
			 get { return _tHOIGIANRA; }
			 set
			 {
					_tHOIGIANRA = value;
			 }
		}

		public string  PHUONGPHAPDIEUTRI
		{
			 get { return _pHUONGPHAPDIEUTRI; }
			 set
			 {
					_pHUONGPHAPDIEUTRI = value;
			 }
		}

		public string  KETQUADIEUTRI
		{
			 get { return _kETQUADIEUTRI; }
			 set
			 {
					_kETQUADIEUTRI = value;
			 }
		}

		public int?  CHIPHIKHAM
		{
			 get { return _cHIPHIKHAM; }
			 set
			 {
					_cHIPHIKHAM = value;
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

		public string  TRIEUCHUNG
		{
			 get { return _tRIEUCHUNG; }
			 set
			 {
					_tRIEUCHUNG = value;
			 }
		}


		#endregion


	}
}
