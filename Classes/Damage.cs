using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleRENTAL.Classes
{
    public enum DamageSeverity 
    {
        Critical,
        Moderate,
        Light
    }
    public class Damage
    {
        public int DamageId { get; set; }
        public string Description { get; set; }
        public DamageSeverity Severity { get; set; }
        public Image Photo { get; set; }
    }
}
