using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleRENTAL.Classes
{
    public class ReportModel
    {
        public string Title { get; set; }
        public DataSet Data { get; set; }
        public ReportType Type { get; set; }
    }
}
