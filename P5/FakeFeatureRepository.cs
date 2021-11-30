using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class FakeFeatureRepository : IFeatureRepository
    {
        public string NO_ERROR = "";
        public string DUPLICATE_TITLE_ERROR = "Title must be unique.";
        public string EMPTY_TITLE_ERROR = "Title must have a value";
        public string NOT_FOUND_ERROR = "Feature not found.";
        public string INVALID_PROJECT_ID = "Invalid Project Id for Feature.";

        private List<Feature> features;

        string Add(Feature feature)
        {
            return "yes";
        }
            
        List<Feature> GetAll(int ProjectId)
        {

        }
        string Remove(Feature feature)
        {

        }
        string Modify(Feature feature)
        {

        }
        Feature GetFeatureById(int projectId, int featureId)
        {

        }
        Feature GetFeatureByTitle(int projectId, string title)
        {

        }
    }
}
