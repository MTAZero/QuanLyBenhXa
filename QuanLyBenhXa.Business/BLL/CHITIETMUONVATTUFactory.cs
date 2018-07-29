using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using QuanLyBenhXa.BusinessLayer.DataLayer;
using System.Linq;

namespace QuanLyBenhXa.BusinessLayer
{
    public class CHITIETMUONVATTUFactory
    {

        #region data Members

        CHITIETMUONVATTUSql _dataObject = null;

        #endregion

        #region Constructor

        public CHITIETMUONVATTUFactory()
        {
            _dataObject = new CHITIETMUONVATTUSql();
        }

        #endregion


        #region Public Methods

        /// <summary>
        /// Insert new CHITIETMUONVATTU
        /// </summary>
        /// <param name="businessObject">CHITIETMUONVATTU object</param>
        /// <returns>true for successfully saved</returns>
        public bool Insert(CHITIETMUONVATTU businessObject)
        {
            if (!businessObject.IsValid)
            {
                businessObject.ShowErrorMessage();//throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }

            VATTUFactory VATTUService = new VATTUFactory();
            VATTU vattu = VATTUService.GetAllEntities().Where(p => p.ID == businessObject.VATTUID).FirstOrDefault();
            vattu.SOLUONG -= businessObject.SOLUONG;
            VATTUService.Update(vattu);

            return _dataObject.Insert(businessObject);

        }

        /// <summary>
        /// Update existing CHITIETMUONVATTU
        /// </summary>
        /// <param name="businessObject">CHITIETMUONVATTU object</param>
        /// <returns>true for successfully saved</returns>
        public bool Update(CHITIETMUONVATTU businessObject)
        {
            if (!businessObject.IsValid)
            {
                businessObject.ShowErrorMessage();//throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Update(businessObject);
        }

        /// <summary>
        /// get CHITIETMUONVATTU by primary key.
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>Student</returns>
        public CHITIETMUONVATTU GetByPrimaryKey(CHITIETMUONVATTUKeys keys)
        {
            return _dataObject.SelectByPrimaryKey(keys); 
        }

        /// <summary>
        /// get list of all CHITIETMUONVATTUs
        /// </summary>
        /// <returns>list</returns>
        public List<CHITIETMUONVATTU> GetAllEntities()
        {
            return _dataObject.SelectAllEntities(); 
        }
        public DataTable GetAll()
        {
            return _dataObject.SelectAll(); 
        }
        /// <summary>
        /// get list of CHITIETMUONVATTU by field
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>list</returns>
        public List<CHITIETMUONVATTU> GetAllBy(CHITIETMUONVATTU.CHITIETMUONVATTUFields fieldName, object value)
        {
            return _dataObject.SelectByField(fieldName.ToString(), value);  
        }

        /// <summary>
        /// delete by primary key
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>true for succesfully deleted</returns>
        public bool Delete(CHITIETMUONVATTUKeys keys)
        {
            CHITIETMUONVATTU businessObject = GetAllEntities().ToList().Where(p => p.ID == keys.ID).FirstOrDefault();

            VATTUFactory VATTUService = new VATTUFactory();
            VATTU vattu = VATTUService.GetAllEntities().Where(p => p.ID == businessObject.VATTUID).FirstOrDefault();
            vattu.SOLUONG += businessObject.SOLUONG;
            VATTUService.Update(vattu);

            return _dataObject.Delete(keys); 
        }

        /// <summary>
        /// delete CHITIETMUONVATTU by field.
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>true for successfully deleted</returns>
        public bool Delete(CHITIETMUONVATTU.CHITIETMUONVATTUFields fieldName, object value)
        {
            return _dataObject.DeleteByField(fieldName.ToString(), value); 
        }

        #endregion

    }
}
