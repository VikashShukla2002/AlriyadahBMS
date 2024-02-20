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
        public StudentRegistrationModel studentRegistrationModel { get; set; } = new();
        private List<StudentRegistrationModel>? students;

        private string searchString = "";
        private IEnumerable<StudentRegistrationModel>? tblRecord = new List<StudentRegistrationModel>();
        protected override async Task OnInitializedAsync()
        {
            tblRecord = await tableService.GetRecords<List<StudentRegistrationModel>>("tblStudents");
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


        private void OnClick_SelectFileItems(StudentRegistrationModel value)
        {
            SelectedFile = value;
            var parameters = new DialogParameters();
            parameters.Add("SelectedFile", SelectedFile);
            Dialog.Show<SetAsMainDialoge>(SelectedFile.MediaName, parameters);
        }


    }
}
