
using Proxy.Services.Interfaces;

namespace Proxy.Services
{
    public class ReportService : IReportService
    {
        public string GetReportById(int id)
        {
            return $"Report {id}";
        }
    }
}
