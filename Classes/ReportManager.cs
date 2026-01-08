using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleRENTAL.Classes;

public class ReportManager
{
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

