using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using QuanLyBenhXa.BusinessLayer.DataLayer;

namespace QuanLyBenhXa.BusinessLayer
{
    public class CAPTHUOCFactory
    {

        #region data Members

        CAPTHUOCSql _dataObject = null;

        #endregion

        #region Constructor

        public CAPTHUOCFactory()
        {
            _dataObject = new CAPTHUOCSql();
        }

        #endregion


        #region Public Methods

        /// <summary>
        /// Insert new CAPTHUOC
        /// </summary>
        /// <param name="businessObject">CAPTHUOC object</param>
        /// <returns>true for successfully saved</returns>
        public bool Insert(CAPTHUOC businessObject)
        {
            if (!businessObject.IsValid)
            {
                businessObject.ShowErrorMessage();//throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Insert(businessObject);

        }

        /// <summary>
        /// Update existing CAPTHUOC
        /// </summary>
        /// <param name="businessObject">CAPTHUOC object</param>
        /// <returns>true for successfully saved</returns>
        public bool Update(CAPTHUOC businessObject)
        {
            if (!businessObject.IsValid)
            {
                businessObject.ShowErrorMessage();//throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Update(businessObject);
        }

        /// <summary>
        /// get CAPTHUOC by primary key.
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>Student</returns>
        public CAPTHUOC GetByPrimaryKey(CAPTHUOCKeys keys)
        {
            return _dataObject.SelectByPrimaryKey(keys); 
        }

        /// <summary>
        /// get list of all CAPTHUOCs
        /// </summary>
        /// <returns>list</returns>
        public List<CAPTHUOC> GetAllEntities()
        {
            return _dataObject.SelectAllEntities(); 
        }
        public DataTable GetAll()
        {
            return _dataObject.SelectAll(); 
        }
        /// <summary>
        /// get list of CAPTHUOC by field
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>list</returns>
        public List<CAPTHUOC> GetAllBy(CAPTHUOC.CAPTHUOCFields fieldName, object value)
        {
            return _dataObject.SelectByField(fieldName.ToString(), value);  
        }

        /// <summary>
        /// delete by primary key
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>true for succesfully deleted</returns>
        public bool Delete(CAPTHUOCKeys keys)
        {
            return _dataObject.Delete(keys); 
        }

        /// <summary>
        /// delete CAPTHUOC by field.
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>true for successfully deleted</returns>
        public bool Delete(CAPTHUOC.CAPTHUOCFields fieldName, object value)
        {
            return _dataObject.DeleteByField(fieldName.ToString(), value); 
        }

        #endregion

    }
}
