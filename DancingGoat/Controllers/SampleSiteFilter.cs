using KenticoCloud.Delivery;

namespace DancingGoat.Controllers
{
    public class SampleSiteFilter : IQueryParameter
    {
        public string GetQueryStringParameter()
        {
            return "samplesite=1";
        }
    }
}