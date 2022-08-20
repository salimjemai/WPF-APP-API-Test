CREATE TABLE [dbo].[User]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [UserName] NVARCHAR(128) NULL, 
    [Fullname] NVARCHAR(128) NULL, 
    [Description] NVARCHAR(MAX) NULL, 
    [Department] NVARCHAR(128) NULL, 
    [UserBadgeID] NVARCHAR(128) NULL, 
    [Password] NVARCHAR(MAX) NULL, 
    [AccessCode] NVARCHAR(128) NULL, 
    [ActiveDirectoryName] NVARCHAR(128) NULL, 
    [UserPermissionsProfile] NVARCHAR(128) NULL, 
    [DefaultScreen] NVARCHAR(128) NULL, 
    [PurchaseLimit] MONEY NULL, 
    [LaborCost] MONEY NULL, 
    [RegularCost] MONEY NULL, 
    [OvertimeCost] MONEY NULL, 
    [DoubleTimeCost] MONEY NULL, 
    [RegularBurdenCost] MONEY NULL, 
    [OvertimeBurdenCost] MONEY NULL, 
    [DoubleTimeBurdenCost] MONEY NULL, 
    [RegularLaborAccountNumber] NVARCHAR(128) NULL, 
    [OvertimeLaborAccountNumber] NVARCHAR(128) NULL,
    [DoubleTimeLaborAccountNumber] NVARCHAR(128) NULL,
    [LaborBurdenAccountNumber] NVARCHAR(128) NULL,
    [MustChangePassword] INT NULL DEFAULT 0,
    [MustChangeAccessCode] INT NULL DEFAULT 0,
    [CannotChangePassword] INT NULL DEFAULT 0,
    [AccountDisabled] INT NULL DEFAULT 0,
    [Locator] INT NULL DEFAULT 0,
        [SuspendLocator] INT NULL DEFAULT 0,

        [CanSelectLocator] INT NULL DEFAULT 0,

        [CanSelectToVendorLot] INT NULL DEFAULT 0,

        [ReceivingInspector] INT NULL DEFAULT 0,

        [TipOfDay] INT NULL DEFAULT 0,

        [LargeButtons] INT NULL DEFAULT 0,

        [DisablePersistence] INT NULL DEFAULT 0,

        [DefaultIncludeFuelActivity] INT NULL DEFAULT 0,

        [OnlyIncludeFuelActivity] INT NULL DEFAULT 0,

        [DefaultIncludeServiceActivity] INT NULL DEFAULT 0,

        [OnlyIncludeServiceActivity] INT NULL DEFAULT 0,

        [DefaultIncludePartSaleActivity] INT NULL DEFAULT 0,

        [OnlyIncludePartSaleActivity] INT NULL DEFAULT 0,

        [DefaultIncludeCateringActivity] INT NULL DEFAULT 0,

        [OnlyIncludeCateringActivity] INT NULL DEFAULT 0,

        [DefaultIncludeHotelActivity] INT NULL DEFAULT 0,

        [OnlyIncludeHotelActivity] INT NULL DEFAULT 0,

        [DefaultIncludeTransportationActivity] INT NULL DEFAULT 0,

        [OnlyIncludeTransportationActivity] INT NULL DEFAULT 0,

        [LaunchLogbookResearch] INT NULL DEFAULT 0,

        [CanEnterCompliance] INT NULL DEFAULT 0,

        [IncludeAllDefaultLogbookSearchCriteria] INT NULL DEFAULT 0,

        [OnlyDisplayAssignedInWOQMgmt] INT NULL DEFAULT 0,

        [phoneNum] NVARCHAR(128) NULL

)
