using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using Terrasoft_Test_Case.Analyzer;

namespace Terrasoft_Test_Case.Services
{
    public class AnalyzerService
    {
        private readonly IServiceProvider _serviceProvider;
        public AnalyzerService(IServiceProvider serviceProvider)
        {
            this._serviceProvider = serviceProvider;
        }

        public async Task<IActionResult> Analyze(string Text)
        {
            var analyzers = _serviceProvider.GetServices<IAnalyzer>();
            List<object> results = new List<object>();
            foreach (var srvc in analyzers)
            {
                results.Add(await srvc.GetMetrics(Text));
            }
            return new JsonResult(results);
        }
    }
}
