using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using QuanLyBenhXa.BusinessLayer.DataLayer;

namespace QuanLyBenhXa.BusinessLayer
{
    public class BENHVIENFactory
    {

        #region data Members

        BENHVIENSql _dataObject = null;

        #endregion

        #region Constructor

        public BENHVIENFactory()
        {
            _dataObject = new BENHVIENSql();
        }

        #endregion


        #region Public Methods

        /// <summary>
        /// Insert new BENHVIEN
        /// </summary>
        /// <param name="businessObject">BENHVIEN object</param>
        /// <returns>true for successfully saved</returns>
        public bool Insert(BENHVIEN businessObject)
        {
            if (!businessObject.IsValid)
            {
                businessObject.ShowErrorMessage();//throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Insert(businessObject);

        }

        /// <summary>
        /// Update existing BENHVIEN
        /// </summary>
        /// <param name="businessObject">BENHVIEN object</param>
        /// <returns>true for successfully saved</returns>
        public bool Update(BENHVIEN businessObject)
        {
            if (!businessObject.IsValid)
            {
                businessObject.ShowErrorMessage();//throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Update(businessObject);
        }

        /// <summary>
        /// get BENHVIEN by primary key.
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>Student</returns>
        public BENHVIEN GetByPrimaryKey(BENHVIENKeys keys)
        {
            return _dataObject.SelectByPrimaryKey(keys); 
        }

        /// <summary>
        /// get list of all BENHVIENs
        /// </summary>
        /// <returns>list</returns>
        public List<BENHVIEN> GetAllEntities()
        {
            return _dataObject.SelectAllEntities(); 
        }
        public DataTable GetAll()
        {
            return _dataObject.SelectAll(); 
        }
        /// <summary>
        /// get list of BENHVIEN by field
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>list</returns>
        public List<BENHVIEN> GetAllBy(BENHVIEN.BENHVIENFields fieldName, object value)
        {
            return _dataObject.SelectByField(fieldName.ToString(), value);  
        }

        /// <summary>
        /// delete by primary key
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>true for succesfully deleted</returns>
        public bool Delete(BENHVIENKeys keys)
        {
            return _dataObject.Delete(keys); 
        }

        /// <summary>
        /// delete BENHVIEN by field.
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>true for successfully deleted</returns>
        public bool Delete(BENHVIEN.BENHVIENFields fieldName, object value)
        {
            return _dataObject.DeleteByField(fieldName.ToString(), value); 
        }

        #endregion

    }
}
