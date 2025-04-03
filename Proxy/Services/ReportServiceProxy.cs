
using Proxy.Services.Interfaces;

namespace Proxy.Services;

public class ReportServiceProxy : IReportService
{
    private readonly ReportService _reportService;

    public ReportServiceProxy()
    {
        _reportService = new ReportService();
    }

    public string GetReportById(int id)
    {
        return $"Proxy ----> {_reportService.GetReportById(id)}";
    }
}
