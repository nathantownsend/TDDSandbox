-- CREATED BY: Nate
-- CREATED DATE: 12/24/2014
-- DO NOT MODIFY THIS CODE
-- CHANGES WILL BE LOST WHEN THE GENERATOR IS RUN AGAIN
-- GENERATION TOOL: Dalapi Code Generator (DalapiPro.com)



USE [Testing]

-- Drop the procedure if it exists.
If OBJECT_ID('[dbo].[Company_Delete]') IS NOT NULL
    BEGIN
    DROP PROCEDURE [dbo].[Company_Delete]
    END
GO

CREATE PROCEDURE [dbo].[Company_Delete]
    @CompanyId Int
AS

BEGIN
    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON;

    DELETE 
        [dbo].[Company]
    WHERE
        [CompanyId] = @CompanyId

    SELECT @@ROWCOUNT AS DELETED; 
END