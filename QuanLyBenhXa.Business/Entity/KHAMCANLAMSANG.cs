using System;
using System.Collections.Generic;
using System.Text;
namespace QuanLyBenhXa.BusinessLayer
{
	public class KHAMCANLAMSANG: BusinessObjectBase
	{

		#region InnerClass
		public enum KHAMCANLAMSANGFields
		{
			ID,
			MAU,
			NUOCTIEU,
			SIEUAM,
			DIENTIM,
			XQUANG,
			XETNGHIEMKHAC,
			KETQUACANLAMSANG,
			GHICHU
		}
		#endregion

		#region Data Members

			int _iD;
			string _mAU;
			string _nUOCTIEU;
			string _sIEUAM;
			string _dIENTIM;
			string _xQUANG;
			string _xETNGHIEMKHAC;
			string _kETQUACANLAMSANG;
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

		public string  MAU
		{
			 get { return _mAU; }
			 set
			 {
					_mAU = value;
			 }
		}

		public string  NUOCTIEU
		{
			 get { return _nUOCTIEU; }
			 set
			 {
					_nUOCTIEU = value;
			 }
		}

		public string  SIEUAM
		{
			 get { return _sIEUAM; }
			 set
			 {
					_sIEUAM = value;
			 }
		}

		public string  DIENTIM
		{
			 get { return _dIENTIM; }
			 set
			 {
					_dIENTIM = value;
			 }
		}

		public string  XQUANG
		{
			 get { return _xQUANG; }
			 set
			 {
					_xQUANG = value;
			 }
		}

		public string  XETNGHIEMKHAC
		{
			 get { return _xETNGHIEMKHAC; }
			 set
			 {
					_xETNGHIEMKHAC = value;
			 }
		}

		public string  KETQUACANLAMSANG
		{
			 get { return _kETQUACANLAMSANG; }
			 set
			 {
					_kETQUACANLAMSANG = value;
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
