using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using QuanLyBenhXa.BusinessLayer.DataLayer;

namespace QuanLyBenhXa.BusinessLayer
{
    public class GIAYGIOITHIEUFactory
    {

        #region data Members

        GIAYGIOITHIEUSql _dataObject = null;

        #endregion

        #region Constructor

        public GIAYGIOITHIEUFactory()
        {
            _dataObject = new GIAYGIOITHIEUSql();
        }

        #endregion


        #region Public Methods

        /// <summary>
        /// Insert new GIAYGIOITHIEU
        /// </summary>
        /// <param name="businessObject">GIAYGIOITHIEU object</param>
        /// <returns>true for successfully saved</returns>
        public bool Insert(GIAYGIOITHIEU businessObject)
        {
            if (!businessObject.IsValid)
            {
                businessObject.ShowErrorMessage();//throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Insert(businessObject);

        }

        /// <summary>
        /// Update existing GIAYGIOITHIEU
        /// </summary>
        /// <param name="businessObject">GIAYGIOITHIEU object</param>
        /// <returns>true for successfully saved</returns>
        public bool Update(GIAYGIOITHIEU businessObject)
        {
            if (!businessObject.IsValid)
            {
                businessObject.ShowErrorMessage();//throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Update(businessObject);
        }

        /// <summary>
        /// get GIAYGIOITHIEU by primary key.
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>Student</returns>
        public GIAYGIOITHIEU GetByPrimaryKey(GIAYGIOITHIEUKeys keys)
        {
            return _dataObject.SelectByPrimaryKey(keys); 
        }

        /// <summary>
        /// get list of all GIAYGIOITHIEUs
        /// </summary>
        /// <returns>list</returns>
        public List<GIAYGIOITHIEU> GetAllEntities()
        {
            return _dataObject.SelectAllEntities(); 
        }
        public DataTable GetAll()
        {
            return _dataObject.SelectAll(); 
        }
        /// <summary>
        /// get list of GIAYGIOITHIEU by field
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>list</returns>
        public List<GIAYGIOITHIEU> GetAllBy(GIAYGIOITHIEU.GIAYGIOITHIEUFields fieldName, object value)
        {
            return _dataObject.SelectByField(fieldName.ToString(), value);  
        }

        /// <summary>
        /// delete by primary key
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>true for succesfully deleted</returns>
        public bool Delete(GIAYGIOITHIEUKeys keys)
        {
            return _dataObject.Delete(keys); 
        }

        /// <summary>
        /// delete GIAYGIOITHIEU by field.
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>true for successfully deleted</returns>
        public bool Delete(GIAYGIOITHIEU.GIAYGIOITHIEUFields fieldName, object value)
        {
            return _dataObject.DeleteByField(fieldName.ToString(), value); 
        }

        #endregion

    }
}
