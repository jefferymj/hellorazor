using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Diagnostics;

namespace MyApp.Namespace;

public class ProcessModel : PageModel
{
    public void OnGet()
    {
        Process[] processes = Process.GetProcesses();
        ViewData["P"] = processes;
    }
}
