// CREATED BY: Nate
// CREATED DATE: 12/24/2014
// DO NOT MODIFY THIS CODE
// CHANGES WILL BE LOST WHEN THE GENERATOR IS RUN AGAIN
// GENERATION TOOL: Dalapi Code Generator (DalapiPro.com)



using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Configuration;
using DealerDAL.DAL;
using DealerDAL.DO;

namespace DealerDAL.DAL
{
    /// <summary>
    /// Provides data access methods for the Company database table
    /// </summary>
    /// <remarks>
    public partial class Company
    {

        /// <summary>
        /// Creates a new Company record
        /// </summary>
        public static int Create(CompanyDO DO)
        {
            return Create(null); 
        }
        

        /// <summary>
        /// Creates a new Company record
        /// </summary>
        public static int Create(CompanyDO DO, DalapiTransaction Transaction)
        {
            SqlParameter _Name = new SqlParameter("Name", SqlDbType.VarChar);
            SqlParameter _PhoneNumber = new SqlParameter("PhoneNumber", SqlDbType.VarChar);
            
            _Name.Value = DO.Name;
            _PhoneNumber.Value = DO.PhoneNumber;
            
            SqlParameter[] _params = new SqlParameter[] {
                _Name,
                _PhoneNumber
            };

            string pid = ConfigurationManager.AppSettings["PID"];

            return DataCommon.ExecuteScalar(String.Format("[{0}].[Company_Insert]", pid), _params, pid, Transaction);
            
        }


        /// <summary>
        /// Updates a Company record and returns the number of records affected
        /// </summary>
        public static int Update(CompanyDO DO)
        {
             return Update(DO, null);
        }


        /// <summary>
        /// Updates a Company record and returns the number of records affected
        /// </summary>
        public static int Update(CompanyDO DO, DalapiTransaction Transaction)
        {
            SqlParameter _CompanyId = new SqlParameter("CompanyId", SqlDbType.Int);
            SqlParameter _Name = new SqlParameter("Name", SqlDbType.VarChar);
            SqlParameter _PhoneNumber = new SqlParameter("PhoneNumber", SqlDbType.VarChar);
            
            _CompanyId.Value = DO.CompanyId;
            _Name.Value = DO.Name;
            _PhoneNumber.Value = DO.PhoneNumber;
            
            SqlParameter[] _params = new SqlParameter[] {
                _CompanyId,
                _Name,
                _PhoneNumber
            };

            string pid = ConfigurationManager.AppSettings["PID"];

            return DataCommon.ExecuteScalar(String.Format("[{0}].[Company_Update]", pid), _params, pid, Transaction);
        }


        /// <summary>
        /// Deletes a Company record
        /// </summary>
        public static int Delete(CompanyDO DO)
        {
            return Delete(DO, null);
        }

        /// <summary>
        /// Deletes a Company record
        /// </summary>
        public static int Delete(CompanyDO DO, DalapiTransaction Transaction)
        {
            SqlParameter _CompanyId = new SqlParameter("CompanyId", SqlDbType.Int);
            
            _CompanyId.Value = DO.CompanyId;
            
            SqlParameter[] _params = new SqlParameter[] {
                _CompanyId
            };

            string pid = ConfigurationManager.AppSettings["PID"];

            return DataCommon.ExecuteScalar(String.Format("[{0}].[Company_Delete]", pid), _params, pid, Transaction);
        }


        /// <summary>
        /// Gets all Company records
        /// </summary>
        public static CompanyDO[] GetAll()
        {

            string pid = ConfigurationManager.AppSettings["PID"];

            SafeReader sr = DataCommon.ExecuteSafeReader(String.Format("[{0}].[Company_GetAll]", pid), new SqlParameter[] { }, pid);
            
            List<CompanyDO> objs = new List<CompanyDO>();
            
            while(sr.Read()){

                CompanyDO obj = new CompanyDO();
                
                obj.CompanyId = sr.GetInt32(sr.GetOrdinal("CompanyId"));
                obj.Name = sr.GetString(sr.GetOrdinal("Name"));
                obj.PhoneNumber = sr.GetString(sr.GetOrdinal("PhoneNumber"));
                


                objs.Add(obj);
            }

            return objs.ToArray();
        }


        /// <summary>
        /// Selects Company records by PK
        /// </summary>
        public static CompanyDO[] GetByPK(Int32 CompanyId)
        {

            SqlParameter _CompanyId = new SqlParameter("CompanyId", SqlDbType.Int);
			
            _CompanyId.Value = CompanyId;
			
            SqlParameter[] _params = new SqlParameter[] {
                _CompanyId
            };

            string pid = ConfigurationManager.AppSettings["PID"];

            SafeReader sr = DataCommon.ExecuteSafeReader(String.Format("[{0}].[Company_GetByPK]", pid), _params, pid);


            List<CompanyDO> objs = new List<CompanyDO>();
			
            while(sr.Read())
            {
                CompanyDO obj = new CompanyDO();
				
                obj.CompanyId = sr.GetInt32(sr.GetOrdinal("CompanyId"));
                obj.Name = sr.GetString(sr.GetOrdinal("Name"));
                obj.PhoneNumber = sr.GetString(sr.GetOrdinal("PhoneNumber"));
                

                objs.Add(obj);
            }

            return objs.ToArray();
        }




        /// <summary>
        /// Truncates the Company Table
        /// </summary>
        public static void Truncate()
        {
            Truncate(null);
        }


        /// <summary>
        /// Truncates the Company Table
        /// </summary>
        public static void Truncate(DalapiTransaction Transaction)
        {
            string pid = ConfigurationManager.AppSettings["PID"];            
            DataCommon.TruncateTable(pid, "Company", Transaction);
        }

    }
}