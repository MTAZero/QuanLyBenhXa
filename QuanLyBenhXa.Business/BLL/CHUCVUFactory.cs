using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using QuanLyBenhXa.BusinessLayer.DataLayer;

namespace QuanLyBenhXa.BusinessLayer
{
    public class CHUCVUFactory
    {

        #region data Members

        CHUCVUSql _dataObject = null;

        #endregion

        #region Constructor

        public CHUCVUFactory()
        {
            _dataObject = new CHUCVUSql();
        }

        #endregion


        #region Public Methods

        /// <summary>
        /// Insert new CHUCVU
        /// </summary>
        /// <param name="businessObject">CHUCVU object</param>
        /// <returns>true for successfully saved</returns>
        public bool Insert(CHUCVU businessObject)
        {
            if (!businessObject.IsValid)
            {
                businessObject.ShowErrorMessage();//throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Insert(businessObject);

        }

        /// <summary>
        /// Update existing CHUCVU
        /// </summary>
        /// <param name="businessObject">CHUCVU object</param>
        /// <returns>true for successfully saved</returns>
        public bool Update(CHUCVU businessObject)
        {
            if (!businessObject.IsValid)
            {
                businessObject.ShowErrorMessage();//throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Update(businessObject);
        }

        /// <summary>
        /// get CHUCVU by primary key.
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>Student</returns>
        public CHUCVU GetByPrimaryKey(CHUCVUKeys keys)
        {
            return _dataObject.SelectByPrimaryKey(keys); 
        }

        /// <summary>
        /// get list of all CHUCVUs
        /// </summary>
        /// <returns>list</returns>
        public List<CHUCVU> GetAllEntities()
        {
            return _dataObject.SelectAllEntities(); 
        }
        public DataTable GetAll()
        {
            return _dataObject.SelectAll(); 
        }
        /// <summary>
        /// get list of CHUCVU by field
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>list</returns>
        public List<CHUCVU> GetAllBy(CHUCVU.CHUCVUFields fieldName, object value)
        {
            return _dataObject.SelectByField(fieldName.ToString(), value);  
        }

        /// <summary>
        /// delete by primary key
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>true for succesfully deleted</returns>
        public bool Delete(CHUCVUKeys keys)
        {
            return _dataObject.Delete(keys); 
        }

        /// <summary>
        /// delete CHUCVU by field.
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>true for successfully deleted</returns>
        public bool Delete(CHUCVU.CHUCVUFields fieldName, object value)
        {
            return _dataObject.DeleteByField(fieldName.ToString(), value); 
        }

        #endregion

    }
}
