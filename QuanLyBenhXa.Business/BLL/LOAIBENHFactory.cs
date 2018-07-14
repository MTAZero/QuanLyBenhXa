using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using QuanLyBenhXa.BusinessLayer.DataLayer;

namespace QuanLyBenhXa.BusinessLayer
{
    public class LOAIBENHFactory
    {

        #region data Members

        LOAIBENHSql _dataObject = null;

        #endregion

        #region Constructor

        public LOAIBENHFactory()
        {
            _dataObject = new LOAIBENHSql();
        }

        #endregion


        #region Public Methods

        /// <summary>
        /// Insert new LOAIBENH
        /// </summary>
        /// <param name="businessObject">LOAIBENH object</param>
        /// <returns>true for successfully saved</returns>
        public bool Insert(LOAIBENH businessObject)
        {
            if (!businessObject.IsValid)
            {
                businessObject.ShowErrorMessage();//throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Insert(businessObject);

        }

        /// <summary>
        /// Update existing LOAIBENH
        /// </summary>
        /// <param name="businessObject">LOAIBENH object</param>
        /// <returns>true for successfully saved</returns>
        public bool Update(LOAIBENH businessObject)
        {
            if (!businessObject.IsValid)
            {
                businessObject.ShowErrorMessage();//throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Update(businessObject);
        }

        /// <summary>
        /// get LOAIBENH by primary key.
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>Student</returns>
        public LOAIBENH GetByPrimaryKey(LOAIBENHKeys keys)
        {
            return _dataObject.SelectByPrimaryKey(keys); 
        }

        /// <summary>
        /// get list of all LOAIBENHs
        /// </summary>
        /// <returns>list</returns>
        public List<LOAIBENH> GetAllEntities()
        {
            return _dataObject.SelectAllEntities(); 
        }
        public DataTable GetAll()
        {
            return _dataObject.SelectAll(); 
        }
        /// <summary>
        /// get list of LOAIBENH by field
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>list</returns>
        public List<LOAIBENH> GetAllBy(LOAIBENH.LOAIBENHFields fieldName, object value)
        {
            return _dataObject.SelectByField(fieldName.ToString(), value);  
        }

        /// <summary>
        /// delete by primary key
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>true for succesfully deleted</returns>
        public bool Delete(LOAIBENHKeys keys)
        {
            return _dataObject.Delete(keys); 
        }

        /// <summary>
        /// delete LOAIBENH by field.
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>true for successfully deleted</returns>
        public bool Delete(LOAIBENH.LOAIBENHFields fieldName, object value)
        {
            return _dataObject.DeleteByField(fieldName.ToString(), value); 
        }

        #endregion

    }
}
