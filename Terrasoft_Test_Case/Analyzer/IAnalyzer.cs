using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Terrasoft_Test_Case.Analyzer
{
    public interface IAnalyzer
    {
        public Task<object> GetMetrics(string Text);
    }
}
