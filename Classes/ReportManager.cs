using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleRENTAL.Classes;

public class ReportManager
{
    public ReportModel GenerateAllReports()
    {
        // Compile data
        DataSet data = CompileData();

        // Build report object
        ReportModel report = new ReportModel();
        report.Data = data;
        report.Title = "System Reports";

        return report;
    }
    public void PrintReport(ReportModel report)
    {
        // printing logic here
    }
    public void ExportPDF(ReportType report, string path)
    {

    }
    public void ExportCSV(ReportType report, string path)
    {

    }
    public void ExportExcel(ReportType report, string path)
    {

    }
    public void PrintReport(ReportType report)
    {

    }
    public DataSet CompileData()
    {
        return new DataSet();
    }
    public ReportModel GenerateFleetReport()
    {
        ReportModel report = new ReportModel();
        report.Title = "Fleet Report";
        report.Data = null;
        return report;
    }

    // Generate rental report
    public ReportModel GenerateRentalReport()
    {
        ReportModel report = new ReportModel();
        report.Title = "Rental Report";
        report.Data = null;
        return report;
    }
}


