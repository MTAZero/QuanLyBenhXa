using System;
using System.Data;
using System.Data.SqlTypes;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace QuanLyBenhXa.BusinessLayer.DataLayer
{
	/// <summary>
	/// Data access layer class for KHAMTHELUC
	/// </summary>
	class KHAMTHELUCSql : DataLayerBase 
	{

        #region Constructor

		/// <summary>
		/// Class constructor
		/// </summary>
		public KHAMTHELUCSql()
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
		public bool Insert(KHAMTHELUC businessObject)
		{
			SqlCommand	sqlCommand = new SqlCommand();
			sqlCommand.CommandText = "dbo.[KHAMTHELUC_Insert]";
			sqlCommand.CommandType = CommandType.StoredProcedure;

			// Use connection object of base class
			sqlCommand.Connection = MainConnection;

			try
			{
                
				sqlCommand.Parameters.Add(new SqlParameter("@ID", SqlDbType.Int, 4, ParameterDirection.Output, false, 0, 0, "", DataRowVersion.Proposed, businessObject.ID));
				sqlCommand.Parameters.Add(new SqlParameter("@CHIEUCAO", SqlDbType.NVarChar, 2147483647, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.CHIEUCAO));
				sqlCommand.Parameters.Add(new SqlParameter("@CANNANG", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.CANNANG));
				sqlCommand.Parameters.Add(new SqlParameter("@MACH", SqlDbType.NVarChar, 2147483647, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.MACH));
				sqlCommand.Parameters.Add(new SqlParameter("@HUYETAP", SqlDbType.NVarChar, 2147483647, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.HUYETAP));
				sqlCommand.Parameters.Add(new SqlParameter("@VONGNGUC", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.VONGNGUC));
				sqlCommand.Parameters.Add(new SqlParameter("@NHIETDO", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.NHIETDO));
				sqlCommand.Parameters.Add(new SqlParameter("@KETQUALAMSANG", SqlDbType.NVarChar, 2147483647, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.KETQUALAMSANG));
				sqlCommand.Parameters.Add(new SqlParameter("@GHICHU", SqlDbType.NVarChar, 2147483647, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.GHICHU));

								
				MainConnection.Open();
				
				sqlCommand.ExecuteNonQuery();
                businessObject.ID = (int)sqlCommand.Parameters["@ID"].Value;

				return true;
			}
			catch//(Exception ex)
			{				
				return false;//throw new Exception("KHAMTHELUC::Insert::Error occured.", ex);
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
        public bool Update(KHAMTHELUC businessObject)
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = "dbo.[KHAMTHELUC_Update]";
            sqlCommand.CommandType = CommandType.StoredProcedure;

            // Use connection object of base class
            sqlCommand.Connection = MainConnection;

            try
            {
                
				sqlCommand.Parameters.Add(new SqlParameter("@ID", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.ID));
				sqlCommand.Parameters.Add(new SqlParameter("@CHIEUCAO", SqlDbType.NVarChar, 2147483647, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.CHIEUCAO));
				sqlCommand.Parameters.Add(new SqlParameter("@CANNANG", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.CANNANG));
				sqlCommand.Parameters.Add(new SqlParameter("@MACH", SqlDbType.NVarChar, 2147483647, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.MACH));
				sqlCommand.Parameters.Add(new SqlParameter("@HUYETAP", SqlDbType.NVarChar, 2147483647, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.HUYETAP));
				sqlCommand.Parameters.Add(new SqlParameter("@VONGNGUC", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.VONGNGUC));
				sqlCommand.Parameters.Add(new SqlParameter("@NHIETDO", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.NHIETDO));
				sqlCommand.Parameters.Add(new SqlParameter("@KETQUALAMSANG", SqlDbType.NVarChar, 2147483647, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.KETQUALAMSANG));
				sqlCommand.Parameters.Add(new SqlParameter("@GHICHU", SqlDbType.NVarChar, 2147483647, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.GHICHU));

                
                MainConnection.Open();

                sqlCommand.ExecuteNonQuery();
                return true;
            }
            catch //(Exception ex)
            {
                return false;//throw new Exception("KHAMTHELUC::Update::Error occured.", ex);
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
        /// <returns>KHAMTHELUC business object</returns>
        public KHAMTHELUC SelectByPrimaryKey(KHAMTHELUCKeys keys)
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = "dbo.[KHAMTHELUC_SelectByPrimaryKey]";
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
                    KHAMTHELUC businessObject = new KHAMTHELUC();

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
                return null;//throw new Exception("KHAMTHELUC::SelectByPrimaryKey::Error occured.", ex);
            }
            finally
            {             
                MainConnection.Close();
                sqlCommand.Dispose();
            }

        }

        public List<KHAMTHELUC> SelectAllEntities()
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = "dbo.[KHAMTHELUC_SelectAll]";
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
                return null;//throw new Exception("KHAMTHELUC::SelectAll::Error occured.", ex);
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
            sqlCommand.CommandText = "dbo.[KHAMTHELUC_SelectAll]";
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
                return null;//throw new Exception("KHAMTHELUC::SelectAll::Error occured.", ex);
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
        /// <returns>list of KHAMTHELUC</returns>
        public List<KHAMTHELUC> SelectByField(string fieldName, object value)
        {

            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = "dbo.[KHAMTHELUC_SelectByField]";
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
                return null;//throw new Exception("KHAMTHELUC::SelectByField::Error occured.", ex);
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
        public bool Delete(KHAMTHELUCKeys keys)
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = "dbo.[KHAMTHELUC_DeleteByPrimaryKey]";
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
                return false;//throw new Exception("KHAMTHELUC::DeleteByKey::Error occured.", ex);
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
            sqlCommand.CommandText = "dbo.[KHAMTHELUC_DeleteByField]";
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
                return false;//throw new Exception("KHAMTHELUC::DeleteByField::Error occured.", ex);
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
        internal void PopulateBusinessObjectFromReader(KHAMTHELUC businessObject, IDataReader dataReader)
        {


				businessObject.ID = dataReader.GetInt32(dataReader.GetOrdinal(KHAMTHELUC.KHAMTHELUCFields.ID.ToString()));

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(KHAMTHELUC.KHAMTHELUCFields.CHIEUCAO.ToString())))
				{
					businessObject.CHIEUCAO = dataReader.GetString(dataReader.GetOrdinal(KHAMTHELUC.KHAMTHELUCFields.CHIEUCAO.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(KHAMTHELUC.KHAMTHELUCFields.CANNANG.ToString())))
				{
					businessObject.CANNANG = dataReader.GetInt32(dataReader.GetOrdinal(KHAMTHELUC.KHAMTHELUCFields.CANNANG.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(KHAMTHELUC.KHAMTHELUCFields.MACH.ToString())))
				{
					businessObject.MACH = dataReader.GetString(dataReader.GetOrdinal(KHAMTHELUC.KHAMTHELUCFields.MACH.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(KHAMTHELUC.KHAMTHELUCFields.HUYETAP.ToString())))
				{
					businessObject.HUYETAP = dataReader.GetString(dataReader.GetOrdinal(KHAMTHELUC.KHAMTHELUCFields.HUYETAP.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(KHAMTHELUC.KHAMTHELUCFields.VONGNGUC.ToString())))
				{
					businessObject.VONGNGUC = dataReader.GetInt32(dataReader.GetOrdinal(KHAMTHELUC.KHAMTHELUCFields.VONGNGUC.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(KHAMTHELUC.KHAMTHELUCFields.NHIETDO.ToString())))
				{
					businessObject.NHIETDO = dataReader.GetInt32(dataReader.GetOrdinal(KHAMTHELUC.KHAMTHELUCFields.NHIETDO.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(KHAMTHELUC.KHAMTHELUCFields.KETQUALAMSANG.ToString())))
				{
					businessObject.KETQUALAMSANG = dataReader.GetString(dataReader.GetOrdinal(KHAMTHELUC.KHAMTHELUCFields.KETQUALAMSANG.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(KHAMTHELUC.KHAMTHELUCFields.GHICHU.ToString())))
				{
					businessObject.GHICHU = dataReader.GetString(dataReader.GetOrdinal(KHAMTHELUC.KHAMTHELUCFields.GHICHU.ToString()));
				}


        }

        /// <summary>
        /// Populate business objects from the data reader
        /// </summary>
        /// <param name="dataReader">data reader</param>
        /// <returns>list of KHAMTHELUC</returns>
        internal List<KHAMTHELUC> PopulateObjectsFromReader(IDataReader dataReader)
        {

            List<KHAMTHELUC> list = new List<KHAMTHELUC>();

            while (dataReader.Read())
            {
                KHAMTHELUC businessObject = new KHAMTHELUC();
                PopulateBusinessObjectFromReader(businessObject, dataReader);
                list.Add(businessObject);
            }
            return list;

        }

        #endregion

	}
}
