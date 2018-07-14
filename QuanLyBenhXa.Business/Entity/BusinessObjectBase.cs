using System;
using System.Collections.Generic;
using System.ComponentModel;


namespace QuanLyBenhXa.BusinessLayer
{
    /// <summary>
    /// base class for all business objects
    /// </summary>
    public abstract class BusinessObjectBase : ICloneable
    {       
        #region Data Member
        protected bool _isvalid = true;
        protected string _errorMsg = "";

        public string ErrorMsg
        {
            get { return _errorMsg; }
            set { _errorMsg = value; }
        }
        public virtual bool IsValid
        {
            get { return _isvalid; }
            set { _isvalid = value; }
        }
        public object Clone()
        {
            return MemberwiseClone();
        } 
        public void ShowErrorMessage()
        {
            System.Windows.Forms.MessageBox.Show(_errorMsg,"Thông báo", System.Windows.Forms.MessageBoxButtons.OK,  System.Windows.Forms.MessageBoxIcon.Warning);
        }
        #endregion  

    }
}
