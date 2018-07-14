using System;
using System.Collections.Generic;
using System.Text;
namespace QuanLyBenhXa.BusinessLayer
{
	public class BACSI: BusinessObjectBase
	{

		#region InnerClass
		public enum BACSIFields
		{
			ID,
			HOTEN,
			GIOITINH,
			SDT,
			QUEQUAN,
			QUYEN,
			NGAYSINH,
			CAPBACID,
			CHUCVUID,
			DONVI,
			DANTOC,
			TRINHDOVANHOA,
			DOITUONGID,
			DONVIID,
			CANBOCAPCAO,
			TAIKHOANID,
			GHICHU
		}
		#endregion

		#region Data Members

			int _iD;
			string _hOTEN;
			int? _gIOITINH;
			string _sDT;
			string _qUEQUAN;
			int? _qUYEN;
			DateTime? _nGAYSINH;
			int? _cAPBACID;
			int? _cHUCVUID;
			string _dONVI;
			string _dANTOC;
			string _tRINHDOVANHOA;
			int? _dOITUONGID;
			int? _dONVIID;
			int? _cANBOCAPCAO;
			int? _tAIKHOANID;
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

		public int?  QUYEN
		{
			 get { return _qUYEN; }
			 set
			 {
					_qUYEN = value;
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

		public string  DONVI
		{
			 get { return _dONVI; }
			 set
			 {
					_dONVI = value;
			 }
		}

		public string  DANTOC
		{
			 get { return _dANTOC; }
			 set
			 {
					_dANTOC = value;
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

		public int?  CANBOCAPCAO
		{
			 get { return _cANBOCAPCAO; }
			 set
			 {
					_cANBOCAPCAO = value;
			 }
		}

		public int?  TAIKHOANID
		{
			 get { return _tAIKHOANID; }
			 set
			 {
					_tAIKHOANID = value;
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
