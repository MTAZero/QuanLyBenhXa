using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using QuanLyBenhXa.BusinessLayer.DataLayer;
using System.Linq;

namespace QuanLyBenhXa.BusinessLayer
{
    public class NHOMBENHFactory
    {

        #region data Members

        NHOMBENHSql _dataObject = null;

        #endregion

        #region Constructor

        public NHOMBENHFactory()
        {
            _dataObject = new NHOMBENHSql();
        }

        #endregion


        #region Public Methods

        /// <summary>
        /// Insert new NHOMBENH
        /// </summary>
        /// <param name="businessObject">NHOMBENH object</param>
        /// <returns>true for successfully saved</returns>
        public bool Insert(NHOMBENH businessObject)
        {
            if (!businessObject.IsValid)
            {
                businessObject.ShowErrorMessage();//throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Insert(businessObject);

        }

        /// <summary>
        /// Update existing NHOMBENH
        /// </summary>
        /// <param name="businessObject">NHOMBENH object</param>
        /// <returns>true for successfully saved</returns>
        public bool Update(NHOMBENH businessObject)
        {
            if (!businessObject.IsValid)
            {
                businessObject.ShowErrorMessage();//throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Update(businessObject);
        }

        /// <summary>
        /// get NHOMBENH by primary key.
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>Student</returns>
        public NHOMBENH GetByPrimaryKey(NHOMBENHKeys keys)
        {
            return _dataObject.SelectByPrimaryKey(keys); 
        }

        /// <summary>
        /// get list of all NHOMBENHs
        /// </summary>
        /// <returns>list</returns>
        public List<NHOMBENH> GetAllEntities()
        {
            return _dataObject.SelectAllEntities(); 
        }
        public DataTable GetAll()
        {
            return _dataObject.SelectAll(); 
        }
        /// <summary>
        /// get list of NHOMBENH by field
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>list</returns>
        public List<NHOMBENH> GetAllBy(NHOMBENH.NHOMBENHFields fieldName, object value)
        {
            return _dataObject.SelectByField(fieldName.ToString(), value);  
        }

        /// <summary>
        /// delete by primary key
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>true for succesfully deleted</returns>
        public bool Delete(NHOMBENHKeys keys)
        {
            try
            {
                LOAIBENHFactory LOAIBENHService = new LOAIBENHFactory();
                NHOMBENH lb = GetAllBy(NHOMBENH.NHOMBENHFields.ID, keys.ID).FirstOrDefault();

                List<LOAIBENH> dsBENH = LOAIBENHService.GetAllEntities().ToList().Where(p => p.NHOMBENHID == lb.ID).ToList();
                foreach (LOAIBENH item in dsBENH) LOAIBENHService.Delete(new LOAIBENHKeys(item.ID));
            }
            catch
            {
            }

            return _dataObject.Delete(keys); 
        }

        /// <summary>
        /// delete NHOMBENH by field.
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>true for successfully deleted</returns>
        public bool Delete(NHOMBENH.NHOMBENHFields fieldName, object value)
        {
            return _dataObject.DeleteByField(fieldName.ToString(), value); 
        }

        #endregion

    }
}
