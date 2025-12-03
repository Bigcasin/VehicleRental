using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleRENTAL.Classes
{
    public enum Report
    {
        Fleet,
        Rental
    }
    public class ReportManager
    {
        public Report GenerateFleetReport { get; set; }
        public Report GenerateRentalReport { get; set; }
        public void ExportPDF(Report report, string path) 
        {
            
        }
        public void ExportCSV(Report report, string path)
        {

        }
        public void ExportExcel(Report report, string path)
        {
            
        }
        public void PrintReport(Report report) 
        {
            
        }
        public DataSet CompileData() 
        {
            return new DataSet();
        }
    }
}
