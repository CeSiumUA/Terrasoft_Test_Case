using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Terrasoft_Test_Case.Analyzer;
using Terrasoft_Test_Case.Services;

namespace Terrasoft_Test_Case.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MetricsController : ControllerBase
    {
        private readonly AnalyzerService _analyzerService;
        public MetricsController(AnalyzerService analyzerService)
        {
            this._analyzerService = analyzerService;
        }

        [HttpPost]
        public async Task<IActionResult> GetMetrics([FromBody] AnalyzerRequest Text)
        {
            return await _analyzerService.Analyze(Text.Text);
        }
    }

    public class AnalyzerRequest
    {
        public string Text { get; set; }
    }
}
