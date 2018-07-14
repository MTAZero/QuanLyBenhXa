using System;
using System.Data;
using System.Data.SqlTypes;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace QuanLyBenhXa.BusinessLayer.DataLayer
{
	/// <summary>
	/// Data access layer class for MUONVATTU
	/// </summary>
	class MUONVATTUSql : DataLayerBase 
	{

        #region Constructor

		/// <summary>
		/// Class constructor
		/// </summary>
		public MUONVATTUSql()
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
		public bool Insert(MUONVATTU businessObject)
		{
			SqlCommand	sqlCommand = new SqlCommand();
			sqlCommand.CommandText = "dbo.[MUONVATTU_Insert]";
			sqlCommand.CommandType = CommandType.StoredProcedure;

			// Use connection object of base class
			sqlCommand.Connection = MainConnection;

			try
			{
                
				sqlCommand.Parameters.Add(new SqlParameter("@ID", SqlDbType.Int, 4, ParameterDirection.Output, false, 0, 0, "", DataRowVersion.Proposed, businessObject.ID));
				sqlCommand.Parameters.Add(new SqlParameter("@NGAYMUON", SqlDbType.DateTime, 8, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.NGAYMUON));
				sqlCommand.Parameters.Add(new SqlParameter("@NGAYTRA", SqlDbType.DateTime, 8, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.NGAYTRA));
				sqlCommand.Parameters.Add(new SqlParameter("@GHICHU", SqlDbType.NVarChar, 2147483647, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.GHICHU));
				sqlCommand.Parameters.Add(new SqlParameter("@BACSIMUONID", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.BACSIMUONID));
				sqlCommand.Parameters.Add(new SqlParameter("@BACSITRAID", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.BACSITRAID));
				sqlCommand.Parameters.Add(new SqlParameter("@BENHNHANID", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.BENHNHANID));
				sqlCommand.Parameters.Add(new SqlParameter("@KHAMTHUONGXUYENID", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.KHAMTHUONGXUYENID));
				sqlCommand.Parameters.Add(new SqlParameter("@TRANGTHAI", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.TRANGTHAI));

								
				MainConnection.Open();
				
				sqlCommand.ExecuteNonQuery();
                businessObject.ID = (int)sqlCommand.Parameters["@ID"].Value;

				return true;
			}
			catch//(Exception ex)
			{				
				return false;//throw new Exception("MUONVATTU::Insert::Error occured.", ex);
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
        public bool Update(MUONVATTU businessObject)
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = "dbo.[MUONVATTU_Update]";
            sqlCommand.CommandType = CommandType.StoredProcedure;

            // Use connection object of base class
            sqlCommand.Connection = MainConnection;

            try
            {
                
				sqlCommand.Parameters.Add(new SqlParameter("@ID", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.ID));
				sqlCommand.Parameters.Add(new SqlParameter("@NGAYMUON", SqlDbType.DateTime, 8, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.NGAYMUON));
				sqlCommand.Parameters.Add(new SqlParameter("@NGAYTRA", SqlDbType.DateTime, 8, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.NGAYTRA));
				sqlCommand.Parameters.Add(new SqlParameter("@GHICHU", SqlDbType.NVarChar, 2147483647, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.GHICHU));
				sqlCommand.Parameters.Add(new SqlParameter("@BACSIMUONID", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.BACSIMUONID));
				sqlCommand.Parameters.Add(new SqlParameter("@BACSITRAID", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.BACSITRAID));
				sqlCommand.Parameters.Add(new SqlParameter("@BENHNHANID", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.BENHNHANID));
				sqlCommand.Parameters.Add(new SqlParameter("@KHAMTHUONGXUYENID", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.KHAMTHUONGXUYENID));
				sqlCommand.Parameters.Add(new SqlParameter("@TRANGTHAI", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.TRANGTHAI));

                
                MainConnection.Open();

                sqlCommand.ExecuteNonQuery();
                return true;
            }
            catch //(Exception ex)
            {
                return false;//throw new Exception("MUONVATTU::Update::Error occured.", ex);
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
        /// <returns>MUONVATTU business object</returns>
        public MUONVATTU SelectByPrimaryKey(MUONVATTUKeys keys)
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = "dbo.[MUONVATTU_SelectByPrimaryKey]";
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
                    MUONVATTU businessObject = new MUONVATTU();

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
                return null;//throw new Exception("MUONVATTU::SelectByPrimaryKey::Error occured.", ex);
            }
            finally
            {             
                MainConnection.Close();
                sqlCommand.Dispose();
            }

        }

        public List<MUONVATTU> SelectAllEntities()
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = "dbo.[MUONVATTU_SelectAll]";
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
                return null;//throw new Exception("MUONVATTU::SelectAll::Error occured.", ex);
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
            sqlCommand.CommandText = "dbo.[MUONVATTU_SelectAll]";
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
                return null;//throw new Exception("MUONVATTU::SelectAll::Error occured.", ex);
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
        /// <returns>list of MUONVATTU</returns>
        public List<MUONVATTU> SelectByField(string fieldName, object value)
        {

            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = "dbo.[MUONVATTU_SelectByField]";
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
                return null;//throw new Exception("MUONVATTU::SelectByField::Error occured.", ex);
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
        public bool Delete(MUONVATTUKeys keys)
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = "dbo.[MUONVATTU_DeleteByPrimaryKey]";
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
                return false;//throw new Exception("MUONVATTU::DeleteByKey::Error occured.", ex);
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
            sqlCommand.CommandText = "dbo.[MUONVATTU_DeleteByField]";
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
                return false;//throw new Exception("MUONVATTU::DeleteByField::Error occured.", ex);
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
        internal void PopulateBusinessObjectFromReader(MUONVATTU businessObject, IDataReader dataReader)
        {


				businessObject.ID = dataReader.GetInt32(dataReader.GetOrdinal(MUONVATTU.MUONVATTUFields.ID.ToString()));

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(MUONVATTU.MUONVATTUFields.NGAYMUON.ToString())))
				{
					businessObject.NGAYMUON = dataReader.GetDateTime(dataReader.GetOrdinal(MUONVATTU.MUONVATTUFields.NGAYMUON.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(MUONVATTU.MUONVATTUFields.NGAYTRA.ToString())))
				{
					businessObject.NGAYTRA = dataReader.GetDateTime(dataReader.GetOrdinal(MUONVATTU.MUONVATTUFields.NGAYTRA.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(MUONVATTU.MUONVATTUFields.GHICHU.ToString())))
				{
					businessObject.GHICHU = dataReader.GetString(dataReader.GetOrdinal(MUONVATTU.MUONVATTUFields.GHICHU.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(MUONVATTU.MUONVATTUFields.BACSIMUONID.ToString())))
				{
					businessObject.BACSIMUONID = dataReader.GetInt32(dataReader.GetOrdinal(MUONVATTU.MUONVATTUFields.BACSIMUONID.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(MUONVATTU.MUONVATTUFields.BACSITRAID.ToString())))
				{
					businessObject.BACSITRAID = dataReader.GetInt32(dataReader.GetOrdinal(MUONVATTU.MUONVATTUFields.BACSITRAID.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(MUONVATTU.MUONVATTUFields.BENHNHANID.ToString())))
				{
					businessObject.BENHNHANID = dataReader.GetInt32(dataReader.GetOrdinal(MUONVATTU.MUONVATTUFields.BENHNHANID.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(MUONVATTU.MUONVATTUFields.KHAMTHUONGXUYENID.ToString())))
				{
					businessObject.KHAMTHUONGXUYENID = dataReader.GetInt32(dataReader.GetOrdinal(MUONVATTU.MUONVATTUFields.KHAMTHUONGXUYENID.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(MUONVATTU.MUONVATTUFields.TRANGTHAI.ToString())))
				{
					businessObject.TRANGTHAI = dataReader.GetInt32(dataReader.GetOrdinal(MUONVATTU.MUONVATTUFields.TRANGTHAI.ToString()));
				}


        }

        /// <summary>
        /// Populate business objects from the data reader
        /// </summary>
        /// <param name="dataReader">data reader</param>
        /// <returns>list of MUONVATTU</returns>
        internal List<MUONVATTU> PopulateObjectsFromReader(IDataReader dataReader)
        {

            List<MUONVATTU> list = new List<MUONVATTU>();

            while (dataReader.Read())
            {
                MUONVATTU businessObject = new MUONVATTU();
                PopulateBusinessObjectFromReader(businessObject, dataReader);
                list.Add(businessObject);
            }
            return list;

        }

        #endregion

	}
}
