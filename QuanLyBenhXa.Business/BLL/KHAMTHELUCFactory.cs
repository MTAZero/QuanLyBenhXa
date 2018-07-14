using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using QuanLyBenhXa.BusinessLayer.DataLayer;

namespace QuanLyBenhXa.BusinessLayer
{
    public class KHAMTHELUCFactory
    {

        #region data Members

        KHAMTHELUCSql _dataObject = null;

        #endregion

        #region Constructor

        public KHAMTHELUCFactory()
        {
            _dataObject = new KHAMTHELUCSql();
        }

        #endregion


        #region Public Methods

        /// <summary>
        /// Insert new KHAMTHELUC
        /// </summary>
        /// <param name="businessObject">KHAMTHELUC object</param>
        /// <returns>true for successfully saved</returns>
        public bool Insert(KHAMTHELUC businessObject)
        {
            if (!businessObject.IsValid)
            {
                businessObject.ShowErrorMessage();//throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Insert(businessObject);

        }

        /// <summary>
        /// Update existing KHAMTHELUC
        /// </summary>
        /// <param name="businessObject">KHAMTHELUC object</param>
        /// <returns>true for successfully saved</returns>
        public bool Update(KHAMTHELUC businessObject)
        {
            if (!businessObject.IsValid)
            {
                businessObject.ShowErrorMessage();//throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Update(businessObject);
        }

        /// <summary>
        /// get KHAMTHELUC by primary key.
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>Student</returns>
        public KHAMTHELUC GetByPrimaryKey(KHAMTHELUCKeys keys)
        {
            return _dataObject.SelectByPrimaryKey(keys); 
        }

        /// <summary>
        /// get list of all KHAMTHELUCs
        /// </summary>
        /// <returns>list</returns>
        public List<KHAMTHELUC> GetAllEntities()
        {
            return _dataObject.SelectAllEntities(); 
        }
        public DataTable GetAll()
        {
            return _dataObject.SelectAll(); 
        }
        /// <summary>
        /// get list of KHAMTHELUC by field
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>list</returns>
        public List<KHAMTHELUC> GetAllBy(KHAMTHELUC.KHAMTHELUCFields fieldName, object value)
        {
            return _dataObject.SelectByField(fieldName.ToString(), value);  
        }

        /// <summary>
        /// delete by primary key
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>true for succesfully deleted</returns>
        public bool Delete(KHAMTHELUCKeys keys)
        {
            return _dataObject.Delete(keys); 
        }

        /// <summary>
        /// delete KHAMTHELUC by field.
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>true for successfully deleted</returns>
        public bool Delete(KHAMTHELUC.KHAMTHELUCFields fieldName, object value)
        {
            return _dataObject.DeleteByField(fieldName.ToString(), value); 
        }

        #endregion

    }
}
