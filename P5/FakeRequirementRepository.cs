using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class FakeRequirementRepository : IRequirementRepository
    {
        public string NO_ERROR = "";
        public string DUPLICATE_STATEMENT_ERROR = "Statements must be unique";
        public string EMPTY_STATEMENT_ERROR = "Statement must have a value";
        public string REQUIREMENT_NOT_FOUND_ERROR = "Requirement does not exist";
        public string MISSING_FEATURE_ERROR = "Must select a feature for this requirement.";
        public string MISSING_PROJECTID_ERROR = "Must select a project for this requirement.";

        List<Requirement> requirementList;

        public FakeRequirementRepository()
        {
            if (requirementList == null)
            {
                requirementList = new List<Requirement>();
                Requirement requirement = new Requirement();

                requirement.Id = 1;
                requirement.FeatureId = 1;
                requirement.ProjectId = 1;
                requirement.Statement = "Requirement 1 Feature 1 Project 1";
                requirementList.Add(requirement);

                requirement = new Requirement();
                requirement.Id = 2;
                requirement.FeatureId = 1;
                requirement.ProjectId = 1;
                requirement.Statement = "Requirement 2 Feature 1 Project 1";
                requirementList.Add(requirement);

                requirement = new Requirement();
                requirement.Id = 3;
                requirement.FeatureId = 2;
                requirement.ProjectId = 1;
                requirement.Statement = "Requirement 3 Feature 2 Project 1";
                requirementList.Add(requirement);

                requirement = new Requirement();
                requirement.Id = 4;
                requirement.FeatureId = 1;
                requirement.ProjectId = 2;
                requirement.Statement = "Requirement 4 Feature 1 Project 2";
                requirementList.Add(requirement);

                requirement = new Requirement();
                requirement.Id = 5;
                requirement.FeatureId = 1;
                requirement.ProjectId = 3;
                requirement.Statement = "Requirement 5 Feature 1 Project 3";
                requirementList.Add(requirement);

            }
        }

        public string Add(Requirement newRequirement)
        {
            int count = 1;

            if (newRequirement == null)
            {
                return EMPTY_STATEMENT_ERROR;
            }

            foreach (Requirement requirement in requirementList)
            {
                if (requirement.Statement == newRequirement.Statement)
                {
                    return DUPLICATE_STATEMENT_ERROR;
                }
                count++;
            }

            newRequirement.Id = count;
            requirementList.Add(newRequirement);

            return NO_ERROR;
        }
        public List<Requirement> GetAll()
        {
            return requirementList;
        }
        public string Remove(Requirement requirement)
        {
            this.requirementList.Remove(requirement);
            return "success";
        }
        public string Modify(Requirement requirement)
        {
            return "cool";
        }
        public Requirement GetRequirementById(int requirementId)
        {
            foreach (Requirement r in requirementList)
                if (r.Id == requirementId)
                    return r;
            return null;
        }
        public int CountByFeatureId(int featureId)
        {
            int count = 0;
            foreach (Requirement requirement in requirementList)
                if (requirement.FeatureId == featureId)
                    count++;
            return count;
        }
        public void RemoveByFeatureId(int featureId)
        {

        }
    }
}
