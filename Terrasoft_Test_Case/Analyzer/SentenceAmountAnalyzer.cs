using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Terrasoft_Test_Case.Analyzer
{
    public class SentenceAmountAnalyzer : IAnalyzer
    {
        private async Task<MetricsResult<int>> GetSentencesAmount(string Text)
        {
            return new MetricsResult<int>("Количество предложений", Regex.Split(Text, @"(?<=[\.!\?])\s+").Length);
        }
        public async Task<object> GetMetrics(string Text)
        {
            return await GetSentencesAmount(Text);
        }
    }
}