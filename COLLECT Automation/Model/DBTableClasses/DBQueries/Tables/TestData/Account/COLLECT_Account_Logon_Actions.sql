DROP TABLE [AutomationDB].[COLLECT].[Account_Login_Actions]

GO
	CREATE TABLE [AutomationDB].[COLLECT].[Account_Login_Actions](
      [LogonId] [int] IDENTITY(1,1) NOT NULL,
      [TestCaseId] VARCHAR(255)  NOT NULL,
      [TestType] VARCHAR(255) NOT NULL,
      [Priority] VARCHAR(255) NOT NULL,
      [Negative] VARCHAR(10) NOT NULL,
      [ExpectedError] VARCHAR(255) NOT NULL,
      [TestCaseDescription] VARCHAR(255) NOT NULL,

	  [IUserName] VARCHAR(50) NOT NULL,			
	  [IUserPassword] VARCHAR(100) NOT NULL,			


      [LastTestExecutionResult] VARCHAR(5) NULL,
      [LastTestExecutionDateTime] VARCHAR(100) NULL,
      [VerificationErrors] VARCHAR(MAX) NULL,

	  [TestCategories] VARCHAR(MAX) NULL,
	  [TestProperties] VARCHAR(MAX) NULL,
	)
GO


-- Positive
--- COLLECT_Account_Login_Actions_MainBody_SignIn

INSERT INTO [AutomationDB].[COLLECT].[Account_Login_Actions]
VALUES (
  'COLLECT_Account_Login_Actions_MainBody_SignIn_01', -- [TestCaseId] VARCHAR(255)  NOT NULL,
  'Regression, Smoke', -- [TestType] VARCHAR(255) NOT NULL,
  '1', -- [Priority] VARCHAR(255) NOT NULL,
  'No', -- [Negative] VARCHAR(10) NOT NULL,
  '', -- [ExpectedError] VARCHAR(255) NOT NULL,
  'COLLECT_Account_Login_Actions_MainBody_SignIn_01_WhenBothUserNameAndPasswordFieldsAreFilledInThenSignInSucceeds', -- [TestCaseDescription] VARCHAR(255) NOT NULL,

  'yogeshchugh05@gmail.com', -- [IUserName] VARCHAR(50) NOT NULL,			-- Max DB Allowed is 35
  '1@qwerty', -- [IPassword] VARCHAR(100) NOT NULL,			-- Max DB Allowed is 71


  '', -- [LastTestExecutionResult] VARCHAR(5) NULL,
  '', -- [LastTestExecutionDateTime] VARCHAR(250) NULL,
  '', -- [VerificationErrors]VARCHAR(MAX) NULL,  

  '', -- [TestCategories] VARCHAR(MAX) NULL,
  '' -- [TestProperties] VARCHAR(MAX) NULL,
)