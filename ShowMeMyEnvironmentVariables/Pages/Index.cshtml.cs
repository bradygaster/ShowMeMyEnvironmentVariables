using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShowMeMyEnvironmentVariables.Pages
{
    public class IndexModel : PageModel
    {
        private readonly IConfiguration _configuration;

        public IndexModel(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public List<KeyValuePair<string, string>> EnvironmentVariables { get; private set; }

        public void OnGet()
        {
            EnvironmentVariables = _configuration.AsEnumerable().OrderBy(_ => _.Key).ToList();
        }
    }
}
