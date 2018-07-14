using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using QuanLyBenhXa.BusinessLayer.DataLayer;

namespace QuanLyBenhXa.BusinessLayer
{
    public class PHANLOAISUCKHOEFactory
    {

        #region data Members

        PHANLOAISUCKHOESql _dataObject = null;

        #endregion

        #region Constructor

        public PHANLOAISUCKHOEFactory()
        {
            _dataObject = new PHANLOAISUCKHOESql();
        }

        #endregion


        #region Public Methods

        /// <summary>
        /// Insert new PHANLOAISUCKHOE
        /// </summary>
        /// <param name="businessObject">PHANLOAISUCKHOE object</param>
        /// <returns>true for successfully saved</returns>
        public bool Insert(PHANLOAISUCKHOE businessObject)
        {
            if (!businessObject.IsValid)
            {
                businessObject.ShowErrorMessage();//throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Insert(businessObject);

        }

        /// <summary>
        /// Update existing PHANLOAISUCKHOE
        /// </summary>
        /// <param name="businessObject">PHANLOAISUCKHOE object</param>
        /// <returns>true for successfully saved</returns>
        public bool Update(PHANLOAISUCKHOE businessObject)
        {
            if (!businessObject.IsValid)
            {
                businessObject.ShowErrorMessage();//throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Update(businessObject);
        }

        /// <summary>
        /// get PHANLOAISUCKHOE by primary key.
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>Student</returns>
        public PHANLOAISUCKHOE GetByPrimaryKey(PHANLOAISUCKHOEKeys keys)
        {
            return _dataObject.SelectByPrimaryKey(keys); 
        }

        /// <summary>
        /// get list of all PHANLOAISUCKHOEs
        /// </summary>
        /// <returns>list</returns>
        public List<PHANLOAISUCKHOE> GetAllEntities()
        {
            return _dataObject.SelectAllEntities(); 
        }
        public DataTable GetAll()
        {
            return _dataObject.SelectAll(); 
        }
        /// <summary>
        /// get list of PHANLOAISUCKHOE by field
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>list</returns>
        public List<PHANLOAISUCKHOE> GetAllBy(PHANLOAISUCKHOE.PHANLOAISUCKHOEFields fieldName, object value)
        {
            return _dataObject.SelectByField(fieldName.ToString(), value);  
        }

        /// <summary>
        /// delete by primary key
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>true for succesfully deleted</returns>
        public bool Delete(PHANLOAISUCKHOEKeys keys)
        {
            return _dataObject.Delete(keys); 
        }

        /// <summary>
        /// delete PHANLOAISUCKHOE by field.
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>true for successfully deleted</returns>
        public bool Delete(PHANLOAISUCKHOE.PHANLOAISUCKHOEFields fieldName, object value)
        {
            return _dataObject.DeleteByField(fieldName.ToString(), value); 
        }

        #endregion

    }
}
