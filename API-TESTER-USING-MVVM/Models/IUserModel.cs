using Microsoft.OData.Edm;
using System;

namespace API_TESTER_USING_MVVM.Models.UserManagement
{
    public interface IUserModel
    {
        string AccessCode { get; set; }

        bool? AccountDisabled { get; set; }

        string ActiveDirectoryName { get; set; }

        bool? CanEnterCompliance { get; set; }

        bool? CannotChangePassword { get; set; }

        bool? CanSelectLocator { get; set; }

        bool? CanSelectToVendorLot { get; set; }

        Date Date { get; set; }

        bool? DefaultIncludeCateringActivity { get; set; }

        bool? DefaultIncludeFuelActivity { get; set; }

        bool? DefaultIncludeHotelActivity { get; set; }

        bool? DefaultIncludePartSaleActivity { get; set; }

        bool? DefaultIncludeServiceActivity { get; set; }

        bool? DefaultIncludeTransportationActivity { get; set; }

        string DefaultScreen { get; set; }

        string Department { get; set; }

        string Description { get; set; }

        bool? DisablePersistence { get; set; }

        long? DoubleTimeBurdenCost { get; set; }

        long? DoubleTimeCost { get; set; }

        string DoubleTimeLaborAccountNumber { get; set; }

        string Fullname { get; set; }

        bool? IncludeAllDefaultLogbookSearchCriteria { get; set; }

        string LaborBurdenAccountNumber { get; set; }

        long? LaborCost { get; set; }

        bool? LargeButtons { get; set; }

        bool? LaunchLogbookResearch { get; set; }

        bool? Locator { get; set; }

        bool? MustChangeAccessCode { get; set; }

        bool? MustChangePassword { get; set; }

        string NewUserName { get; set; }

        bool? OnlyDisplayAssignedInWOQMgmt { get; set; }

        bool? OnlyIncludeCateringActivity { get; set; }

        bool? OnlyIncludeFuelActivity { get; set; }

        bool? OnlyIncludeHotelActivity { get; set; }

        bool? OnlyIncludePartSaleActivity { get; set; }

        bool? OnlyIncludeServiceActivity { get; set; }

        bool? OnlyIncludeTransportationActivity { get; set; }

        long? OvertimeBurdenCost { get; set; }

        long? OvertimeCost { get; set; }

        string OvertimeLaborAccountNumber { get; set; }

        string Password { get; set; }

        string phoneNum { get; set; }

        long? PurchaseLimit { get; set; }

        bool? ReceivingInspector { get; set; }

        long? RegularBurdenCost { get; set; }

        long? RegularCost { get; set; }

        string RegularLaborAccountNumber { get; set; }

        bool? SuspendLocator { get; set; }

        bool? TipOfDay { get; set; }

        string UserBadgeID { get; set; }

        string UserName { get; set; }

        string UserPermissionsProfile { get; set; }
    }
}