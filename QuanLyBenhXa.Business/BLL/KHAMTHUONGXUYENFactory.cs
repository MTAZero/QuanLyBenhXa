using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using QuanLyBenhXa.BusinessLayer.DataLayer;

namespace QuanLyBenhXa.BusinessLayer
{
    public class KHAMTHUONGXUYENFactory
    {

        #region data Members

        KHAMTHUONGXUYENSql _dataObject = null;

        #endregion

        #region Constructor

        public KHAMTHUONGXUYENFactory()
        {
            _dataObject = new KHAMTHUONGXUYENSql();
        }

        #endregion


        #region Public Methods

        /// <summary>
        /// Insert new KHAMTHUONGXUYEN
        /// </summary>
        /// <param name="businessObject">KHAMTHUONGXUYEN object</param>
        /// <returns>true for successfully saved</returns>
        public bool Insert(KHAMTHUONGXUYEN businessObject)
        {
            if (!businessObject.IsValid)
            {
                businessObject.ShowErrorMessage();//throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Insert(businessObject);

        }

        /// <summary>
        /// Update existing KHAMTHUONGXUYEN
        /// </summary>
        /// <param name="businessObject">KHAMTHUONGXUYEN object</param>
        /// <returns>true for successfully saved</returns>
        public bool Update(KHAMTHUONGXUYEN businessObject)
        {
            if (!businessObject.IsValid)
            {
                businessObject.ShowErrorMessage();//throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Update(businessObject);
        }

        /// <summary>
        /// get KHAMTHUONGXUYEN by primary key.
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>Student</returns>
        public KHAMTHUONGXUYEN GetByPrimaryKey(KHAMTHUONGXUYENKeys keys)
        {
            return _dataObject.SelectByPrimaryKey(keys); 
        }

        /// <summary>
        /// get list of all KHAMTHUONGXUYENs
        /// </summary>
        /// <returns>list</returns>
        public List<KHAMTHUONGXUYEN> GetAllEntities()
        {
            return _dataObject.SelectAllEntities(); 
        }
        public DataTable GetAll()
        {
            return _dataObject.SelectAll(); 
        }
        /// <summary>
        /// get list of KHAMTHUONGXUYEN by field
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>list</returns>
        public List<KHAMTHUONGXUYEN> GetAllBy(KHAMTHUONGXUYEN.KHAMTHUONGXUYENFields fieldName, object value)
        {
            return _dataObject.SelectByField(fieldName.ToString(), value);  
        }

        /// <summary>
        /// delete by primary key
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>true for succesfully deleted</returns>
        public bool Delete(KHAMTHUONGXUYENKeys keys)
        {
            return _dataObject.Delete(keys); 
        }

        /// <summary>
        /// delete KHAMTHUONGXUYEN by field.
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>true for successfully deleted</returns>
        public bool Delete(KHAMTHUONGXUYEN.KHAMTHUONGXUYENFields fieldName, object value)
        {
            return _dataObject.DeleteByField(fieldName.ToString(), value); 
        }

        #endregion

    }
}
