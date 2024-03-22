using AlriyadahBMS.Shared.Helper;
using AlriyadahBMS.Shared.ViewModels;
using Microsoft.AspNetCore.Components;
using MudBlazor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace AlriyadahBMS.Components.Pages
{
    public partial class StudentRegistration
    {
        //  public StudentRegistrationModel studentRegistrationModel { get; set; } = new();
        // private List<StudentRegistrationModel>? students;
        public MudTable<StudentRegistrationModel> StdRegGrid { get; set; }
        public StudentRegistrationModel? StudentData { get; set; }

        private IEnumerable<StudentRegistrationModel> filteredRecords;

        private string searchString = "";
        private IEnumerable<StudentRegistrationModel>? tblRecord = new List<StudentRegistrationModel>();
        public IEnumerable<CityModel>? CityList = new List<CityModel>();
        protected override async Task OnInitializedAsync()
        {
            tblRecord = await tableService.GetRecords<List<StudentRegistrationModel>>(TableConst.TblStudents);
            filteredRecords = tblRecord;
            StateHasChanged();
        }


        private void FilterRecords()
        {
            if (string.IsNullOrWhiteSpace(searchString))
            {
                filteredRecords = tblRecord;
            }
            else
            {
                filteredRecords = tblRecord.Where(record =>
                {
                    if (record == null)
                        return false;

                    if (string.IsNullOrWhiteSpace(searchString))
                        return true;

                    if (!string.IsNullOrWhiteSpace(record.str_First_Name) && record.str_First_Name.Contains(searchString, StringComparison.OrdinalIgnoreCase))
                        return true;

                    if (!string.IsNullOrWhiteSpace(record.str_Last_Name) && record.str_Last_Name.Contains(searchString, StringComparison.OrdinalIgnoreCase))
                        return true;

                    if (!string.IsNullOrWhiteSpace(record.str_Cell_Phone) && record.str_Cell_Phone.Contains(searchString, StringComparison.OrdinalIgnoreCase))
                        return true;

                    if (!string.IsNullOrWhiteSpace(record.str_Email) && record.str_Email.Contains(searchString, StringComparison.OrdinalIgnoreCase))
                        return true;

                    if (!string.IsNullOrWhiteSpace(record.str_NationalID_Iqama) && record.str_NationalID_Iqama.Contains(searchString, StringComparison.OrdinalIgnoreCase))
                        return true;

                    if (!string.IsNullOrWhiteSpace(record.AbsherApptNbr) && record.AbsherApptNbr.Contains(searchString, StringComparison.OrdinalIgnoreCase))
                        return true;

                    if (record.intDrivinglicenseType.HasValue && $"{record.intDrivinglicenseType}".Contains(searchString))
                        return true;

                    return false;
                });
            }
        }


        private bool FilterFunc(StudentRegistrationModel record)
        {
            if (record == null)
                return false;
            if (string.IsNullOrWhiteSpace(searchString))
                return true;
            if (!string.IsNullOrWhiteSpace(record.str_First_Name) && record.str_First_Name.Contains(searchString, StringComparison.OrdinalIgnoreCase))
                return true;
            if (!string.IsNullOrWhiteSpace(record.str_Last_Name) && record.str_Last_Name.Contains(searchString, StringComparison.OrdinalIgnoreCase))
                return true;
            if (!string.IsNullOrWhiteSpace(record.str_Cell_Phone) && record.str_Cell_Phone.Contains(searchString, StringComparison.OrdinalIgnoreCase))
                return true;
            if (!string.IsNullOrWhiteSpace(record.str_Email) && record.str_Email.Contains(searchString, StringComparison.OrdinalIgnoreCase))
                return true;
            if (!string.IsNullOrWhiteSpace(record.str_NationalID_Iqama) && record.str_NationalID_Iqama.Contains(searchString, StringComparison.OrdinalIgnoreCase))
                return true;
            if (!string.IsNullOrWhiteSpace(record.AbsherApptNbr) && record.AbsherApptNbr.Contains(searchString, StringComparison.OrdinalIgnoreCase))
                return true;
            if (record.intDrivinglicenseType.HasValue && $"{record.intDrivinglicenseType}".Contains(searchString))
                return true;
            return false;
        }






        private void OnClick_StudentViewDetails(StudentRegistrationModel value)
        {
            StudentData = value;
            var parameters = new DialogParameters();
            DialogOptions dialogOptions = new DialogOptions()
            {
                //MaxWidth = MaxWidth.Large,
                //FullWidth = true,
                //Position = DialogPosition.TopCenter,
                FullScreen = true
            };
            parameters.Add("StudentData", StudentData);
            Dialog.Show<StudentViewDialog>(Language.Phrase("permissionsearch"), parameters, dialogOptions);
        }



        private async Task RefreshStudentList()
        {
            // Code to fetch the updated student list data from the server or data source
            // For example:
            
            tblRecord = await tableService.GetRecords<List<StudentRegistrationModel>>(TableConst.TblStudents);
        }


        private async Task OnClick_StudentEditDetails(StudentRegistrationModel value)
        {
            StudentData = value;
            var parameters = new DialogParameters();
            DialogOptions dialogOptions = new DialogOptions()
            {
                //MaxWidth = MaxWidth.Medium,
                //FullWidth = true,
                //Position = DialogPosition.TopCenter
                FullScreen = true
            };
            parameters.Add("StudentEditData", StudentData);
            //var dialog = Dialog.Show<StudentEditDialog>(Language.Phrase("edit"), parameters, dialogOptions);


            var dialog = DialogService.Show<StudentEditDialog>(Language.Phrase("edit"), parameters, dialogOptions);


            var result =  await dialog.Result;
            if (!result.Canceled)
            {
                await RefreshStudentList();
                StateHasChanged();
            }
           

        }


    }
}
