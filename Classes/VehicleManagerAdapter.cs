using System.ComponentModel;

namespace VehicleRENTAL.Classes
{
    // Adapter over the existing singleton to avoid UI depending on concrete singletons
    public class VehicleManagerAdapter : IVehicleManager
    {
        private readonly VehicleManager inner;
        private readonly BindingList<Vehicle> vehicles;

        // Accept a VehicleManager for DI; fall back to singleton for compatibility
        public VehicleManagerAdapter(VehicleManager inner = null)
        {
            this.inner = inner ?? VehicleManager.Instance;
            vehicles = this.inner?.Vehicles == null
                ? new BindingList<Vehicle>()
                : new BindingList<Vehicle>(this.inner.Vehicles);
        }

        // Return a single BindingList instance so UI can hold references and stay in sync
        public BindingList<Vehicle> Vehicles => vehicles;

        // Operate on the BindingList so underlying list and UI remain consistent
        public void Remove(Vehicle vehicle)
        {
            if (vehicle == null) return;
            if (vehicles.Contains(vehicle))
                vehicles.Remove(vehicle);
        }
    }
}