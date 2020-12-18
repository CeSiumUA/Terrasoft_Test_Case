using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Terrasoft_Test_Case.Analyzer
{
    public class ExclamatoryCounterAnalyzer : IAnalyzer
    {
        private async Task<MetricsResult<int>> Count(string Text)
        {
            var sentences = Regex.Split(Text, @"(?<=[\.!\?])\s+");
            return new MetricsResult<int>("Количество восклицательных предложений", sentences.Count(x => x.EndsWith("!")));
        } 
        public async Task<object> GetMetrics(string Text)
        {
            return await Count(Text);
        }
    }
}