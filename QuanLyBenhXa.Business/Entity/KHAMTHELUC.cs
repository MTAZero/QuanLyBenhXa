using System;
using System.Collections.Generic;
using System.Text;
namespace QuanLyBenhXa.BusinessLayer
{
	public class KHAMTHELUC: BusinessObjectBase
	{

		#region InnerClass
		public enum KHAMTHELUCFields
		{
			ID,
			BACSIID,
			CHIEUCAO,
			CANNANG,
			MACH,
			HUYETAP,
			VONGNGUC,
			NHIETDO,
			KETQUALAMSANG,
			GHICHU
		}
		#endregion

		#region Data Members

			int _iD;
			int? _bACSIID;
			string _cHIEUCAO;
			int? _cANNANG;
			string _mACH;
			string _hUYETAP;
			int? _vONGNGUC;
			int? _nHIETDO;
			string _kETQUALAMSANG;
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

		public int?  BACSIID
		{
			 get { return _bACSIID; }
			 set
			 {
					_bACSIID = value;
			 }
		}

		public string  CHIEUCAO
		{
			 get { return _cHIEUCAO; }
			 set
			 {
					_cHIEUCAO = value;
			 }
		}

		public int?  CANNANG
		{
			 get { return _cANNANG; }
			 set
			 {
					_cANNANG = value;
			 }
		}

		public string  MACH
		{
			 get { return _mACH; }
			 set
			 {
					_mACH = value;
			 }
		}

		public string  HUYETAP
		{
			 get { return _hUYETAP; }
			 set
			 {
					_hUYETAP = value;
			 }
		}

		public int?  VONGNGUC
		{
			 get { return _vONGNGUC; }
			 set
			 {
					_vONGNGUC = value;
			 }
		}

		public int?  NHIETDO
		{
			 get { return _nHIETDO; }
			 set
			 {
					_nHIETDO = value;
			 }
		}

		public string  KETQUALAMSANG
		{
			 get { return _kETQUALAMSANG; }
			 set
			 {
					_kETQUALAMSANG = value;
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
