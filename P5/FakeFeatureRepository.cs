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

        private List<Feature> featureList;

        public FakeFeatureRepository()
        {
                featureList = new List<Feature>();
                Feature feature = new Feature();
                feature.Id = 1;
                feature.ProjectId = 1;
                feature.Title = "New Feature Project 1";

                featureList.Add(feature);

                feature = new Feature();
                feature.Id = 2;
                feature.ProjectId = 1;
                feature.Title = "Old Feature Project 1";

                featureList.Add(feature);

                feature = new Feature();
                feature.Id = 3;
                feature.ProjectId = 2;
                feature.Title = "New Feature Project 2";

                featureList.Add(feature);

                feature = new Feature();
                feature.Id = 4;
                feature.ProjectId = 3;
                feature.Title = "New Feature Project 3";

                featureList.Add(feature);
            
        }

        public string Add(Feature newFeature)
        {
            int count = 1;
            if (newFeature == null)
            {
                return EMPTY_TITLE_ERROR;
            }

            foreach (Feature feature in featureList)
            {
                if (feature.Title == newFeature.Title)
                {
                    return DUPLICATE_TITLE_ERROR;
                }
                count++;
            }

            newFeature.Id = count;
            featureList.Add(newFeature);
            
            return NO_ERROR;
        }

        public List<Feature> GetAll(int ProjectId)
        {
            List<Feature> returnfeat = new List<Feature>();
            foreach (Feature f in featureList)
            { 
                if(f.ProjectId == ProjectId)
                    returnfeat.Add(f);
            }
            return returnfeat;
        }
        public string Remove(Feature feature)
        {
            featureList.Remove(feature);
            return "success";
        }
        public string Modify(Feature feature)
        {
            foreach(Feature f in featureList)
            {
                if (f.Title == feature.Title)
                    return "Cannot have the same title";
            }
            featureList [feature.Id - 1 ] = feature;
            return "check";
        }
        public Feature GetFeatureById(int projectId, int featureId)
        {
            foreach (Feature f in featureList)
                if (f.Id == featureId)
                    return f;
            return null;
        }
        public Feature GetFeatureByTitle(string title)
        {
            foreach (Feature f in featureList)
                if (f.Title == title)
                    return f;
            return null;
        }
    }
}
