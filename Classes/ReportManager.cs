using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleRENTAL.Classes;

public class ReportManager
{

   
    public class ReportManager 
    {
        public ReportType GenerateFleetReport { get; set; }
        public ReportType GenerateRentalReport { get; set; }
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
    }

	// Generate fleet report
	public Report GenerateFleetReport()
	{
		Report report = new Report();
		// later: fill report with vehicle data
		return report;
	}

	// Generate rental report
	public Report GenerateRentalReport()
	{
		Report report = new Report();
		// later: fill report with rental data
		return report;
	}

	public void ExportPDF(Report report, string path)
	{
		// future implementation
	}

	public void ExportCSV(Report report, string path)
	{
		// future implementation
	}

	public void ExportExcel(Report report, string path)
	{
		// future implementation
	}

	public void PrintReport(Report report)
	{
		// future implementation
	}

	public DataSet CompileData()
	{
		return new DataSet();
	}

}

