using MaterialSkin.Controls;

namespace VehicleRENTAL.Services
{
    // Interface for theming so UI depends on an abstraction (SOLID: Dependency Inversion)
    public interface IThemeService
    {
        void ApplyTheme(MaterialForm form);
    }
}