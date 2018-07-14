using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using QuanLyBenhXa.BusinessLayer.DataLayer;

namespace QuanLyBenhXa.BusinessLayer
{
    public class TAIKHOANFactory
    {

        #region data Members

        TAIKHOANSql _dataObject = null;

        #endregion

        #region Constructor

        public TAIKHOANFactory()
        {
            _dataObject = new TAIKHOANSql();
        }

        #endregion


        #region Public Methods

        /// <summary>
        /// Insert new TAIKHOAN
        /// </summary>
        /// <param name="businessObject">TAIKHOAN object</param>
        /// <returns>true for successfully saved</returns>
        public bool Insert(TAIKHOAN businessObject)
        {
            if (!businessObject.IsValid)
            {
                businessObject.ShowErrorMessage();//throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Insert(businessObject);

        }

        /// <summary>
        /// Update existing TAIKHOAN
        /// </summary>
        /// <param name="businessObject">TAIKHOAN object</param>
        /// <returns>true for successfully saved</returns>
        public bool Update(TAIKHOAN businessObject)
        {
            if (!businessObject.IsValid)
            {
                businessObject.ShowErrorMessage();//throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Update(businessObject);
        }

        /// <summary>
        /// get TAIKHOAN by primary key.
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>Student</returns>
        public TAIKHOAN GetByPrimaryKey(TAIKHOANKeys keys)
        {
            return _dataObject.SelectByPrimaryKey(keys); 
        }

        /// <summary>
        /// get list of all TAIKHOANs
        /// </summary>
        /// <returns>list</returns>
        public List<TAIKHOAN> GetAllEntities()
        {
            return _dataObject.SelectAllEntities(); 
        }
        public DataTable GetAll()
        {
            return _dataObject.SelectAll(); 
        }
        /// <summary>
        /// get list of TAIKHOAN by field
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>list</returns>
        public List<TAIKHOAN> GetAllBy(TAIKHOAN.TAIKHOANFields fieldName, object value)
        {
            return _dataObject.SelectByField(fieldName.ToString(), value);  
        }

        /// <summary>
        /// delete by primary key
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>true for succesfully deleted</returns>
        public bool Delete(TAIKHOANKeys keys)
        {
            return _dataObject.Delete(keys); 
        }

        /// <summary>
        /// delete TAIKHOAN by field.
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>true for successfully deleted</returns>
        public bool Delete(TAIKHOAN.TAIKHOANFields fieldName, object value)
        {
            return _dataObject.DeleteByField(fieldName.ToString(), value); 
        }

        #endregion

    }
}
