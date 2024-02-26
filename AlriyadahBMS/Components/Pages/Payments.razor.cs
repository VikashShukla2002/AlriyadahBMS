using AlriyadahBMS.Services;
using AlriyadahBMS.Shared.Helper;
using AlriyadahBMS.Shared.ViewModels;
using MudBlazor;
using MudBlazor.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MudBlazor.CategoryTypes;

namespace AlriyadahBMS.Components.Pages
{
    public partial class Payments
    {
        public PaymentsModel? PaymentData { get; set; }

        private string searchString = "";

        private IEnumerable<PaymentsModel>? tblPaymentsRecord = new List<PaymentsModel>();
        protected override async Task OnInitializedAsync()
        {
            var t = Language;
            tblPaymentsRecord = await tableService.GetRecords<List<PaymentsModel>>(TableConst.TblPayments);

            var check = tblPaymentsRecord;
        }


        private bool FilterFunc(PaymentsModel record)
        {
            if (record == null)
                return false;
            if (string.IsNullOrWhiteSpace(searchString))
                return true;
            if (!string.IsNullOrWhiteSpace(record.str_First_Name) && record.str_First_Name.Contains(searchString, StringComparison.OrdinalIgnoreCase))
                return true;
            if (!string.IsNullOrWhiteSpace(record.str_Last_Name) && record.str_Last_Name.Contains(searchString, StringComparison.OrdinalIgnoreCase))
                return true;
            if (!string.IsNullOrWhiteSpace(record.str_ApprovalCode) && record.str_ApprovalCode.Contains(searchString, StringComparison.OrdinalIgnoreCase))
                return true;
            if (record.Pricelist.HasValue && $"{record.Payment_Number} && {record.NationalID}".Contains(searchString))
                return true;
            return false;
        }


        private void OnClick_PaymentsDetails(PaymentsModel value)
        {
            PaymentData = value;
            var parameters = new DialogParameters();
            DialogOptions dialogOptions = new DialogOptions()
            {
                //MaxWidth = MaxWidth.Medium,
                //FullWidth = true,
                //Position = DialogPosition.TopCenter 
                FullScreen = true
            };
            parameters.Add("paymentsData", PaymentData);
            Dialog.Show<PaymentsViewDialog>("Payment View", parameters, dialogOptions);
        }

        private void OnClick_PaymentsEditDetails(PaymentsModel value)
        {
            PaymentData = value;
            var parameters = new DialogParameters();
            DialogOptions dialogOptions = new DialogOptions()
            {
                //MaxWidth = MaxWidth.Medium,
                //FullWidth = true,
                //Position = DialogPosition.TopCenter

                FullScreen = true
            };

            
            //{
            //    dialogOptions.FullScreen = true;
            //}

            //Breakpoint = "Breakpoint.SmAndDown "

            parameters.Add("paymentsEditData", PaymentData);
            Dialog.Show<PaymentEditDialog>("Payment Edit", parameters, dialogOptions);

        }


    }
}
