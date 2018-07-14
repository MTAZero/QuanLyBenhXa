using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using QuanLyBenhXa.BusinessLayer.DataLayer;

namespace QuanLyBenhXa.BusinessLayer
{
    public class NHAPTHUOCFactory
    {

        #region data Members

        NHAPTHUOCSql _dataObject = null;

        #endregion

        #region Constructor

        public NHAPTHUOCFactory()
        {
            _dataObject = new NHAPTHUOCSql();
        }

        #endregion


        #region Public Methods

        /// <summary>
        /// Insert new NHAPTHUOC
        /// </summary>
        /// <param name="businessObject">NHAPTHUOC object</param>
        /// <returns>true for successfully saved</returns>
        public bool Insert(NHAPTHUOC businessObject)
        {
            if (!businessObject.IsValid)
            {
                businessObject.ShowErrorMessage();//throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Insert(businessObject);

        }

        /// <summary>
        /// Update existing NHAPTHUOC
        /// </summary>
        /// <param name="businessObject">NHAPTHUOC object</param>
        /// <returns>true for successfully saved</returns>
        public bool Update(NHAPTHUOC businessObject)
        {
            if (!businessObject.IsValid)
            {
                businessObject.ShowErrorMessage();//throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Update(businessObject);
        }

        /// <summary>
        /// get NHAPTHUOC by primary key.
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>Student</returns>
        public NHAPTHUOC GetByPrimaryKey(NHAPTHUOCKeys keys)
        {
            return _dataObject.SelectByPrimaryKey(keys); 
        }

        /// <summary>
        /// get list of all NHAPTHUOCs
        /// </summary>
        /// <returns>list</returns>
        public List<NHAPTHUOC> GetAllEntities()
        {
            return _dataObject.SelectAllEntities(); 
        }
        public DataTable GetAll()
        {
            return _dataObject.SelectAll(); 
        }
        /// <summary>
        /// get list of NHAPTHUOC by field
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>list</returns>
        public List<NHAPTHUOC> GetAllBy(NHAPTHUOC.NHAPTHUOCFields fieldName, object value)
        {
            return _dataObject.SelectByField(fieldName.ToString(), value);  
        }

        /// <summary>
        /// delete by primary key
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>true for succesfully deleted</returns>
        public bool Delete(NHAPTHUOCKeys keys)
        {
            return _dataObject.Delete(keys); 
        }

        /// <summary>
        /// delete NHAPTHUOC by field.
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>true for successfully deleted</returns>
        public bool Delete(NHAPTHUOC.NHAPTHUOCFields fieldName, object value)
        {
            return _dataObject.DeleteByField(fieldName.ToString(), value); 
        }

        #endregion

    }
}
