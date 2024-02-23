using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlriyadahBMS.Shared.ViewModels
{
    public class PaymentsModel
    {

        public int int_Bill_ID { get; set; }
        public int? int_Payment_Method { get; set; }
        public int int_Student_ID { get; set; }
        public long? NationalID { get; set; }
        public string? str_First_Name { get; set; }
        public string? str_Last_Name { get; set; }
        public string? str_Username { get; set; }
        public int? AssessmentID { get; set; }
        public string? str_Amount { get; set; }
        public decimal? Price { get; set; }
        public DateTime? date_Paid { get; set; }
        public string? str_CC_Holder_Name { get; set; }
        public string? str_CC_Number { get; set; }
        public int? int_CC_ExpMonth { get; set; }
        public int? int_CC_ExpYear { get; set; }
        public int? int_CC_Type { get; set; }
        public string? str_Card_Id { get; set; }
        public string? str_CC_ValidationNum { get; set; }
        public string? str_reference { get; set; }
        public string? str_Notes { get; set; }
        public string? str_Amount_Pay { get; set; }
        public string? str_Payment_Note { get; set; }
        public decimal? mny_Running_Payments { get; set; }
        public decimal? mny_Running_Balance { get; set; }
        public string? str_Payment_Reference { get; set; }
        public int? int_Accepted_By { get; set; }
        public string? str_Check_Number { get; set; }
        public bool? bit_Is_Check_Deposited { get; set; }
        public string? str_Adjustment_Type { get; set; }
        public string? str_Adjust_Sub_Type { get; set; }
        public bool? bit_Archive { get; set; }
        public int? int_Created_By { get; set; }
        public int? int_Modified_By { get; set; }
        public DateTime? date_Created { get; set; }
        public DateTime? date_Modified { get; set; }
        public bool? bit_IsDeleted { get; set; }
        public string? str_CardHolder_Address { get; set; }
        public string? str_CH_City { get; set; }
        public string? str_CH_Zip { get; set; }
        public int? int_State { get; set; }
        public bool? bit_IsAuthDotNet { get; set; }
        public bool? bit_IsRefund { get; set; }
        public string? str_Receipt { get; set; }
        public string? str_TransactionNumber { get; set; }
        public string? str_OrderId { get; set; }
        public string? str_TransactionTime { get; set; }
        public string? str_ApprovalCode { get; set; }
        public int? int_Location_Id { get; set; }
        public string? str_Enrollment_Id { get; set; }
        public int? int_Package_ID { get; set; }
        public string? Package_Name { get; set; }
        public string? course { get; set; }
        public string? institution { get; set; }
        public string? UniqueIdx { get; set; }
        public int? Payment_Number { get; set; }
        public decimal? Pricelist { get; set; }

    }
}
