using DesignPatterns.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Interfaces
{
    public interface IBuilder
    {
        void GenerateReportHeaders();
        void GenerateReportSummary();
        void GenerateReportData();
        Report GetReport();

    }
}
