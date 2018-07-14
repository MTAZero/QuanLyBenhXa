using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using QuanLyBenhXa.BusinessLayer.DataLayer;

namespace QuanLyBenhXa.BusinessLayer
{
    public class BENHFactory
    {

        #region data Members

        BENHSql _dataObject = null;

        #endregion

        #region Constructor

        public BENHFactory()
        {
            _dataObject = new BENHSql();
        }

        #endregion


        #region Public Methods

        /// <summary>
        /// Insert new BENH
        /// </summary>
        /// <param name="businessObject">BENH object</param>
        /// <returns>true for successfully saved</returns>
        public bool Insert(BENH businessObject)
        {
            if (!businessObject.IsValid)
            {
                businessObject.ShowErrorMessage();//throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Insert(businessObject);

        }

        /// <summary>
        /// Update existing BENH
        /// </summary>
        /// <param name="businessObject">BENH object</param>
        /// <returns>true for successfully saved</returns>
        public bool Update(BENH businessObject)
        {
            if (!businessObject.IsValid)
            {
                businessObject.ShowErrorMessage();//throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Update(businessObject);
        }

        /// <summary>
        /// get BENH by primary key.
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>Student</returns>
        public BENH GetByPrimaryKey(BENHKeys keys)
        {
            return _dataObject.SelectByPrimaryKey(keys); 
        }

        /// <summary>
        /// get list of all BENHs
        /// </summary>
        /// <returns>list</returns>
        public List<BENH> GetAllEntities()
        {
            return _dataObject.SelectAllEntities(); 
        }
        public DataTable GetAll()
        {
            return _dataObject.SelectAll(); 
        }
        /// <summary>
        /// get list of BENH by field
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>list</returns>
        public List<BENH> GetAllBy(BENH.BENHFields fieldName, object value)
        {
            return _dataObject.SelectByField(fieldName.ToString(), value);  
        }

        /// <summary>
        /// delete by primary key
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>true for succesfully deleted</returns>
        public bool Delete(BENHKeys keys)
        {
            return _dataObject.Delete(keys); 
        }

        /// <summary>
        /// delete BENH by field.
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>true for successfully deleted</returns>
        public bool Delete(BENH.BENHFields fieldName, object value)
        {
            return _dataObject.DeleteByField(fieldName.ToString(), value); 
        }

        #endregion

    }
}
