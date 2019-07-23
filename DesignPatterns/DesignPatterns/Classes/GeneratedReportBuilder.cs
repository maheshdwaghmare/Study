using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.Interfaces;

namespace DesignPatterns.Classes
{
    public class GeneratedReportBuilder : IBuilder
    {
        private Report _report = new Report();
        public void GenerateReportHeaders()
        {
            _report.ReportHeaders = "Generated Report Headers";
        }

        public void GenerateReportSummary()
        {
            _report.ReportSummary = "Generated Report Summary";
        }

        public void GenerateReportData()
        {
            _report.ReportData = "Generated Report Data";
        }

        public Report GetReport()
        {
            return _report;
        }
    }
}
