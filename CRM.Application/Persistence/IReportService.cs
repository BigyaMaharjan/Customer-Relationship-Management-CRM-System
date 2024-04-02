using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Application.Persistence
{
     public  interface IReportService
     {
        Task GenerateCustomerAcquisitionReportAsync();
        Task GenerateLeadConversionReportAsync();
        Task GenerateCustomReportAsync();
        Task AnalyzeSalesPerformanceAsync();
        Task VisualizeDataAsync();
     }
}
