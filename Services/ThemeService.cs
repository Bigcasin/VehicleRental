using System;
using MaterialSkin;
using MaterialSkin.Controls;

namespace VehicleRENTAL.Services
{
    // Concrete theme logic moved out of the form (Single Responsibility)
    public class ThemeService : IThemeService
    {
        public void ApplyTheme(MaterialForm form)
        {
            if (form == null) return;

            try
            {
                var materialSkinManager = MaterialSkinManager.Instance;
                materialSkinManager.AddFormToManage(form);
                materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
                materialSkinManager.ColorScheme = new ColorScheme(
                    Primary.BlueGrey800, Primary.BlueGrey900,
                    Primary.BlueGrey500, Accent.Teal200, TextShade.WHITE
                );
            }
            catch
            {
                // non-fatal: keep designer and runtime robust
            }
        }
    }
}