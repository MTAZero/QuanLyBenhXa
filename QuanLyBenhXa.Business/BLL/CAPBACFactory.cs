using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using QuanLyBenhXa.BusinessLayer.DataLayer;

namespace QuanLyBenhXa.BusinessLayer
{
    public class CAPBACFactory
    {

        #region data Members

        CAPBACSql _dataObject = null;

        #endregion

        #region Constructor

        public CAPBACFactory()
        {
            _dataObject = new CAPBACSql();
        }

        #endregion


        #region Public Methods

        /// <summary>
        /// Insert new CAPBAC
        /// </summary>
        /// <param name="businessObject">CAPBAC object</param>
        /// <returns>true for successfully saved</returns>
        public bool Insert(CAPBAC businessObject)
        {
            if (!businessObject.IsValid)
            {
                businessObject.ShowErrorMessage();//throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Insert(businessObject);

        }

        /// <summary>
        /// Update existing CAPBAC
        /// </summary>
        /// <param name="businessObject">CAPBAC object</param>
        /// <returns>true for successfully saved</returns>
        public bool Update(CAPBAC businessObject)
        {
            if (!businessObject.IsValid)
            {
                businessObject.ShowErrorMessage();//throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Update(businessObject);
        }

        /// <summary>
        /// get CAPBAC by primary key.
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>Student</returns>
        public CAPBAC GetByPrimaryKey(CAPBACKeys keys)
        {
            return _dataObject.SelectByPrimaryKey(keys); 
        }

        /// <summary>
        /// get list of all CAPBACs
        /// </summary>
        /// <returns>list</returns>
        public List<CAPBAC> GetAllEntities()
        {
            return _dataObject.SelectAllEntities(); 
        }
        public DataTable GetAll()
        {
            return _dataObject.SelectAll(); 
        }
        /// <summary>
        /// get list of CAPBAC by field
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>list</returns>
        public List<CAPBAC> GetAllBy(CAPBAC.CAPBACFields fieldName, object value)
        {
            return _dataObject.SelectByField(fieldName.ToString(), value);  
        }

        /// <summary>
        /// delete by primary key
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>true for succesfully deleted</returns>
        public bool Delete(CAPBACKeys keys)
        {
            return _dataObject.Delete(keys); 
        }

        /// <summary>
        /// delete CAPBAC by field.
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>true for successfully deleted</returns>
        public bool Delete(CAPBAC.CAPBACFields fieldName, object value)
        {
            return _dataObject.DeleteByField(fieldName.ToString(), value); 
        }

        #endregion

    }
}
