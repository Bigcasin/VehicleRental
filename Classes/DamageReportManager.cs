using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleRENTAL.Classes
{
    public class DamageReportManager
    {
        private List<DamageReport> reports = new List<DamageReport>();

        public List<DamageReport> LoadPendingReports()
        {
            return reports.Where(r => !r.ApprovedByAdmin).ToList();
        }

        public void ApproveReport(int reportId)
        {
            DamageReport report = reports.FirstOrDefault(r => r.ReportId == reportId);

            if (report != null)
            {
                report.ApprovedByAdmin = true;
            }
        }

        public void AddReport(DamageReport report)
        {
            reports.Add(report);
        }
    }
}
