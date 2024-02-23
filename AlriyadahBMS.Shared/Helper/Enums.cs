using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlriyadahBMS.Shared.Helper
{
    public enum DrivingLicense
    {
        [Description("Private Vehicle")]
        PrivateVehicle = 1,

        [Description("Motorbike")]
        Motorbike = 2,

        [Description("Taxi")]
        Taxi = 3,

        [Description("CDL (Trucks & Buses)")]
        CdlTruckAndBus = 4
    }

    public enum RelationshipType
    {
        Father,
        Mother,
        Brother,
        Sister,
        Uncle,
        Aunt,
        Friend
    }

    public enum PaymentMethod
    {
        [Description("Mada / Credit Card")]
        MadaCreditCard = 1,

        [Description("Cash")]
        Cash = 2,

        [Description("Apple Pay")]
        ApplePay = 3,

        [Description("STC Pay")]
        STCPay = 4
    }

}
