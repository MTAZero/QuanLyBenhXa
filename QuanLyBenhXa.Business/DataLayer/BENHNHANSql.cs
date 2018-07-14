using System;
using System.Data;
using System.Data.SqlTypes;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace QuanLyBenhXa.BusinessLayer.DataLayer
{
	/// <summary>
	/// Data access layer class for BENHNHAN
	/// </summary>
	class BENHNHANSql : DataLayerBase 
	{

        #region Constructor

		/// <summary>
		/// Class constructor
		/// </summary>
		public BENHNHANSql()
		{
			// Nothing for now.
		}

        #endregion

        #region Public Methods

        /// <summary>
        /// insert new row in the table
        /// </summary>
		/// <param name="businessObject">business object</param>
		/// <returns>true of successfully insert</returns>
		public bool Insert(BENHNHAN businessObject)
		{
			SqlCommand	sqlCommand = new SqlCommand();
			sqlCommand.CommandText = "dbo.[BENHNHAN_Insert]";
			sqlCommand.CommandType = CommandType.StoredProcedure;

			// Use connection object of base class
			sqlCommand.Connection = MainConnection;

			try
			{
                
				sqlCommand.Parameters.Add(new SqlParameter("@ID", SqlDbType.Int, 4, ParameterDirection.Output, false, 0, 0, "", DataRowVersion.Proposed, businessObject.ID));
				sqlCommand.Parameters.Add(new SqlParameter("@HOTEN", SqlDbType.NVarChar, 2147483647, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.HOTEN));
				sqlCommand.Parameters.Add(new SqlParameter("@GIOITINH", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.GIOITINH));
				sqlCommand.Parameters.Add(new SqlParameter("@SDT", SqlDbType.NVarChar, 2147483647, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.SDT));
				sqlCommand.Parameters.Add(new SqlParameter("@QUEQUAN", SqlDbType.NVarChar, 2147483647, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.QUEQUAN));
				sqlCommand.Parameters.Add(new SqlParameter("@NGAYSINH", SqlDbType.DateTime, 8, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.NGAYSINH));
				sqlCommand.Parameters.Add(new SqlParameter("@MATHEBHYT", SqlDbType.NVarChar, 2147483647, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.MATHEBHYT));
				sqlCommand.Parameters.Add(new SqlParameter("@NAMNHAPNGU", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.NAMNHAPNGU));
				sqlCommand.Parameters.Add(new SqlParameter("@TRINHDOVANHOA", SqlDbType.NVarChar, 2147483647, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.TRINHDOVANHOA));
				sqlCommand.Parameters.Add(new SqlParameter("@CAPBACID", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.CAPBACID));
				sqlCommand.Parameters.Add(new SqlParameter("@CHUCVUID", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.CHUCVUID));
				sqlCommand.Parameters.Add(new SqlParameter("@NGHENGHIEP", SqlDbType.NVarChar, 2147483647, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.NGHENGHIEP));
				sqlCommand.Parameters.Add(new SqlParameter("@DOITUONGID", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.DOITUONGID));
				sqlCommand.Parameters.Add(new SqlParameter("@DONVIID", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.DONVIID));
				sqlCommand.Parameters.Add(new SqlParameter("@TIENSUBENH", SqlDbType.NVarChar, 2147483647, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.TIENSUBENH));
				sqlCommand.Parameters.Add(new SqlParameter("@NHOMMAU", SqlDbType.NVarChar, 2147483647, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.NHOMMAU));
				sqlCommand.Parameters.Add(new SqlParameter("@DIUNG", SqlDbType.NVarChar, 2147483647, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.DIUNG));
				sqlCommand.Parameters.Add(new SqlParameter("@GHICHU", SqlDbType.NVarChar, 2147483647, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.GHICHU));

								
				MainConnection.Open();
				
				sqlCommand.ExecuteNonQuery();
                businessObject.ID = (int)sqlCommand.Parameters["@ID"].Value;

				return true;
			}
			catch//(Exception ex)
			{				
				return false;//throw new Exception("BENHNHAN::Insert::Error occured.", ex);
			}
			finally
			{			
				MainConnection.Close();
				sqlCommand.Dispose();
			}
		}

         /// <summary>
        /// update row in the table
        /// </summary>
        /// <param name="businessObject">business object</param>
        /// <returns>true for successfully updated</returns>
        public bool Update(BENHNHAN businessObject)
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = "dbo.[BENHNHAN_Update]";
            sqlCommand.CommandType = CommandType.StoredProcedure;

            // Use connection object of base class
            sqlCommand.Connection = MainConnection;

            try
            {
                
				sqlCommand.Parameters.Add(new SqlParameter("@ID", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.ID));
				sqlCommand.Parameters.Add(new SqlParameter("@HOTEN", SqlDbType.NVarChar, 2147483647, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.HOTEN));
				sqlCommand.Parameters.Add(new SqlParameter("@GIOITINH", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.GIOITINH));
				sqlCommand.Parameters.Add(new SqlParameter("@SDT", SqlDbType.NVarChar, 2147483647, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.SDT));
				sqlCommand.Parameters.Add(new SqlParameter("@QUEQUAN", SqlDbType.NVarChar, 2147483647, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.QUEQUAN));
				sqlCommand.Parameters.Add(new SqlParameter("@NGAYSINH", SqlDbType.DateTime, 8, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.NGAYSINH));
				sqlCommand.Parameters.Add(new SqlParameter("@MATHEBHYT", SqlDbType.NVarChar, 2147483647, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.MATHEBHYT));
				sqlCommand.Parameters.Add(new SqlParameter("@NAMNHAPNGU", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.NAMNHAPNGU));
				sqlCommand.Parameters.Add(new SqlParameter("@TRINHDOVANHOA", SqlDbType.NVarChar, 2147483647, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.TRINHDOVANHOA));
				sqlCommand.Parameters.Add(new SqlParameter("@CAPBACID", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.CAPBACID));
				sqlCommand.Parameters.Add(new SqlParameter("@CHUCVUID", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.CHUCVUID));
				sqlCommand.Parameters.Add(new SqlParameter("@NGHENGHIEP", SqlDbType.NVarChar, 2147483647, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.NGHENGHIEP));
				sqlCommand.Parameters.Add(new SqlParameter("@DOITUONGID", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.DOITUONGID));
				sqlCommand.Parameters.Add(new SqlParameter("@DONVIID", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.DONVIID));
				sqlCommand.Parameters.Add(new SqlParameter("@TIENSUBENH", SqlDbType.NVarChar, 2147483647, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.TIENSUBENH));
				sqlCommand.Parameters.Add(new SqlParameter("@NHOMMAU", SqlDbType.NVarChar, 2147483647, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.NHOMMAU));
				sqlCommand.Parameters.Add(new SqlParameter("@DIUNG", SqlDbType.NVarChar, 2147483647, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.DIUNG));
				sqlCommand.Parameters.Add(new SqlParameter("@GHICHU", SqlDbType.NVarChar, 2147483647, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.GHICHU));

                
                MainConnection.Open();

                sqlCommand.ExecuteNonQuery();
                return true;
            }
            catch //(Exception ex)
            {
                return false;//throw new Exception("BENHNHAN::Update::Error occured.", ex);
            }
            finally
            {
                MainConnection.Close();
                sqlCommand.Dispose();
            }
        }

        /// <summary>
        /// Select by primary key
        /// </summary>
        /// <param name="keys">primary keys</param>
        /// <returns>BENHNHAN business object</returns>
        public BENHNHAN SelectByPrimaryKey(BENHNHANKeys keys)
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = "dbo.[BENHNHAN_SelectByPrimaryKey]";
            sqlCommand.CommandType = CommandType.StoredProcedure;

            // Use connection object of base class
            sqlCommand.Connection = MainConnection;

            try
            {

				sqlCommand.Parameters.Add(new SqlParameter("@ID", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, keys.ID));

                
                MainConnection.Open();

                IDataReader dataReader = sqlCommand.ExecuteReader();

                if (dataReader.Read())
                {
                    BENHNHAN businessObject = new BENHNHAN();

                    PopulateBusinessObjectFromReader(businessObject, dataReader);

                    return businessObject;
                }
                else
                {
                    return null;
                }
            }
            catch //(Exception ex)
            {
                return null;//throw new Exception("BENHNHAN::SelectByPrimaryKey::Error occured.", ex);
            }
            finally
            {             
                MainConnection.Close();
                sqlCommand.Dispose();
            }

        }

        public List<BENHNHAN> SelectAllEntities()
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = "dbo.[BENHNHAN_SelectAll]";
            sqlCommand.CommandType = CommandType.StoredProcedure;

            // Use connection object of base class
            sqlCommand.Connection = MainConnection;

            try
            {
                
                MainConnection.Open();

                IDataReader dataReader = sqlCommand.ExecuteReader();

                return PopulateObjectsFromReader(dataReader);

            }
            catch //(Exception ex)
            {                
                return null;//throw new Exception("BENHNHAN::SelectAll::Error occured.", ex);
            }
            finally
            {
                MainConnection.Close();
                sqlCommand.Dispose();
            }

        }

        public DataTable SelectAll()
        {
            DataTable result = new DataTable();
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = "dbo.[BENHNHAN_SelectAll]";
            sqlCommand.CommandType = CommandType.StoredProcedure;

            // Use connection object of base class
            sqlCommand.Connection = MainConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);  
            try
            {
               adapter.Fill(result);           
            }
            catch //(Exception ex)
            {                
                return null;//throw new Exception("BENHNHAN::SelectAll::Error occured.", ex);
            }
            finally
            {
                MainConnection.Close();
                sqlCommand.Dispose();
            }
            return result;
        }
        /// <summary>
        /// Select records by field
        /// </summary>
        /// <param name="fieldName">name of field</param>
        /// <param name="value">value of field</param>
        /// <returns>list of BENHNHAN</returns>
        public List<BENHNHAN> SelectByField(string fieldName, object value)
        {

            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = "dbo.[BENHNHAN_SelectByField]";
            sqlCommand.CommandType = CommandType.StoredProcedure;

            // Use connection object of base class
            sqlCommand.Connection = MainConnection;

            try
            {

                sqlCommand.Parameters.Add(new SqlParameter("@FieldName", fieldName));
                sqlCommand.Parameters.Add(new SqlParameter("@Value", value));

                MainConnection.Open();
                
                IDataReader dataReader = sqlCommand.ExecuteReader();

                return PopulateObjectsFromReader(dataReader);

            }
            catch //(Exception ex)
            {
                return null;//throw new Exception("BENHNHAN::SelectByField::Error occured.", ex);
            }
            finally
            {

                MainConnection.Close();
                sqlCommand.Dispose();
            }

        }

        /// <summary>
        /// Delete by primary key
        /// </summary>
        /// <param name="keys">primary keys</param>
        /// <returns>true for successfully deleted</returns>
        public bool Delete(BENHNHANKeys keys)
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = "dbo.[BENHNHAN_DeleteByPrimaryKey]";
            sqlCommand.CommandType = CommandType.StoredProcedure;

            // Use connection object of base class
            sqlCommand.Connection = MainConnection;

            try
            {

				sqlCommand.Parameters.Add(new SqlParameter("@ID", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, keys.ID));


                MainConnection.Open();

                sqlCommand.ExecuteNonQuery();

                return true;
            }
            catch //(Exception ex)
            {
                return false;//throw new Exception("BENHNHAN::DeleteByKey::Error occured.", ex);
            }
            finally
            {                
                MainConnection.Close();
                sqlCommand.Dispose();
            }

        }

        /// <summary>
        /// Delete records by field
        /// </summary>
        /// <param name="fieldName">name of field</param>
        /// <param name="value">value of field</param>
        /// <returns>true for successfully deleted</returns>
        public bool DeleteByField(string fieldName, object value)
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = "dbo.[BENHNHAN_DeleteByField]";
            sqlCommand.CommandType = CommandType.StoredProcedure;

            // Use connection object of base class
            sqlCommand.Connection = MainConnection;

            try
            {

                sqlCommand.Parameters.Add(new SqlParameter("@FieldName", fieldName));
                sqlCommand.Parameters.Add(new SqlParameter("@Value", value));
                
                MainConnection.Open();

                sqlCommand.ExecuteNonQuery();

                return true;

            }
            catch //(Exception ex)
            {                
                return false;//throw new Exception("BENHNHAN::DeleteByField::Error occured.", ex);
            }
            finally
            {             
                MainConnection.Close();
                sqlCommand.Dispose();
            }

        }

        #endregion

        #region Private Methods

        /// <summary>
        /// Populate business object from data reader
        /// </summary>
        /// <param name="businessObject">business object</param>
        /// <param name="dataReader">data reader</param>
        internal void PopulateBusinessObjectFromReader(BENHNHAN businessObject, IDataReader dataReader)
        {


				businessObject.ID = dataReader.GetInt32(dataReader.GetOrdinal(BENHNHAN.BENHNHANFields.ID.ToString()));

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(BENHNHAN.BENHNHANFields.HOTEN.ToString())))
				{
					businessObject.HOTEN = dataReader.GetString(dataReader.GetOrdinal(BENHNHAN.BENHNHANFields.HOTEN.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(BENHNHAN.BENHNHANFields.GIOITINH.ToString())))
				{
					businessObject.GIOITINH = dataReader.GetInt32(dataReader.GetOrdinal(BENHNHAN.BENHNHANFields.GIOITINH.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(BENHNHAN.BENHNHANFields.SDT.ToString())))
				{
					businessObject.SDT = dataReader.GetString(dataReader.GetOrdinal(BENHNHAN.BENHNHANFields.SDT.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(BENHNHAN.BENHNHANFields.QUEQUAN.ToString())))
				{
					businessObject.QUEQUAN = dataReader.GetString(dataReader.GetOrdinal(BENHNHAN.BENHNHANFields.QUEQUAN.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(BENHNHAN.BENHNHANFields.NGAYSINH.ToString())))
				{
					businessObject.NGAYSINH = dataReader.GetDateTime(dataReader.GetOrdinal(BENHNHAN.BENHNHANFields.NGAYSINH.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(BENHNHAN.BENHNHANFields.MATHEBHYT.ToString())))
				{
					businessObject.MATHEBHYT = dataReader.GetString(dataReader.GetOrdinal(BENHNHAN.BENHNHANFields.MATHEBHYT.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(BENHNHAN.BENHNHANFields.NAMNHAPNGU.ToString())))
				{
					businessObject.NAMNHAPNGU = dataReader.GetInt32(dataReader.GetOrdinal(BENHNHAN.BENHNHANFields.NAMNHAPNGU.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(BENHNHAN.BENHNHANFields.TRINHDOVANHOA.ToString())))
				{
					businessObject.TRINHDOVANHOA = dataReader.GetString(dataReader.GetOrdinal(BENHNHAN.BENHNHANFields.TRINHDOVANHOA.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(BENHNHAN.BENHNHANFields.CAPBACID.ToString())))
				{
					businessObject.CAPBACID = dataReader.GetInt32(dataReader.GetOrdinal(BENHNHAN.BENHNHANFields.CAPBACID.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(BENHNHAN.BENHNHANFields.CHUCVUID.ToString())))
				{
					businessObject.CHUCVUID = dataReader.GetInt32(dataReader.GetOrdinal(BENHNHAN.BENHNHANFields.CHUCVUID.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(BENHNHAN.BENHNHANFields.NGHENGHIEP.ToString())))
				{
					businessObject.NGHENGHIEP = dataReader.GetString(dataReader.GetOrdinal(BENHNHAN.BENHNHANFields.NGHENGHIEP.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(BENHNHAN.BENHNHANFields.DOITUONGID.ToString())))
				{
					businessObject.DOITUONGID = dataReader.GetInt32(dataReader.GetOrdinal(BENHNHAN.BENHNHANFields.DOITUONGID.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(BENHNHAN.BENHNHANFields.DONVIID.ToString())))
				{
					businessObject.DONVIID = dataReader.GetInt32(dataReader.GetOrdinal(BENHNHAN.BENHNHANFields.DONVIID.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(BENHNHAN.BENHNHANFields.TIENSUBENH.ToString())))
				{
					businessObject.TIENSUBENH = dataReader.GetString(dataReader.GetOrdinal(BENHNHAN.BENHNHANFields.TIENSUBENH.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(BENHNHAN.BENHNHANFields.NHOMMAU.ToString())))
				{
					businessObject.NHOMMAU = dataReader.GetString(dataReader.GetOrdinal(BENHNHAN.BENHNHANFields.NHOMMAU.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(BENHNHAN.BENHNHANFields.DIUNG.ToString())))
				{
					businessObject.DIUNG = dataReader.GetString(dataReader.GetOrdinal(BENHNHAN.BENHNHANFields.DIUNG.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(BENHNHAN.BENHNHANFields.GHICHU.ToString())))
				{
					businessObject.GHICHU = dataReader.GetString(dataReader.GetOrdinal(BENHNHAN.BENHNHANFields.GHICHU.ToString()));
				}


        }

        /// <summary>
        /// Populate business objects from the data reader
        /// </summary>
        /// <param name="dataReader">data reader</param>
        /// <returns>list of BENHNHAN</returns>
        internal List<BENHNHAN> PopulateObjectsFromReader(IDataReader dataReader)
        {

            List<BENHNHAN> list = new List<BENHNHAN>();

            while (dataReader.Read())
            {
                BENHNHAN businessObject = new BENHNHAN();
                PopulateBusinessObjectFromReader(businessObject, dataReader);
                list.Add(businessObject);
            }
            return list;

        }

        #endregion

	}
}
