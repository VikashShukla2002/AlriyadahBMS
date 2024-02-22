using AlriyadahBMS.Services;
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
    public partial class StudentEditDialog
    {
        [CascadingParameter] MudDialogInstance MudDialog { get; set; } = null!;

        [Parameter]
        public StudentRegistrationModel? StudentEditData { get; set; }

        //[Parameter]
        //public List<CityModel>? CityList { get; set; }
        public IEnumerable<CityModel>? CityList = new List<CityModel>();
        public IEnumerable<HijriModel>? HijriList = new List<HijriModel>();
        public IEnumerable<UserLevelModel>? userLevels = new List<UserLevelModel>();

        protected override async Task OnInitializedAsync()
        {
            CityList = await tableService.GetRecords<List<CityModel>>(TableConst.Cities);
            HijriList = await tableService.GetRecords<List<HijriModel>>(TableConst.Hijri_Table);
            userLevels = await tableService.GetRecords<List<UserLevelModel>>(TableConst.UserLevels);

        }




        void Cancel() => MudDialog.Cancel();

        public async void OnClick_UpdateGeneralInformation()
        {
          
        }

    }
}
