using Microsoft.AspNetCore.Components;
using MudBlazor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Button = MudBlazor.Button;

namespace AlriyadahBMS.Components.Layout
{
    public partial class MainLayout
    {
        bool _drawerOpen = true;

        [Parameter]
        public string PageName { get; set; } = "Home";
            
        public void DrawerToggle()
        {
            _drawerOpen = !_drawerOpen;
        }

        MudTheme MyCustomTheme = new MudTheme()
        {
            Palette = new PaletteLight()
            {
                AppbarBackground = new MudBlazor.Utilities.MudColor("#198754"),
                DrawerBackground = new MudBlazor.Utilities.MudColor("#f1e9d2"),
                Primary = new MudBlazor.Utilities.MudColor("#198754")
            },
            Typography = new Typography()
            {
                Default = new Default()
                {
                    FontFamily = new[] { "Poppins", "sans-serif" }
                },

                Button = new Button()
                {
                    TextTransform = "unset"
                }
               
            }
        };
    }
}


