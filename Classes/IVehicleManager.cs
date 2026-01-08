using System.ComponentModel;

namespace VehicleRENTAL.Classes
{
    // Small abstraction so UI depends on an interface (Dependency Inversion)
    public interface IVehicleManager
    {
        BindingList<Vehicle> Vehicles { get; }
        void Remove(Vehicle vehicle);
        // add other needed operations here
    }
}