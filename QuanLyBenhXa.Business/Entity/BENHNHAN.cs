using System;
using System.Collections.Generic;
using System.Text;
namespace QuanLyBenhXa.BusinessLayer
{
	public class BENHNHAN: BusinessObjectBase
	{

		#region InnerClass
		public enum BENHNHANFields
		{
			ID,
			HOTEN,
			GIOITINH,
			SDT,
			QUEQUAN,
			NGAYSINH,
			MATHEBHYT,
			NAMNHAPNGU,
			TRINHDOVANHOA,
			CAPBACID,
			CHUCVUID,
			NGHENGHIEP,
			DOITUONGID,
			DONVIID,
			TIENSUBENH,
			NHOMMAU,
			DIUNG,
			GHICHU
		}
		#endregion

		#region Data Members

			int _iD;
			string _hOTEN;
			int? _gIOITINH;
			string _sDT;
			string _qUEQUAN;
			DateTime? _nGAYSINH;
			string _mATHEBHYT;
			int? _nAMNHAPNGU;
			string _tRINHDOVANHOA;
			int? _cAPBACID;
			int? _cHUCVUID;
			string _nGHENGHIEP;
			int? _dOITUONGID;
			int? _dONVIID;
			string _tIENSUBENH;
			string _nHOMMAU;
			string _dIUNG;
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

		public string  HOTEN
		{
			 get { return _hOTEN; }
			 set
			 {
					_hOTEN = value;
			 }
		}

		public int?  GIOITINH
		{
			 get { return _gIOITINH; }
			 set
			 {
					_gIOITINH = value;
			 }
		}

		public string  SDT
		{
			 get { return _sDT; }
			 set
			 {
					_sDT = value;
			 }
		}

		public string  QUEQUAN
		{
			 get { return _qUEQUAN; }
			 set
			 {
					_qUEQUAN = value;
			 }
		}

		public DateTime?  NGAYSINH
		{
			 get { return _nGAYSINH; }
			 set
			 {
					_nGAYSINH = value;
			 }
		}

		public string  MATHEBHYT
		{
			 get { return _mATHEBHYT; }
			 set
			 {
					_mATHEBHYT = value;
			 }
		}

		public int?  NAMNHAPNGU
		{
			 get { return _nAMNHAPNGU; }
			 set
			 {
					_nAMNHAPNGU = value;
			 }
		}

		public string  TRINHDOVANHOA
		{
			 get { return _tRINHDOVANHOA; }
			 set
			 {
					_tRINHDOVANHOA = value;
			 }
		}

		public int?  CAPBACID
		{
			 get { return _cAPBACID; }
			 set
			 {
					_cAPBACID = value;
			 }
		}

		public int?  CHUCVUID
		{
			 get { return _cHUCVUID; }
			 set
			 {
					_cHUCVUID = value;
			 }
		}

		public string  NGHENGHIEP
		{
			 get { return _nGHENGHIEP; }
			 set
			 {
					_nGHENGHIEP = value;
			 }
		}

		public int?  DOITUONGID
		{
			 get { return _dOITUONGID; }
			 set
			 {
					_dOITUONGID = value;
			 }
		}

		public int?  DONVIID
		{
			 get { return _dONVIID; }
			 set
			 {
					_dONVIID = value;
			 }
		}

		public string  TIENSUBENH
		{
			 get { return _tIENSUBENH; }
			 set
			 {
					_tIENSUBENH = value;
			 }
		}

		public string  NHOMMAU
		{
			 get { return _nHOMMAU; }
			 set
			 {
					_nHOMMAU = value;
			 }
		}

		public string  DIUNG
		{
			 get { return _dIUNG; }
			 set
			 {
					_dIUNG = value;
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
