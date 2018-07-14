using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using QuanLyBenhXa.BusinessLayer.DataLayer;

namespace QuanLyBenhXa.BusinessLayer
{
    public class MUONVATTUFactory
    {

        #region data Members

        MUONVATTUSql _dataObject = null;

        #endregion

        #region Constructor

        public MUONVATTUFactory()
        {
            _dataObject = new MUONVATTUSql();
        }

        #endregion


        #region Public Methods

        /// <summary>
        /// Insert new MUONVATTU
        /// </summary>
        /// <param name="businessObject">MUONVATTU object</param>
        /// <returns>true for successfully saved</returns>
        public bool Insert(MUONVATTU businessObject)
        {
            if (!businessObject.IsValid)
            {
                businessObject.ShowErrorMessage();//throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Insert(businessObject);

        }

        /// <summary>
        /// Update existing MUONVATTU
        /// </summary>
        /// <param name="businessObject">MUONVATTU object</param>
        /// <returns>true for successfully saved</returns>
        public bool Update(MUONVATTU businessObject)
        {
            if (!businessObject.IsValid)
            {
                businessObject.ShowErrorMessage();//throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Update(businessObject);
        }

        /// <summary>
        /// get MUONVATTU by primary key.
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>Student</returns>
        public MUONVATTU GetByPrimaryKey(MUONVATTUKeys keys)
        {
            return _dataObject.SelectByPrimaryKey(keys); 
        }

        /// <summary>
        /// get list of all MUONVATTUs
        /// </summary>
        /// <returns>list</returns>
        public List<MUONVATTU> GetAllEntities()
        {
            return _dataObject.SelectAllEntities(); 
        }
        public DataTable GetAll()
        {
            return _dataObject.SelectAll(); 
        }
        /// <summary>
        /// get list of MUONVATTU by field
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>list</returns>
        public List<MUONVATTU> GetAllBy(MUONVATTU.MUONVATTUFields fieldName, object value)
        {
            return _dataObject.SelectByField(fieldName.ToString(), value);  
        }

        /// <summary>
        /// delete by primary key
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>true for succesfully deleted</returns>
        public bool Delete(MUONVATTUKeys keys)
        {
            return _dataObject.Delete(keys); 
        }

        /// <summary>
        /// delete MUONVATTU by field.
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>true for successfully deleted</returns>
        public bool Delete(MUONVATTU.MUONVATTUFields fieldName, object value)
        {
            return _dataObject.DeleteByField(fieldName.ToString(), value); 
        }

        #endregion

    }
}
