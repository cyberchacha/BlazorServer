using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BlazorApp1.Pages
{
    [ValidateAntiForgeryToken, ResponseCache(Duration = 0x100, Location = ResponseCacheLocation.Client, NoStore = false)]
    public partial class HostModel : PageModel
    {
        public void OnGet()
        {
            logger.LogInformation("Host: { }, Path: { }, RemoteIpAddress: { }",
                                  HttpContext.Request.Host,
                                  HttpContext.Request.Path,
                                  HttpContext.Connection.RemoteIpAddress);
        }
        public HostModel(ILogger<HostModel> logger)
        {
            this.logger = logger;
        }
        readonly ILogger<HostModel> logger;
    }
}