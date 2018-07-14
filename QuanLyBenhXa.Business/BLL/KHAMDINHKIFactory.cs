using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using QuanLyBenhXa.BusinessLayer.DataLayer;

namespace QuanLyBenhXa.BusinessLayer
{
    public class KHAMDINHKIFactory
    {

        #region data Members

        KHAMDINHKISql _dataObject = null;

        #endregion

        #region Constructor

        public KHAMDINHKIFactory()
        {
            _dataObject = new KHAMDINHKISql();
        }

        #endregion


        #region Public Methods

        /// <summary>
        /// Insert new KHAMDINHKI
        /// </summary>
        /// <param name="businessObject">KHAMDINHKI object</param>
        /// <returns>true for successfully saved</returns>
        public bool Insert(KHAMDINHKI businessObject)
        {
            if (!businessObject.IsValid)
            {
                businessObject.ShowErrorMessage();//throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Insert(businessObject);

        }

        /// <summary>
        /// Update existing KHAMDINHKI
        /// </summary>
        /// <param name="businessObject">KHAMDINHKI object</param>
        /// <returns>true for successfully saved</returns>
        public bool Update(KHAMDINHKI businessObject)
        {
            if (!businessObject.IsValid)
            {
                businessObject.ShowErrorMessage();//throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Update(businessObject);
        }

        /// <summary>
        /// get KHAMDINHKI by primary key.
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>Student</returns>
        public KHAMDINHKI GetByPrimaryKey(KHAMDINHKIKeys keys)
        {
            return _dataObject.SelectByPrimaryKey(keys); 
        }

        /// <summary>
        /// get list of all KHAMDINHKIs
        /// </summary>
        /// <returns>list</returns>
        public List<KHAMDINHKI> GetAllEntities()
        {
            return _dataObject.SelectAllEntities(); 
        }
        public DataTable GetAll()
        {
            return _dataObject.SelectAll(); 
        }
        /// <summary>
        /// get list of KHAMDINHKI by field
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>list</returns>
        public List<KHAMDINHKI> GetAllBy(KHAMDINHKI.KHAMDINHKIFields fieldName, object value)
        {
            return _dataObject.SelectByField(fieldName.ToString(), value);  
        }

        /// <summary>
        /// delete by primary key
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>true for succesfully deleted</returns>
        public bool Delete(KHAMDINHKIKeys keys)
        {
            return _dataObject.Delete(keys); 
        }

        /// <summary>
        /// delete KHAMDINHKI by field.
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>true for successfully deleted</returns>
        public bool Delete(KHAMDINHKI.KHAMDINHKIFields fieldName, object value)
        {
            return _dataObject.DeleteByField(fieldName.ToString(), value); 
        }

        #endregion

    }
}
