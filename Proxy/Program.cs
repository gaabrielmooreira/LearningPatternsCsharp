using Proxy.Services;
using Proxy.Services.Interfaces;

// Client code

IReportService reportService = new ReportService();
Console.WriteLine(reportService.GetReportById(5));

IReportService reportServiceProxy = new ReportServiceProxy();
Console.WriteLine(reportServiceProxy.GetReportById(5));