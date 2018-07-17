using System;
using System.Data;
using System.Data.SqlTypes;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace QuanLyBenhXa.BusinessLayer.DataLayer
{
	/// <summary>
	/// Data access layer class for KHAMCANLAMSANG
	/// </summary>
	class KHAMCANLAMSANGSql : DataLayerBase 
	{

        #region Constructor

		/// <summary>
		/// Class constructor
		/// </summary>
		public KHAMCANLAMSANGSql()
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
		public bool Insert(KHAMCANLAMSANG businessObject)
		{
			SqlCommand	sqlCommand = new SqlCommand();
			sqlCommand.CommandText = "dbo.[KHAMCANLAMSANG_Insert]";
			sqlCommand.CommandType = CommandType.StoredProcedure;

			// Use connection object of base class
			sqlCommand.Connection = MainConnection;

			try
			{
                
				sqlCommand.Parameters.Add(new SqlParameter("@ID", SqlDbType.Int, 4, ParameterDirection.Output, false, 0, 0, "", DataRowVersion.Proposed, businessObject.ID));
				sqlCommand.Parameters.Add(new SqlParameter("@BACSIID", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.BACSIID));
				sqlCommand.Parameters.Add(new SqlParameter("@MAU", SqlDbType.NVarChar, 2147483647, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.MAU));
				sqlCommand.Parameters.Add(new SqlParameter("@NUOCTIEU", SqlDbType.NVarChar, 2147483647, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.NUOCTIEU));
				sqlCommand.Parameters.Add(new SqlParameter("@SIEUAM", SqlDbType.NVarChar, 2147483647, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.SIEUAM));
				sqlCommand.Parameters.Add(new SqlParameter("@DIENTIM", SqlDbType.NVarChar, 2147483647, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.DIENTIM));
				sqlCommand.Parameters.Add(new SqlParameter("@XQUANG", SqlDbType.NVarChar, 2147483647, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.XQUANG));
				sqlCommand.Parameters.Add(new SqlParameter("@XETNGHIEMKHAC", SqlDbType.NVarChar, 2147483647, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.XETNGHIEMKHAC));
				sqlCommand.Parameters.Add(new SqlParameter("@KETQUACANLAMSANG", SqlDbType.NVarChar, 2147483647, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.KETQUACANLAMSANG));
				sqlCommand.Parameters.Add(new SqlParameter("@GHICHU", SqlDbType.NVarChar, 2147483647, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.GHICHU));

								
				MainConnection.Open();
				
				sqlCommand.ExecuteNonQuery();
                businessObject.ID = (int)sqlCommand.Parameters["@ID"].Value;

				return true;
			}
			catch//(Exception ex)
			{				
				return false;//throw new Exception("KHAMCANLAMSANG::Insert::Error occured.", ex);
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
        public bool Update(KHAMCANLAMSANG businessObject)
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = "dbo.[KHAMCANLAMSANG_Update]";
            sqlCommand.CommandType = CommandType.StoredProcedure;

            // Use connection object of base class
            sqlCommand.Connection = MainConnection;

            try
            {
                
				sqlCommand.Parameters.Add(new SqlParameter("@ID", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.ID));
				sqlCommand.Parameters.Add(new SqlParameter("@BACSIID", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.BACSIID));
				sqlCommand.Parameters.Add(new SqlParameter("@MAU", SqlDbType.NVarChar, 2147483647, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.MAU));
				sqlCommand.Parameters.Add(new SqlParameter("@NUOCTIEU", SqlDbType.NVarChar, 2147483647, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.NUOCTIEU));
				sqlCommand.Parameters.Add(new SqlParameter("@SIEUAM", SqlDbType.NVarChar, 2147483647, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.SIEUAM));
				sqlCommand.Parameters.Add(new SqlParameter("@DIENTIM", SqlDbType.NVarChar, 2147483647, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.DIENTIM));
				sqlCommand.Parameters.Add(new SqlParameter("@XQUANG", SqlDbType.NVarChar, 2147483647, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.XQUANG));
				sqlCommand.Parameters.Add(new SqlParameter("@XETNGHIEMKHAC", SqlDbType.NVarChar, 2147483647, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.XETNGHIEMKHAC));
				sqlCommand.Parameters.Add(new SqlParameter("@KETQUACANLAMSANG", SqlDbType.NVarChar, 2147483647, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.KETQUACANLAMSANG));
				sqlCommand.Parameters.Add(new SqlParameter("@GHICHU", SqlDbType.NVarChar, 2147483647, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.GHICHU));

                
                MainConnection.Open();

                sqlCommand.ExecuteNonQuery();
                return true;
            }
            catch //(Exception ex)
            {
                return false;//throw new Exception("KHAMCANLAMSANG::Update::Error occured.", ex);
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
        /// <returns>KHAMCANLAMSANG business object</returns>
        public KHAMCANLAMSANG SelectByPrimaryKey(KHAMCANLAMSANGKeys keys)
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = "dbo.[KHAMCANLAMSANG_SelectByPrimaryKey]";
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
                    KHAMCANLAMSANG businessObject = new KHAMCANLAMSANG();

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
                return null;//throw new Exception("KHAMCANLAMSANG::SelectByPrimaryKey::Error occured.", ex);
            }
            finally
            {             
                MainConnection.Close();
                sqlCommand.Dispose();
            }

        }

        public List<KHAMCANLAMSANG> SelectAllEntities()
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = "dbo.[KHAMCANLAMSANG_SelectAll]";
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
                return null;//throw new Exception("KHAMCANLAMSANG::SelectAll::Error occured.", ex);
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
            sqlCommand.CommandText = "dbo.[KHAMCANLAMSANG_SelectAll]";
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
                return null;//throw new Exception("KHAMCANLAMSANG::SelectAll::Error occured.", ex);
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
        /// <returns>list of KHAMCANLAMSANG</returns>
        public List<KHAMCANLAMSANG> SelectByField(string fieldName, object value)
        {

            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = "dbo.[KHAMCANLAMSANG_SelectByField]";
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
                return null;//throw new Exception("KHAMCANLAMSANG::SelectByField::Error occured.", ex);
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
        public bool Delete(KHAMCANLAMSANGKeys keys)
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = "dbo.[KHAMCANLAMSANG_DeleteByPrimaryKey]";
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
                return false;//throw new Exception("KHAMCANLAMSANG::DeleteByKey::Error occured.", ex);
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
            sqlCommand.CommandText = "dbo.[KHAMCANLAMSANG_DeleteByField]";
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
                return false;//throw new Exception("KHAMCANLAMSANG::DeleteByField::Error occured.", ex);
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
        internal void PopulateBusinessObjectFromReader(KHAMCANLAMSANG businessObject, IDataReader dataReader)
        {


				businessObject.ID = dataReader.GetInt32(dataReader.GetOrdinal(KHAMCANLAMSANG.KHAMCANLAMSANGFields.ID.ToString()));

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(KHAMCANLAMSANG.KHAMCANLAMSANGFields.BACSIID.ToString())))
				{
					businessObject.BACSIID = dataReader.GetInt32(dataReader.GetOrdinal(KHAMCANLAMSANG.KHAMCANLAMSANGFields.BACSIID.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(KHAMCANLAMSANG.KHAMCANLAMSANGFields.MAU.ToString())))
				{
					businessObject.MAU = dataReader.GetString(dataReader.GetOrdinal(KHAMCANLAMSANG.KHAMCANLAMSANGFields.MAU.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(KHAMCANLAMSANG.KHAMCANLAMSANGFields.NUOCTIEU.ToString())))
				{
					businessObject.NUOCTIEU = dataReader.GetString(dataReader.GetOrdinal(KHAMCANLAMSANG.KHAMCANLAMSANGFields.NUOCTIEU.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(KHAMCANLAMSANG.KHAMCANLAMSANGFields.SIEUAM.ToString())))
				{
					businessObject.SIEUAM = dataReader.GetString(dataReader.GetOrdinal(KHAMCANLAMSANG.KHAMCANLAMSANGFields.SIEUAM.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(KHAMCANLAMSANG.KHAMCANLAMSANGFields.DIENTIM.ToString())))
				{
					businessObject.DIENTIM = dataReader.GetString(dataReader.GetOrdinal(KHAMCANLAMSANG.KHAMCANLAMSANGFields.DIENTIM.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(KHAMCANLAMSANG.KHAMCANLAMSANGFields.XQUANG.ToString())))
				{
					businessObject.XQUANG = dataReader.GetString(dataReader.GetOrdinal(KHAMCANLAMSANG.KHAMCANLAMSANGFields.XQUANG.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(KHAMCANLAMSANG.KHAMCANLAMSANGFields.XETNGHIEMKHAC.ToString())))
				{
					businessObject.XETNGHIEMKHAC = dataReader.GetString(dataReader.GetOrdinal(KHAMCANLAMSANG.KHAMCANLAMSANGFields.XETNGHIEMKHAC.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(KHAMCANLAMSANG.KHAMCANLAMSANGFields.KETQUACANLAMSANG.ToString())))
				{
					businessObject.KETQUACANLAMSANG = dataReader.GetString(dataReader.GetOrdinal(KHAMCANLAMSANG.KHAMCANLAMSANGFields.KETQUACANLAMSANG.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(KHAMCANLAMSANG.KHAMCANLAMSANGFields.GHICHU.ToString())))
				{
					businessObject.GHICHU = dataReader.GetString(dataReader.GetOrdinal(KHAMCANLAMSANG.KHAMCANLAMSANGFields.GHICHU.ToString()));
				}


        }

        /// <summary>
        /// Populate business objects from the data reader
        /// </summary>
        /// <param name="dataReader">data reader</param>
        /// <returns>list of KHAMCANLAMSANG</returns>
        internal List<KHAMCANLAMSANG> PopulateObjectsFromReader(IDataReader dataReader)
        {

            List<KHAMCANLAMSANG> list = new List<KHAMCANLAMSANG>();

            while (dataReader.Read())
            {
                KHAMCANLAMSANG businessObject = new KHAMCANLAMSANG();
                PopulateBusinessObjectFromReader(businessObject, dataReader);
                list.Add(businessObject);
            }
            return list;

        }

        #endregion

	}
}
