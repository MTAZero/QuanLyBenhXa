using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using QuanLyBenhXa.BusinessLayer.DataLayer;

namespace QuanLyBenhXa.BusinessLayer
{
    public class BACSIFactory
    {

        #region data Members

        BACSISql _dataObject = null;

        #endregion

        #region Constructor

        public BACSIFactory()
        {
            _dataObject = new BACSISql();
        }

        #endregion


        #region Public Methods

        /// <summary>
        /// Insert new BACSI
        /// </summary>
        /// <param name="businessObject">BACSI object</param>
        /// <returns>true for successfully saved</returns>
        public bool Insert(BACSI businessObject)
        {
            if (!businessObject.IsValid)
            {
                businessObject.ShowErrorMessage();//throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Insert(businessObject);

        }

        /// <summary>
        /// Update existing BACSI
        /// </summary>
        /// <param name="businessObject">BACSI object</param>
        /// <returns>true for successfully saved</returns>
        public bool Update(BACSI businessObject)
        {
            if (!businessObject.IsValid)
            {
                businessObject.ShowErrorMessage();//throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Update(businessObject);
        }

        /// <summary>
        /// get BACSI by primary key.
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>Student</returns>
        public BACSI GetByPrimaryKey(BACSIKeys keys)
        {
            return _dataObject.SelectByPrimaryKey(keys); 
        }

        /// <summary>
        /// get list of all BACSIs
        /// </summary>
        /// <returns>list</returns>
        public List<BACSI> GetAllEntities()
        {
            return _dataObject.SelectAllEntities(); 
        }
        public DataTable GetAll()
        {
            return _dataObject.SelectAll(); 
        }
        /// <summary>
        /// get list of BACSI by field
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>list</returns>
        public List<BACSI> GetAllBy(BACSI.BACSIFields fieldName, object value)
        {
            return _dataObject.SelectByField(fieldName.ToString(), value);  
        }

        /// <summary>
        /// delete by primary key
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>true for succesfully deleted</returns>
        public bool Delete(BACSIKeys keys)
        {
            return _dataObject.Delete(keys); 
        }

        /// <summary>
        /// delete BACSI by field.
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>true for successfully deleted</returns>
        public bool Delete(BACSI.BACSIFields fieldName, object value)
        {
            return _dataObject.DeleteByField(fieldName.ToString(), value); 
        }

        #endregion

    }
}
