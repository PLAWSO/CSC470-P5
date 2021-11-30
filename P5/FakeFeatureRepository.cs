﻿using System;
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

        public string Add(Feature newFeature)
        {
            bool match = false;
            if (newFeature == null)
            {
                return EMPTY_TITLE_ERROR;
            }

            foreach (Feature feature in features)
            {
                if (feature.Title == newFeature.Title)
                {
                    match = true;
                }
            }

            if (match == true)
            {
                return DUPLICATE_TITLE_ERROR;
            }

            features.Add(newFeature);
            
            return NO_ERROR;
        }

        public List<Feature> GetAll(int ProjectId)
        {
            return new List<Feature>();
        }
        public string Remove(Feature feature)
        {
            return "cool";
        }
        public string Modify(Feature feature)
        {
            return "cool";
        }
        public Feature GetFeatureById(int projectId, int featureId)
        {
            return new Feature();
        }
        public Feature GetFeatureByTitle(int projectId, string title)
        {
            return new Feature();
        }
    }
}
