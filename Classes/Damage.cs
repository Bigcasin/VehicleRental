using System.Drawing;

namespace VehicleRENTAL.Classes {

    public class Damage {
        public int DamageId { get; set; }
        public string Description { get; set; }
        public DamageSeverity Severity { get; set; }
        public Image Photo { get; set; }
    }
}
