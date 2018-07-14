using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using QuanLyBenhXa.BusinessLayer.DataLayer;

namespace QuanLyBenhXa.BusinessLayer
{
    public class DONVIFactory
    {

        #region data Members

        DONVISql _dataObject = null;

        #endregion

        #region Constructor

        public DONVIFactory()
        {
            _dataObject = new DONVISql();
        }

        #endregion


        #region Public Methods

        /// <summary>
        /// Insert new DONVI
        /// </summary>
        /// <param name="businessObject">DONVI object</param>
        /// <returns>true for successfully saved</returns>
        public bool Insert(DONVI businessObject)
        {
            if (!businessObject.IsValid)
            {
                businessObject.ShowErrorMessage();//throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Insert(businessObject);

        }

        /// <summary>
        /// Update existing DONVI
        /// </summary>
        /// <param name="businessObject">DONVI object</param>
        /// <returns>true for successfully saved</returns>
        public bool Update(DONVI businessObject)
        {
            if (!businessObject.IsValid)
            {
                businessObject.ShowErrorMessage();//throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Update(businessObject);
        }

        /// <summary>
        /// get DONVI by primary key.
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>Student</returns>
        public DONVI GetByPrimaryKey(DONVIKeys keys)
        {
            return _dataObject.SelectByPrimaryKey(keys); 
        }

        /// <summary>
        /// get list of all DONVIs
        /// </summary>
        /// <returns>list</returns>
        public List<DONVI> GetAllEntities()
        {
            return _dataObject.SelectAllEntities(); 
        }
        public DataTable GetAll()
        {
            return _dataObject.SelectAll(); 
        }
        /// <summary>
        /// get list of DONVI by field
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>list</returns>
        public List<DONVI> GetAllBy(DONVI.DONVIFields fieldName, object value)
        {
            return _dataObject.SelectByField(fieldName.ToString(), value);  
        }

        /// <summary>
        /// delete by primary key
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>true for succesfully deleted</returns>
        public bool Delete(DONVIKeys keys)
        {
            return _dataObject.Delete(keys); 
        }

        /// <summary>
        /// delete DONVI by field.
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>true for successfully deleted</returns>
        public bool Delete(DONVI.DONVIFields fieldName, object value)
        {
            return _dataObject.DeleteByField(fieldName.ToString(), value); 
        }

        #endregion

    }
}
