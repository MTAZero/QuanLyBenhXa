using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using QuanLyBenhXa.BusinessLayer.DataLayer;

namespace QuanLyBenhXa.BusinessLayer
{
    public class BENHNHANFactory
    {

        #region data Members

        BENHNHANSql _dataObject = null;

        #endregion

        #region Constructor

        public BENHNHANFactory()
        {
            _dataObject = new BENHNHANSql();
        }

        #endregion


        #region Public Methods

        /// <summary>
        /// Insert new BENHNHAN
        /// </summary>
        /// <param name="businessObject">BENHNHAN object</param>
        /// <returns>true for successfully saved</returns>
        public bool Insert(BENHNHAN businessObject)
        {
            if (!businessObject.IsValid)
            {
                businessObject.ShowErrorMessage();//throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Insert(businessObject);

        }

        /// <summary>
        /// Update existing BENHNHAN
        /// </summary>
        /// <param name="businessObject">BENHNHAN object</param>
        /// <returns>true for successfully saved</returns>
        public bool Update(BENHNHAN businessObject)
        {
            if (!businessObject.IsValid)
            {
                businessObject.ShowErrorMessage();//throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Update(businessObject);
        }

        /// <summary>
        /// get BENHNHAN by primary key.
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>Student</returns>
        public BENHNHAN GetByPrimaryKey(BENHNHANKeys keys)
        {
            return _dataObject.SelectByPrimaryKey(keys); 
        }

        /// <summary>
        /// get list of all BENHNHANs
        /// </summary>
        /// <returns>list</returns>
        public List<BENHNHAN> GetAllEntities()
        {
            return _dataObject.SelectAllEntities(); 
        }
        public DataTable GetAll()
        {
            return _dataObject.SelectAll(); 
        }
        /// <summary>
        /// get list of BENHNHAN by field
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>list</returns>
        public List<BENHNHAN> GetAllBy(BENHNHAN.BENHNHANFields fieldName, object value)
        {
            return _dataObject.SelectByField(fieldName.ToString(), value);  
        }

        /// <summary>
        /// delete by primary key
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>true for succesfully deleted</returns>
        public bool Delete(BENHNHANKeys keys)
        {
            return _dataObject.Delete(keys); 
        }

        /// <summary>
        /// delete BENHNHAN by field.
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>true for successfully deleted</returns>
        public bool Delete(BENHNHAN.BENHNHANFields fieldName, object value)
        {
            return _dataObject.DeleteByField(fieldName.ToString(), value); 
        }

        #endregion

    }
}
