using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.Interfaces;

namespace DesignPatterns.Classes
{
    public class ScheduledReportBuilder : IBuilder
    {
        private Report _report = new Report();
        public void GenerateReportHeaders()
        {
            _report.ReportHeaders = "Scheduled Report Headers";
        }

        public void GenerateReportSummary()
        {
            _report.ReportSummary = "Scheduled Report Summary";
        }

        public void GenerateReportData()
        {
            _report.ReportData = "Scheduled Report Data";
        }

        public Report GetReport()
        {
            return _report;
        }
    }
}
