using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using QuanLyBenhXa.BusinessLayer.DataLayer;

namespace QuanLyBenhXa.BusinessLayer
{
    public class CHITIETCAPTHUOCFactory
    {

        #region data Members

        CHITIETCAPTHUOCSql _dataObject = null;

        #endregion

        #region Constructor

        public CHITIETCAPTHUOCFactory()
        {
            _dataObject = new CHITIETCAPTHUOCSql();
        }

        #endregion


        #region Public Methods

        /// <summary>
        /// Insert new CHITIETCAPTHUOC
        /// </summary>
        /// <param name="businessObject">CHITIETCAPTHUOC object</param>
        /// <returns>true for successfully saved</returns>
        public bool Insert(CHITIETCAPTHUOC businessObject)
        {
            if (!businessObject.IsValid)
            {
                businessObject.ShowErrorMessage();//throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Insert(businessObject);

        }

        /// <summary>
        /// Update existing CHITIETCAPTHUOC
        /// </summary>
        /// <param name="businessObject">CHITIETCAPTHUOC object</param>
        /// <returns>true for successfully saved</returns>
        public bool Update(CHITIETCAPTHUOC businessObject)
        {
            if (!businessObject.IsValid)
            {
                businessObject.ShowErrorMessage();//throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Update(businessObject);
        }

        /// <summary>
        /// get CHITIETCAPTHUOC by primary key.
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>Student</returns>
        public CHITIETCAPTHUOC GetByPrimaryKey(CHITIETCAPTHUOCKeys keys)
        {
            return _dataObject.SelectByPrimaryKey(keys); 
        }

        /// <summary>
        /// get list of all CHITIETCAPTHUOCs
        /// </summary>
        /// <returns>list</returns>
        public List<CHITIETCAPTHUOC> GetAllEntities()
        {
            return _dataObject.SelectAllEntities(); 
        }
        public DataTable GetAll()
        {
            return _dataObject.SelectAll(); 
        }
        /// <summary>
        /// get list of CHITIETCAPTHUOC by field
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>list</returns>
        public List<CHITIETCAPTHUOC> GetAllBy(CHITIETCAPTHUOC.CHITIETCAPTHUOCFields fieldName, object value)
        {
            return _dataObject.SelectByField(fieldName.ToString(), value);  
        }

        /// <summary>
        /// delete by primary key
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>true for succesfully deleted</returns>
        public bool Delete(CHITIETCAPTHUOCKeys keys)
        {
            return _dataObject.Delete(keys); 
        }

        /// <summary>
        /// delete CHITIETCAPTHUOC by field.
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>true for successfully deleted</returns>
        public bool Delete(CHITIETCAPTHUOC.CHITIETCAPTHUOCFields fieldName, object value)
        {
            return _dataObject.DeleteByField(fieldName.ToString(), value); 
        }

        #endregion

    }
}
