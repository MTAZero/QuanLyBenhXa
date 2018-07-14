using System;
using System.Data;
using System.Data.SqlTypes;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace QuanLyBenhXa.BusinessLayer.DataLayer
{
	/// <summary>
	/// Data access layer class for KHAMTHUONGXUYEN
	/// </summary>
	class KHAMTHUONGXUYENSql : DataLayerBase 
	{

        #region Constructor

		/// <summary>
		/// Class constructor
		/// </summary>
		public KHAMTHUONGXUYENSql()
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
		public bool Insert(KHAMTHUONGXUYEN businessObject)
		{
			SqlCommand	sqlCommand = new SqlCommand();
			sqlCommand.CommandText = "dbo.[KHAMTHUONGXUYEN_Insert]";
			sqlCommand.CommandType = CommandType.StoredProcedure;

			// Use connection object of base class
			sqlCommand.Connection = MainConnection;

			try
			{
                
				sqlCommand.Parameters.Add(new SqlParameter("@ID", SqlDbType.Int, 4, ParameterDirection.Output, false, 0, 0, "", DataRowVersion.Proposed, businessObject.ID));
				sqlCommand.Parameters.Add(new SqlParameter("@BENHNHANID", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.BENHNHANID));
				sqlCommand.Parameters.Add(new SqlParameter("@BACSIID", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.BACSIID));
				sqlCommand.Parameters.Add(new SqlParameter("@THOIGIAN", SqlDbType.DateTime, 8, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.THOIGIAN));
				sqlCommand.Parameters.Add(new SqlParameter("@BENHID", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.BENHID));
				sqlCommand.Parameters.Add(new SqlParameter("@CHANDOANSOBO", SqlDbType.NVarChar, 2147483647, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.CHANDOANSOBO));
				sqlCommand.Parameters.Add(new SqlParameter("@CACHGIAIQUYET", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.CACHGIAIQUYET));
				sqlCommand.Parameters.Add(new SqlParameter("@THOIGIANCHUYEN", SqlDbType.DateTime, 8, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.THOIGIANCHUYEN));
				sqlCommand.Parameters.Add(new SqlParameter("@BENHVIENID", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.BENHVIENID));
				sqlCommand.Parameters.Add(new SqlParameter("@THOIGIANVAO", SqlDbType.DateTime, 8, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.THOIGIANVAO));
				sqlCommand.Parameters.Add(new SqlParameter("@THOIGIANRA", SqlDbType.DateTime, 8, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.THOIGIANRA));
				sqlCommand.Parameters.Add(new SqlParameter("@PHUONGPHAPDIEUTRI", SqlDbType.NVarChar, 2147483647, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.PHUONGPHAPDIEUTRI));
				sqlCommand.Parameters.Add(new SqlParameter("@KETQUADIEUTRI", SqlDbType.VarChar, 2147483647, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.KETQUADIEUTRI));
				sqlCommand.Parameters.Add(new SqlParameter("@CHIPHIKHAM", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.CHIPHIKHAM));
				sqlCommand.Parameters.Add(new SqlParameter("@GHICHU", SqlDbType.NVarChar, 2147483647, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.GHICHU));

								
				MainConnection.Open();
				
				sqlCommand.ExecuteNonQuery();
                businessObject.ID = (int)sqlCommand.Parameters["@ID"].Value;

				return true;
			}
			catch//(Exception ex)
			{				
				return false;//throw new Exception("KHAMTHUONGXUYEN::Insert::Error occured.", ex);
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
        public bool Update(KHAMTHUONGXUYEN businessObject)
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = "dbo.[KHAMTHUONGXUYEN_Update]";
            sqlCommand.CommandType = CommandType.StoredProcedure;

            // Use connection object of base class
            sqlCommand.Connection = MainConnection;

            try
            {
                
				sqlCommand.Parameters.Add(new SqlParameter("@ID", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.ID));
				sqlCommand.Parameters.Add(new SqlParameter("@BENHNHANID", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.BENHNHANID));
				sqlCommand.Parameters.Add(new SqlParameter("@BACSIID", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.BACSIID));
				sqlCommand.Parameters.Add(new SqlParameter("@THOIGIAN", SqlDbType.DateTime, 8, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.THOIGIAN));
				sqlCommand.Parameters.Add(new SqlParameter("@BENHID", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.BENHID));
				sqlCommand.Parameters.Add(new SqlParameter("@CHANDOANSOBO", SqlDbType.NVarChar, 2147483647, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.CHANDOANSOBO));
				sqlCommand.Parameters.Add(new SqlParameter("@CACHGIAIQUYET", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.CACHGIAIQUYET));
				sqlCommand.Parameters.Add(new SqlParameter("@THOIGIANCHUYEN", SqlDbType.DateTime, 8, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.THOIGIANCHUYEN));
				sqlCommand.Parameters.Add(new SqlParameter("@BENHVIENID", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.BENHVIENID));
				sqlCommand.Parameters.Add(new SqlParameter("@THOIGIANVAO", SqlDbType.DateTime, 8, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.THOIGIANVAO));
				sqlCommand.Parameters.Add(new SqlParameter("@THOIGIANRA", SqlDbType.DateTime, 8, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.THOIGIANRA));
				sqlCommand.Parameters.Add(new SqlParameter("@PHUONGPHAPDIEUTRI", SqlDbType.NVarChar, 2147483647, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.PHUONGPHAPDIEUTRI));
				sqlCommand.Parameters.Add(new SqlParameter("@KETQUADIEUTRI", SqlDbType.VarChar, 2147483647, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.KETQUADIEUTRI));
				sqlCommand.Parameters.Add(new SqlParameter("@CHIPHIKHAM", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.CHIPHIKHAM));
				sqlCommand.Parameters.Add(new SqlParameter("@GHICHU", SqlDbType.NVarChar, 2147483647, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.GHICHU));

                
                MainConnection.Open();

                sqlCommand.ExecuteNonQuery();
                return true;
            }
            catch //(Exception ex)
            {
                return false;//throw new Exception("KHAMTHUONGXUYEN::Update::Error occured.", ex);
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
        /// <returns>KHAMTHUONGXUYEN business object</returns>
        public KHAMTHUONGXUYEN SelectByPrimaryKey(KHAMTHUONGXUYENKeys keys)
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = "dbo.[KHAMTHUONGXUYEN_SelectByPrimaryKey]";
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
                    KHAMTHUONGXUYEN businessObject = new KHAMTHUONGXUYEN();

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
                return null;//throw new Exception("KHAMTHUONGXUYEN::SelectByPrimaryKey::Error occured.", ex);
            }
            finally
            {             
                MainConnection.Close();
                sqlCommand.Dispose();
            }

        }

        public List<KHAMTHUONGXUYEN> SelectAllEntities()
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = "dbo.[KHAMTHUONGXUYEN_SelectAll]";
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
                return null;//throw new Exception("KHAMTHUONGXUYEN::SelectAll::Error occured.", ex);
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
            sqlCommand.CommandText = "dbo.[KHAMTHUONGXUYEN_SelectAll]";
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
                return null;//throw new Exception("KHAMTHUONGXUYEN::SelectAll::Error occured.", ex);
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
        /// <returns>list of KHAMTHUONGXUYEN</returns>
        public List<KHAMTHUONGXUYEN> SelectByField(string fieldName, object value)
        {

            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = "dbo.[KHAMTHUONGXUYEN_SelectByField]";
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
                return null;//throw new Exception("KHAMTHUONGXUYEN::SelectByField::Error occured.", ex);
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
        public bool Delete(KHAMTHUONGXUYENKeys keys)
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = "dbo.[KHAMTHUONGXUYEN_DeleteByPrimaryKey]";
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
                return false;//throw new Exception("KHAMTHUONGXUYEN::DeleteByKey::Error occured.", ex);
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
            sqlCommand.CommandText = "dbo.[KHAMTHUONGXUYEN_DeleteByField]";
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
                return false;//throw new Exception("KHAMTHUONGXUYEN::DeleteByField::Error occured.", ex);
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
        internal void PopulateBusinessObjectFromReader(KHAMTHUONGXUYEN businessObject, IDataReader dataReader)
        {


				businessObject.ID = dataReader.GetInt32(dataReader.GetOrdinal(KHAMTHUONGXUYEN.KHAMTHUONGXUYENFields.ID.ToString()));

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(KHAMTHUONGXUYEN.KHAMTHUONGXUYENFields.BENHNHANID.ToString())))
				{
					businessObject.BENHNHANID = dataReader.GetInt32(dataReader.GetOrdinal(KHAMTHUONGXUYEN.KHAMTHUONGXUYENFields.BENHNHANID.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(KHAMTHUONGXUYEN.KHAMTHUONGXUYENFields.BACSIID.ToString())))
				{
					businessObject.BACSIID = dataReader.GetInt32(dataReader.GetOrdinal(KHAMTHUONGXUYEN.KHAMTHUONGXUYENFields.BACSIID.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(KHAMTHUONGXUYEN.KHAMTHUONGXUYENFields.THOIGIAN.ToString())))
				{
					businessObject.THOIGIAN = dataReader.GetDateTime(dataReader.GetOrdinal(KHAMTHUONGXUYEN.KHAMTHUONGXUYENFields.THOIGIAN.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(KHAMTHUONGXUYEN.KHAMTHUONGXUYENFields.BENHID.ToString())))
				{
					businessObject.BENHID = dataReader.GetInt32(dataReader.GetOrdinal(KHAMTHUONGXUYEN.KHAMTHUONGXUYENFields.BENHID.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(KHAMTHUONGXUYEN.KHAMTHUONGXUYENFields.CHANDOANSOBO.ToString())))
				{
					businessObject.CHANDOANSOBO = dataReader.GetString(dataReader.GetOrdinal(KHAMTHUONGXUYEN.KHAMTHUONGXUYENFields.CHANDOANSOBO.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(KHAMTHUONGXUYEN.KHAMTHUONGXUYENFields.CACHGIAIQUYET.ToString())))
				{
					businessObject.CACHGIAIQUYET = dataReader.GetInt32(dataReader.GetOrdinal(KHAMTHUONGXUYEN.KHAMTHUONGXUYENFields.CACHGIAIQUYET.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(KHAMTHUONGXUYEN.KHAMTHUONGXUYENFields.THOIGIANCHUYEN.ToString())))
				{
					businessObject.THOIGIANCHUYEN = dataReader.GetDateTime(dataReader.GetOrdinal(KHAMTHUONGXUYEN.KHAMTHUONGXUYENFields.THOIGIANCHUYEN.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(KHAMTHUONGXUYEN.KHAMTHUONGXUYENFields.BENHVIENID.ToString())))
				{
					businessObject.BENHVIENID = dataReader.GetInt32(dataReader.GetOrdinal(KHAMTHUONGXUYEN.KHAMTHUONGXUYENFields.BENHVIENID.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(KHAMTHUONGXUYEN.KHAMTHUONGXUYENFields.THOIGIANVAO.ToString())))
				{
					businessObject.THOIGIANVAO = dataReader.GetDateTime(dataReader.GetOrdinal(KHAMTHUONGXUYEN.KHAMTHUONGXUYENFields.THOIGIANVAO.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(KHAMTHUONGXUYEN.KHAMTHUONGXUYENFields.THOIGIANRA.ToString())))
				{
					businessObject.THOIGIANRA = dataReader.GetDateTime(dataReader.GetOrdinal(KHAMTHUONGXUYEN.KHAMTHUONGXUYENFields.THOIGIANRA.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(KHAMTHUONGXUYEN.KHAMTHUONGXUYENFields.PHUONGPHAPDIEUTRI.ToString())))
				{
					businessObject.PHUONGPHAPDIEUTRI = dataReader.GetString(dataReader.GetOrdinal(KHAMTHUONGXUYEN.KHAMTHUONGXUYENFields.PHUONGPHAPDIEUTRI.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(KHAMTHUONGXUYEN.KHAMTHUONGXUYENFields.KETQUADIEUTRI.ToString())))
				{
					businessObject.KETQUADIEUTRI = dataReader.GetString(dataReader.GetOrdinal(KHAMTHUONGXUYEN.KHAMTHUONGXUYENFields.KETQUADIEUTRI.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(KHAMTHUONGXUYEN.KHAMTHUONGXUYENFields.CHIPHIKHAM.ToString())))
				{
					businessObject.CHIPHIKHAM = dataReader.GetInt32(dataReader.GetOrdinal(KHAMTHUONGXUYEN.KHAMTHUONGXUYENFields.CHIPHIKHAM.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(KHAMTHUONGXUYEN.KHAMTHUONGXUYENFields.GHICHU.ToString())))
				{
					businessObject.GHICHU = dataReader.GetString(dataReader.GetOrdinal(KHAMTHUONGXUYEN.KHAMTHUONGXUYENFields.GHICHU.ToString()));
				}


        }

        /// <summary>
        /// Populate business objects from the data reader
        /// </summary>
        /// <param name="dataReader">data reader</param>
        /// <returns>list of KHAMTHUONGXUYEN</returns>
        internal List<KHAMTHUONGXUYEN> PopulateObjectsFromReader(IDataReader dataReader)
        {

            List<KHAMTHUONGXUYEN> list = new List<KHAMTHUONGXUYEN>();

            while (dataReader.Read())
            {
                KHAMTHUONGXUYEN businessObject = new KHAMTHUONGXUYEN();
                PopulateBusinessObjectFromReader(businessObject, dataReader);
                list.Add(businessObject);
            }
            return list;

        }

        #endregion

	}
}
