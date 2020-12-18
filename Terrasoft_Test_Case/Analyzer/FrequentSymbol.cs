using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Terrasoft_Test_Case.Analyzer
{
    public class FrequentSymbol : IAnalyzer
    {
        private async Task<MetricsResult<char>> AnalyzeText(string Text)
        {
            Dictionary<char, int> chars = new Dictionary<char, int>();
            foreach (var chr in Text)
            {
                if (chars.ContainsKey(chr))
                {
                    chars[chr]++;
                }
                else
                {
                    chars.Add(chr, 1);
                }
            }
            return new MetricsResult<char>("Частота символа", chars.Where(x => x.Key != ' ').OrderByDescending(x => x.Value).FirstOrDefault().Key);
        }
        public async Task<object> GetMetrics(string Text)
        {
            var result = await AnalyzeText(Text);
            return result;
        }
    }
}