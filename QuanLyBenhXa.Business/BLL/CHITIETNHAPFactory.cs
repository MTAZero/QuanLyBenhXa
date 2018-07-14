using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using QuanLyBenhXa.BusinessLayer.DataLayer;

namespace QuanLyBenhXa.BusinessLayer
{
    public class CHITIETNHAPFactory
    {

        #region data Members

        CHITIETNHAPSql _dataObject = null;

        #endregion

        #region Constructor

        public CHITIETNHAPFactory()
        {
            _dataObject = new CHITIETNHAPSql();
        }

        #endregion


        #region Public Methods

        /// <summary>
        /// Insert new CHITIETNHAP
        /// </summary>
        /// <param name="businessObject">CHITIETNHAP object</param>
        /// <returns>true for successfully saved</returns>
        public bool Insert(CHITIETNHAP businessObject)
        {
            if (!businessObject.IsValid)
            {
                businessObject.ShowErrorMessage();//throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Insert(businessObject);

        }

        /// <summary>
        /// Update existing CHITIETNHAP
        /// </summary>
        /// <param name="businessObject">CHITIETNHAP object</param>
        /// <returns>true for successfully saved</returns>
        public bool Update(CHITIETNHAP businessObject)
        {
            if (!businessObject.IsValid)
            {
                businessObject.ShowErrorMessage();//throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Update(businessObject);
        }

        /// <summary>
        /// get CHITIETNHAP by primary key.
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>Student</returns>
        public CHITIETNHAP GetByPrimaryKey(CHITIETNHAPKeys keys)
        {
            return _dataObject.SelectByPrimaryKey(keys); 
        }

        /// <summary>
        /// get list of all CHITIETNHAPs
        /// </summary>
        /// <returns>list</returns>
        public List<CHITIETNHAP> GetAllEntities()
        {
            return _dataObject.SelectAllEntities(); 
        }
        public DataTable GetAll()
        {
            return _dataObject.SelectAll(); 
        }
        /// <summary>
        /// get list of CHITIETNHAP by field
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>list</returns>
        public List<CHITIETNHAP> GetAllBy(CHITIETNHAP.CHITIETNHAPFields fieldName, object value)
        {
            return _dataObject.SelectByField(fieldName.ToString(), value);  
        }

        /// <summary>
        /// delete by primary key
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>true for succesfully deleted</returns>
        public bool Delete(CHITIETNHAPKeys keys)
        {
            return _dataObject.Delete(keys); 
        }

        /// <summary>
        /// delete CHITIETNHAP by field.
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>true for successfully deleted</returns>
        public bool Delete(CHITIETNHAP.CHITIETNHAPFields fieldName, object value)
        {
            return _dataObject.DeleteByField(fieldName.ToString(), value); 
        }

        #endregion

    }
}
