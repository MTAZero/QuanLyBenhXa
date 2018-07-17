using System;
using System.Data;
using System.Data.SqlTypes;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace QuanLyBenhXa.BusinessLayer.DataLayer
{
	/// <summary>
	/// Data access layer class for KHAMDINHKI
	/// </summary>
	class KHAMDINHKISql : DataLayerBase 
	{

        #region Constructor

		/// <summary>
		/// Class constructor
		/// </summary>
		public KHAMDINHKISql()
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
		public bool Insert(KHAMDINHKI businessObject)
		{
			SqlCommand	sqlCommand = new SqlCommand();
			sqlCommand.CommandText = "dbo.[KHAMDINHKI_Insert]";
			sqlCommand.CommandType = CommandType.StoredProcedure;

			// Use connection object of base class
			sqlCommand.Connection = MainConnection;

			try
			{
                
				sqlCommand.Parameters.Add(new SqlParameter("@ID", SqlDbType.Int, 4, ParameterDirection.Output, false, 0, 0, "", DataRowVersion.Proposed, businessObject.ID));
				sqlCommand.Parameters.Add(new SqlParameter("@BENHNHANID", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.BENHNHANID));
				sqlCommand.Parameters.Add(new SqlParameter("@PHANLOAISUCKHOEID", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.PHANLOAISUCKHOEID));
				sqlCommand.Parameters.Add(new SqlParameter("@KHAMTHELUCID", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.KHAMTHELUCID));
				sqlCommand.Parameters.Add(new SqlParameter("@KHAMCANLAMSANGID", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.KHAMCANLAMSANGID));
				sqlCommand.Parameters.Add(new SqlParameter("@KHAMCHUYENKHOAID", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.KHAMCHUYENKHOAID));
				sqlCommand.Parameters.Add(new SqlParameter("@KETLUAN", SqlDbType.NVarChar, 2147483647, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.KETLUAN));
				sqlCommand.Parameters.Add(new SqlParameter("@THOIGIANKHAM", SqlDbType.DateTime, 8, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.THOIGIANKHAM));
				sqlCommand.Parameters.Add(new SqlParameter("@LOAIHINHKHAM", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.LOAIHINHKHAM));
				sqlCommand.Parameters.Add(new SqlParameter("@BENHHIEMNGHEO", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.BENHHIEMNGHEO));
				sqlCommand.Parameters.Add(new SqlParameter("@GHICHU", SqlDbType.NVarChar, 2147483647, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.GHICHU));

								
				MainConnection.Open();
				
				sqlCommand.ExecuteNonQuery();
                businessObject.ID = (int)sqlCommand.Parameters["@ID"].Value;

				return true;
			}
			catch//(Exception ex)
			{				
				return false;//throw new Exception("KHAMDINHKI::Insert::Error occured.", ex);
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
        public bool Update(KHAMDINHKI businessObject)
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = "dbo.[KHAMDINHKI_Update]";
            sqlCommand.CommandType = CommandType.StoredProcedure;

            // Use connection object of base class
            sqlCommand.Connection = MainConnection;

            try
            {
                
				sqlCommand.Parameters.Add(new SqlParameter("@ID", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.ID));
				sqlCommand.Parameters.Add(new SqlParameter("@BENHNHANID", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.BENHNHANID));
				sqlCommand.Parameters.Add(new SqlParameter("@PHANLOAISUCKHOEID", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.PHANLOAISUCKHOEID));
				sqlCommand.Parameters.Add(new SqlParameter("@KHAMTHELUCID", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.KHAMTHELUCID));
				sqlCommand.Parameters.Add(new SqlParameter("@KHAMCANLAMSANGID", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.KHAMCANLAMSANGID));
				sqlCommand.Parameters.Add(new SqlParameter("@KHAMCHUYENKHOAID", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.KHAMCHUYENKHOAID));
				sqlCommand.Parameters.Add(new SqlParameter("@KETLUAN", SqlDbType.NVarChar, 2147483647, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.KETLUAN));
				sqlCommand.Parameters.Add(new SqlParameter("@THOIGIANKHAM", SqlDbType.DateTime, 8, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.THOIGIANKHAM));
				sqlCommand.Parameters.Add(new SqlParameter("@LOAIHINHKHAM", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.LOAIHINHKHAM));
				sqlCommand.Parameters.Add(new SqlParameter("@BENHHIEMNGHEO", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.BENHHIEMNGHEO));
				sqlCommand.Parameters.Add(new SqlParameter("@GHICHU", SqlDbType.NVarChar, 2147483647, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.GHICHU));

                
                MainConnection.Open();

                sqlCommand.ExecuteNonQuery();
                return true;
            }
            catch //(Exception ex)
            {
                return false;//throw new Exception("KHAMDINHKI::Update::Error occured.", ex);
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
        /// <returns>KHAMDINHKI business object</returns>
        public KHAMDINHKI SelectByPrimaryKey(KHAMDINHKIKeys keys)
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = "dbo.[KHAMDINHKI_SelectByPrimaryKey]";
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
                    KHAMDINHKI businessObject = new KHAMDINHKI();

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
                return null;//throw new Exception("KHAMDINHKI::SelectByPrimaryKey::Error occured.", ex);
            }
            finally
            {             
                MainConnection.Close();
                sqlCommand.Dispose();
            }

        }

        public List<KHAMDINHKI> SelectAllEntities()
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = "dbo.[KHAMDINHKI_SelectAll]";
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
                return null;//throw new Exception("KHAMDINHKI::SelectAll::Error occured.", ex);
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
            sqlCommand.CommandText = "dbo.[KHAMDINHKI_SelectAll]";
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
                return null;//throw new Exception("KHAMDINHKI::SelectAll::Error occured.", ex);
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
        /// <returns>list of KHAMDINHKI</returns>
        public List<KHAMDINHKI> SelectByField(string fieldName, object value)
        {

            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = "dbo.[KHAMDINHKI_SelectByField]";
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
                return null;//throw new Exception("KHAMDINHKI::SelectByField::Error occured.", ex);
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
        public bool Delete(KHAMDINHKIKeys keys)
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = "dbo.[KHAMDINHKI_DeleteByPrimaryKey]";
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
                return false;//throw new Exception("KHAMDINHKI::DeleteByKey::Error occured.", ex);
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
            sqlCommand.CommandText = "dbo.[KHAMDINHKI_DeleteByField]";
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
                return false;//throw new Exception("KHAMDINHKI::DeleteByField::Error occured.", ex);
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
        internal void PopulateBusinessObjectFromReader(KHAMDINHKI businessObject, IDataReader dataReader)
        {


				businessObject.ID = dataReader.GetInt32(dataReader.GetOrdinal(KHAMDINHKI.KHAMDINHKIFields.ID.ToString()));

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(KHAMDINHKI.KHAMDINHKIFields.BENHNHANID.ToString())))
				{
					businessObject.BENHNHANID = dataReader.GetInt32(dataReader.GetOrdinal(KHAMDINHKI.KHAMDINHKIFields.BENHNHANID.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(KHAMDINHKI.KHAMDINHKIFields.PHANLOAISUCKHOEID.ToString())))
				{
					businessObject.PHANLOAISUCKHOEID = dataReader.GetInt32(dataReader.GetOrdinal(KHAMDINHKI.KHAMDINHKIFields.PHANLOAISUCKHOEID.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(KHAMDINHKI.KHAMDINHKIFields.KHAMTHELUCID.ToString())))
				{
					businessObject.KHAMTHELUCID = dataReader.GetInt32(dataReader.GetOrdinal(KHAMDINHKI.KHAMDINHKIFields.KHAMTHELUCID.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(KHAMDINHKI.KHAMDINHKIFields.KHAMCANLAMSANGID.ToString())))
				{
					businessObject.KHAMCANLAMSANGID = dataReader.GetInt32(dataReader.GetOrdinal(KHAMDINHKI.KHAMDINHKIFields.KHAMCANLAMSANGID.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(KHAMDINHKI.KHAMDINHKIFields.KHAMCHUYENKHOAID.ToString())))
				{
					businessObject.KHAMCHUYENKHOAID = dataReader.GetInt32(dataReader.GetOrdinal(KHAMDINHKI.KHAMDINHKIFields.KHAMCHUYENKHOAID.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(KHAMDINHKI.KHAMDINHKIFields.KETLUAN.ToString())))
				{
					businessObject.KETLUAN = dataReader.GetString(dataReader.GetOrdinal(KHAMDINHKI.KHAMDINHKIFields.KETLUAN.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(KHAMDINHKI.KHAMDINHKIFields.THOIGIANKHAM.ToString())))
				{
					businessObject.THOIGIANKHAM = dataReader.GetDateTime(dataReader.GetOrdinal(KHAMDINHKI.KHAMDINHKIFields.THOIGIANKHAM.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(KHAMDINHKI.KHAMDINHKIFields.LOAIHINHKHAM.ToString())))
				{
					businessObject.LOAIHINHKHAM = dataReader.GetInt32(dataReader.GetOrdinal(KHAMDINHKI.KHAMDINHKIFields.LOAIHINHKHAM.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(KHAMDINHKI.KHAMDINHKIFields.BENHHIEMNGHEO.ToString())))
				{
					businessObject.BENHHIEMNGHEO = dataReader.GetInt32(dataReader.GetOrdinal(KHAMDINHKI.KHAMDINHKIFields.BENHHIEMNGHEO.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(KHAMDINHKI.KHAMDINHKIFields.GHICHU.ToString())))
				{
					businessObject.GHICHU = dataReader.GetString(dataReader.GetOrdinal(KHAMDINHKI.KHAMDINHKIFields.GHICHU.ToString()));
				}


        }

        /// <summary>
        /// Populate business objects from the data reader
        /// </summary>
        /// <param name="dataReader">data reader</param>
        /// <returns>list of KHAMDINHKI</returns>
        internal List<KHAMDINHKI> PopulateObjectsFromReader(IDataReader dataReader)
        {

            List<KHAMDINHKI> list = new List<KHAMDINHKI>();

            while (dataReader.Read())
            {
                KHAMDINHKI businessObject = new KHAMDINHKI();
                PopulateBusinessObjectFromReader(businessObject, dataReader);
                list.Add(businessObject);
            }
            return list;

        }

        #endregion

	}
}
