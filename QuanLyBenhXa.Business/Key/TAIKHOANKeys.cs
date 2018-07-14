using System;
using System.Collections.Generic;
using System.Text;
namespace QuanLyBenhXa.BusinessLayer
{
	public class TAIKHOANKeys
	{

		#region Data Members

		int _iD;

		#endregion

		#region Constructor

		public TAIKHOANKeys(int iD)
		{
			 _iD = iD; 
		}

		#endregion

		#region Properties

		public int  ID
		{
			 get { return _iD; }
		}

		#endregion

	}
}
