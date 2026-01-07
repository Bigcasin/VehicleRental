using System.Data;

namespace VehicleRENTAL.Classes {

    public class ReportManager {
        public Report GenerateFleetReport { get; set; }
        public Report GenerateRentalReport { get; set; }
        public void ExportPDF(Report report, string path) {

        }
        public void ExportCSV(Report report, string path) {

        }
        public void ExportExcel(Report report, string path) {

        }
        public void PrintReport(Report report) {

        }
        public DataSet CompileData() {
        return new DataSet();
        }
    }
}
