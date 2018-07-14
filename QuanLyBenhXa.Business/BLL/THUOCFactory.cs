using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using QuanLyBenhXa.BusinessLayer.DataLayer;

namespace QuanLyBenhXa.BusinessLayer
{
    public class THUOCFactory
    {

        #region data Members

        THUOCSql _dataObject = null;

        #endregion

        #region Constructor

        public THUOCFactory()
        {
            _dataObject = new THUOCSql();
        }

        #endregion


        #region Public Methods

        /// <summary>
        /// Insert new THUOC
        /// </summary>
        /// <param name="businessObject">THUOC object</param>
        /// <returns>true for successfully saved</returns>
        public bool Insert(THUOC businessObject)
        {
            if (!businessObject.IsValid)
            {
                businessObject.ShowErrorMessage();//throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Insert(businessObject);

        }

        /// <summary>
        /// Update existing THUOC
        /// </summary>
        /// <param name="businessObject">THUOC object</param>
        /// <returns>true for successfully saved</returns>
        public bool Update(THUOC businessObject)
        {
            if (!businessObject.IsValid)
            {
                businessObject.ShowErrorMessage();//throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Update(businessObject);
        }

        /// <summary>
        /// get THUOC by primary key.
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>Student</returns>
        public THUOC GetByPrimaryKey(THUOCKeys keys)
        {
            return _dataObject.SelectByPrimaryKey(keys); 
        }

        /// <summary>
        /// get list of all THUOCs
        /// </summary>
        /// <returns>list</returns>
        public List<THUOC> GetAllEntities()
        {
            return _dataObject.SelectAllEntities(); 
        }
        public DataTable GetAll()
        {
            return _dataObject.SelectAll(); 
        }
        /// <summary>
        /// get list of THUOC by field
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>list</returns>
        public List<THUOC> GetAllBy(THUOC.THUOCFields fieldName, object value)
        {
            return _dataObject.SelectByField(fieldName.ToString(), value);  
        }

        /// <summary>
        /// delete by primary key
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>true for succesfully deleted</returns>
        public bool Delete(THUOCKeys keys)
        {
            return _dataObject.Delete(keys); 
        }

        /// <summary>
        /// delete THUOC by field.
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>true for successfully deleted</returns>
        public bool Delete(THUOC.THUOCFields fieldName, object value)
        {
            return _dataObject.DeleteByField(fieldName.ToString(), value); 
        }

        #endregion

    }
}
