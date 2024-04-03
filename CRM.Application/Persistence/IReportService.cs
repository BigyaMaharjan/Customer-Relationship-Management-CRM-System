
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
