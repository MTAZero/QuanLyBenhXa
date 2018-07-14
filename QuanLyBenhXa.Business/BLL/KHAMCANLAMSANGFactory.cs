using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using QuanLyBenhXa.BusinessLayer.DataLayer;

namespace QuanLyBenhXa.BusinessLayer
{
    public class KHAMCANLAMSANGFactory
    {

        #region data Members

        KHAMCANLAMSANGSql _dataObject = null;

        #endregion

        #region Constructor

        public KHAMCANLAMSANGFactory()
        {
            _dataObject = new KHAMCANLAMSANGSql();
        }

        #endregion


        #region Public Methods

        /// <summary>
        /// Insert new KHAMCANLAMSANG
        /// </summary>
        /// <param name="businessObject">KHAMCANLAMSANG object</param>
        /// <returns>true for successfully saved</returns>
        public bool Insert(KHAMCANLAMSANG businessObject)
        {
            if (!businessObject.IsValid)
            {
                businessObject.ShowErrorMessage();//throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Insert(businessObject);

        }

        /// <summary>
        /// Update existing KHAMCANLAMSANG
        /// </summary>
        /// <param name="businessObject">KHAMCANLAMSANG object</param>
        /// <returns>true for successfully saved</returns>
        public bool Update(KHAMCANLAMSANG businessObject)
        {
            if (!businessObject.IsValid)
            {
                businessObject.ShowErrorMessage();//throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Update(businessObject);
        }

        /// <summary>
        /// get KHAMCANLAMSANG by primary key.
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>Student</returns>
        public KHAMCANLAMSANG GetByPrimaryKey(KHAMCANLAMSANGKeys keys)
        {
            return _dataObject.SelectByPrimaryKey(keys); 
        }

        /// <summary>
        /// get list of all KHAMCANLAMSANGs
        /// </summary>
        /// <returns>list</returns>
        public List<KHAMCANLAMSANG> GetAllEntities()
        {
            return _dataObject.SelectAllEntities(); 
        }
        public DataTable GetAll()
        {
            return _dataObject.SelectAll(); 
        }
        /// <summary>
        /// get list of KHAMCANLAMSANG by field
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>list</returns>
        public List<KHAMCANLAMSANG> GetAllBy(KHAMCANLAMSANG.KHAMCANLAMSANGFields fieldName, object value)
        {
            return _dataObject.SelectByField(fieldName.ToString(), value);  
        }

        /// <summary>
        /// delete by primary key
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>true for succesfully deleted</returns>
        public bool Delete(KHAMCANLAMSANGKeys keys)
        {
            return _dataObject.Delete(keys); 
        }

        /// <summary>
        /// delete KHAMCANLAMSANG by field.
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>true for successfully deleted</returns>
        public bool Delete(KHAMCANLAMSANG.KHAMCANLAMSANGFields fieldName, object value)
        {
            return _dataObject.DeleteByField(fieldName.ToString(), value); 
        }

        #endregion

    }
}
