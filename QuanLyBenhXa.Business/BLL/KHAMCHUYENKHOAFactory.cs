using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using QuanLyBenhXa.BusinessLayer.DataLayer;

namespace QuanLyBenhXa.BusinessLayer
{
    public class KHAMCHUYENKHOAFactory
    {

        #region data Members

        KHAMCHUYENKHOASql _dataObject = null;

        #endregion

        #region Constructor

        public KHAMCHUYENKHOAFactory()
        {
            _dataObject = new KHAMCHUYENKHOASql();
        }

        #endregion


        #region Public Methods

        /// <summary>
        /// Insert new KHAMCHUYENKHOA
        /// </summary>
        /// <param name="businessObject">KHAMCHUYENKHOA object</param>
        /// <returns>true for successfully saved</returns>
        public bool Insert(KHAMCHUYENKHOA businessObject)
        {
            if (!businessObject.IsValid)
            {
                businessObject.ShowErrorMessage();//throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Insert(businessObject);

        }

        /// <summary>
        /// Update existing KHAMCHUYENKHOA
        /// </summary>
        /// <param name="businessObject">KHAMCHUYENKHOA object</param>
        /// <returns>true for successfully saved</returns>
        public bool Update(KHAMCHUYENKHOA businessObject)
        {
            if (!businessObject.IsValid)
            {
                businessObject.ShowErrorMessage();//throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Update(businessObject);
        }

        /// <summary>
        /// get KHAMCHUYENKHOA by primary key.
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>Student</returns>
        public KHAMCHUYENKHOA GetByPrimaryKey(KHAMCHUYENKHOAKeys keys)
        {
            return _dataObject.SelectByPrimaryKey(keys); 
        }

        /// <summary>
        /// get list of all KHAMCHUYENKHOAs
        /// </summary>
        /// <returns>list</returns>
        public List<KHAMCHUYENKHOA> GetAllEntities()
        {
            return _dataObject.SelectAllEntities(); 
        }
        public DataTable GetAll()
        {
            return _dataObject.SelectAll(); 
        }
        /// <summary>
        /// get list of KHAMCHUYENKHOA by field
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>list</returns>
        public List<KHAMCHUYENKHOA> GetAllBy(KHAMCHUYENKHOA.KHAMCHUYENKHOAFields fieldName, object value)
        {
            return _dataObject.SelectByField(fieldName.ToString(), value);  
        }

        /// <summary>
        /// delete by primary key
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>true for succesfully deleted</returns>
        public bool Delete(KHAMCHUYENKHOAKeys keys)
        {
            return _dataObject.Delete(keys); 
        }

        /// <summary>
        /// delete KHAMCHUYENKHOA by field.
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>true for successfully deleted</returns>
        public bool Delete(KHAMCHUYENKHOA.KHAMCHUYENKHOAFields fieldName, object value)
        {
            return _dataObject.DeleteByField(fieldName.ToString(), value); 
        }

        #endregion

    }
}
