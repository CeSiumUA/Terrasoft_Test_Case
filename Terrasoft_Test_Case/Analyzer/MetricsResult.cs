namespace Terrasoft_Test_Case.Analyzer
{
    public class MetricsResult<TReturnType>
    {
        public string MetricName { get; set; }
        public TReturnType MetricResult { get; set; }

        public MetricsResult(string metricName, TReturnType metricResult)
        {
            this.MetricName = metricName;
            this.MetricResult = metricResult;
        }
    }
}