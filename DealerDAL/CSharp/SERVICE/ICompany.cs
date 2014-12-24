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
using DealerDAL.DO;

namespace DealerDAL.Service
{



    /// <summary>
    /// Provides the interface for data access methods to the Company database table
    /// </summary>
    /// <remarks>
    public interface ICompanyService
    {


        /// <summary>
        /// Creates a new Company record
        /// </summary>
        int Create(CompanyDO DO);
        

        /// <summary>
        /// Creates a new Company record
        /// </summary>
        int Create(CompanyDO DO, DalapiTransaction Transaction);


        /// <summary>
        /// Updates a Company record and returns the number of records affected
        /// </summary>
        int Update(CompanyDO DO);


        /// <summary>
        /// Updates a Company record and returns the number of records affected
        /// </summary>
        int Update(CompanyDO DO, DalapiTransaction Transaction);


        /// <summary>
        /// Deletes a Company record
        /// </summary>
        int Delete(CompanyDO DO);

        /// <summary>
        /// Deletes a Company record
        /// </summary>
        int Delete(CompanyDO DO, DalapiTransaction Transaction);


        /// <summary>
        /// Gets all Company records
        /// </summary>
        CompanyDO[] GetAll();


        /// <summary>
        /// Selects Company records by PK
        /// </summary>
        CompanyDO[] GetByPK(Int32 CompanyId);




        /// <summary>
        /// Truncates the Company Table
        /// </summary>
        void Truncate();
        

        /// <summary>
        /// Truncates the Company Table
        /// </summary>
        void Truncate(DalapiTransaction Transaction);

    }
}