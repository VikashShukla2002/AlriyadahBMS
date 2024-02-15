using MudBlazor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlriyadahBMS.Components.Layout
{
    public partial class MainLayout
    {
        bool _drawerOpen = true;

        void DrawerToggle()
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
                }

            }
        };
    }
}
