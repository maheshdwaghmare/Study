using DesignPatterns.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Classes
{
    public class Director
    {
        private readonly IBuilder objBuilder;
        public Director(IBuilder builder)
        {
            objBuilder = builder;
        }

        public void CreateReport()
        {
            objBuilder.GenerateReportHeaders();
            objBuilder.GenerateReportSummary();
            objBuilder.GenerateReportData();
        }

        public Report GetReport()
        {
            return objBuilder.GetReport();
        }
    }
}
