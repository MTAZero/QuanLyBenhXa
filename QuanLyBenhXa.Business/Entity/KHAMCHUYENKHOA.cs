using System;
using System.Collections.Generic;
using System.Text;
namespace QuanLyBenhXa.BusinessLayer
{
	public class KHAMCHUYENKHOA: BusinessObjectBase
	{

		#region InnerClass
		public enum KHAMCHUYENKHOAFields
		{
			ID,
			BACSIID,
			TAI,
			RANG,
			HAM,
			MAT,
			KHAC,
			GHICHU
		}
		#endregion

		#region Data Members

			int _iD;
			int? _bACSIID;
			string _tAI;
			string _rANG;
			string _hAM;
			string _mAT;
			string _kHAC;
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

		public string  TAI
		{
			 get { return _tAI; }
			 set
			 {
					_tAI = value;
			 }
		}

		public string  RANG
		{
			 get { return _rANG; }
			 set
			 {
					_rANG = value;
			 }
		}

		public string  HAM
		{
			 get { return _hAM; }
			 set
			 {
					_hAM = value;
			 }
		}

		public string  MAT
		{
			 get { return _mAT; }
			 set
			 {
					_mAT = value;
			 }
		}

		public string  KHAC
		{
			 get { return _kHAC; }
			 set
			 {
					_kHAC = value;
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
