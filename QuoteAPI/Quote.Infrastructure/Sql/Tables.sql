CREATE TABLE [dbo].[QuoteRequest]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY(1,1), 
    [AggregatorId] INT NOT NULL, 
    [PolicyTypeId] INT NOT NULL, 
    [InsuredName] VARCHAR(100) NOT NULL, 
    [CustomerEmail] VARCHAR(50) NOT NULL, 
    [QuotationDate] DATETIME2 NOT NULL, 
    [PhoneNo] VARCHAR(50) NULL, 
    [Nationality] INT NOT NULL, 
    [InsuredDob] DATETIME2 NOT NULL, 
    [BusinessCode] VARCHAR(250) NULL, 
    [VehicleMake] VARCHAR(50) NOT NULL, 
    [VehicleModel] VARCHAR(50) NOT NULL, 
    [DlIssueDate] DATETIME2 NOT NULL, 
    [ClaimsFreeDriveYrs] INT NOT NULL, 
    [ModelYear] VARCHAR(50) NOT NULL, 
    [CityOfRegistration] VARCHAR(50) NOT NULL, 
    [RegistrationDate] DATETIME2 NOT NULL, 
    [VehicleType] VARCHAR(50) NOT NULL, 
    [BodyType] VARCHAR(50) NOT NULL, 
    [PassengerSeats] INT NOT NULL, 
    [Tonnage] INT NOT NULL, 
    [CC] INT NOT NULL, 
    [Cylinder] INT NOT NULL, 
    [IsRepairCondition] BIT NOT NULL, 
    [UseOfVehicle] VARCHAR(250) NOT NULL, 
    [SumInsured] DECIMAL NOT NULL, 
    [IsExcesssDeductible] BIT NOT NULL, 
    [IsNewDrivingLicense] BIT NOT NULL, 
    [IsUnderageDriver] BIT NOT NULL, 
    [IsReventDLHolder] BIT NOT NULL, 
    [Premium] DECIMAL NOT NULL, 
    [VAT] DECIMAL NOT NULL, 
    [Total] DECIMAL NOT NULL, 
    [IsPabDriver] BIT NOT NULL, 
    [IsPabPassenger] BIT NOT NULL, 
    [RtaEvg] VARCHAR(50) NOT NULL, 
    [Grasp] VARCHAR(50) NOT NULL, 
    [IsHireCar] BIT NOT NULL, 
    [QuotevalidityDays] INT NOT NULL, 
    [QuoteResponse] VARCHAR(MAX) NULL, 
    [CreatedDate] DATETIME2 NOT NULL, 
    [UpdatedDate] DATETIME2 NULL
)


