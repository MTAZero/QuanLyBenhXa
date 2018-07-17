using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace QuanLyBenhXa.BusinessLayer.DataLayer
{
    /// <summary>
    /// Data layer base class for database interaction.
    /// </summary>
    abstract class DataLayerBase : IDisposable
    {
        #region Data Members

        SqlConnection _mainConnection;        
        bool _isDisposed;

        #endregion

        #region Constructor

        /// <summary>
        /// Constructor 
        /// </summary>
        public DataLayerBase()
        {
            // Initialize the class members of data layer.
            InitClass();
        }

        #endregion

        #region Properties

        /// <summary>
        /// get the sql connection object
        /// </summary>
        protected SqlConnection MainConnection
        {
            get { return _mainConnection; }

        }

        #endregion

        #region Private Methods

        /// <summary>
        /// Initializes class members.
        /// </summary>
        private void InitClass()
        {
            // create Connection Object
            _mainConnection = new SqlConnection();

            // Get connection string from Config File and set to the connection
            _mainConnection.ConnectionString = ConfigurationManager.ConnectionStrings["Main_DB"].ConnectionString;
            _isDisposed = false;
        }

        #endregion

        #region IDisposeable

        /// <summary>
        /// Implements the IDispose' method Dispose.
        /// </summary>
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        
        /// <summary>
        /// Implements the Dispose functionality.
        /// </summary>
        protected virtual void Dispose(bool bIsDisposing)
        {
            // Check to see if Dispose has already been called.
            if (!_isDisposed)
            {
                if (bIsDisposing)
                {
                    // Dispose managed resources.
                    _mainConnection.Dispose();
                    _mainConnection = null;
                }
            }
            _isDisposed = true;
        }

        #endregion

        #region PublicMethod
        public DataTable Do_SpSelect(string sp_name, params SqlParameter [] sqlParams)
        {
            DataTable result = new DataTable();            

            SqlCommand sqlCmd = new SqlCommand(sp_name,MainConnection);
            sqlCmd.CommandType = CommandType.StoredProcedure;            
            SqlDataAdapter _Adapter = new SqlDataAdapter(sqlCmd);
            try
            {
                if (sqlParams != null) sqlCmd.Parameters.AddRange(sqlParams);
                _Adapter.Fill(result);
            }
            catch (Exception ex) { Console.WriteLine(ex.ToString()); }
            finally 
            {
                _Adapter.Dispose();
                sqlCmd.Parameters.Clear();
                sqlCmd.Dispose();
                MainConnection.Close();
            }
            return result;
        }
        public DataTable DoSelect(string SelectCmd,params object[] paramValues)
        {
            DataTable result = new DataTable();

            SqlCommand sqlCmd = new SqlCommand(SelectCmd, MainConnection);
            sqlCmd.CommandType = CommandType.Text;            
            SqlDataAdapter _Adapter = new SqlDataAdapter(sqlCmd);
            try
            {
                _Adapter.Fill(result);
            }
            catch { }
            finally
            {
                _Adapter.Dispose();
                sqlCmd.Dispose();
                MainConnection.Close();
            }
            return result;
        }
        #endregion

    }
}
