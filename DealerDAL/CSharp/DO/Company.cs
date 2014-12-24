// CREATED BY: Nate
// CREATED DATE: 12/24/2014
// DO NOT MODIFY THIS CODE
// CHANGES WILL BE LOST WHEN THE GENERATOR IS RUN AGAIN
// GENERATION TOOL: Dalapi Code Generator (DalapiPro.com)



using System;

namespace DealerDAL.DO
{
    /// <summary>
    /// Encapsulates a row of data in the Company table
    /// </summary>
    public partial class CompanyDO
    {

        public virtual Int32 CompanyId {get; set;}
        public virtual String Name {get; set;}
        public virtual String PhoneNumber {get; set;}

    }
}