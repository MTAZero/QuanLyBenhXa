using System;
using System.Data;
using System.Data.SqlTypes;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace QuanLyBenhXa.BusinessLayer.DataLayer
{
	/// <summary>
	/// Data access layer class for BACSI
	/// </summary>
	class BACSISql : DataLayerBase 
	{

        #region Constructor

		/// <summary>
		/// Class constructor
		/// </summary>
		public BACSISql()
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
		public bool Insert(BACSI businessObject)
		{
			SqlCommand	sqlCommand = new SqlCommand();
			sqlCommand.CommandText = "dbo.[BACSI_Insert]";
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
				sqlCommand.Parameters.Add(new SqlParameter("@QUYEN", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.QUYEN));
				sqlCommand.Parameters.Add(new SqlParameter("@NGAYSINH", SqlDbType.DateTime, 8, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.NGAYSINH));
				sqlCommand.Parameters.Add(new SqlParameter("@CAPBACID", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.CAPBACID));
				sqlCommand.Parameters.Add(new SqlParameter("@CHUCVUID", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.CHUCVUID));
				sqlCommand.Parameters.Add(new SqlParameter("@DONVI", SqlDbType.NVarChar, 2147483647, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.DONVI));
				sqlCommand.Parameters.Add(new SqlParameter("@DANTOC", SqlDbType.NVarChar, 2147483647, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.DANTOC));
				sqlCommand.Parameters.Add(new SqlParameter("@TRINHDOVANHOA", SqlDbType.NVarChar, 2147483647, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.TRINHDOVANHOA));
				sqlCommand.Parameters.Add(new SqlParameter("@DOITUONGID", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.DOITUONGID));
				sqlCommand.Parameters.Add(new SqlParameter("@DONVIID", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.DONVIID));
				sqlCommand.Parameters.Add(new SqlParameter("@TAIKHOANID", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.TAIKHOANID));
				sqlCommand.Parameters.Add(new SqlParameter("@GHICHU", SqlDbType.NVarChar, 2147483647, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.GHICHU));

								
				MainConnection.Open();
				
				sqlCommand.ExecuteNonQuery();
                businessObject.ID = (int)sqlCommand.Parameters["@ID"].Value;

				return true;
			}
			catch//(Exception ex)
			{				
				return false;//throw new Exception("BACSI::Insert::Error occured.", ex);
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
        public bool Update(BACSI businessObject)
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = "dbo.[BACSI_Update]";
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
				sqlCommand.Parameters.Add(new SqlParameter("@QUYEN", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.QUYEN));
				sqlCommand.Parameters.Add(new SqlParameter("@NGAYSINH", SqlDbType.DateTime, 8, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.NGAYSINH));
				sqlCommand.Parameters.Add(new SqlParameter("@CAPBACID", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.CAPBACID));
				sqlCommand.Parameters.Add(new SqlParameter("@CHUCVUID", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.CHUCVUID));
				sqlCommand.Parameters.Add(new SqlParameter("@DONVI", SqlDbType.NVarChar, 2147483647, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.DONVI));
				sqlCommand.Parameters.Add(new SqlParameter("@DANTOC", SqlDbType.NVarChar, 2147483647, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.DANTOC));
				sqlCommand.Parameters.Add(new SqlParameter("@TRINHDOVANHOA", SqlDbType.NVarChar, 2147483647, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.TRINHDOVANHOA));
				sqlCommand.Parameters.Add(new SqlParameter("@DOITUONGID", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.DOITUONGID));
				sqlCommand.Parameters.Add(new SqlParameter("@DONVIID", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.DONVIID));
				sqlCommand.Parameters.Add(new SqlParameter("@TAIKHOANID", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.TAIKHOANID));
				sqlCommand.Parameters.Add(new SqlParameter("@GHICHU", SqlDbType.NVarChar, 2147483647, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.GHICHU));

                
                MainConnection.Open();

                sqlCommand.ExecuteNonQuery();
                return true;
            }
            catch //(Exception ex)
            {
                return false;//throw new Exception("BACSI::Update::Error occured.", ex);
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
        /// <returns>BACSI business object</returns>
        public BACSI SelectByPrimaryKey(BACSIKeys keys)
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = "dbo.[BACSI_SelectByPrimaryKey]";
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
                    BACSI businessObject = new BACSI();

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
                return null;//throw new Exception("BACSI::SelectByPrimaryKey::Error occured.", ex);
            }
            finally
            {             
                MainConnection.Close();
                sqlCommand.Dispose();
            }

        }

        public List<BACSI> SelectAllEntities()
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = "dbo.[BACSI_SelectAll]";
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
                return null;//throw new Exception("BACSI::SelectAll::Error occured.", ex);
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
            sqlCommand.CommandText = "dbo.[BACSI_SelectAll]";
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
                return null;//throw new Exception("BACSI::SelectAll::Error occured.", ex);
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
        /// <returns>list of BACSI</returns>
        public List<BACSI> SelectByField(string fieldName, object value)
        {

            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = "dbo.[BACSI_SelectByField]";
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
                return null;//throw new Exception("BACSI::SelectByField::Error occured.", ex);
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
        public bool Delete(BACSIKeys keys)
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = "dbo.[BACSI_DeleteByPrimaryKey]";
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
                return false;//throw new Exception("BACSI::DeleteByKey::Error occured.", ex);
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
            sqlCommand.CommandText = "dbo.[BACSI_DeleteByField]";
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
                return false;//throw new Exception("BACSI::DeleteByField::Error occured.", ex);
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
        internal void PopulateBusinessObjectFromReader(BACSI businessObject, IDataReader dataReader)
        {


				businessObject.ID = dataReader.GetInt32(dataReader.GetOrdinal(BACSI.BACSIFields.ID.ToString()));

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(BACSI.BACSIFields.HOTEN.ToString())))
				{
					businessObject.HOTEN = dataReader.GetString(dataReader.GetOrdinal(BACSI.BACSIFields.HOTEN.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(BACSI.BACSIFields.GIOITINH.ToString())))
				{
					businessObject.GIOITINH = dataReader.GetInt32(dataReader.GetOrdinal(BACSI.BACSIFields.GIOITINH.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(BACSI.BACSIFields.SDT.ToString())))
				{
					businessObject.SDT = dataReader.GetString(dataReader.GetOrdinal(BACSI.BACSIFields.SDT.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(BACSI.BACSIFields.QUEQUAN.ToString())))
				{
					businessObject.QUEQUAN = dataReader.GetString(dataReader.GetOrdinal(BACSI.BACSIFields.QUEQUAN.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(BACSI.BACSIFields.QUYEN.ToString())))
				{
					businessObject.QUYEN = dataReader.GetInt32(dataReader.GetOrdinal(BACSI.BACSIFields.QUYEN.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(BACSI.BACSIFields.NGAYSINH.ToString())))
				{
					businessObject.NGAYSINH = dataReader.GetDateTime(dataReader.GetOrdinal(BACSI.BACSIFields.NGAYSINH.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(BACSI.BACSIFields.CAPBACID.ToString())))
				{
					businessObject.CAPBACID = dataReader.GetInt32(dataReader.GetOrdinal(BACSI.BACSIFields.CAPBACID.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(BACSI.BACSIFields.CHUCVUID.ToString())))
				{
					businessObject.CHUCVUID = dataReader.GetInt32(dataReader.GetOrdinal(BACSI.BACSIFields.CHUCVUID.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(BACSI.BACSIFields.DONVI.ToString())))
				{
					businessObject.DONVI = dataReader.GetString(dataReader.GetOrdinal(BACSI.BACSIFields.DONVI.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(BACSI.BACSIFields.DANTOC.ToString())))
				{
					businessObject.DANTOC = dataReader.GetString(dataReader.GetOrdinal(BACSI.BACSIFields.DANTOC.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(BACSI.BACSIFields.TRINHDOVANHOA.ToString())))
				{
					businessObject.TRINHDOVANHOA = dataReader.GetString(dataReader.GetOrdinal(BACSI.BACSIFields.TRINHDOVANHOA.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(BACSI.BACSIFields.DOITUONGID.ToString())))
				{
					businessObject.DOITUONGID = dataReader.GetInt32(dataReader.GetOrdinal(BACSI.BACSIFields.DOITUONGID.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(BACSI.BACSIFields.DONVIID.ToString())))
				{
					businessObject.DONVIID = dataReader.GetInt32(dataReader.GetOrdinal(BACSI.BACSIFields.DONVIID.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(BACSI.BACSIFields.TAIKHOANID.ToString())))
				{
					businessObject.TAIKHOANID = dataReader.GetInt32(dataReader.GetOrdinal(BACSI.BACSIFields.TAIKHOANID.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(BACSI.BACSIFields.GHICHU.ToString())))
				{
					businessObject.GHICHU = dataReader.GetString(dataReader.GetOrdinal(BACSI.BACSIFields.GHICHU.ToString()));
				}


        }

        /// <summary>
        /// Populate business objects from the data reader
        /// </summary>
        /// <param name="dataReader">data reader</param>
        /// <returns>list of BACSI</returns>
        internal List<BACSI> PopulateObjectsFromReader(IDataReader dataReader)
        {

            List<BACSI> list = new List<BACSI>();

            while (dataReader.Read())
            {
                BACSI businessObject = new BACSI();
                PopulateBusinessObjectFromReader(businessObject, dataReader);
                list.Add(businessObject);
            }
            return list;

        }

        #endregion

	}
}
