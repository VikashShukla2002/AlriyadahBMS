using AlriyadahBMS.Shared.Helper;
using AlriyadahBMS.Shared.ViewModels;
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

        public StudentRegistrationModel? StudentData { get; set; }

        private string searchString = "";
        private IEnumerable<StudentRegistrationModel>? tblRecord = new List<StudentRegistrationModel>();
        public IEnumerable<CityModel>? CityList = new List<CityModel>();
        protected override async Task OnInitializedAsync()
        {
            tblRecord = await tableService.GetRecords<List<StudentRegistrationModel>>(TableConst.TblStudents);
            // CityList = await tableService.GetRecords<List<CityModel>>(TableConst.Cities);
            var check = await tableService.UpdateRecord<UserLevel, UserLevel>(TableConst.UserLevels, -2, new UserLevel
            {
                UserLevelName = "Captain"
            });
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
                MaxWidth = MaxWidth.Medium,
                FullWidth = true,
                Position = DialogPosition.TopCenter
            };
            parameters.Add("StudentData", StudentData);
            Dialog.Show<StudentViewDialog>("View", parameters, dialogOptions);
        }

        private void OnClick_StudentEditDetails(StudentRegistrationModel value)
        {
            StudentData = value;
            var parameters = new DialogParameters();
            DialogOptions dialogOptions = new DialogOptions()
            {
                MaxWidth = MaxWidth.Medium,
                FullWidth = true,
                Position = DialogPosition.TopCenter
            };
            parameters.Add("StudentEditData", StudentData);
            Dialog.Show<StudentEditDialog>("Edit", parameters, dialogOptions);
        }


    }
}
