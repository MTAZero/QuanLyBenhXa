using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using QuanLyBenhXa.BusinessLayer.DataLayer;

namespace QuanLyBenhXa.BusinessLayer
{
    public class DOITUONGFactory
    {

        #region data Members

        DOITUONGSql _dataObject = null;

        #endregion

        #region Constructor

        public DOITUONGFactory()
        {
            _dataObject = new DOITUONGSql();
        }

        #endregion


        #region Public Methods

        /// <summary>
        /// Insert new DOITUONG
        /// </summary>
        /// <param name="businessObject">DOITUONG object</param>
        /// <returns>true for successfully saved</returns>
        public bool Insert(DOITUONG businessObject)
        {
            if (!businessObject.IsValid)
            {
                businessObject.ShowErrorMessage();//throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Insert(businessObject);

        }

        /// <summary>
        /// Update existing DOITUONG
        /// </summary>
        /// <param name="businessObject">DOITUONG object</param>
        /// <returns>true for successfully saved</returns>
        public bool Update(DOITUONG businessObject)
        {
            if (!businessObject.IsValid)
            {
                businessObject.ShowErrorMessage();//throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Update(businessObject);
        }

        /// <summary>
        /// get DOITUONG by primary key.
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>Student</returns>
        public DOITUONG GetByPrimaryKey(DOITUONGKeys keys)
        {
            return _dataObject.SelectByPrimaryKey(keys); 
        }

        /// <summary>
        /// get list of all DOITUONGs
        /// </summary>
        /// <returns>list</returns>
        public List<DOITUONG> GetAllEntities()
        {
            return _dataObject.SelectAllEntities(); 
        }
        public DataTable GetAll()
        {
            return _dataObject.SelectAll(); 
        }
        /// <summary>
        /// get list of DOITUONG by field
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>list</returns>
        public List<DOITUONG> GetAllBy(DOITUONG.DOITUONGFields fieldName, object value)
        {
            return _dataObject.SelectByField(fieldName.ToString(), value);  
        }

        /// <summary>
        /// delete by primary key
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>true for succesfully deleted</returns>
        public bool Delete(DOITUONGKeys keys)
        {
            return _dataObject.Delete(keys); 
        }

        /// <summary>
        /// delete DOITUONG by field.
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>true for successfully deleted</returns>
        public bool Delete(DOITUONG.DOITUONGFields fieldName, object value)
        {
            return _dataObject.DeleteByField(fieldName.ToString(), value); 
        }

        #endregion

    }
}
