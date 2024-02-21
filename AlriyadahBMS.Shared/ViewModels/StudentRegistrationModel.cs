using AlriyadahBMS.Shared.ApiModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlriyadahBMS.Shared.ViewModels
{
    public class StudentRegistrationModel 
    {
     
        public int? int_Student_ID { get; set; }
        public int? int_Staff_Id { get; set; }
        public string? str_First_Name { get; set; }
        public string? str_Middle_Name { get; set; }
        public string? str_Last_Name { get; set; }
        public string? str_Full_Name { get; set; }
        public string? str_Address { get; set; }
        public string? str_City { get; set; }
        public int? int_State { get; set; }
        public string? str_Zip { get; set; }
        //public DateTime? date_Hired { get; set; }
        public string? date_Hired { get; set; }
        //public DateTime? date_Left { get; set; }
        public string? date_Left { get; set; }
        public string? str_CertNumber { get; set; }
        public string? date_CertExp { get; set; }
        public string? str_Home_Phone { get; set; }
        public string? str_Cell_Phone { get; set; }
        public string? str_Other_Phone { get; set; }
        public string? str_Email { get; set; }
        public string? str_Code { get; set; }
        public string? str_Username { get; set; }
        public string? str_Password { get; set; }
        public string? Parent_Username { get; set; }
        public string? date_Birth_Hijri { get; set; }
        public DateTime? date_Birth { get; set; }   
        public string? str_Emergency_Contact_Name { get; set; }
        public string? str_Emergency_Contact_Phone { get; set; }
        public string? str_Emergency_Contact_Relation { get; set; }
        public string? str_Notes { get; set; }
        public int? int_ClassType { get; set; }
        public string? str_ZipCodes { get; set; }
        public int? int_VehicleAssigned { get; set; }
        public int? int_Status { get; set; }
        public int? int_Type { get; set; }
        public int? int_Location { get; set; }
        public DateTime? date_Created { get; set; }
        public DateTime? date_Modified { get; set; }
        public decimal? int_Created_By { get; set; }
        public decimal? int_Modified_By { get; set; }
        public bool? bit_IsDeleted { get; set; }
        public string? str_InstPermitNo { get; set; }
        public string? date_PermitExpiration { get; set; }
        public string? date_InCarPermitIssue { get; set; }
        public string? str_InClassPermitNo { get; set; }
        public string? date_InClassPermitIssue { get; set; }
        public string? date_Started { get; set; }
        public string? str_DateHired { get; set; }
        public string? str_DateLeft { get; set; }
        public string? instructor_caption { get; set; }
        public string? str_LicType { get; set; }
        public int? int_Order { get; set; }
        public string? str_InstLicenceDate { get; set; }
        public string? str_DLNum { get; set; }
        public string? str_DLExp { get; set; }
        public bool? bit_appointmentColor { get; set; }
        public string? str_appointmentColorCode { get; set; }
        public bool? bit_IsSuperAdmin { get; set; }
        public int? IsDistanceBasedScheduling { get; set; }
        public string? str_Package_Code { get; set; }
        public int? int_Nationality { get; set; }
        public string? str_NationalID_Iqama { get; set; }
        public long? NationalID { get; set; }
        public int? int_RoadDistanceCoverage { get; set; }
        public string? str_Badge { get; set; }
        public string? strZoomHostUrl { get; set; }
        public string? strZoomUserUrl { get; set; }
        public string? Signature { get; set; }
        public string? str_VehicleType { get; set; }
        public string? ProfilePicturePath { get; set; }
        public int? UserlevelID { get; set; }
        public bool? Activated { get; set; }
        public bool? IsDrivingexperience { get; set; }
        public int? intDrivinglicenseType { get; set; }
        public string? Absherphoto { get; set; }
        public string? AbsherApptNbr { get; set; }
        public string? Fingerprint { get; set; }
        public string? ProfileField { get; set; }
        public int? Hijri_Day { get; set; }
        public int? Hijri_Month { get; set; }
        public int? Hijri_Year { get; set; }
        public string? Institution { get; set; }
        public string? User_Role { get; set; }
    }
}

