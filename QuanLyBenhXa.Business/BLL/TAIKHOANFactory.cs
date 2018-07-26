using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using QuanLyBenhXa.BusinessLayer.DataLayer;
using System.Linq;

namespace QuanLyBenhXa.BusinessLayer
{
    public class TAIKHOANFactory
    {

        #region data Members

        TAIKHOANSql _dataObject = null;

        #endregion

        #region Constructor

        public TAIKHOANFactory()
        {
            _dataObject = new TAIKHOANSql();
        }

        #endregion


        #region Public Methods

        /// <summary>
        /// Insert new TAIKHOAN
        /// </summary>
        /// <param name="businessObject">TAIKHOAN object</param>
        /// <returns>true for successfully saved</returns>
        public bool Insert(TAIKHOAN businessObject, int? bacsiID)
        {
            if (!businessObject.IsValid)
            {
                businessObject.ShowErrorMessage();//throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }

            bool ans = _dataObject.Insert(businessObject);

            if (bacsiID!=0 || bacsiID!=null)
            {
                try
                {
                    BACSIFactory BACSIService = new BACSIFactory();
                    BACSI bacsi = BACSIService.GetByPrimaryKey(new BACSIKeys((int)bacsiID));
                    bacsi.TAIKHOANID = businessObject.ID;
                    BACSIService.Update(bacsi);
                }
                catch
                {
                }
            }

            return ans;
        }

        /// <summary>
        /// Update existing TAIKHOAN
        /// </summary>
        /// <param name="businessObject">TAIKHOAN object</param>
        /// <returns>true for successfully saved</returns>
        public bool Update(TAIKHOAN businessObject)
        {
            if (!businessObject.IsValid)
            {
                businessObject.ShowErrorMessage();//throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Update(businessObject);
        }

        /// <summary>
        /// get TAIKHOAN by primary key.
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>Student</returns>
        public TAIKHOAN GetByPrimaryKey(TAIKHOANKeys keys)
        {
            return _dataObject.SelectByPrimaryKey(keys); 
        }

        /// <summary>
        /// get list of all TAIKHOANs
        /// </summary>
        /// <returns>list</returns>
        public List<TAIKHOAN> GetAllEntities()
        {
            return _dataObject.SelectAllEntities(); 
        }
        public DataTable GetAll()
        {
            return _dataObject.SelectAll(); 
        }
        /// <summary>
        /// get list of TAIKHOAN by field
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>list</returns>
        public List<TAIKHOAN> GetAllBy(TAIKHOAN.TAIKHOANFields fieldName, object value)
        {
            return _dataObject.SelectByField(fieldName.ToString(), value);  
        }

        /// <summary>
        /// delete by primary key
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>true for succesfully deleted</returns>
        public bool Delete(TAIKHOANKeys keys)
        {
            BACSIFactory BACSIService = new BACSIFactory();
            try
            {
                BACSI bacsi = BACSIService.GetAllEntities().ToList()
                              .Where(p => p.TAIKHOANID == keys.ID)
                              .FirstOrDefault();
                bacsi.TAIKHOANID = null;
                BACSIService.Update(bacsi);
            }
            catch
            {
            }
            return _dataObject.Delete(keys); 
        }

        /// <summary>
        /// delete TAIKHOAN by field.
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>true for successfully deleted</returns>
        public bool Delete(TAIKHOAN.TAIKHOANFields fieldName, object value)
        {
            return _dataObject.DeleteByField(fieldName.ToString(), value); 
        }

        public int LoaiTaiKhoan(TAIKHOAN a)
        {
            // 0: tài khoản tự do
            // 1: tài khoản sở hữu
            BACSIFactory BACSIService = new BACSIFactory();
            int soluong = BACSIService.GetAllEntities().ToList()
                          .Where(p => p.TAIKHOANID == a.ID)
                          .ToList()
                          .Count;
            if (soluong == 0) return 0;
            return 1;
        }

        public BACSI ChuSoHuu(TAIKHOAN a)
        {
            BACSI ans = new BACSI();

            BACSIFactory BACSIService = new BACSIFactory();
            ans = BACSIService.GetAllEntities().ToList()
                  .Where(p => p.TAIKHOANID == a.ID)
                  .FirstOrDefault();

            return ans;
        }
        #endregion

    }
}
