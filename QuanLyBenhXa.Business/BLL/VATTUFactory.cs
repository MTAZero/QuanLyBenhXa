using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using QuanLyBenhXa.BusinessLayer.DataLayer;

namespace QuanLyBenhXa.BusinessLayer
{
    public class VATTUFactory
    {

        #region data Members

        VATTUSql _dataObject = null;

        #endregion

        #region Constructor

        public VATTUFactory()
        {
            _dataObject = new VATTUSql();
        }

        #endregion


        #region Public Methods

        /// <summary>
        /// Insert new VATTU
        /// </summary>
        /// <param name="businessObject">VATTU object</param>
        /// <returns>true for successfully saved</returns>
        public bool Insert(VATTU businessObject)
        {
            if (!businessObject.IsValid)
            {
                businessObject.ShowErrorMessage();//throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Insert(businessObject);

        }

        /// <summary>
        /// Update existing VATTU
        /// </summary>
        /// <param name="businessObject">VATTU object</param>
        /// <returns>true for successfully saved</returns>
        public bool Update(VATTU businessObject)
        {
            if (!businessObject.IsValid)
            {
                businessObject.ShowErrorMessage();//throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Update(businessObject);
        }

        /// <summary>
        /// get VATTU by primary key.
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>Student</returns>
        public VATTU GetByPrimaryKey(VATTUKeys keys)
        {
            return _dataObject.SelectByPrimaryKey(keys); 
        }

        /// <summary>
        /// get list of all VATTUs
        /// </summary>
        /// <returns>list</returns>
        public List<VATTU> GetAllEntities()
        {
            return _dataObject.SelectAllEntities(); 
        }
        public DataTable GetAll()
        {
            return _dataObject.SelectAll(); 
        }
        /// <summary>
        /// get list of VATTU by field
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>list</returns>
        public List<VATTU> GetAllBy(VATTU.VATTUFields fieldName, object value)
        {
            return _dataObject.SelectByField(fieldName.ToString(), value);  
        }

        /// <summary>
        /// delete by primary key
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>true for succesfully deleted</returns>
        public bool Delete(VATTUKeys keys)
        {
            return _dataObject.Delete(keys); 
        }

        /// <summary>
        /// delete VATTU by field.
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>true for successfully deleted</returns>
        public bool Delete(VATTU.VATTUFields fieldName, object value)
        {
            return _dataObject.DeleteByField(fieldName.ToString(), value); 
        }

        #endregion

    }
}
